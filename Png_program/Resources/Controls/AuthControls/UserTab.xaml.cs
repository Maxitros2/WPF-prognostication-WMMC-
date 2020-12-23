using Png_program.Resources.Controls.AuthControls;
using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using Png_program.Resources.DBs;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Png_program.Resources.Controls
{
    /// <summary>
    /// Логика взаимодействия для MaintTab.xaml
    /// </summary>
    public partial class UserTab : UserControl
    {

        public UserTab()
        {
            InitializeComponent();
            this.DataContext = new UserViewModels();            
            NewsButton.Locked = true;
            Items.ItemsSource = ((UserViewModels)DataContext).NormalUsers;
            BindingOperations.DisableCollectionSynchronization(((UserViewModels)DataContext).Admins);
            BindingOperations.EnableCollectionSynchronization(((UserViewModels)DataContext).NormalUsers, Items.ItemsSource);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var viewModel = (UserViewModels)DataContext;
            if (viewModel.EditCommand.CanExecute(Items.SelectedItem))
                viewModel.EditCommand.Execute(Items.SelectedItem);
        }

        private void CustomGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var viewModel = (UserViewModels)DataContext;
            viewModel.AddCommand.Execute(NewsButton.Locked);
        }

        private void CustomGrid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var viewModel = (UserViewModels)DataContext;
            if (viewModel.DeleteCommand.CanExecute(Items.SelectedItem))
                viewModel.DeleteCommand.Execute(Items.SelectedItem);
        }

        private void TaskButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NewsButton.UpdateColorToStart();
            TaskButton.UpdateColorToEnd();
            Items.ItemsSource = ((UserViewModels)DataContext).Admins;
            BindingOperations.DisableCollectionSynchronization(((UserViewModels)DataContext).NormalUsers);
            BindingOperations.EnableCollectionSynchronization(((UserViewModels)DataContext).Admins, Items.ItemsSource);
        }

        private void NewsButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TaskButton.UpdateColorToStart();
            NewsButton.UpdateColorToEnd();
            Items.ItemsSource = ((UserViewModels)DataContext).NormalUsers;
            BindingOperations.DisableCollectionSynchronization(((UserViewModels)DataContext).Admins);
            BindingOperations.EnableCollectionSynchronization(((UserViewModels)DataContext).NormalUsers, Items.ItemsSource);
            
        }
        string alpha = "ЙЦУКЕНГШЩЗХЪФЫВАПРЛДЖЭЯЧСМИТЬБЮ";


        private void TextBlock_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            string ret = "";
            foreach (string s in (((TextBlock)sender).Text).Split(' ').Where(x => alpha.Contains(x[0])))
            {
                ret += s + " ";
            }
            ((TextBlock)sender).Text = ret;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ret = "";
            foreach (string s in (((TextBlock)sender).Text).Split(' ').Where(x => alpha.Contains(x[0])))
            {
                ret += s + " ";
            }
            ((TextBlock)sender).Text = ret;
        }
    }
}
