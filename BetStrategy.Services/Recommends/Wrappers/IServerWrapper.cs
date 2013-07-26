using BetStrategy.Domain.Models;
using System;
using System.Collections.Generic;

namespace BetStrategy.Services.Recommends.Wrappers
{
    interface IServerWrapper
    {
        void Download(int startPage, int endPage, Action<IEnumerable<Recommend>> onRecommends, Action finish);
    }
}
