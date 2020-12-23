using Png_program.Resources.Controls.AdditionalControls;
using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Png_program.Resources.Controls.AuthControls
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : UserControl
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void RoundedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserContext userContext = new UserContext();
            userContext.UserDatas.Load();
            bool flag = false;            
            foreach (UserData userData in userContext.UserDatas.ToList())
               if (userData.UserName == Login.Text && CryptHelper.ComputeHash(Password.Password) == userData.Password)
               {
                    MainWindow.User = userData;
                    flag = true;                    
                    break;
               }  
            
            if (!flag)
            {
                CustomMessageBox.Show("Неверный логин или пароль!");
            }
            userContext.SaveChanges();
            


        }

        private void RoundedButton_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            PasswordShown.Text = Password.Password;
            PasswordShown.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Collapsed;
        }

        private void PasswordShown_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PasswordShown.Visibility = Visibility.Collapsed;
            Password.Visibility = Visibility.Visible;
            Password.Focus();
        }

        private void RoundedButton_MouseLeave(object sender, MouseEventArgs e)
        {
            PasswordShown_MouseUp(null, new MouseButtonEventArgs(Mouse.PrimaryDevice,1,MouseButton.Left));
        }
    }
}
