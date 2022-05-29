using System;
using System.Globalization;
using System.Windows.Data;

namespace VividWpf.UI.Converter
{
    [ValueConversion(typeof(string),typeof(bool))]
    public class String2BoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrWhiteSpace((string)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
