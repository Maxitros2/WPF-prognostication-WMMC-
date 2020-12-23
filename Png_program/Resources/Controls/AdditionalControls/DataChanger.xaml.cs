using Png_program.Resources.Controls.AuthControls;
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

namespace Png_program.Resources.Controls.AdditionalControls
{
    /// <summary>
    /// Логика взаимодействия для DataChanger.xaml
    /// </summary>
    public partial class DataChanger : Window
    {
        private EditWindowType type;
        public UserData User;
        public DataChanger(EditWindowType type, UserData user)
        {
            InitializeComponent();
            this.type = type;
            User = user;
            switch (type)
            {
                case EditWindowType.NewPass: newPass.Visibility = Visibility.Visible; break;
                case EditWindowType.SetPass: setPass.Visibility = Visibility.Visible; break;
                case EditWindowType.NewLogin: newLogin.Visibility = Visibility.Visible; break;
            }
          
        }

        private void RoundedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch(type)
            {
                case EditWindowType.NewPass: TrySetNewPass(); break;
                case EditWindowType.SetPass: TrySetPass(); break;
                case EditWindowType.NewLogin: TrySetNewLogin(); break;
            }
        }

        private void TrySetNewLogin()
        {
            if (Login1.Text != Login2.Text)
            {
                CustomMessageBox.Show("Логины не совпадают");
                return;
            }
            UserContext userContext = new UserContext();
            userContext.UserDatas.Load();
            if(userContext.UserDatas.Any(x=>x.UserName== Login1.Text))
            {
                CustomMessageBox.Show("Логин занят!");
                return;
            }
            this.DialogResult = true;
        }

        private void TrySetPass()
        {
            if (SetPass1.Text != SetPass2.Text)
            {
                CustomMessageBox.Show("Пароли не совпадают");
                return;
            }
            this.DialogResult = true;
        }

        private void TrySetNewPass()
        {
            if (CryptHelper.ComputeHash(OldPass.Password) != User.Password)
            {
                CustomMessageBox.Show("Неверный старый пароль!");
                return;
            }                
            if (NewPass1.Password != NewPass2.Password)
            {
                CustomMessageBox.Show("Пароли не совпадают");
                return;
            }
            this.DialogResult = true;
        }
    }
    public enum EditWindowType
    {
        SetPass,
        NewPass,
        NewLogin
    }
}
