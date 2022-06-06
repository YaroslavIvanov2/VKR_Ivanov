using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Diplom_Ivanov_Admin.resources.Converters
{
    public class CoverterImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            
                string path = value as string;
                if (String.IsNullOrWhiteSpace(path)) return "pack://application:,,,/resources/images/нет.jpg";
            try
            {
                return !File.Exists(path) ? "pack://application:,,,/resources/images/нет.jpg" : Path.GetFullPath(path);
            }
               catch (Exception)
            {
                return "pack://application:,,,/resources/images/нет.jpg";
            }
            
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
