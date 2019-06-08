using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using MAIN_GUI_Mangaer_window.ma_controller;

namespace Main.yonor
{
    /// <summary>
    /// Summary description for Smtp
    /// </summary>


    public static class Mailer
    {

        public static int smtpPortSrv { get; set; }
        public static string smtpHost { get; set; }
        public static string smtpUser { get; set; }
        public static string smtpPassSrv { get; set; }
        public static string recieptEmail { get; set; }
        public static MailMessage message = new MailMessage();
        public static SmtpClient smtp = new SmtpClient();
        
        public static void EmailAd()
        {

            using (StreamReader reader = File.OpenText(XmlParser.adTemp)) // Path to your 
            {
                try
                {

                    message.From = new MailAddress("main-delivery@yonor.me");
                    message.To.Add(new MailAddress("6yonor@gmail.com"));
                    message.Subject = "Test";
                    message.IsBodyHtml = true; //to make message body as html  
                    message.Body = reader.ReadToEnd();


                }
                catch (Exception) { }
            }
        }

        public static void SendEmail()
        {
            LoadClient();
            EmailAd();
            smtp.Send(message);

        }
        public static void LoadClient()
        {
            smtp.Port = 25;
            smtp.Host = "smtp.g-cloud.co.il"; //for gmail host  
                                              //smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("yizrael", "YI$123456");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        }

    }

}
