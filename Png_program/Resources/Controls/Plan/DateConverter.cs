using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Png_program.Resources.Controls.Plan
{
    public class DateConverter : IValueConverter
    {
      
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {           
            return DateTime.Parse((string)value).ToString("MM/dd/yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
