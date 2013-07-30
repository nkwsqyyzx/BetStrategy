using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace WSQ.CSharp.Helper
{
    public static class EmailHelper
    {
        public static void SendEmailViaGmail(List<string> tos, string username, string password, string subject, string body)
        {
            string gmailHost = "smtp.gmail.com";

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = gmailHost;
            client.Timeout = 60000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(username, password);

            MailMessage objeto_mail = new MailMessage();
            objeto_mail.From = new MailAddress(username);
            foreach (var to in tos)
            {
                objeto_mail.To.Add(new MailAddress(to));
            }
            objeto_mail.Subject = subject;
            objeto_mail.Body = body;

            client.Send(objeto_mail);
        }

        public static void SendEmailViaHotmail(string from,
            List<string> tos,
            string username,
            string password,
            string subject,
            string body)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress(from);
            foreach (var to in tos)
            {
                mail.To.Add(new MailAddress(to));
            }
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}