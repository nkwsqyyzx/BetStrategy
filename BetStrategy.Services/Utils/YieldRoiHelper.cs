using BetStrategy.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using WSQ.CSharp.Extensions;

namespace BetStrategy.Services.Utils
{
    public class YieldRoiHelper
    {
        private static float GainLose(Recommend r)
        {
            switch (r.PreferResult)
            {
                case PreferResult.Waiting: return .0f;
                case PreferResult.Lose: return -1.0f;
                case PreferResult.LoseHalf: return -.5f;
                case PreferResult.Useless: return .0f;
                case PreferResult.WinHalf: return 0.5f * r.Odds;
                case PreferResult.Win: return 1.0f * r.Odds;
                default:
                    return .0f;
            }
        }

        public static float CalculateYield(IEnumerable<Recommend> recs)
        {
            var total = 0.0f;
            recs.Enumerate((i) => total += GainLose(i));
            return recs.Count() > 0 ? total / recs.Count() : .0f;
        }

        public static void RefreshProfit(IEnumerable<Recommend> recs, Person p)
        {
            p.Total = recs.Count();
            p.Win = recs.Count((i) => i.PreferResult == PreferResult.Win);
            p.WinHalf = recs.Count((i) => i.PreferResult == PreferResult.WinHalf);
            p.Lose = recs.Count((i) => i.PreferResult == PreferResult.Lose);
            p.LoseHalf = recs.Count((i) => i.PreferResult == PreferResult.LoseHalf);
            p.Draw = recs.Count((i) => i.PreferResult == PreferResult.Useless);
            p.Profit = p.WinHalf * 0.5f + p.Win - p.LoseHalf * 0.5f - p.Lose;
        }

        public static float CalculateRoi(IEnumerable<Recommend> recs)
        {
            var total = 0.0f;
            recs.Enumerate((i) => total += GainLose(i));
            return total;
        }
    }
}
