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
    /// Логика взаимодействия для UserEditWindow.xaml
    /// </summary>
    public partial class UserEditWindow : Window
    {
        public UserData CurrentUser { get; private set; }
        public List<Permissons> UserPermissons { get; private set; }
        private bool isAdmin = false;
        private bool isAdmins = false;
        public UserEditWindow(UserData user, bool newUser)
        {
            InitializeComponent();
            CurrentUser = user;
            UserPermissons = new List<Permissons>();
            isAdmin = false;
            LoginPlace.IsReadOnly = false;
            PasswordBorder.Visibility = Visibility.Visible;   
            
        }
            public UserEditWindow(UserData user)
        {
            InitializeComponent();
            CurrentUser = user;
            this.DataContext = CurrentUser;
            UserPermissons = User.ParsePermission(user.Permissions.Split(' '));
            isAdmin = user.Type == "Администратор" ? true : false;
            isAdmins = user.Type == "Администратор" ? true : false;
            PasswordBorder.Visibility = Visibility.Collapsed;
            LoginPlace.IsReadOnly = true;
            if (MainWindow.User.Type != "Администратор")
            {
                AdminTools.Visibility = Visibility.Hidden;
                
               
            }
            else
            {
                AdminTools.Visibility = Visibility.Visible;
                            
            }
            if(isAdmin)
            {
                UserButton.UpdateColorToStart();
                AdminButton.UpdateColorToEnd();
                UserStatusControl.IsEnabled = false;
            }
            else
            {
                UserButton.UpdateColorToEnd();
                AdminButton.UpdateColorToStart();
            }
        }

        private void RoundedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(LoginPlace.Text==null|| LoginPlace.Text == "")
            {
                CustomMessageBox.Show("Логин не валиден!");
                return;
            }
            UserContext userContext = new UserContext();
            userContext.UserDatas.Load();
            if (PasswordBorder.Visibility==Visibility.Visible && userContext.UserDatas.Any(x => x.UserName == CurrentUser.UserName))
            {
                CustomMessageBox.Show("Логин занят!");
                return;
            }
            if (PasswordBorder.Visibility == Visibility.Visible)
            {
                CurrentUser.UserName = LoginPlace.Text;
                CurrentUser.Password = CryptHelper.ComputeHash(PassBox.Text);
                CurrentUser.Type = isAdmins ? "Администратор" : "Пользователь";
            }
                if (PasswordBorder.Visibility == Visibility.Visible && (PassBox.Text == null || PassBox.Text == ""))
            {
                CustomMessageBox.Show("Пароль не валиден!");
                return;
            }
            string perms = "";
            foreach(Permissons permissons in UserPermissons)
                perms += Enum.GetName(typeof(Permissons),permissons) + " ";
            if (perms != "")
                perms.Remove(perms.Length - 2, 1);
            CurrentUser.Permissions=perms;
            CurrentUser.Type = AdminButton.Locked ? "Администратор" : "Пользователь";
            this.DialogResult = true;
        }

        private void RoundedButton_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            PermissionViewer permissionViewer = new PermissionViewer(MainWindow.User.Type == "Администратор", UserPermissons);
            permissionViewer.ShowDialog();
        }

        private void RoundedButton_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            PermissionViewer permissionViewer = new PermissionViewer(MainWindow.User.Type == "Администратор", UserPermissons);
            permissionViewer.ShowDialog();
        }

        private void RoundedButton_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            DataChanger dataChanger = new DataChanger(EditWindowType.SetPass, CurrentUser);
            if(dataChanger.ShowDialog()==true)
            {
                CurrentUser.Password = dataChanger.SetPass1.Text;
            }
                //MessageBox.Show(dataChanger.User.Password);

        }

        private void RoundedButton_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            DataChanger dataChanger = new DataChanger(EditWindowType.NewLogin, CurrentUser);
            if (dataChanger.ShowDialog() == true)
            {
                CurrentUser.UserName = dataChanger.Login1.Text;
            }
        }

        private void RoundedButton_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            DataChanger dataChanger = new DataChanger(EditWindowType.NewPass, CurrentUser);
            if (dataChanger.ShowDialog() == true)
            {
                CurrentUser.Password = CryptHelper.ComputeHash(dataChanger.NewPass2.Password);
            }
        }

        private void UserButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainWindow.User.Type == "Администратор")
            {
                UserButton.UpdateColorToEnd();
                AdminButton.UpdateColorToStart();
                isAdmins = false;
            }            
        }

        private void AdminButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainWindow.User.Type == "Администратор")
            {
                UserButton.UpdateColorToStart();
                AdminButton.UpdateColorToEnd();
                isAdmins = true;
            }
        }
    }
}
