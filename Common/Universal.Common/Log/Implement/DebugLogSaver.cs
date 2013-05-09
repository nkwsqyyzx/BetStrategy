using System;
using System.Diagnostics;
using System.Globalization;

namespace WSQ.CSharp.Log
{
    class DebugLogSaver : ILogSaver
    {
        private void Write(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        public void Debug(string messageOrFormat, object[] args)
        {
            string message = args == null ? messageOrFormat : string.Format(CultureInfo.CurrentCulture, messageOrFormat, args);
            Write("DEBUG:" + message);
        }

        public void Info(string messageOrFormat, object[] args)
        {
            string message = args == null ? messageOrFormat : string.Format(CultureInfo.CurrentCulture, messageOrFormat, args);
            Write("INFO:" + message);
        }

        public void Warn(string messageOrFormat, object[] args)
        {
            string message = args == null ? messageOrFormat : string.Format(CultureInfo.CurrentCulture, messageOrFormat, args);
            Write("WARN:" + message);
        }

        public void Error(string messageOrFormat, object[] args)
        {
            string message = args == null ? messageOrFormat : string.Format(CultureInfo.CurrentCulture, messageOrFormat, args);
            Write("ERROR:" + message);
        }

        public void Fatal(string messageOrFormat, object[] args)
        {
            string message = args == null ? messageOrFormat : string.Format(CultureInfo.CurrentCulture, messageOrFormat, args);
            Write("FATAL:" + message);
        }

        public void SaveException(Exception e)
        {
            Write("EXCEPTION:" + e.Message);
        }

        public void SaveStackTrace()
        {
            Write("STACKTRACE:" + new StackTrace().ToString());
        }
    }
}
