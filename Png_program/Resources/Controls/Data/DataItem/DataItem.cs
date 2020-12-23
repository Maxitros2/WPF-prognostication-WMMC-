using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data.DataItem
{
    public class DataItem : INotifyPropertyChanged
    {
        /*
CREATE TABLE "ImportDatas" (
	"ID"	INTEGER NOT NULL,
	"Date"	TEXT,
	"DValue"	TEXT,
	PRIMARY KEY("ID" AUTOINCREMENT)
);
         */

        private string date;
        private string dValue;
        public int ID { get; set; }


        public string Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public string DValue
        {
            get { return dValue; }
            set
            {
                dValue = value;
                OnPropertyChanged("dValue");
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
