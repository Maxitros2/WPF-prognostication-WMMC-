using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Png_program.Resources.Controls
{
    /// <summary>
    /// Логика взаимодействия для DatabaseversionControl.xaml
    /// </summary>
    ///    
    public partial class DatabaseversionControl : UserControl
    {
        public DatabaseversionControl(bool locked)
        {
            InitializeComponent();
            if (locked)
            { backgrid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF006E7A"));
                
                backcolor.To= (Color)ColorConverter.ConvertFromString("#FF006E7A");
            }
        }
    }
}
