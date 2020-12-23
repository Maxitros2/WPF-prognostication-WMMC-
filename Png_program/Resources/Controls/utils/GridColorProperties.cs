using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Png_program.Resources.Controls.utils
{
    public static class GridColorProperties
    {
        public static Brush GetTickBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(TickBrushProperty);
        }

        public static void SetTickBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(TickBrushProperty, value);
        }

        public static readonly DependencyProperty TickBrushProperty =
            DependencyProperty.RegisterAttached(
                "TickBrush",
                typeof(Brush),
                typeof(GridColorProperties),
                new FrameworkPropertyMetadata(Brushes.Black));
    }
}
