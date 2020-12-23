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

namespace Png_program.Resources.Controls.MainTabControls
{
    /// <summary>
    /// Логика взаимодействия для NewsControl.xaml
    /// </summary>
    public partial class NewsControl : UserControl
    {
        public static readonly DependencyProperty LabelC;
        public static readonly DependencyProperty DateC;
        public static readonly DependencyProperty TextC;
        public static readonly DependencyProperty CheckedC;
        public string _Label
        {
            get { return (string)GetValue(LabelC); }
            set { SetValue(LabelC, value);  }
        }
        public string _Date
        {
            get { return (string)GetValue(DateC); }
            set { SetValue(DateC, value); }
        }
        public string _Text
        {
            get { return (string)GetValue(TextC); }
            set { SetValue(TextC, value); }
        }
        public int _Checked
        {
            get { return (int)GetValue(CheckedC); }
            set { SetValue(CheckedC, value); }
        }
        public NewsControl()
        {
            InitializeComponent();          
        }
        static NewsControl()
        {
            LabelC = DependencyProperty.Register(
                        "_Label",
                        typeof(string),
                        typeof(NewsControl),new UIPropertyMetadata("", new PropertyChangedCallback(UpateLable)));
            TextC = DependencyProperty.Register(
                       "_Text",
                       typeof(string),
                       typeof(NewsControl), new UIPropertyMetadata("", new PropertyChangedCallback(UpateText)));
            DateC = DependencyProperty.Register(
                       "_Date",
                       typeof(string),
                       typeof(NewsControl), new UIPropertyMetadata("", new PropertyChangedCallback(UpateDate)));
            CheckedC = DependencyProperty.Register(
                      "_Checked",
                      typeof(int),
                      typeof(NewsControl), new UIPropertyMetadata(0, new PropertyChangedCallback(UpateState)));
        }

        private static void UpateState(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NewsControl newsControl = (NewsControl) d;
            if(((int)e.NewValue)==0)
            {
                newsControl.Marked.Visibility = Visibility.Hidden;
                newsControl.NotMarked.Visibility = Visibility.Visible;
            }
            else
            {
                newsControl.Marked.Visibility = Visibility.Visible;
                newsControl.NotMarked.Visibility = Visibility.Hidden;
            }
        }

        private static void UpateDate(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NewsControl newsControl = (NewsControl)d;
            newsControl.Date.Content = e.NewValue.ToString();
        }

        private static void UpateText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NewsControl newsControl = (NewsControl) d;
            if(e.NewValue!=null)
            newsControl.Text.Text = e.NewValue.ToString();
        }

        private static void UpateLable(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NewsControl newsControl = (NewsControl) d;
            newsControl.NewsLabel.Content = e.NewValue.ToString();
        }
    }
}
