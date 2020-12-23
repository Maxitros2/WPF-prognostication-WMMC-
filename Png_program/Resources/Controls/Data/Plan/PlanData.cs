using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    public class PlanData : INotifyPropertyChanged
    {
        /*
         "ID"	INTEGER NOT NULL,
    "Type"	INTEGER NOT NULL,
    "Col1_data1_1"	INTEGER,
    "Col1_data2_1"	INTEGER,
    "Col1_data3_1"	INTEGER,
    "Col1_data1_2"	INTEGER,
    "Col1_data2_2"	INTEGER,
    "Col1_data3_2"	INTEGER,
    "Col1_data4_1"	INTEGER,
    "Col1_data4_2"	INTEGER,
    "Col1_data4_3"	INTEGER,
    "Col2_data1_1"	INTEGER,
    "Col2_data2_1"	INTEGER,
    "Col2_data3_1"	INTEGER,
    "Col2_data4_1"	INTEGER,
    "Col2_data1_2"	INTEGER,
    "Col2_data2_2"	INTEGER,
    "Col2_data3_2"	INTEGER,
    "Col2_data4_2"	INTEGER,
    "Col3_data1_1"	INTEGER,
    "Col3_data2_1"	INTEGER,
    "Col3_data3_1"	INTEGER,
    "Col3_data1_2"	INTEGER,
    "Col3_data2_2"	INTEGER,
    "Col3_data3_2"	INTEGER,
    "Date"	INTEGER,
    PRIMARY KEY("ID" AUTOINCREMENT)
         */
        private int type;
        private double? col1_data1_1;
        private double? col1_data2_1;
        private double? col1_data3_1;
        private double? col1_data1_2;
        private double? col1_data2_2;
        private double? col1_data3_2;
        private double? col1_data4_1;
        private double? col1_data4_2;
        private double? col1_data4_3;
        private double? col1_data5_1;
        private double? col1_data5_2;
        private double? col2_data1_1;
        private double? col2_data2_1;
        private double? col2_data3_1;
        private double? col2_data4_1;
        private double? col2_data1_2;
        private double? col2_data2_2;
        private double? col2_data3_2;
        private double? col2_data4_2;
        private double? col3_data1_1;
        private double? col3_data2_1;
        private double? col3_data3_1;
        private double? col3_data1_2;
        private double? col3_data2_2;
        private double? col3_data3_2;
        private string date;
        public int ID { get; set; }

        #region Col1
        public double? Col1_data1_1
        {
            get { return (col1_data1_1 == 0) ? null : col1_data1_1; }
            set
            {
                col1_data1_1 = value;
                OnPropertyChanged("Col1_data1_1");
            }
        }
        public double? Col1_data1_2
        {
            get { return (col1_data1_2 == 0) ? null : col1_data1_2; }
            set
            {
                col1_data1_2 = value;
                OnPropertyChanged("Col1_data1_2");
            }
        }
        public double? Col1_data2_1
        {
            get { return (col1_data2_1== 0) ? null : col1_data2_1; }
            set
            {
                col1_data2_1 = value;
                OnPropertyChanged("Col1_data2_1");
            }
        }
        public double? Col1_data3_1
        {
            get { return (col1_data3_1== 0) ? null : col1_data3_1; }
            set
            {
                col1_data3_1 = value;
                OnPropertyChanged("Col1_data3_1");
            }
        }
        public double? Col1_data2_2
        {
            get { return (col1_data2_2== 0) ? null : col1_data2_2; }
            set
            {
                col1_data2_2 = value;
                OnPropertyChanged("Col1_data2_2");
            }
        }
        public double? Col1_data3_2
        {
            get { return (col1_data3_2== 0) ? null : col1_data3_2; }
            set
            {
                col1_data3_2 = value;
                OnPropertyChanged("Col1_data3_2");
            }
        }
        public double? Col1_data4_1
        {
            get { return (col1_data4_1== 0) ? null : col1_data4_1; }
            set
            {
                col1_data4_1 = value;
                OnPropertyChanged("Col1_data4_1");
            }
        }
        public double? Col1_data4_2
        {
            get { return (col1_data4_2== 0) ? null : col1_data4_2; }
            set
            {
                col1_data4_2 = value;
                OnPropertyChanged("Col1_data4_2");
            }
        }
        public double? Col1_data4_3
        {
            get { return (col1_data4_3== 0) ? null : col1_data4_3; }
            set
            {
                col1_data4_3 = value;
                OnPropertyChanged("Col1_data4_3");
            }
        }
        public double? Col1_data5_1
        {
            get { return (col1_data5_1 == 0) ? null : col1_data5_1; }
            set
            {
                col1_data5_1 = value;
                OnPropertyChanged("Col1_data5_1");
            }
        }
        public double? Col1_data5_2
        {
            get { return (col1_data5_2 == 0) ? null : col1_data5_2; }
            set
            {
                col1_data5_2 = value;
                OnPropertyChanged("Col1_data5_2");
            }
        }
        #endregion
        #region Col2
        public double? Col2_data1_1
        {
            get { return (col2_data1_1== 0) ? null : col2_data1_1; }
            set
            {
                col2_data1_1 = value;
                OnPropertyChanged("Col2_data1_1");
            }
        }
        public double? Col2_data1_2
        {
            get { return (col2_data1_2== 0) ? null : col2_data1_2; }
            set
            {
                col2_data1_2 = value;
                OnPropertyChanged("Col2_data1_2");
            }
        }
        public double? Col2_data2_1
        {
            get { return (col2_data2_1== 0) ? null : col2_data2_1; }
            set
            {
                col2_data2_1 = value;
                OnPropertyChanged("Col2_data2_1");
            }
        }
        public double? Col2_data3_1
        {
            get { return (col2_data3_1== 0) ? null : col2_data3_1; }
            set
            {
                col2_data3_1 = value;
                OnPropertyChanged("Col2_data3_1");
            }
        }
        public double? Col2_data2_2
        {
            get { return (col2_data2_2== 0) ? null : col2_data2_2; }
            set
            {
                col2_data2_2 = value;
                OnPropertyChanged("Col2_data2_2");
            }
        }
        public double? Col2_data3_2
        {
            get { return (col2_data3_2== 0) ? null : col2_data3_2; }
            set
            {
                col2_data3_2 = value;
                OnPropertyChanged("Col2_data3_2");
            }
        }
        public double? Col2_data4_1
        {
            get { return (col2_data4_1== 0) ? null : col2_data4_1; }
            set
            {
                col2_data4_1 = value;
                OnPropertyChanged("Col2_data4_1");
            }
        }
        public double? Col2_data4_2
        {
            get { return (col2_data4_2== 0) ? null : col2_data4_2; }
            set
            {
                col2_data4_2 = value;
                OnPropertyChanged("Col2_data4_2");
            }
        }

        #endregion
        #region Col3
        public double? Col3_data1_1
        {
            get { return (col3_data1_1== 0) ? null : col3_data1_1; }
            set
            {
                col3_data1_1 = value;
                OnPropertyChanged("Col3_data1_1");
            }
        }
        public double? Col3_data1_2
        {
            get { return (col3_data1_2== 0) ? null : col3_data1_2; }
            set
            {
                col3_data1_2 = value;
                OnPropertyChanged("Col3_data1_2");
            }
        }
        public double? Col3_data2_1
        {
            get { return (col3_data2_1== 0) ? null : col3_data2_1; }
            set
            {
                col3_data2_1 = value;
                OnPropertyChanged("Col3_data2_1");
            }
        }
        public double? Col3_data3_1
        {
            get { return (col3_data3_1== 0) ? null : col3_data3_1; }
            set
            {
                col3_data3_1 = value;
                OnPropertyChanged("Col3_data3_1");
            }
        }
        public double? Col3_data2_2
        {
            get { return (col3_data2_2== 0) ? null : col3_data2_2; }
            set
            {
                col3_data2_2 = value;
                OnPropertyChanged("Col3_data2_2");
            }
        }
        public double? Col3_data3_2
        {
            get { return (col3_data3_2== 0) ? null : col3_data3_2; }
            set
            {
                col3_data3_2 = value;
                OnPropertyChanged("Col3_data3_2");
            }
        }
        
        #endregion
        public int Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public string Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
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
