using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using DataAccess;
using System.Net.Mail;
using System.Web;
using System.Globalization;
using System.Collections;
using System.Net;
namespace BuisnessController
{
    public class UtilityBC
    {
        public static bool SendMail(string empname, string toMail)
        {
            bool status = false;
            try
            {
                // mailtemplateMacroBC objmacro = new mailtemplateMacroBC();
                //mailtemplateBL mltBL = new mailtemplateBL();
                //mailTemplateMacroBL mltmacroBL = new mailTemplateMacroBL();
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string mailbody = string.Empty;
                string physicalPath = string.Empty;
                string Subject = string.Empty;
                // var lst = mltBL.fetchmailtemplateBL(6);
                //var lst1 = custBL.fetchdetailscustomerBL(new Guid(DropDownList1.SelectedValue));




                Subject = "Registration Mail-" + empname;
                string AVerfierMail = System.Configuration.ConfigurationManager.AppSettings["AVerfier"];
                mm.To.Add(new MailAddress(toMail, "Display name To"));
                mm.To.Add(new MailAddress(AVerfierMail, "Display name To"));

                mailbody = "Welcome " + empname + "<br><br> Thanks for your registration.";


                mm.Subject = Subject;
                //for (int i = 0; i < lst[0].Lstflm.Count; i++)
                //{
                //    physicalPath = HttpContext.Current.Request.MapPath(lst[0].Lstflm[i].Link + "/" + lst[0].Lstflm[i].FilesNameoriginal);
                //    Attachment atch = new Attachment(physicalPath);
                //    mm.Attachments.Add(atch);
                //}
                string EmailSender = System.Configuration.ConfigurationManager.AppSettings["EmailSender"];
                string EmailText = System.Configuration.ConfigurationManager.AppSettings["EmailText"];
                string EmailPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
                string EmailServer = System.Configuration.ConfigurationManager.AppSettings["EmailServer"];
                string EmailPort = System.Configuration.ConfigurationManager.AppSettings["EmailPort"];
                mm.From = new MailAddress(EmailSender);
                mm.Body = mailbody;
                mm.IsBodyHtml = true;
                mm.ReplyTo = new MailAddress(EmailSender, EmailText);
                smtp.Host = EmailServer;
                smtp.Port = Convert.ToInt32(EmailPort);
                smtp.Credentials = new System.Net.NetworkCredential(EmailSender, EmailPassword);
                //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                status = true;
            }
            catch (Exception es)
            {
                status = false;
            }
            return status;



        }
        public static bool SendCommentMail(int id, string sender, string recevier, string emp, string senderemail, string recevieremail, string empemail, string comment, bool chk)
        {
            bool status = false;
            try
            {
                // mailtemplateMacroBC objmacro = new mailtemplateMacroBC();
                //mailtemplateBL mltBL = new mailtemplateBL();
                //mailTemplateMacroBL mltmacroBL = new mailTemplateMacroBL();
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string mailbody = string.Empty;
                string physicalPath = string.Empty;
                string Subject = string.Empty;
                string EmailSender = System.Configuration.ConfigurationManager.AppSettings["EmailSender"];
                string EmailText = System.Configuration.ConfigurationManager.AppSettings["EmailText"];
                string EmailPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
                string EmailServer = System.Configuration.ConfigurationManager.AppSettings["EmailServer"];
                string EmailPort = System.Configuration.ConfigurationManager.AppSettings["EmailPort"];
                // var lst = mltBL.fetchmailtemplateBL(6);
                //var lst1 = custBL.fetchdetailscustomerBL(new Guid(DropDownList1.SelectedValue));
                Subject = "New Message from " + sender;
                if (chk == true)
                {
                    var lst = EmployeeBC.getUserForMailsend(id);

                    if (lst.Count > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            mm.To.Add(new MailAddress(lst[i].EMAIL, "Display name To"));

                            // mm.To.Add(new MailAddress(AVerfierMail, "Display name To"));

                            mailbody = "Hello, " + lst[i].EMP_NAME + "<br> a new message arrived <br> Sender Name: " + sender + "<br> Receiver Name: " + recevier + "<br> Concern To: " + emp + "<br>Comment: " + comment;

                            mm.Subject = Subject;

                            mm.From = new MailAddress(EmailSender);
                            mm.Body = mailbody;
                            mm.IsBodyHtml = true;
                            mm.ReplyTo = new MailAddress(EmailSender, EmailText);
                            smtp.Host = EmailServer;
                            smtp.Port = Convert.ToInt32(EmailPort);
                            smtp.Credentials = new System.Net.NetworkCredential(EmailSender, EmailPassword);
                            //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                            smtp.EnableSsl = true;
                            smtp.Send(mm);
                            status = true;
                        }

                    }
                }
                else
                {
                    mm.To.Add(new MailAddress(recevieremail, "Display name To"));

                    mailbody = "Hello, " + recevier + "<br> a new message arrived <br> Sender Name: " + sender + "<br> Receiver Name: " + recevier + "<br> Concern To: " + emp + "<br>Comment: " + comment;
                    mm.Subject = Subject;

                    mm.From = new MailAddress(EmailSender);
                    mm.Body = mailbody;
                    mm.IsBodyHtml = true;
                    mm.ReplyTo = new MailAddress(EmailSender, EmailText);
                    smtp.Host = EmailServer;
                    smtp.Port = Convert.ToInt32(EmailPort);
                    smtp.Credentials = new System.Net.NetworkCredential(EmailSender, EmailPassword);
                    //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                    smtp.EnableSsl = true;
                    smtp.Send(mm);
                    status = true;
                }
                
            }
            catch (Exception es)
            {
                status = false;
            }
            return status;



        }
        public static bool SendShipAssignMail(string empname, string shipname, string empMail, string comname, string frmdate, string todate, string txt, string vrytxt)
        {
            bool status = false;
            try
            {
                // mailtemplateMacroBC objmacro = new mailtemplateMacroBC();
                //mailtemplateBL mltBL = new mailtemplateBL();
                //mailTemplateMacroBL mltmacroBL = new mailTemplateMacroBL();
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string mailbody = string.Empty;
                string physicalPath = string.Empty;
                string Subject = string.Empty;
                // var lst = mltBL.fetchmailtemplateBL(6);
                //var lst1 = custBL.fetchdetailscustomerBL(new Guid(DropDownList1.SelectedValue));


                if (txt == "ShipAssign")
                {
                    Subject = "Assign Ship " + empname;
                    
                    mm.To.Add(new MailAddress(empMail, "Display name To"));

                    mailbody = "Hello " + empname + "<br>You have been assigned to the ship " + shipname + " of " + comname + " from " + frmdate + " to " + todate;


                    mm.Subject = Subject;
                }
                if (txt == "Verify")
                {
                    Subject = vrytxt + empname;

                    mm.To.Add(new MailAddress(empMail, "Display name To"));

                    mailbody = "Hello " + empname + "<br>You are " + vrytxt + " for ship " + shipname + "of " + comname; ;


                    mm.Subject = Subject;
                }
                string EmailSender = System.Configuration.ConfigurationManager.AppSettings["EmailSender"];
                string EmailText = System.Configuration.ConfigurationManager.AppSettings["EmailText"];
                string EmailPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
                string EmailServer = System.Configuration.ConfigurationManager.AppSettings["EmailServer"];
                string EmailPort = System.Configuration.ConfigurationManager.AppSettings["EmailPort"];
                mm.From = new MailAddress(EmailSender);
                mm.Body = mailbody;
                mm.IsBodyHtml = true;
                mm.ReplyTo = new MailAddress(EmailSender, EmailText);
                smtp.Host = EmailServer;
                smtp.Port = Convert.ToInt32(EmailPort);
                smtp.Credentials = new System.Net.NetworkCredential(EmailSender, EmailPassword);
                //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                status = true;
            }
            catch (Exception es)
            {
                status = false;
            }
            return status;



        }
        public static bool SendShipAssignMailToAdmin(string empname, string shipname, string adminMail, string clientMail, string comname,string frmdate,string todate, string txt, string vrytxt)
        {
            bool status = false;
            try
            {
                // mailtemplateMacroBC objmacro = new mailtemplateMacroBC();
                //mailtemplateBL mltBL = new mailtemplateBL();
                //mailTemplateMacroBL mltmacroBL = new mailTemplateMacroBL();
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string mailbody = string.Empty;
                string physicalPath = string.Empty;
                string Subject = string.Empty;
                // var lst = mltBL.fetchmailtemplateBL(6);
                //var lst1 = custBL.fetchdetailscustomerBL(new Guid(DropDownList1.SelectedValue));


                if (txt == "ShipAssign")
                {
                    Subject = "Assign Ship " + empname;

                    mm.To.Add(new MailAddress(adminMail, "Display name To"));
                    mm.To.Add(new MailAddress(clientMail, "Display name To"));

                    mailbody = "This " + shipname + "ship of " + comname + "<br>is assigned to " + empname + " from " + frmdate + " to " + todate;


                    mm.Subject = Subject;
                }
                if (txt == "Verify")
                {
                    Subject = vrytxt + empname;

                    mm.To.Add(new MailAddress(adminMail, "Display name To"));
                    mm.To.Add(new MailAddress(clientMail, "Display name To"));

                    mailbody = empname + "<br>has been " + vrytxt + " for ship " + shipname + " of " + comname;


                    mm.Subject = Subject;
                }
                string EmailSender = System.Configuration.ConfigurationManager.AppSettings["EmailSender"];
                string EmailText = System.Configuration.ConfigurationManager.AppSettings["EmailText"];
                string EmailPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
                string EmailServer = System.Configuration.ConfigurationManager.AppSettings["EmailServer"];
                string EmailPort = System.Configuration.ConfigurationManager.AppSettings["EmailPort"];
                mm.From = new MailAddress(EmailSender);
                mm.Body = mailbody;
                mm.IsBodyHtml = true;
                mm.ReplyTo = new MailAddress(EmailSender, EmailText);
                smtp.Host = EmailServer;
                smtp.Port = Convert.ToInt32(EmailPort);
                smtp.Credentials = new System.Net.NetworkCredential(EmailSender, EmailPassword);
                //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                status = true;
            }
            catch (Exception es)
            {
                status = false;
            }
            return status;



        }

