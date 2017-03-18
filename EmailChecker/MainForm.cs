using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using System.Text;
using Microsoft.CognitiveServices.ContentModerator;

namespace EmailChecker
{
    public partial class MainForm : Form
    {
        Microsoft.Office.Interop.Outlook.Application outlookApp;
        Microsoft.Office.Interop.Outlook.NameSpace outlookNamespace;
        Microsoft.Office.Interop.Outlook.Accounts accounts;
        private readonly ModeratorClient client = null;

        public MainForm()
        {
            InitializeComponent();

            this.client = new ModeratorClient(Properties.Settings.Default.ContentModerator_SubscriptionKey);

            webBody.ScriptErrorsSuppressed = true;

            outlookApp = new Microsoft.Office.Interop.Outlook.Application();
            outlookNamespace = outlookApp.GetNamespace("MAPI");
            accounts = outlookApp.Session.Accounts;

            foreach (Microsoft.Office.Interop.Outlook.Account account in accounts)
            {
                toolStripComboBox_Accounts.Items.Add(account.DisplayName);
            }

            if (accountsExist())
                toolStripComboBox_Accounts.SelectedIndex = 0;
        }

        private bool accountsExist()
        {
            return toolStripComboBox_Accounts.Items.Count > 0;
        }

        private void toolStripButtonReadEmail_Click(object sender, EventArgs e)
        {
            actionReadEmails();
        } 

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            outlookApp = null;
        }

        private void listBoxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutlookEmailItem selectedMail = null;

            if (listBoxEmails.SelectedItem != null)
                selectedMail = listBoxEmails.SelectedItem as OutlookEmailItem;

