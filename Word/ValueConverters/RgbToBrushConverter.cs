using System;
using System.Globalization;
using System.Windows.Media;

namespace Word.ValueConverters
{
    /// <summary>
    /// A converter that takes in the rgb string and returns a WPF brush.
    /// </summary>
    public class RgbToBrushConverter : BaseValueConverters<RgbToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)new BrushConverter().ConvertFrom($"#{value}");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
