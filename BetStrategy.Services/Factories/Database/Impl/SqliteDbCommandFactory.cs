using BetStrategy.Domain.Models;
using System.Data.Common;
using System.Data.SQLite;
using BetStrategy.Services.Utils;

namespace BetStrategy.Services.Factories
{
    class SqliteDbCommandFactory : IDbCommandFactory
    {
        private string connectionString;
        public SqliteDbCommandFactory(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        private SQLiteConnection _conn;
        private void EnsureConnect()
        {
            if (_conn == null)
            {
                _conn = new SQLiteConnection(connectionString);
                _conn.Open();
            }
        }

        private SQLiteConnection Connection
        {
            get
            {
                EnsureConnect();
                return _conn;
            }
        }

        public DbCommand GetDbCommand()
        {
            return new SQLiteCommand(Connection);
        }

        public string GetReplaceRecommendSql(Recommend rec)
        {
            return DBHelper.ReplaceCommand(rec);
        }
    }
}
