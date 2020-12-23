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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Png_program.Resources.Controls.AuthControls
{
    /// <summary>
    /// Логика взаимодействия для PermissionItem.xaml
    /// </summary>
    public partial class PermissionItem : UserControl
    {
        bool canEditPerms = false;
        public Permissons permisson;
        public PermissionItem(Permissons permission, bool has, bool isAdmin)
        {
            canEditPerms = isAdmin;
            this.permisson = permission;
            InitializeComponent();         
            
            if (has)
            {
                PermState.IsChecked = true;
            }
            else
            {
                PermState.IsChecked = false;
            }
            try
            {
                PermDesc.Text = PermissionHelper.NamedPermissions[permisson];
            }catch(Exception e)
            { MessageBox.Show(permisson.ToString()); }

            if (!isAdmin)
            {
                PermState.IsEnabled = false;
            }
        }

       

        private void PermState_Click(object sender, RoutedEventArgs e)
        {          
            
        }
    }
}
