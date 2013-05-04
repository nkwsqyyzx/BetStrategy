
namespace BetStrategy.Models
{
    public enum PreferResult
    {
	/// <summary>
	/// 等待
	/// </summary>
 	Waiting = 0,
	/// <summary>
	/// 输盘
	/// </summary>
	Lose,
	/// <summary>
	/// 输半
	/// </summary>
	LoseHalf,
	/// <summary>
	/// 走盘
	/// </summary>
	Useless,
	/// <summary>
	/// 赢半
	/// </summary>
	WinHalf,
	/// <summary>
	/// 赢盘
	/// </summary>
	Win
    }
}
