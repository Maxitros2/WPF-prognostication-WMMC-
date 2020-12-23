using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Png_program.Resources.Controls.AdditionalControls
{
    public class ListToString : IValueConverter
    {
        string alpha = "ЙЦУКЕНГШЩЗХЪФЫВАПРЛДЖЭЯЧСМИТЬБЮ";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((String)value) == null)
                return "Error";
            string ret = "";
            foreach (string s in ((String)value).Split(' ').Where(x => x.Length>1 && alpha.Contains(x[0])))
            {
                ret += s + " ";
            }
            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
