using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Opp3_Form
{
    class MailGonderService : IBilgilendirmeService
    {
        public void Bilgilendir()
        {
            SendEmail();
        }
        private void SendEmail()
        {
            string[] mailadresleri = { "harun.didin83@gmail.com"};

            
            string str="Test";
            
            

            for (int i = 0; i <= mailadresleri.Length - 1; i++)
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("mail.debak.com.tr");

                    mail.From = new MailAddress("admin1@debak.com.tr");
                    mail.To.Add(mailadresleri[i]);
                    mail.Subject = "TEST AMAÇLI GONDERDIM";

                    mail.IsBodyHtml = true;
                    string htmlBody;

                    htmlBody = str;

                    mail.Body = htmlBody;

                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("admin1@debak.com.tr", "Adm2020");
                    SmtpServer.EnableSsl = false;

                    SmtpServer.Send(mail);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }
        
    }
}
