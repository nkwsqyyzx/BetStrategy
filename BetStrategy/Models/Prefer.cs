
namespace BetStrategy.Models
{
    /// <summary>
    /// 推荐的具体内容
    /// </summary>
    public class Prefer
    {
        /// <summary>
        /// 推荐内容.(球队名/大小球)
        /// </summary>
        public string Description { get; set; }

	/// <summary>
	/// 统一推荐
	/// </summary>
        public string UniformDescription { get; set; }
    }
}
