using System;
using System.Globalization;
using System.Windows.Data;

namespace Lindra_Market_v3.Utils;

public class SliderFillWidthConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length != 4
            || values[0] is not double value
            || values[1] is not double min
            || values[2] is not double max
            || values[3] is not double totalWidth
            || max <= min)
            return 0.0;

        var ratio = Math.Max(0, Math.Min(1, (value - min) / (max - min)));
        return ratio * totalWidth;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        => throw new NotSupportedException();
}