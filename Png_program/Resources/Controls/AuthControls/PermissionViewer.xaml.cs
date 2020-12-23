using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
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

namespace Png_program.Resources.Controls.AuthControls
{
    /// <summary>
    /// Логика взаимодействия для PermissionViewer.xaml
    /// </summary>
    public partial class PermissionViewer : Window
    {
        public PermissionViewer(bool isAdmin, List<Permissons> UserPermissons)
        {
            InitializeComponent();
            //List<Permissons> UserPermissons = User.ParsePermission(user.Permissions.Split(' '));
            foreach (Permissons permissons in Enum.GetValues(typeof(Permissons)))
            {
                PermissionItem permissionItem = new PermissionItem(permissons, UserPermissons.Contains(permissons), isAdmin);
                permissionItem.PermState.Checked += delegate
                     {
                         if(!UserPermissons.Contains(permissons))
                         {
                             UserPermissons.Add(permissons);
                         }
                     };
                permissionItem.PermState.Unchecked += delegate
                {
                    if (UserPermissons.Contains(permissons))
                    {
                        UserPermissons.Remove(permissons);
                    }
                };
                PermsList.Children.Add(permissionItem);
            }
        }
    }
}
