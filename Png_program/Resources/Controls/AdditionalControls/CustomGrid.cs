using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Png_program.Resources.Controls.AdditionalControls
{
    class CustomGrid : Grid
    {
        public static readonly DependencyProperty StartColorC;
        public static readonly DependencyProperty EndColorC;
        public static readonly DependencyProperty LockedC;

        public bool Locked
        {
            get { return (bool)GetValue(LockedC); }
            set { SetValue(LockedC, value); }
        }
        public SolidColorBrush StartColor
        {
            get { return (SolidColorBrush)GetValue(StartColorC); }
            set { SetValue(StartColorC, value); }
        }
        public SolidColorBrush EndColor
        {
            get { return (SolidColorBrush)GetValue(EndColorC); }
            set { SetValue(EndColorC, value); }
        }
        public void UpdateColorToStart()
        {
            Locked = false;
            CustomGrid_MouseLeave(null, new System.Windows.Input.MouseEventArgs(Mouse.PrimaryDevice, 1));            
        }

        public void UpdateColorToEnd()
        {
            CustomGrid_MouseEnter(null, new System.Windows.Input.MouseEventArgs(Mouse.PrimaryDevice,1));
            Locked = true;
        }
        static CustomGrid()
        {
            StartColorC = DependencyProperty.Register(
                       "StartColor",
                       typeof(SolidColorBrush),
                       typeof(CustomGrid), new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF008C95")), FrameworkPropertyMetadataOptions.AffectsMeasure |
                        FrameworkPropertyMetadataOptions.AffectsRender));
            EndColorC = DependencyProperty.Register(
                      "EndColor",
                      typeof(SolidColorBrush),
                      typeof(CustomGrid), new FrameworkPropertyMetadata(Brushes.White, FrameworkPropertyMetadataOptions.AffectsMeasure |
                        FrameworkPropertyMetadataOptions.AffectsRender));
            LockedC = DependencyProperty.Register(
                     "Locked",
                     typeof(bool),
                     typeof(CustomGrid), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsMeasure |
                       FrameworkPropertyMetadataOptions.AffectsRender));
        }
        public CustomGrid() : base()
        {
            this.MouseEnter += CustomGrid_MouseEnter;
            this.MouseLeave += CustomGrid_MouseLeave;
        }

        private void CustomGrid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Locked)
                return;
            ColorAnimation animation = new ColorAnimation();
            animation.To = StartColor.Color;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            var child = this.Children[0];
            if (child is Rectangle)
                ((Rectangle)Children[0]).Fill.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            if (child is Path)
                ((Path)Children[0]).Fill.BeginAnimation(SolidColorBrush.ColorProperty, animation);
        }

        private void CustomGrid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Locked)
                return;
            ColorAnimation animation = new ColorAnimation();
            animation.To = EndColor.Color;
             animation.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            var child = this.Children[0];
            if (child is Rectangle)
                ((Rectangle)Children[0]).Fill.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            if (child is Path)
                ((Path)Children[0]).Fill.BeginAnimation(SolidColorBrush.ColorProperty, animation);

        }
    }
}
