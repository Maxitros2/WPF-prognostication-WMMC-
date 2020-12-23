using Png_program.Resources.Controls.AdditionalControls;
using Png_program.Resources.Controls.Data;
using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Png_program.Resources.Controls.Plan
{
    /// <summary>
    /// Логика взаимодействия для PlanTab.xaml
    /// </summary>
    public partial class PlanTab : UserControl
    {
        PlanType? type;
        bool typeselected = false;      
        public PlanTab(UserData user)
        {
            InitializeComponent();
            Plan0.Visibility = Visibility.Collapsed;
            Plan1.Visibility = Visibility.Collapsed;
            Plan2.Visibility = Visibility.Collapsed;
            Plan3.Visibility = Visibility.Collapsed;
            Plan4.Visibility = Visibility.Collapsed;
            Plan5.Visibility = Visibility.Collapsed;
            Plan6.Visibility = Visibility.Collapsed;
            Plan7.Visibility = Visibility.Collapsed;
            List<PlanType> types3 = new List<PlanType>();
            List<Permissons> perms = User.ParsePermission(user.Permissions.Split(' '));
            if (perms.Contains(Permissons.ГГПЗ))
                types3.Add(PlanType.ГГПЗ);
            if (perms.Contains(Permissons.НГП))
                types3.Add(PlanType.НГП);
            if (perms.Contains(Permissons.ЮПГПЗ))
                types3.Add(PlanType.ЮПГПЗ);
            if (perms.Contains(Permissons.ЮБГПЗ))
                types3.Add(PlanType.ЮБГПЗ);
            if (perms.Contains(Permissons.МГПЗ))
                types3.Add(PlanType.МГПЗ);
            if (perms.Contains(Permissons.МГПЗ))
                types3.Add(PlanType.МГПЗ);
            if (perms.Contains(Permissons.ВГПЗ))
                types3.Add(PlanType.ВГПЗ);
            if (perms.Contains(Permissons.БГПК))
                types3.Add(PlanType.БГПК);
            if (perms.Contains(Permissons.НВГПК))
                types3.Add(PlanType.НВГПК);
            if (user.Type=="Администратор")
            {
                types3.Add(PlanType.ГГПЗ);
                types3.Add(PlanType.НГП);
                types3.Add(PlanType.ЮПГПЗ);
                types3.Add(PlanType.ЮБГПЗ);
                types3.Add(PlanType.МГПЗ);
                types3.Add(PlanType.ВГПЗ);             
                types3.Add(PlanType.БГПК);
                types3.Add(PlanType.НВГПК);
            }    
           
            foreach (PlanType type in types3)
            {
                /*
                 *   <AdditionalControls:CustomGrid StartColor="#FF86C000" EndColor="#FF008C95" Height="50" MouseDown="CustomGrid_MouseDown">
                        <Rectangle Fill="#FF86C000" RadiusX="10" Stroke="#FF86C000" Margin="40,7,40,9" RadiusY="10"></Rectangle>
                        <Label Style="{StaticResource NormalFont}" Content="Применить" Margin="0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" Foreground="White" FontSize="20"/>
                    </AdditionalControls:CustomGrid>
                 */
                CustomGrid roundedButton = new CustomGrid()
                {

                    Margin = new Thickness(0, 0, 0, 10),
                    StartColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF86C000")),
                    EndColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF008C95")),
                    Height = 50

                };
                roundedButton.Children.Add
                    (
                    new Rectangle()
                    {
                        Fill = new SolidColorBrush((System.Windows.Media.Color)ColorConverter.ConvertFromString("#FF86C000")),
                        Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF86C000")),
                        RadiusX = 10,
                        RadiusY = 10

                    }
                    );
                roundedButton.Children.Add
                    (
                    new Label()
                    {
                        Style= (Style)FindResource("NormalFont"),
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center,
                        Foreground = Brushes.White,
                        FontSize = 20,
                        Content = Enum.GetName(typeof(PlanType), type)

                    }
                    );             
                    
                roundedButton.MouseDown += delegate
                {
                    typeselected = true;
                    this.type = type;
                    GetLayout(type);
                };
                ZavPanel.Children.Add(roundedButton);
            }
            FactoryListSize.To = 540;
        }

        private void GetLayout(PlanType? type)
        {
            if (this.type == null)
                return;
            if (call1.SelectedDate == null)
                return;
            if (call2.SelectedDate == null)
                return;          
            List<DateTime> dates = new List<DateTime>();
            DateTime date1 = (DateTime)call1.SelectedDate;
            while(date1.Ticks<=((DateTime)call2.SelectedDate).Ticks)
            {
                dates.Add(date1);
                date1 = date1.AddDays(1d);
            }            
            this.DataContext = new PlanViewModels((PlanType)type, dates);
            Plan0.Visibility = Visibility.Collapsed;
            Plan1.Visibility = Visibility.Collapsed;
            Plan2.Visibility = Visibility.Collapsed;
            Plan3.Visibility = Visibility.Collapsed;
            Plan4.Visibility = Visibility.Collapsed;
            Plan5.Visibility = Visibility.Collapsed;
            Plan6.Visibility = Visibility.Collapsed;
            Plan7.Visibility = Visibility.Collapsed;
            switch (type)
            {
                case PlanType.ГГПЗ:Plan0.Visibility = Visibility.Visible; Plan0_Items.ItemsSource = ((PlanViewModels)DataContext).PlanGGPZ; break;
                case PlanType.НГП: Plan1.Visibility = Visibility.Visible; Plan1_Items.ItemsSource = ((PlanViewModels)DataContext).PlanNGP; break;
                case PlanType.ЮПГПЗ: Plan2.Visibility = Visibility.Visible; Plan2_Items.ItemsSource = ((PlanViewModels)DataContext).PlanYPGPZ; break;
                case PlanType.ЮБГПЗ: Plan3.Visibility = Visibility.Visible; Plan3_Items.ItemsSource = ((PlanViewModels)DataContext).PlanYBGPZ; break;
                case PlanType.МГПЗ: Plan4.Visibility = Visibility.Visible; Plan4_Items.ItemsSource = ((PlanViewModels)DataContext).PlanMGPZ; break;

                case PlanType.ВГПЗ: Plan7.Visibility = Visibility.Visible; Plan7_Items.ItemsSource = ((PlanViewModels)DataContext).PlanVGPZ; break;
                case PlanType.БГПК: Plan5.Visibility = Visibility.Visible; Plan5_Items.ItemsSource = ((PlanViewModels)DataContext).PlanBGPK; break;
                case PlanType.НВГПК: Plan6.Visibility = Visibility.Visible; Plan6_Items.ItemsSource = ((PlanViewModels)DataContext).PlanNVGPK; break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {            
           
        }
        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_LostFocus_1(object sender, RoutedEventArgs e)
        {
            var viewModel = (PlanViewModels)DataContext;
            if (((TextBox)sender).IsReadOnly)
                return;
            switch (type)
            {
                case PlanType.ГГПЗ:
                    if (viewModel.EditCommand.CanExecute(((PlanViewModels)DataContext).PlanGGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()))
                        viewModel.EditCommand.Execute(((PlanViewModels)DataContext).PlanGGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()); break;
                case PlanType.НГП:
                    if (viewModel.EditCommand.CanExecute(((PlanViewModels)DataContext).PlanNGP.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()))
                        viewModel.EditCommand.Execute(((PlanViewModels)DataContext).PlanNGP.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()); break;
                case PlanType.ЮПГПЗ:
                    if (viewModel.EditCommand.CanExecute(((PlanViewModels)DataContext).PlanYPGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()))
                        viewModel.EditCommand.Execute(((PlanViewModels)DataContext).PlanYPGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()); break;
                case PlanType.ЮБГПЗ:
                    if (viewModel.EditCommand.CanExecute(((PlanViewModels)DataContext).PlanYBGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()))
                        viewModel.EditCommand.Execute(((PlanViewModels)DataContext).PlanYBGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()); break;
                case PlanType.МГПЗ:
                    if (viewModel.EditCommand.CanExecute(((PlanViewModels)DataContext).PlanMGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()))
                        viewModel.EditCommand.Execute(((PlanViewModels)DataContext).PlanMGPZ.Where(x => x.ID == Convert.ToInt32(((TextBox)sender).Tag)).First()); break;
            }
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetLayout(this.type);
        }

        private void cal_LostFocus(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            GetLayout(type);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // new ImportViewModels(new Permissons[] { Permissons.БГПЗ, Permissons.ВарКС}, DateTime.Parse("1 October 2020") , DateTime.Parse("1 November 2020"),1,false);
        }

        

        private void Viewbox_MouseEnter(object sender, MouseEventArgs e)
        {
            fview.Visibility = Visibility.Visible;
        }

        private void Viewbox_MouseLeave(object sender, MouseEventArgs e)
        {
            fview.Visibility = Visibility.Hidden;
        }

        private void Viewbox_MouseEnter_1(object sender, MouseEventArgs e)
        {
            sview.Visibility = Visibility.Visible;
        }

        private void Viewbox_MouseLeave_1(object sender, MouseEventArgs e)
        {
            sview.Visibility = Visibility.Hidden;
        }

        private void CustomGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            GetLayout(type);
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {          
           
            if (e.Key == Key.Enter)
            {
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
                {
                    if (this.DataContext != null)
                    {
                        var viewModel = (PlanViewModels)DataContext;
                        if (((TextBox)sender).IsReadOnly)
                            return;
                        string text = "";
                        BindingExpression binding = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
                        string fields = binding.ParentBinding.Path.Path;
                        switch (type)
                        {
                            case PlanType.ГГПЗ:
                                foreach (PlanGGPZ data in ((PlanViewModels)DataContext).PlanGGPZ)
                                {
                                    data.GetType().GetProperty(fields).SetValue(data, Convert.ToDouble(((TextBox)sender).Text));
                                    if (viewModel.EditCommand.CanExecute(data))
                                        viewModel.EditCommand.Execute(data);
                                }
                                break;
                            case PlanType.НГП:
                                foreach (PlanNGP data in ((PlanViewModels)DataContext).PlanNGP)
                                {
                                    data.GetType().GetProperty(fields).SetValue(data, Convert.ToDouble(((TextBox)sender).Text));
                                    if (viewModel.EditCommand.CanExecute(data))
                                        viewModel.EditCommand.Execute(data);
                                }
                                break; break;
                            case PlanType.ЮПГПЗ:
                                foreach (PlanYPGPZ data in ((PlanViewModels)DataContext).PlanYPGPZ)
                                {
                                    data.GetType().GetProperty(fields).SetValue(data, Convert.ToDouble(((TextBox)sender).Text));
                                    if (viewModel.EditCommand.CanExecute(data))
                                        viewModel.EditCommand.Execute(data);
                                }
                                break; break;
                            case PlanType.ЮБГПЗ:
                                foreach (PlanYBGPZ data in ((PlanViewModels)DataContext).PlanYBGPZ)
                                {
                                    data.GetType().GetProperty(fields).SetValue(data, Convert.ToDouble(((TextBox)sender).Text));
                                    if (viewModel.EditCommand.CanExecute(data))
                                        viewModel.EditCommand.Execute(data);
                                }
                                break;
                            case PlanType.МГПЗ:
                                foreach (PlanMGPZ data in ((PlanViewModels)DataContext).PlanMGPZ)
                                {
                                    data.GetType().GetProperty(fields).SetValue(data, Convert.ToDouble(((TextBox)sender).Text));
                                    if (viewModel.EditCommand.CanExecute(data))
                                        viewModel.EditCommand.Execute(data);
                                }
                                break;
                        }                        
                    }
                }
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
            {
                if (e.Key == Key.Right)
                {
                    Grid g = (Grid)VisualTreeHelper.GetParent(((TextBox)sender));
                    int now = g.Children.IndexOf(((TextBox)sender)) + 1;
                    if (now >= g.Children.Count - 1)
                    {
                        ((TextBox)VisualTreeHelper.GetChild(g, 1)).Focus();
                    }
                    else
                    {
                        while (((TextBox)VisualTreeHelper.GetChild(g, now)).IsReadOnly == true)
                        {
                            now++;
                        }
                       ((TextBox)VisualTreeHelper.GetChild(g, now)).Focus();
                    }

                }
                if (e.Key == Key.Left)
                {
                    Grid g = (Grid)VisualTreeHelper.GetParent(((TextBox)sender));
                    int now = g.Children.IndexOf(((TextBox)sender)) - 1;
                    if (now <= 0)
                    {
                        ((TextBox)VisualTreeHelper.GetChild(g, g.Children.Count - 2)).Focus();
                    }
                    else
                    {
                        while (((TextBox)VisualTreeHelper.GetChild(g, now)).IsReadOnly == true)
                        {
                            now--;
                        }
                       ((TextBox)VisualTreeHelper.GetChild(g, now)).Focus();
                    }

                }
                if (e.Key == Key.Down)
                {
                    Grid g = (Grid)VisualTreeHelper.GetParent(((TextBox)sender));
                    int now = g.Children.IndexOf(((TextBox)sender));
                    var ob = VisualTreeHelper.GetParent(g);
                    while(!(VisualTreeHelper.GetParent(ob) is VirtualizingStackPanel))
                    {
                        ob = VisualTreeHelper.GetParent(ob);
                    }
                    VirtualizingStackPanel list = (VirtualizingStackPanel)VisualTreeHelper.GetParent(ob);
                    int now2 = list.Children.IndexOf((ListViewItem)ob);
                    if(now2== list.Children.Count-1)
                    {
                        ob = list.Children[0];
                        while (!(ob is Grid))
                        {
                            ob = VisualTreeHelper.GetChild(ob,0);

                        }
                        ((TextBox)((Grid)ob).Children[now]).Focus();
                    }
                    else
                    {
                        ob = list.Children[now2+1];
                        while (!(ob is Grid))
                        {
                            ob = VisualTreeHelper.GetChild(ob, 0);

                        }
                        ((TextBox)((Grid)ob).Children[now]).Focus();
                    }    
                }
                if (e.Key == Key.Up)
                {
                    Grid g = (Grid)VisualTreeHelper.GetParent(((TextBox)sender));
                    int now = g.Children.IndexOf(((TextBox)sender));
                    var ob = VisualTreeHelper.GetParent(g);
                    while (!(VisualTreeHelper.GetParent(ob) is VirtualizingStackPanel))
                    {
                        ob = VisualTreeHelper.GetParent(ob);
                    }
                    VirtualizingStackPanel list = (VirtualizingStackPanel)VisualTreeHelper.GetParent(ob);
                    int now2 = list.Children.IndexOf((ListViewItem)ob);
                    if (now2 == 0)
                    {
                        ob = list.Children[list.Children.Count - 1];
                        while (!(ob is Grid))
                        {
                            ob = VisualTreeHelper.GetChild(ob, 0);

                        }
                        ((TextBox)((Grid)ob).Children[now]).Focus();
                    }
                    else
                    {
                        ob = list.Children[now2 - 1];
                        while (!(ob is Grid))
                        {
                            ob = VisualTreeHelper.GetChild(ob, 0);

                        }
                        ((TextBox)((Grid)ob).Children[now]).Focus();
                    }
                }
            }
        }
    }
}
