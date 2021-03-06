﻿using Png_program.Resources.Controls.AdditionalControls;
using Png_program.Resources.Controls.Data;
using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Png_program.Resources.Controls.ImportControls
{
    /// <summary>
    /// Логика взаимодействия для ImportWindow.xaml
    /// </summary>
    public partial class ImportWindow : UserControl
    {
        List<Permissons> permissons =  new List<Permissons>();
        DateTime first;
        DateTime second;
        List<string> headers = new List<string>();
        bool[] sorts = new bool[3] { false, true, true };
        public ImportWindow(UserData user)
        {
            InitializeComponent();
           
            if (user.Type == "Администратор")
            {
                permissons.Add(Permissons.МГПЗ);
                permissons.Add(Permissons.ЮБГПЗ);
            }
            else
            {
                permissons = User.ParsePermission(user.Permissions.Split(' ')).Where(x => x.Equals(Permissons.МГПЗ) || x.Equals(Permissons.ЮБГПЗ)).ToList();
            }
            
            
            for (int n = 0; n < ((first.Year - second.Year) * 12) + second.Month - first.Month + 1; n++)
            {
                headers.Add(DateTranslater.GetMYString(first.AddMonths(n)));
            }
            TableHeader.ItemsSource = headers;
                this.DataContext = new ImportViewModels(permissons.ToArray(), first, second,false);
           
        }

        private void cal1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            tryGetValues();
        }

        private void tryGetValues()
        {
            /*
            if(cal1.SelectedDates!=null)
            {
                this.DataContext = new ImportViewModels(permissons.ToArray(), cal1.SelectedDates);
            }
            foreach(ViewModel ((ImportViewModels)this.DataContext))
            */
        }
        private void TextBox_LostFocus_1(object sender, RoutedEventArgs e)
        {
           
            var viewModel = (ImportViewModels)DataContext;
            if (((TextBox)sender).IsReadOnly)
                return;
            if (viewModel.EditCommand.CanExecute(((TextBox)sender).Tag))
                viewModel.EditCommand.Execute(((TextBox)sender).Tag);
           
            
        }

        private void cal2_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            tryGetValues();
        }

        private void DockPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            foreach(ListViewItem viewItem in ((DockPanel)sender).Children.Cast<ListViewItem>())
            {               
                if (viewItem.Height < ((DockPanel)sender).ActualHeight)
                    viewItem.Height = ((DockPanel)sender).ActualHeight;               
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CustomGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (call1.SelectedDate == null)
            {
                CustomMessageBox.Show("Не выбрана первая дата!");
                return;
            }
            if (call2.SelectedDate == null)
            {
                CustomMessageBox.Show("Не выбрана вторая дата!");
                return;
            }
            if (call1.SelectedDate >= call2.SelectedDate)
            {
                CustomMessageBox.Show("Первая дата больше второй!");
                return;
            }
            first = new DateTime(call1.SelectedDate.Value.Year, call1.SelectedDate.Value.Month, 1);
            second = new DateTime(call2.SelectedDate.Value.Year, call2.SelectedDate.Value.Month, 1);
            headers = new List<string>();
            for (int n = 0; n < ((second.Year - first.Year) * 12) + second.Month - first.Month + 1; n++)
            {
                headers.Add(DateTranslater.GetMYString(first.AddMonths(n)));
            }
            TableHeader.ItemsSource = headers;
            this.DataContext = new ImportViewModels(permissons.ToArray(), first, second, false);           
            Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (((ImportViewModels)DataContext).ImportContexts == null)
                return;
            if (sorts[2])
            {
                var t = ((ImportViewModels)DataContext).ImportContexts.OrderBy(x => x.Key.Data2);
                ((ImportViewModels)DataContext).ImportContexts = t.ToDictionary(x => x.Key, y => y.Value);
                Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
            }
            else
            {
                var t = ((ImportViewModels)DataContext).ImportContexts.OrderByDescending(x => x.Key.Data2);
                ((ImportViewModels)DataContext).ImportContexts = t.ToDictionary(x => x.Key, y => y.Value);
                Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
            }
            sorts[2] = !sorts[2];
        }
        private void Grid_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            if (((ImportViewModels)DataContext).ImportContexts == null)
                return;
            if (sorts[1])
            {
                var t = ((ImportViewModels)DataContext).ImportContexts.OrderBy(x => x.Key.Data1);
                ((ImportViewModels)DataContext).ImportContexts = t.ToDictionary(x => x.Key, y => y.Value);
                Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
            }
            else
            {
                var t = ((ImportViewModels)DataContext).ImportContexts.OrderByDescending(x => x.Key.Data1);
                ((ImportViewModels)DataContext).ImportContexts = t.ToDictionary(x => x.Key, y => y.Value);
                Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
            }
            sorts[1] = !sorts[1];
        }
    
    private void Grid_MouseDown2(object sender, MouseButtonEventArgs e)
    {
        if (((ImportViewModels)DataContext).ImportContexts == null)
            return;
        if (sorts[0])
        {
            var t = ((ImportViewModels)DataContext).ImportContexts.OrderBy(x => x.Key.Factory);
            ((ImportViewModels)DataContext).ImportContexts = t.ToDictionary(x => x.Key, y => y.Value);
            Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
        }
        else
        {
            var t = ((ImportViewModels)DataContext).ImportContexts.OrderByDescending(x => x.Key.Factory);
            ((ImportViewModels)DataContext).ImportContexts = t.ToDictionary(x => x.Key, y => y.Value);
            Items.ItemsSource = ((ImportViewModels)DataContext).ImportContexts;
        }
        sorts[0] = !sorts[0];
    }
        private void Viewbox_MouseEnter(object sender, MouseEventArgs e)
        {
            fview.Visibility = Visibility.Visible;
        }

        private void Viewbox_MouseLeave(object sender, MouseEventArgs e)
        {
            fview.Visibility = Visibility.Hidden;
        }

        private void call1_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            if (((Calendar)sender).DisplayMode == CalendarMode.Month)
                ((Calendar)sender).DisplayMode = CalendarMode.Year;
        }
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
            {
                if (e.Key == Key.Right)
                {
                    var ob = VisualTreeHelper.GetParent(((TextBox)sender));
                    while (!(VisualTreeHelper.GetParent(ob) is DockPanel))
                    {
                        ob = VisualTreeHelper.GetParent(ob);
                    }                    
                    int now = ((DockPanel)VisualTreeHelper.GetParent(ob)).Children.IndexOf((UIElement)ob) + 1;
                    if (now >= ((DockPanel)VisualTreeHelper.GetParent(ob)).Children.Count - 1)
                    {
                        ((UIElement)VisualTreeHelper.GetChild(((UIElement)VisualTreeHelper.GetChild((DockPanel)VisualTreeHelper.GetParent(ob), 0)),0)).Focus();
                    }
                    else
                    {
                        ((UIElement)VisualTreeHelper.GetChild(((UIElement)VisualTreeHelper.GetChild((DockPanel)VisualTreeHelper.GetParent(ob), now)), 0)).Focus();
                    }

                }
                if (e.Key == Key.Left)
                {
                    var ob = VisualTreeHelper.GetParent(((TextBox)sender));
                    while (!(VisualTreeHelper.GetParent(ob) is DockPanel))
                    {
                        ob = VisualTreeHelper.GetParent(ob);
                    }
                    int now = ((DockPanel)VisualTreeHelper.GetParent(ob)).Children.IndexOf((UIElement)ob) + 1;
                    if (now <= 1)
                    {
                        ((UIElement)VisualTreeHelper.GetChild(((UIElement)VisualTreeHelper.GetChild((DockPanel)VisualTreeHelper.GetParent(ob), ((DockPanel)VisualTreeHelper.GetParent(ob)).Children.Count - 1)), 0)).Focus();
                    }
                    else
                    {
                        ((UIElement)VisualTreeHelper.GetChild(((UIElement)VisualTreeHelper.GetChild((DockPanel)VisualTreeHelper.GetParent(ob), now-2)), 0)).Focus();
                    }               

                }
                
            }
        }
    }
}
