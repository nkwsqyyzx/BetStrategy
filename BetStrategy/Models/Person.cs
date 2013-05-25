
namespace BetStrategy.Models
{

    /// <summary>
    /// 推荐人
    /// </summary>
    public class Person
    {
	/// <summary>
	/// 总推荐场次
	/// </summary>
        public int Total { get; set; }

	/// <summary>
	/// 净胜场次
	/// </summary>
        public float Profit { get; set; }

	/// <summary>
	/// 赢的场次
	/// </summary>
        public int Win { get; set; }

	/// <summary>
	/// 赢半的场次
	/// </summary>
        public int WinHalf { get; set; }

	/// <summary>
	/// 输的场次
	/// </summary>
        public int Lose { get; set; }

	/// <summary>
	/// 输半的场次
	/// </summary>
        public int LoseHalf { get; set; }

	/// <summary>
	/// 走水场次
	/// </summary>
        public int Draw { get; set; }

	/// <summary>
	/// 名称
	/// </summary>
        public string Name { get; set; }
    }
}
