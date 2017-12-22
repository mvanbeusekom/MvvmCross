using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using UIKit;

namespace Playground.iOS.ValueConverters
{
    public class RandomColorValueConverter : IMvxValueConverter
    {
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var colors = new UIColor[] {
                UIColor.Black,
                UIColor.Blue,
                UIColor.Brown,
                UIColor.Cyan,
                UIColor.Green,
                UIColor.Gray,
                UIColor.Magenta,
                UIColor.Orange,
                UIColor.Purple,
                UIColor.Red,
                UIColor.Yellow
            };

            var random = new Random();
            var index = random.Next(0, 10);

            return colors[index];
        }
    }
}
