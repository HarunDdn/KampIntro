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
            string[] mailadresleri = { "harun.didin83@gmail.com"};//mail göndermek istediğiniz adresler

            
            string str="Test";
            
            

            for (int i = 0; i <= mailadresleri.Length - 1; i++)
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("*****.com");//maili gönderecek olan server port

                    mail.From = new MailAddress("****@****.com**");//maili gönderecek olan kişi
                    mail.To.Add(mailadresleri[i]);
                    mail.Subject = "TEST AMAÇLI GONDERDIM";//mail konusu

                    mail.IsBodyHtml = true;
                    string htmlBody;

                    htmlBody = str;

                    mail.Body = htmlBody;

                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("*****@****.com", "*****");//göndericinin kullanıcı adı, parolası
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
