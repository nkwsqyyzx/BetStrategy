using BetStrategy.Models;
using BetStrategy.Properties;
using System;
using System.Windows;
using System.Windows.Data;

namespace BetStrategy.Converters
{
    public static class PreferResultExtention
    {
        public static string ConvertToString(this PreferResult pr)
        {
            switch (pr)
            {
                case PreferResult.Waiting:
                    return Resources.Waiting;
                case PreferResult.Lose:
                    return Resources.Lose;
                case PreferResult.LoseHalf:
                    return Resources.LoseHalf;
                case PreferResult.Useless:
                    return Resources.Useless;
                case PreferResult.WinHalf:
                    return Resources.WinHalf;
                case PreferResult.Win:
                    return Resources.Win;
                default:
                    return Resources.Useless;
            }
        }
    }

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
            PreferResult result = PreferResult.Useless;
            if (value is PreferResult)
            {
                result = (PreferResult)value;
            }
            return result.ConvertToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PreferResult result = PreferResult.Useless;

            if (value is string)
            {
                string sz = value as string;
                if (sz.Equals(Resources.Waiting)) result = PreferResult.Waiting;
                if (sz.Equals(Resources.Lose)) result = PreferResult.Lose;
                if (sz.Equals(Resources.LoseHalf)) result = PreferResult.LoseHalf;
                if (sz.Equals(Resources.WinHalf)) result = PreferResult.WinHalf;
                if (sz.Equals(Resources.Win)) result = PreferResult.Win;
            }

            return result;
        }
        #endregion
    }
}
