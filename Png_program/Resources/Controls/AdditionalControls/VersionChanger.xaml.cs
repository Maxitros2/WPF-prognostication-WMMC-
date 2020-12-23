using Png_program.Resources.Controls.AuthControls;
using Png_program.Resources.Controls.MainTabControls;
using Png_program.Resources.Controls.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class VersionChanger : Window
    {
        public DatabaseversionControl type;
        MainWindow window;
        public VersionChanger(DatabaseversionControl control, MainWindow main)
        {
            InitializeComponent();
            this.type = control;
            OldPass.Text = control.Name1.Content.ToString();
            window = main;
        }

        private void RoundedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            window.ProgSet.dblist[window.ProgSet.dblist.Where(x => x.Key == type.Tag.ToString()).First().Key] = OldPass.Text;
            window.setChecker.SaveConfig(window.ProgSet);
            CustomMessageBox.Show("Обновление может занять несколько секунд!");
            Close();
            
        }

        private void RoundedButton_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "DBs");

                var srcfile = System.IO.Path.Combine(filePath, "Data" + type.Tag.ToString() + ".bac"); ;
                var destfile = System.IO.Path.Combine(filePath, "Data.db");
                File.Delete(System.IO.Path.Combine(filePath, "Data" + window.ProgSet.currentbase + ".bac"));
                File.Copy(destfile, System.IO.Path.Combine(filePath, "Data" + window.ProgSet.currentbase + ".bac"));
                if (File.Exists(destfile)) File.Delete(destfile);
                File.Move(srcfile, destfile);
                File.Copy(destfile, srcfile);
                window.ProgSet.currentbase = type.Tag.ToString();
                window.setChecker.SaveConfig(window.ProgSet);
                CustomMessageBox.Show("Обновление может занять несколько секунд!");

                Close();
            }
            catch(Exception ee)
            {
                Thread.Sleep(100);
                RoundedButton_MouseDown_1(null, new MouseButtonEventArgs(Mouse.PrimaryDevice, 1, MouseButton.Left));
            }
        }

        private void RoundedButton_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (window.ProgSet.dblist.Count()==1)
            {
                CustomMessageBox.Show("Вы не можете эт сделать!");
            }
            window.ProgSet.dblist.Remove(window.ProgSet.dblist.Where(x => x.Key == type.Tag.ToString()).First().Key);
            window.setChecker.SaveConfig(window.ProgSet);
            CustomMessageBox.Show("Обновление может занять несколько секунд!");
            Close();
        }

    }

}
