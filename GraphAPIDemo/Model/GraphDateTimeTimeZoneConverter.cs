using System;
using System.Globalization;
using Microsoft.Graph;
using Xamarin.Forms;

namespace GraphAPIDemo.Model
{
    class GraphDateTimeTimeZoneConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTimeTimeZone date)
            {
                var parsedDateAs = DateTimeOffset.Parse(date.DateTime);
                // Return the local date time string
                return $"{parsedDateAs.LocalDateTime.ToShortDateString()} {parsedDateAs.LocalDateTime.ToShortTimeString()}";
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
