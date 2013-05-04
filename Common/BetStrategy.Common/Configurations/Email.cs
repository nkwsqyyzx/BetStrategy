using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WSQ.CSharp.Configuration;

namespace BetStrategy.Common.Configurations
{
    internal enum EmailKey
    {
        [Config(typeof(EmailConfig))]
        CONTENT
    }

    public class EmailConfig
    {
        private static string FILE = "email.json.txt";

        private static EmailConfig _instance;
        public static EmailConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    Init();
                }
                return _instance;
            }
        }

        private static IConfig config = null;
        private static void Init()
        {
            config = ConfigurationManager.GetInstance(FILE, (cfg) =>
            {
                cfg.Set(EmailKey.CONTENT, new EmailConfig()
                {
                    Username = "you@gmail.com",
                    Password = "yourgmailpassword",
                    ToAddress = new List<string>() { "mailaddress1@yourfavorite.com", "mailaddress1@yourfavorite.com" }
                });
            });
            _instance = config.Get<EmailConfig>(EmailKey.CONTENT);
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<string> ToAddress { get; set; }
    }
}