            if (selectedMail != null && selectedMail.MailItem != null)
            {
                txtSubject.Text = selectedMail.MailItem.Subject;
                webBody.DocumentText = selectedMail.MailItem.HTMLBody;
            }
            else
            {
                txtSubject.Text = "Email nicht gefunden!";
                webBody.DocumentText = "";
            }
        }

        #region read emails
        private string _account;
        private string _inbox1;
        private string _inbox2;

        public string Account
        {
            get
            {
                return _account;
            }

            set
            {
                _account = value;
            }
        }

        public string Inbox1
        {
            get
            {
                return _inbox1;
            }

            set
            {
                _inbox1 = value;
            }
        }

        public string Inbox2
        {
            get
            {
                return _inbox2;
            }

            set
            {
                _inbox2 = value;
            }
        }

        private void actionReadEmails()
        {
            if (accountsExist())
            {
                listBoxEmails.Items.Clear();
  
               readInboxAsync(
                //  readInbox(
                    toolStripComboBox_Accounts.Text,
                    Properties.Settings.Default.inboxName_DE,
                    Properties.Settings.Default.inboxName_EN);
            }
        }

        private void readInbox(string account, string inbox1, string inbox2)
        {
            outlookNamespace.Logon("", "", false, null);
            Microsoft.Office.Interop.Outlook.MAPIFolder folder = null;

            try
            {
                folder = outlookNamespace.Folders[account].Folders[inbox1];
            }
            catch (Exception)
            {
                folder = outlookNamespace.Folders[account].Folders[inbox2];
            }

            foreach (var item in folder.Items)
            {
                try
                {
                    Microsoft.Office.Interop.Outlook.MailItem mailItem = item as Microsoft.Office.Interop.Outlook.MailItem;
                    listBoxEmails.Items.Add(new OutlookEmailItem(mailItem));
                }
                catch (Exception) { }
            }
        }

        private async void readInboxAsync(string account, string inbox1, string inbox2)
        {
            Account = account;
            Inbox1 = inbox1;
            Inbox2 = inbox2;

            await Task.Run(() => readInbox());
        }

        private void readInbox()
        {
            readInbox(Account, Inbox1, Inbox2);
        }
        #endregion

        #region detect language
        private void actionDetectLanguage(bool useModeartorClient)
        {
            txtCheckResult.Text = "";
            mainStatus.Text = "Spracherkennung-Abfrage von Email \"{0}\"".Include(txtSubject.Text);

            if (useModeartorClient)
                IdentifyLanguage();
            else
                QueryLanguageAsync();
        }

        private async void IdentifyLanguage()
        {
            var subject = txtSubject.Text;

            if (subject.IsNullOrEmptyOrWhitespace()) return;

            var result = await this.client.IdentifyLanguageAsync(subject, Constants.MediaType.Plain);
            mainStatus.Text = "OK (Spracherkennung der Email \"{0}\")".Include(subject);

            if (result != null)              
            {
                txtCheckResult.Text = "Sprache=\"{0}\"; Status: {1}; Tracking-ID={2}".Include(result.DetectedLanguage, result.Status.ToString(), result.TrackingId);

                if (result.Status != null
                 && result.Status.Code == "3000"
                 && !result.DetectedLanguage.IsNullOrEmptyOrWhitespace())
                {
                    toolStripTextBoxDetectedLanguage.Text = result.DetectedLanguage;
                }
            }            
        }

        private async void QueryLanguageAsync()
        {
            var subject = txtSubject.Text;
            var response = await QueryLanguageAsync(subject, "text/plain");

            mainStatus.Text = "Spracherkennung fertig.";

            if (response != null)
            {
                txtCheckResult.Text = await response.Content.ReadAsStringAsync();
                mainStatus.Text = "OK (Spracherkennung der Email \"{0}\")".Include(subject);
            }
            else
            {
                txtCheckResult.Text = "Leere Antwort";
            }
        }

        private static async Task<HttpResponseMessage> QueryLanguageAsync(string data, string dataType)
        {
            return await QueryLanguageAsync(Encoding.Unicode.GetBytes(data), dataType);
        }

        private static async Task<HttpResponseMessage> QueryLanguageAsync(byte[] byteData, string dataType)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add(
                Properties.Settings.Default.OcpApimSubscriptionKey, 
                Properties.Settings.Default.ContentModerator_SubscriptionKey
                );
            
           var uri = Properties.Settings.Default.CognitiveServicesUri_ContentModerator_DetectLanguage + queryString;


            using (var content = new ByteArrayContent(byteData))
            {
               content.Headers.ContentType = new MediaTypeHeaderValue(dataType);
               return await client.PostAsync(uri, content);
            }
        }
        #endregion

        #region moderate content
        private void actionModerateContent()
        {
            txtCheckResult.Text = "";
            mainStatus.Text = "Inhalt-Moderation von Email \"{0}\"".Include(txtSubject.Text);
            ModerateContentAsync();
        }

        private async void ModerateContentAsync()
        {
            // vaidate
            if (webBody.DocumentText.IsNullOrEmptyOrWhitespace()) return;

            // go!
            var subject = txtSubject.Text;

            var lang = toolStripTextBoxDetectedLanguage.Text;
            if (lang.IsNullOrEmptyOrWhitespace())
                lang = Properties.Settings.Default.DefaultLanguage;

            var response = await this.client.ScreenTextAsync(webBody.DocumentText, Constants.MediaType.Html, lang,
                Properties.Settings.Default.ContentModerator_AutoCorrect,
                Properties.Settings.Default.ContentModerator_AnalyzeUrl,
                Properties.Settings.Default.ContenetModerator_DetectPII,
                "");

            mainStatus.Text = "Inhalt-Moderation der Email \"{0}\" ist fertig".Include(subject);

            if (response != null)
            {
                txtCheckResult.Text = response.ToString();
                mainStatus.Text = "OK (Inhalt-Moderation  der Email \"{0}\")".Include(subject);
            }
            else
            {
                txtCheckResult.Text = "Leere Antwort";
            }
        }
        #endregion

        private void toolStripLabelQueryEmails_Click(object sender, EventArgs e)
        {
            actionReadEmails();
        }

        private void toolStripButtonDetectLanguage_Click(object sender, EventArgs e)
        {
            actionDetectLanguage(Properties.Settings.Default.UserModeratorClient);
        }

        private void toolStripLabelDetectLanguage_Click(object sender, EventArgs e)
        {
            actionDetectLanguage(Properties.Settings.Default.UserModeratorClient);
        }

        private void toolStripLabelModerateContent_Click(object sender, EventArgs e)
        {
            actionModerateContent();
        }

        private void toolStripButtonModerateContent_Click(object sender, EventArgs e)
        {
            actionModerateContent();
        }
    }
}
