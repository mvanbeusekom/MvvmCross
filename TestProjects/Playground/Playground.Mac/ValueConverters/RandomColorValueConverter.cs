using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using AppKit;

namespace Playground.Mac.ValueConverters
{
    public class RandomColorValueConverter : IMvxValueConverter
    {
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var colors = new NSColor[] {
                NSColor.Black,
                NSColor.Blue,
                NSColor.Brown,
                NSColor.Cyan,
                NSColor.Green,
                NSColor.Gray,
                NSColor.Magenta,
                NSColor.Orange,
                NSColor.Purple,
                NSColor.Red,
                NSColor.Yellow
            };

            var random = new Random();
            var index = random.Next(0, 10);

            return colors[index];
        }
    }
}
