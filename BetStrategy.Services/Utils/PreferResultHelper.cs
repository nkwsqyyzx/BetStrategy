using BetStrategy.Domain.Models;
using BetStrategy.Services.Properties;
using System;

namespace BetStrategy.Services.Utils
{
    internal static class PreferResultExtention
    {
        internal static string ConvertToString(this PreferResult pr)
        {
            switch (pr)
            {
                case PreferResult.Waiting: return Resource.Waiting;
                case PreferResult.Lose: return Resource.Lose;
                case PreferResult.LoseHalf: return Resource.LoseHalf;
                case PreferResult.Useless: return Resource.Useless;
                case PreferResult.WinHalf: return Resource.WinHalf;
                case PreferResult.Win: return Resource.Win;
                default: return Resource.Useless;
            }
        }
    }

    public static class PreferResultHelper
    {
        #region IValueConverter Members
        public static string Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PreferResult result = PreferResult.Useless;
            if (value is PreferResult)
            {
                result = (PreferResult)value;
            }
            return result.ConvertToString();
        }

        public static PreferResult ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PreferResult result = PreferResult.Useless;

            if (value is string)
            {
                string sz = value as string;
                if (sz.Equals(Resource.Waiting)) result = PreferResult.Waiting;
                if (sz.Equals(Resource.Lose)) result = PreferResult.Lose;
                if (sz.Equals(Resource.LoseHalf)) result = PreferResult.LoseHalf;
                if (sz.Equals(Resource.WinHalf)) result = PreferResult.WinHalf;
                if (sz.Equals(Resource.Win)) result = PreferResult.Win;
            }

            return result;
        }
        #endregion
    }
}
