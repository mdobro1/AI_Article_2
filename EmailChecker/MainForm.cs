using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (accountsExist())
            {
                listBoxEmails.Items.Clear();                

                readInboxAsync(
               // readInbox(
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

        private void readInbox()
        {
            readInbox(Account, Inbox1, Inbox2);
        }

            string _account; string _inbox1; string _inbox2;

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

        private async void readInboxAsync(string account, string inbox1, string inbox2)
        {
            Account = account;
            Inbox1 = inbox1;
            Inbox2 = inbox2;
            await Task.Run(() => readInbox());            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            outlookApp = null;
        }

        private void toolStripButtonValidate_Click(object sender, EventArgs e)
        {

        }

        private void listBoxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutlookEmailItem selectedMail = null;

            if (listBoxEmails.SelectedItem != null)
                selectedMail = listBoxEmails.SelectedItem as OutlookEmailItem;

            if (selectedMail != null)
            {
                txtSubject.Text = selectedMail.MailItem.Subject;
                webBody.DocumentText = selectedMail.MailItem.HTMLBody;
            }
        }
    }
}
