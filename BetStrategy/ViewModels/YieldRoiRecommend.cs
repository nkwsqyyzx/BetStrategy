using BetStrategy.Domain.Models;

namespace BetStrategy.ViewModels
{
    public class YieldRoiRecommend
    {
        public YieldRoiPerson Person { get; private set; }
        public Recommend Recommend { get; private set; }

        public YieldRoiRecommend(Recommend recommend)
        {
            this.Recommend = recommend;
            this.Person = YieldRoiProvider.Instance.GetPerson(recommend.Person);
        }
    }
}
