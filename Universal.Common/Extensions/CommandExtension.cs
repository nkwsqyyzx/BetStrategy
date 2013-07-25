using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace WSQ.CSharp.Extensions
{
    public static class CommandExtension
    {
        public static ICommand RelayCommand(this ICommand command, Action execute)
        {
            if (command == null)
                command = new RelayCommand(execute);
            return command;
        }

        public static ICommand RelayCommand<T>(this ICommand command, Action<T> execute)
        {
            if (command == null)
                command = new RelayCommand<T>(execute);
            return command;
        }
    }
}