        public static bool SendContactMail(string name, string toMail,string email,string phone,string qry)
        {
            bool status = false;
            try
            {
                // mailtemplateMacroBC objmacro = new mailtemplateMacroBC();
                //mailtemplateBL mltBL = new mailtemplateBL();
                //mailTemplateMacroBL mltmacroBL = new mailTemplateMacroBL();
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string mailbody = string.Empty;
                string physicalPath = string.Empty;
                string Subject = string.Empty;
                // var lst = mltBL.fetchmailtemplateBL(6);
                //var lst1 = custBL.fetchdetailscustomerBL(new Guid(DropDownList1.SelectedValue));




                Subject = "Contact Mail From-" + name;
                //string AVerfierMail = System.Configuration.ConfigurationManager.AppSettings["AVerfier"];
                mm.To.Add(new MailAddress(toMail, "Display name To"));
                //mm.To.Add(new MailAddress(AVerfierMail, "Display name To"));

                mailbody = "Hello,<br> Name: " + name + "<br>Email:" + email + "<br>Phone:" + phone + "<br>Query:" + qry;


                mm.Subject = Subject;
                //for (int i = 0; i < lst[0].Lstflm.Count; i++)
                //{
                //    physicalPath = HttpContext.Current.Request.MapPath(lst[0].Lstflm[i].Link + "/" + lst[0].Lstflm[i].FilesNameoriginal);
                //    Attachment atch = new Attachment(physicalPath);
                //    mm.Attachments.Add(atch);
                //}
                string EmailSender = System.Configuration.ConfigurationManager.AppSettings["EmailSender"];
                string EmailText = System.Configuration.ConfigurationManager.AppSettings["EmailText"];
                string EmailPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
                string EmailServer = System.Configuration.ConfigurationManager.AppSettings["EmailServer"];
                string EmailPort = System.Configuration.ConfigurationManager.AppSettings["EmailPort"];
                mm.From = new MailAddress(EmailSender);
                mm.Body = mailbody;
                mm.IsBodyHtml = true;
                mm.ReplyTo = new MailAddress(EmailSender, EmailText);
                smtp.Host = EmailServer;
                smtp.Port = Convert.ToInt32(EmailPort);
                smtp.Credentials = new System.Net.NetworkCredential(EmailSender, EmailPassword);
                //smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                status = true;
            }
            catch (Exception es)
            {
                status = false;
            }
            return status;



        }
        private static bool checkFileExist(string filename)
        {
            bool exist = false;

            string saveFile = HttpContext.Current.Server.MapPath(filename);
            if (!File.Exists(saveFile))
            {
                exist = false;
            }
            else
            { exist = true; }
            return exist;
        }

        public static string GetImage(string path)
        {
            string savepath = HttpContext.Current.Server.MapPath("/uploads/" + path);
            //string savepath = "http://newdemo.infronthrs.com/UploadFiles/Images/" + saveToLocation + "/" + lstfile.FilesNameoriginal.Trim();
            string imageLocation = "/uploads/" + path;
            if (!checkFileExist(imageLocation))
            {
                WebClient webClient = new WebClient();
                string dwlpath = System.Configuration.ConfigurationManager.AppSettings["imgpath"];
                webClient.DownloadFile(dwlpath + imageLocation, savepath);
                //savepath = HttpContext.Current.Server.MapPath("\\UploadFiles\\Images\\" + saveToLocation + "\\" + lstfile.FilesNameoriginal.Trim());
                // savepath = "http://newdemo.infronthrs.com/UploadFiles/Images/" + saveToLocation + "\\" + lstfile.FilesNameoriginal.Trim();
            }
            return savepath;
        }
    
    }
}
