using System;
using System.Net.Mail;
using System.Net.Mime;

namespace Main.yonor
{
    /// <summary>
    /// Summary description for Smtp
    /// </summary>


    public class Mailer
    {

        public int smtpPortSrv { get; set; }
        public string smtpUserSrv { get; set; }
        public string smtpUser { get; set; }
        public string smtpPassSrv { get; set; }

        private string SmtpHost;
        MailMessage mail = new MailMessage("DONT-REPLY@me.com", "user@hotmail.com");
        SmtpClient client = new SmtpClient();

        public Mailer()
        {
            //
            // TODO: Add constructor logic here
            //
            
            client.Port = SmtpSrvPort;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = SmtpHost;
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            
        }

        public void SendEmail()
        {
            client.Send(mail);
        }
        
    }

}
