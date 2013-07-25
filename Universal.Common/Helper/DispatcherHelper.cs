using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace WSQ.CSharp.Helper
{
    public static class DispatcherHelper
    {
        private static Action<Action> _executor = action => action();

        /// <summary>
        /// 初始化时绑定当前UI框架
        /// </summary>
        public static void InitializeDispatcher()
        {
            var dispatcher = Dispatcher.CurrentDispatcher;
            _executor = action =>
            {
                if (dispatcher.CheckAccess())
                    action();
                else
                    dispatcher.BeginInvoke(action);
            };
        }

        /// <summary>
        /// 在UI线程上执行
        /// </summary>
        /// <param name="action"></param>
        public static void OnUIThread(Action action)
        {
            _executor(action);
        }

        /// <summary>
        /// 在UI上执行
        /// </summary>
        /// <param name="action"></param>
        public static void RunOnUI(this Action action)
        {
            OnUIThread(action);
        }
    }
}
