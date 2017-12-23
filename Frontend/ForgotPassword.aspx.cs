using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frontend
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {
            MailMessage mm = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            mm.From = e.Message.From;
            mm.Subject = e.Message.Subject.ToString();
            mm.To.Add(e.Message.To[0]);
            mm.Body = e.Message.Body;
            mm.ReplyTo = e.Message.From;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.Credentials = new System.Net.NetworkCredential("info@tripadapt.com", "tripadapt@info");
            //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            e.Cancel = true;
        }
    }
}