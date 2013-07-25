using BetStrategy.Domain.Models;
using BetStrategy.Properties;
using System;
using System.Windows.Data;
using BetStrategy.Services.Utils;

namespace BetStrategy.Converters
{
    /// <summary>
    /// Bool value to visibility converter
    /// </summary>
    public class PreferResultToStringConverter : IValueConverter
    {
        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        public PreferResultToStringConverter() { }
        #endregion

        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return PreferResultHelper.Convert(value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return PreferResultHelper.ConvertBack(value, targetType, parameter, culture);
        }
        #endregion
    }
}
