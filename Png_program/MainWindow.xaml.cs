using Png_program.Resources.Controls.AdditionalControls;
using Png_program.Resources.Controls.AuthControls;
using Png_program.Resources.Controls.Data.ProgData;
using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using Png_program.Resources.DBs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.IO;
using System.Reflection;
using Png_program.Resources.Controls;
using Png_program.Resources.Controls.Plan;
using Png_program.Resources.Controls.Data;
using Png_program.Resources.Controls.ImportControls;
using System.Windows.Media.Animation;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Timers;
using ControlzEx.Standard;

namespace Png_program
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isAdmin = false;
        bool isBaseLocked = true;
        ProgSet progSet;
        public bool needupdatever = true;
        Dictionary<CustomGrid, string> buttons;
        #region aspect ratio
    

        #endregion
        public ProgSet ProgSet
    {
        get { return progSet; }
        set
        {
            progSet = value;
            if (needupdatever && progSet != null)
            {

                VersionPanel.Children.Clear();
                for (int i = 0; i < progSet.dblist.Count(); i++)
                {
                    if(progSet.currentbase!=null&&progSet.currentbase== progSet.dblist.ElementAt(i).Key)
                    AddDBVersion(progSet.dblist.ElementAt(i).Key, progSet.dblist.ElementAt(i).Value,true);   
                    else
                            AddDBVersion(progSet.dblist.ElementAt(i).Key, progSet.dblist.ElementAt(i).Value, false);
                    }

                if (progSet.isBaseClose == true)
                {
                    BaseGrid.UpdateColorToStart();
                    isBaseLocked = true;
                    BaseText.Content = "База закрыта";
                }
                else
                {
                    BaseGrid.UpdateColorToEnd();
                    isBaseLocked = false;
                    BaseText.Content = "База открыта";
                }
            }


        }
    }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set
            {
                isAdmin = value;
                if(isAdmin==true)
                {
                    ProfileEditButton.Visibility = Visibility.Visible;
                    
                }
                else
                {
                    ProfileEditButton.Visibility = Visibility.Collapsed;
                    
                }
            }
        }
        private static UserData user;
        public static MainWindow window;
        public SetChecker setChecker;
        public static UserData User 
        {
            get { return user; }
            set {
                user = value;
                if(user==null)
                {
                    window.vasth.Visibility = Visibility.Visible;
                    window.IsAdmin = false;
                    window.MainTabButton_MouseDown(window.buttons.Keys.First(), new MouseButtonEventArgs(Mouse.PrimaryDevice, 1, MouseButton.Left));
                    return;
                }
                window.profviewbox_MouseEnter(null, new MouseButtonEventArgs(Mouse.PrimaryDevice, 1, MouseButton.Left));
                window.vasth.Visibility = Visibility.Collapsed;
                window.DataContext = MainWindow.User;
                window.FIO.Content = user.Name1+ " " + user.Name2+ " " + user.Name3;
                if (value.Type == "Администратор")
                {
                    window.IsAdmin = true;
                }
                else
                {
                    window.IsAdmin = false;
                }
            }
        }
        public MainWindow()
        {
            window = this;
            InitializeComponent();
           
            new AppContexts();
            buttons = new Dictionary<CustomGrid, string>() { { MainTabButton, "maintab"},{ CalButton, "Plan" },{ ImporrtButton, "Import1" }, { PostavkaButton, "Import2" } };
            
            try { 
            setChecker = new SetChecker(this);
                setChecker.Init();
            setChecker.RunSync();
                 }catch(Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
            PlanViewModels planContext = new PlanViewModels(PlanType.НВГПК, new List<DateTime>() {DateTime.Now});
        }

        private void RoundedButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((RoundedButton)sender).Checked = !((RoundedButton)sender).Checked;
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void FullScreenButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;                    
        }

        private void ChangeStateButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void AddDBVersion(string data, string name, bool active)
        {
            DatabaseversionControl control = new DatabaseversionControl(active);
            control.Tag = data;
            control.Name1.Content = name;
            control.Date.Content = "от " + data.Split('_')[0];
            control.MouseDown += delegate
              {
                  if (!IsAdmin)
                  {
                      CustomMessageBox.Show("Нет доступа");
                      return;
                  }

                  new VersionChanger(control, this).ShowDialog();
              };
            VersionPanel.Children.Add(control);
            setChecker.SaveConfig(ProgSet);
        }
        private void SaveFileButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!IsAdmin)
            {
                CustomMessageBox.Show("Нет доступа");
                return;
            }
            try
            {

                Random r = new Random();
                string data = DateTranslater.GetDateString(DateTime.Now)[0] + "_" + r.Next(10000);
                string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "DBs");
                var srcfile = System.IO.Path.Combine(path, "Data.db");
                var destfile = System.IO.Path.Combine(path, "Data"+ data + ".bac");
                if (File.Exists(destfile)) File.Delete(destfile);
                File.Copy(srcfile, destfile);               
                string name = "План";
                if (ProgSet == null)
                    ProgSet = new ProgSet();
                ProgSet.dblist.Add(data, name);
                AddDBVersion(data, name, false);
            }
            catch(Exception ee)
            {
               
            }
        }

        private void MainTabButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch(buttons[(CustomGrid)sender])
            {
                
                case "maintab":
                    {
                        foreach(CustomGrid grid in buttons.Keys)
                        {
                            grid.UpdateColorToStart();
                        }
                        ((CustomGrid)sender).UpdateColorToEnd();
                        TabName.Content = "Главная";
                        MainTab.Children.Clear();
                        MainTab.Children.Add(new MaintTab());
                        break;
                    }
                case "Plan":
                    {
                        if ((isBaseLocked && !isAdmin)|| user == null)
                        {
                            CustomMessageBox.Show("Нет доступа");
                            return;
                        }
                        foreach (CustomGrid grid in buttons.Keys)
                        {
                            grid.UpdateColorToStart();
                        }
                        ((CustomGrid)sender).UpdateColorToEnd();
                        TabName.Content = "Календарное планирование";
                        MainTab.Children.Clear();
                        MainTab.Children.Add(new PlanTab(user));
                        break;
                    }
                case "Import1":
                    {
                        if ((isBaseLocked && !isAdmin)|| user == null)
                        {
                            CustomMessageBox.Show("Нет доступа");
                            return;
                        }
                        foreach (CustomGrid grid in buttons.Keys)
                        {
                            grid.UpdateColorToStart();
                        }
                        ((CustomGrid)sender).UpdateColorToEnd();
                        TabName.Content = "Исходные данные";
                        MainTab.Children.Clear();
                        MainTab.Children.Add(new ImportWindow(User));
                        break;
                    }
                case "Import2":
                    {
                        if ((isBaseLocked && !isAdmin) ||user==null)
                        {
                            CustomMessageBox.Show("Нет доступа");
                            return;
                        }
                        foreach (CustomGrid grid in buttons.Keys)
                        {
                            grid.UpdateColorToStart();
                        }
                        ((CustomGrid)sender).UpdateColorToEnd();
                        TabName.Content = "Поставка ПНГ";
                        MainTab.Children.Clear();
                        MainTab.Children.Add(new ImportWindow2(User));
                        break;
                    }
            }
        }

        private void Path_61_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (user == null)
            {
              
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && this.WindowState!=WindowState.Maximized&&this.IsMouseOver)
                this.DragMove();
        }

        private void CustomGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsAdmin)
            {
                CustomMessageBox.Show("Нет доступа");
                return;
            }
            ProgSet.isBaseClose = !ProgSet.isBaseClose;
            setChecker.SaveConfig(ProgSet);
            CustomMessageBox.Show("Обновление может занять несколько секунд!");
        }

        

        private void profviewbox_MouseEnter(object sender, MouseEventArgs e)
        {
            ProfileRect.Visibility = Visibility.Visible;
            

             DoubleAnimation doubleAnimaition = new DoubleAnimation();
            if (user == null)
            {
                doubleAnimaition.To = 221;
                authwindow.Visibility = Visibility.Visible;
            }
            else
            {
                if (isAdmin)
                    doubleAnimaition.To = 172;
                else
                    doubleAnimaition.To = 129;
            }
            doubleAnimaition.Duration = new Duration(TimeSpan.FromMilliseconds(400));
            profviewbox.BeginAnimation(Viewbox.HeightProperty, doubleAnimaition);
        }

        private void profviewbox_MouseLeave(object sender, MouseEventArgs e)
        {
           
            ProfileRect.Visibility = Visibility.Hidden;
            DoubleAnimation doubleAnimaition = new DoubleAnimation();
            
            doubleAnimaition.To = 50;
           
            doubleAnimaition.Duration = new Duration(TimeSpan.FromMilliseconds(400));
            profviewbox.BeginAnimation(Viewbox.HeightProperty, doubleAnimaition);
        }

        private void CustomGrid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            User = null;
            profviewbox_MouseLeave(null, new MouseEventArgs(Mouse.PrimaryDevice, 1));
        }

        private void ProfileEditButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TabName.Content = "Редактирвание пользователей";
            MainTab.Children.Clear();
            MainTab.Children.Add(new UserTab());

        }
        static double aspectratio = 15.9d / 9d;
        internal enum SWP
        {
            NOMOVE = 0x0002
        }
        internal enum WM
        {
            WINDOWPOSCHANGING = 0x0046,
            EXITSIZEMOVE = 0x0232,
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }

        private void Window_SourceInitialized(object sender, EventArgs ea)
        {
            HwndSource hwndSource = (HwndSource)HwndSource.FromVisual((Window)sender);
            hwndSource.AddHook(DragHook);
        }
        bool HeightChanged = false;
        private bool? _adjustingHeight = null;
        static WINDOWPOS lastsize;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        public static Point GetMousePosition() // mouse position relative to screen
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }
        private  IntPtr DragHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handeled)
        {
            if (isdrag)
                return IntPtr.Zero;
            switch ((WM)msg)
            {
                case WM.WINDOWPOSCHANGING:
                    {
                        WINDOWPOS pos = (WINDOWPOS)Marshal.PtrToStructure(lParam, typeof(WINDOWPOS));

                        if ((pos.flags & (int)SWP.NOMOVE) != 0)
                            return IntPtr.Zero;

                        Window wnd = (Window)HwndSource.FromHwnd(hwnd).RootVisual;
                        if (wnd == null)
                            return IntPtr.Zero;

                        // determine what dimension is changed by detecting the mouse position relative to the 
                        // window bounds. if gripped in the corner, either will work.
                        if (!_adjustingHeight.HasValue)
                        {
                            Point p = GetMousePosition();

                            double diffWidth = Math.Min(Math.Abs(p.X - pos.x), Math.Abs(p.X - pos.x - pos.cx));
                            double diffHeight = Math.Min(Math.Abs(p.Y - pos.y), Math.Abs(p.Y - pos.y - pos.cy));

                            _adjustingHeight = diffHeight > diffWidth;
                        }

                        if (_adjustingHeight.Value)
                            pos.cy = (int)(pos.cx / aspectratio); // adjusting height to width change
                        else
                            pos.cx = (int)(pos.cy * aspectratio); // adjusting width to heigth change

                        Marshal.StructureToPtr(pos, lParam, true);
                        handeled = true;
                    }
                    break;
                case WM.EXITSIZEMOVE:
                    _adjustingHeight = null; // reset adjustment dimension and detect again next time window is resized
                    InvalidateVisual();
                    break;
            }

            return IntPtr.Zero;
        
    }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.HeightChanged && !e.WidthChanged)
                HeightChanged = true;
            else
                HeightChanged = false;
        }
        bool isdrag = false;
        private void Window_DragEnter(object sender, DragEventArgs e)
        {
            isdrag = true;
        }

        private void Window_DragLeave(object sender, DragEventArgs e)
        {
            isdrag = false;
        }
    }
}
