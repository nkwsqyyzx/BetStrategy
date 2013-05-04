using System;
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net;
using WSQ.CSharp.Helper;
using BetStrategy.Common.Configurations;

namespace EmailSender.Test
{
    [TestClass]
    public class EmailSenderTest
    {
        [TestMethod]
        public void TestSendEmailUseGmail()
        {
            string gmailHost = "smtp.gmail.com";
            string userName = "";
            string password = "";
            string sendTo = "";

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = gmailHost;
            client.Timeout = 60000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(userName, password);

            MailMessage objeto_mail = new MailMessage();
            objeto_mail.From = new MailAddress(userName);
            objeto_mail.To.Add(new MailAddress(sendTo));
            objeto_mail.Subject = "this is the Subject.";
            objeto_mail.Body = "Body goes here.";

            client.Send(objeto_mail);
        }

        [TestMethod]
        public void TestSendEmailVia163() 
        {
            string host = "smtp.163.com";
            string userName = "";
            string password = "";
            string sendTo = "";

            SmtpClient client = new SmtpClient()
            {
                Host = host,
                EnableSsl = true,
                Port = 465,
                Timeout = 60000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password)
            };

            MailMessage meseage = new MailMessage();
            meseage.From = new MailAddress(userName);
            meseage.To.Add(new MailAddress(sendTo));
            meseage.Subject = "this is the subject";
            meseage.Body = "this is the body";

            client.Send(meseage);
        }

        [TestMethod]
        public void TestEmaiSender() 
        {
            EmailHelper.SendEmailViaGmail(EmailConfig.Instance.Username,EmailConfig.Instance.ToAddress,EmailConfig.Instance.Username,EmailConfig.Instance.Password,"Subject","Body");
        }

        [TestMethodAttribute]
        public void TestSendEmailUseHotmail() 
        {
            EmailHelper.SendEmailViaHotmail("", EmailConfig.Instance.ToAddress, "", "", "Subject", "Body");
        }
    }
}
