using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Chess.Converters
{
    public class ColorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Chess.Models.Color chessColor)
            {
                return chessColor == Chess.Models.Color.White ? Brushes.White : Brushes.Black;
            }

            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
