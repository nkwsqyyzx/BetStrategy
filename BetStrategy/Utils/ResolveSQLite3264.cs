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
            if (Environment.Is64BitOperatingSystem) // or for .NET4 use Environment.Is64BitProcess
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

        public static void HandleUnresovledAssemblies()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += currentDomain_AssemblyResolve;
        }

        private static Assembly currentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name == "System.Data.SQLite")
            {
                var path = Path.Combine("SQLite", "Native");

                if (Environment.Is64BitProcess) // or for .NET4 use Environment.Is64BitProcess
                {
                    path = Path.Combine(path, "64");
                }
                else
                {
                    path = Path.Combine(path, "32");
                }

                path = Path.Combine(path, "System.Data.SQLite.DLL");

                Assembly assembly = Assembly.LoadFrom(path);
                return assembly;
            }

            return null;
        }
    }
}
