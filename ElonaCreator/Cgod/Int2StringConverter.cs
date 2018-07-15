using System;
using System.Windows.Data;


namespace ElonaCreator
{
    public class Int2StringConverter : IValueConverter
    {
        // int -> string
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;
            else if (value is string)
                return value;
            else if (value is int && (int)value == 0)
                return string.Empty;
            else
                return value.ToString();
        }

        // string -> int
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string)
            {
                if (int.TryParse((string)value, out var ret))
                    return ret;
                else
                    return 0;
            }
            return value;
        }
    }
}
