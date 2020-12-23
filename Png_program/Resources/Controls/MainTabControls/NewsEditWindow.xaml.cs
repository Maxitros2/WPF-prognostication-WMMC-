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
using System.Windows.Shapes;

namespace Png_program.Resources.Controls.MainTabControls
{
    /// <summary>
    /// Логика взаимодействия для NewsEditWondow.xaml
    /// </summary>
    public partial class NewsEditWindow : Window
    {
        public NewsData News { get; private set; }
        public NewsEditWindow(NewsData news)
        {
            InitializeComponent();
            News = news;
            this.DataContext = News;
        }

        private void RoundedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
