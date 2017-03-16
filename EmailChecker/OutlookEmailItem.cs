
using Microsoft.Office.Interop.Outlook;

namespace EmailChecker
{
    public sealed class OutlookEmailItem
    {
        private Microsoft.Office.Interop.Outlook.MailItem _mailItem;

        protected OutlookEmailItem() {}

        public OutlookEmailItem(Microsoft.Office.Interop.Outlook.MailItem mailItem)
        {
            _mailItem = mailItem;
        }

        public MailItem MailItem
        {
            get
            {
                return _mailItem;
            }
        }

        public override string ToString()
        {
            if (this.MailItem == null)
                return null;
            else
                return this.MailItem.ReceivedTime + "  -  " + this.MailItem.Subject;
        }
    }
}
