using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Png_program.Resources.Controls.MainTabControls
{
    public class UserData : INotifyPropertyChanged
    {
        /*
        CREATE TABLE "UserDatas" (
	"ID"	INTEGER NOT NULL,
	"UserName"	TEXT NOT NULL,
	"Name1"	TEXT,
	"Name2"	TEXT,
	"Name3"	TEXT,
	"Password"	TEXT NOT NULL,
	"Permissions"	TEXT,
	"Type"	TEXT,
            */
        public static string alpha = "ЙЦУКЕНГШЩЗХЪФЫВАПРЛДЖЭЯЧСМИТЬБЮ";
        private string userName;
        private string name1;
        private string name2;
        private string name3;
        private string password;
        private string permissions;
        private string type;       

        public int ID { get; set; }

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }
        public string Name1
        {
            get { return name1; }
            set
            {
                name1 = value;
                OnPropertyChanged("Name1");
            }
        }
        public string Name2
        {
            get { return name2; }
            set
            {
                name2 = value;
                OnPropertyChanged("Name2");
            }
        }
        public string Name3
        {
            get { return name3; }
            set
            {
                name3 = value;
                OnPropertyChanged("Name3");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Permissions
        {
            get { if (permissions == null) return ""; return permissions; }
            set
            {
                permissions = value;
                OnPropertyChanged("Permissions");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
