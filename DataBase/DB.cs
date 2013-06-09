using DataBase.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DB
    {
        public void Test() 
        {
            using (SQLiteConnection db = new SQLiteConnection(Settings.Default.DB))
            {
                db.Open();
                SQLiteCommand cmd = new SQLiteCommand(db);
                cmd.CommandText = "select * from Table1";
                cmd.CommandType = CommandType.Text;
                using (var reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        System.Diagnostics.Debug.WriteLine(reader.ToString());
                    }
                }
            }
        }
    }
}
