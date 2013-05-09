using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSQ.CSharp.Log
{
    public class LogManager
    {
        private static LogManager _instance = new LogManager();
        public static LogManager Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
