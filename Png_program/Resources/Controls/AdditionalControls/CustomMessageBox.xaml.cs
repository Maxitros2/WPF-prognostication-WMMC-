using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Png_program.Resources.Controls.AdditionalControls
{
    /// <summary>
    /// Логика взаимодействия для CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
        public static void Show(string message)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message);
            customMessageBox.Left = Screen.PrimaryScreen.Bounds.Width/2 - customMessageBox.Width / 2;
            customMessageBox.Top = Screen.PrimaryScreen.Bounds.Height / 2 - customMessageBox.Height / 2;
            customMessageBox.ShowDialog();
           
        }
        public CustomMessageBox(string message)
        {
            InitializeComponent();
            this.DataContext = message;
        }

        private void RoundedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
