using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    public class ImportData : INotifyPropertyChanged
    {
        /*
CREATE TABLE "ImportDatas" (
	"Factory"	INTEGER,
	"ID"	INTEGER NOT NULL,
	"Data1"	TEXT,
	"Data2"	TEXT,
	"Date"	TEXT,
	"DValue"	INTEGER,
	PRIMARY KEY("ID" AUTOINCREMENT)
);
         */
        
        private string factory;       
        private string data1;
        private string data2;        
        public int ID { get; set; }

       
        public string Factory
        {
            get { return factory; }
            set
            {
                factory = value;
                OnPropertyChanged("Factory");
            }
        }
        
        public string Data1
        {
            get { return data1; }
            set
            {
                data1 = value;
                OnPropertyChanged("Data1");
            }
        }
        public string Data2
        {
            get { return data2; }
            set
            {
                data2 = value;
                OnPropertyChanged("Data2");
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
