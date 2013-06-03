using BetStrategy.ViewModels;
using BetStrategy.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace BetStrategy.Utils
{
    public class ViewHelper
    {
        private static Dictionary<string, Window> Windows = new Dictionary<string, Window>();

	/// <summary>
	/// 查看推荐人的所有推荐
	/// </summary>
	/// <param name="name"></param>
        public static void ViewPerson(string name)
        {
            Window window = null;
            if (Windows.ContainsKey(name))
            {
                window = Windows[name];
                window.Activate();
            }
            else
            {
                window = new RecommendsWindow();
                var vm = new RecommendsViewModel();
                window.DataContext = vm;
                window.Loaded += (o, e) => vm.Load(name);
                window.Closed += (o, e) => { Windows.Remove(name); };
                Windows[name] = window;
                window.Show();
            }
        }
    }
}
