using BetStrategy.Domain.Models;
using BetStrategy.Services.Factories;
using BetStrategy.Services.Recommends.Wrappers;
using BetStrategy.Services.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WSQ.CSharp.Extensions;

namespace BetStrategy.Services.Impl.Wrappers
{
    class DatabaseWrapper : ILocalWrapper
    {
        private IDbCommandFactory commandFactory;
        public DatabaseWrapper(IDbCommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public void SaveRecommend(Recommend rec)
        {
            using (var cmd = commandFactory.GetDbCommand())
            {
                cmd.CommandText = commandFactory.GetReplaceRecommendSql(rec);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveRecommends(IEnumerable<Recommend> recs)
        {
            recs.Enumerate(SaveRecommend);
        }

        public void GetAllPerson(Action<string> onPerson, Action finish = null)
        {
            using (var cmd = commandFactory.GetDbCommand())
            {
                cmd.CommandText = DBHelper.sql_all_person;
                cmd.CommandType = CommandType.Text;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        onPerson(reader["Person"] as string);
                    }
                }
            }
            if (finish != null)
            {
                finish();
            }
        }

        public void GetPersons(Action<Person> onPerson, Action finish = null)
        {
            using (var cmd = commandFactory.GetDbCommand())
            {
                cmd.CommandText = DBHelper.sql_all_yield_person;
                cmd.CommandType = CommandType.Text;
                using (IDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        onPerson(DBHelper.PersonFromReader(reader));
                    }
                }
            }
            if (finish != null)
            {
                finish();
            }
        }

        public void GetRecommendsBySql(string sql, Action<Recommend> onRecommend, Action finish, Action<Exception> onSqlError)
        {
            using (var cmd = commandFactory.GetDbCommand())
            {
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                try
                {
                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            onRecommend(DBHelper.RecommendFromReader(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    onSqlError(ex);
                }
            }
            if (finish != null)
            {
                finish();
            }
        }
    }
}
