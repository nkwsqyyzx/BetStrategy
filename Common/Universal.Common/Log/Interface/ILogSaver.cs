using System;

namespace WSQ.CSharp.Log
{
    public interface ILogSaver
    {
        void Debug(string messageOrFormat, object[] args = null);
        void Info(string messageOrFormat, object[] args = null);
        void Warn(string messageOrFormat, object[] args = null);
        void Error(string messageOrFormat, object[] args = null);
        void Fatal(string messageOrFormat, object[] args = null);

        void SaveException(Exception e);
        void SaveStackTrace();
    }
}
