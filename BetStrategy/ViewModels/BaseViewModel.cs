using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace BetStrategy.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChange<T>(Expression<Func<T>> expression)
        {
            if (PropertyChanged != null)
            {
                var propertyName = ((MemberExpression)expression.Body).Member.Name;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}