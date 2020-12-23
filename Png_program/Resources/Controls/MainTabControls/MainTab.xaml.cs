using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using Png_program.Resources.DBs;
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

namespace Png_program.Resources.Controls
{
    /// <summary>
    /// Логика взаимодействия для MaintTab.xaml
    /// </summary>
    public partial class MaintTab : UserControl
    {
        
        public MaintTab()
        {
            InitializeComponent();            
            this.DataContext = new NewsViewModels(true);
            BindingOperations.EnableCollectionSynchronization(((NewsViewModels)DataContext).News,Items);
            NewsButton.Locked = true;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var viewModel = (NewsViewModels)DataContext;
            if (viewModel.EditCommand.CanExecute(Items.SelectedItem))
                viewModel.EditCommand.Execute(Items.SelectedItem);
        }

        private void CustomGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var viewModel = (NewsViewModels)DataContext;
            viewModel.AddCommand.Execute(NewsButton.Locked);
        }

        private void CustomGrid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var viewModel = (NewsViewModels)DataContext;
            if (viewModel.DeleteCommand.CanExecute(Items.SelectedItem))
                viewModel.DeleteCommand.Execute(Items.SelectedItem);
        }

        private void TaskButton_MouseDown(object sender, MouseButtonEventArgs e)
        {            
            NewsButton.UpdateColorToStart();
            TaskButton.UpdateColorToEnd();
            this.DataContext = new NewsViewModels(false);
        }

        private void NewsButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TaskButton.UpdateColorToStart();
            NewsButton.UpdateColorToEnd();
            this.DataContext = new NewsViewModels(true);
        }
    }
}
