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
