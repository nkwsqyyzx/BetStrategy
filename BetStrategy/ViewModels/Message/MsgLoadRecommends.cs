using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetStrategy.ViewModels.Message
{
    public enum State 
    {
	Started,
	Finished
    }

    public class MsgLoadRecommends
    {
	/// <summary>
	/// 运行状态
	/// </summary>
        public State State;
    }
}
