using BetStrategy.Domain.Models;
using System.Data.Common;

namespace BetStrategy.Services.Factories
{
    interface IDbCommandFactory
    {
        DbCommand GetDbCommand();
        string GetReplaceRecommendSql(Recommend rec);
    }
}
