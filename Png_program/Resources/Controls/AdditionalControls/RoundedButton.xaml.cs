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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Png_program.Resources.Controls.AdditionalControls
{
    /// <summary>
    /// Логика взаимодействия для RoundedButton.xaml
    /// </summary>

    public partial class RoundedButton : UserControl
    {
        public static readonly DependencyProperty LabelC;
        public static readonly DependencyProperty IconC;
        public static readonly DependencyProperty OnlyTextC;
        public static readonly DependencyProperty FillC;
        public static readonly DependencyProperty TransitionColorC;
        public static readonly DependencyProperty FontSizeC;
        private bool _checked = false;
        private bool locked = false;
        public bool Locked 
        {
            get { return locked; }
            set
            {
                if (locked != value)
                {
                    if(locked)
                    {
                        TransitionBackS.SetValue(Storyboard.TargetProperty, null);
                        TransitionS.Begin();                        
                    }   
                    else
                    {
                        TransitionBackS.SetValue(Storyboard.TargetProperty, ButtonPath);
                        TransitionBackS.Begin();                        
                    }
                }
                locked = value;
            }
        }
        public bool Checked
        {
            get { return _checked; }
            set { 
                if (_checked != value)
                {
                    SolidColorBrush oldFill = Fill;
                    Fill = TransitionColor;
                    TransitionColor = oldFill;
                }
                _checked = value;
            }
        }
       
        public bool OnlyText
        {
            get { return (bool)GetValue(OnlyTextC); }
            set { SetValue(OnlyTextC, value); }
        }
        public string Label
        {
            get { return (string)GetValue(LabelC); }
            set { SetValue(LabelC, value); }
        }
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconC); }
            set { SetValue(IconC, value); }
        }
        public SolidColorBrush Fill
        {
            get { return (SolidColorBrush)GetValue(FillC); }
            set { SetValue(FillC, value); }
        }
        public SolidColorBrush TransitionColor
        {
            get { return (SolidColorBrush)GetValue(TransitionColorC); }
            set { SetValue(TransitionColorC, value);}
        }
        static RoundedButton()
        {
            LabelC = DependencyProperty.Register(
                        "Label",
                        typeof(string),
                        typeof(RoundedButton), new FrameworkPropertyMetadata("Test", FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(LabelCallback)));
            IconC = DependencyProperty.Register(
                       "Icon",
                       typeof(Geometry),
                       typeof(RoundedButton), new FrameworkPropertyMetadata(Geometry.Parse("F1 M 1223.36, 205.594C 1222.83, 205.594 1222.32, 205.688 1221.82, 205.875C 1221.32, 206.063 1220.86, 206.328 1220.46, 206.672C 1220.08, 206.985 1219.75, 207.376 1219.46, 207.845L 1216.23, 213.378L 1216.23, 200.341C 1216.23, 199.716 1216.45, 199.185 1216.89, 198.747C 1217.32, 198.309 1217.85, 198.09 1218.49, 198.09L 1225.99, 198.09L 1228.99, 201.092L 1236.49, 201.092C 1237.12, 201.092 1237.65, 201.311 1238.08, 201.748C 1238.52, 202.186 1238.74, 202.717 1238.74, 203.343L 1238.74, 205.594M 1243.1, 208.783L 1239.68, 214.598C 1239.46, 215.004 1239.08, 215.364 1238.55, 215.676C 1238.05, 215.958 1237.57, 216.099 1237.1, 216.099L 1218.34, 216.099C 1217.91, 216.099 1217.57, 215.91 1217.35, 215.536C 1217.14, 215.16 1217.14, 214.786 1217.35, 214.41L 1220.79, 208.595C 1221, 208.189 1221.36, 207.845 1221.86, 207.564C 1222.4, 207.25 1222.9, 207.094 1223.36, 207.094L 1242.12, 207.094C 1242.55, 207.094 1242.88, 207.283 1243.1, 207.657C 1243.32, 208.033 1243.32, 208.407 1243.1, 208.783 Z"),
                        FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(IconCallBack)));
            FillC = DependencyProperty.Register(
                       "Fill",
                       typeof(SolidColorBrush),
                       typeof(RoundedButton), new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF008C95")),
                        FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(FillCallBack)));
            TransitionColorC = DependencyProperty.Register(
                      "TransitionColor",
                      typeof(SolidColorBrush),
                      typeof(RoundedButton), new FrameworkPropertyMetadata(Brushes.White,
                        FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(TransitionColorCallback)));
            OnlyTextC = DependencyProperty.Register(
                      "OnlyText",
                      typeof(bool),
                      typeof(RoundedButton), new FrameworkPropertyMetadata(false,
                        FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(OnlyTextCallback)));
        }

        private static void OnlyTextCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RoundedButton)d).InvalidateVisual();
            if (((bool)e.NewValue))
            {
                ((RoundedButton)d).PathImage.Visibility=Visibility.Hidden;
                ((RoundedButton)d).ControlButtonText.Margin = new Thickness(20, 0, 20, 0);
            }
            
        }

        private static void FillCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RoundedButton)d).InvalidateVisual();
            ((RoundedButton)d).ButtonPath.Fill = (SolidColorBrush)e.NewValue;
            ((RoundedButton)d).TransitionBack.To = ((SolidColorBrush)e.NewValue).Color;
        }

        private static void IconCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RoundedButton)d).InvalidateVisual();
            ((RoundedButton)d).PathImage.Data = (Geometry) e.NewValue;
        }

        private static void LabelCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RoundedButton)d).InvalidateVisual();
            ((RoundedButton)d).ControlButtonText.Content = e.NewValue.ToString();
        }

        private static void TransitionColorCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((RoundedButton)d).InvalidateVisual();
            ((RoundedButton)d).Transition.To = ((SolidColorBrush) e.NewValue).Color;
        }

        public RoundedButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
