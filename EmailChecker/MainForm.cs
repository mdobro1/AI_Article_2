using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using System.Text;

namespace EmailChecker
{
    public partial class MainForm : Form
    {
        Microsoft.Office.Interop.Outlook.Application outlookApp;
        Microsoft.Office.Interop.Outlook.NameSpace outlookNamespace;
        Microsoft.Office.Interop.Outlook.Accounts accounts;

        public MainForm()
        {
            InitializeComponent();

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
        private void actionDetectLanguage()
        {
            QueryLanguageAsync();
        }

        private async void QueryLanguageAsync()
        {
            var response = await QueryLanguageAsync(txtSubject.Text, "text/plain");

            if (response != null)
            {
                var content = await response.Content.ReadAsStringAsync();
                MessageBox.Show(content);
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
                //"Ocp-Apim-Subscription-Key", "6f81a959248444388738f0ef0e4b5b35"
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

        private void toolStripLabelQueryEmails_Click(object sender, EventArgs e)
        {
            actionReadEmails();
        }

        private void toolStripButtonDetectLanguage_Click(object sender, EventArgs e)
        {
            actionDetectLanguage();
        }

        private void toolStripLabelDetectLanguage_Click(object sender, EventArgs e)
        {
            actionDetectLanguage();
        }

        private void toolStripLabelModerateContent_Click(object sender, EventArgs e)
        {
            actionModerateContent();
        }

        private static void actionModerateContent()
        {
            ;
        }

        private void toolStripButtonModerateContent_Click(object sender, EventArgs e)
        {
            actionModerateContent();
        }
    }
}
