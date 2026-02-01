using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

namespace Calculadora;

public class BoolToBoxShadowConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool boolValue && boolValue)
        {
            return BoxShadows.Parse("0 1 2 0 #40000000");
        }
        return new BoxShadows();
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
