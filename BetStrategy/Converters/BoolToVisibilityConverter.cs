using System;
using System.Windows;
using System.Windows.Data;

namespace BetStrategy.Converters
{
    /// <summary>
    /// Bool value to visibility converter
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        public BoolToVisibilityConverter() { }
        #endregion

        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool bValue = (value is bool) && (bool)value;

            if (parameter != null)
            {
                if (!Boolean.Parse((string)parameter))
                {
                    bValue = !bValue;
                }
            }
            return bValue ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            bool ret = (visibility == Visibility.Visible);
            if (parameter != null)
            {
                if (!(bool)parameter)
                {
                    ret = !ret;
                }
            }
            return ret;
        }
        #endregion
    }
}
