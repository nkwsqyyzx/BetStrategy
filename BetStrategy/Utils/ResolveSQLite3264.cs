using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BetStrategy.Utils
{
    public class ResolveSQLite3264
    {
        public static void CopySQLiteDll()
        {
            string filename = "";
            if (Environment.Is64BitProcess) // or for .NET4 use Environment.Is64BitProcess
            {
                filename = "System.Data.SQLite.x64.dll";
            }
            else
            {
                filename = "System.Data.SQLite.x86.dll";
            }
            filename = Path.Combine(System.Windows.Forms.Application.StartupPath, filename);
            File.Copy(filename, "System.Data.SQLite.dll", true);
        }
    }
}
