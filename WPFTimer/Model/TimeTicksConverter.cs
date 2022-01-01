using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFTimer.Model
{
    public class TimeTicksConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Length == 1)
            {
                return $"0{value}";
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
