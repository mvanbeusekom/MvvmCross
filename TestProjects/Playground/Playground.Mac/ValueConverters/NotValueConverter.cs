using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace Playground.Mac.ValueConverters
{
    public class NotValueConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }
    }
}
