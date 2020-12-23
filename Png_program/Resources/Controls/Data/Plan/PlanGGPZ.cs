using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    public class PlanGGPZ : INotifyPropertyChanged
    {
        /*
     CREATE TABLE "PlanGGPZ" (
	"ID"	INTEGER NOT NULL,
	"Date"	TEXT,
	"Acceptance_Purneftegaz_days"	REAL,
	"Acceptance_Purneftegaz_hours"	REAL,
	"Acceptance_Yangpur_days"	REAL,
	"Acceptance_Yangpur_hours"	REAL,
	"Acceptance_Purneft_days"	REAL,
	"Acceptance_Purneft_hours"	REAL,
	"Acceptance_Total_days"	REAL,
	"Acceptance_Total_hours"	REAL,
	"Fat_PNG"	REAL,
	"SOG_Reduce"	REAL,
	"SHFLY_Production_days"	REAL,
	"SHFLY_Production_hours"	REAL,
	"Etan_Percent"	REAL,
	"Etan_Record"	REAL,
	"SOGProduction_Factory_days"	REAL,
	"SOGProduction_Factory_hours"	REAL,
	"SOGProduction_Magistral_days"	REAL,
	"SOGProduction_Magistral_hours"	REAL,
	PRIMARY KEY("ID" AUTOINCREMENT)
)
         */
        
        public int ID { get; set; }
        private string date;
        private double? acceptance_Purneftegaz_days;
        private double? acceptance_Purneftegaz_hours;
        private double? acceptance_Yangpur_days;
        private double? acceptance_Yangpur_hours;
        private double? acceptance_Purneft_days;
        private double? acceptance_Purneft_hours;
        private double? acceptance_Total_days;
        private double? acceptance_Total_hours;
        private double? fat_PNG;
        private double? sOG_Reduce;
        private double? sHFLY_Production_days;
        private double? sHFLY_Production_hours;
        private double? etan_Percent;
        private double? etan_Record;
        private double? sOGProduction_Factory_days;
        private double? sOGProduction_Factory_hours;
        private double? sOGProduction_Magistral_days;
        private double? sOGProduction_Magistral_hours;
     

        #region Col1
        public double? Acceptance_Purneftegaz_days
        {
            get { return (acceptance_Purneftegaz_days == 0) ? null : acceptance_Purneftegaz_days; }
            set
            {
                acceptance_Purneftegaz_days = value;
                OnPropertyChanged("Acceptance_Purneftegaz_days");
            }
        }
        public double? Acceptance_Yangpur_hours
        {
            get { return (acceptance_Yangpur_hours == 0) ? null : acceptance_Yangpur_hours; }
            set
            {
                acceptance_Yangpur_hours = value;
                OnPropertyChanged("Acceptance_Yangpur_hours");
            }
        }
        public double? Acceptance_Purneftegaz_hours
        {
            get { return (acceptance_Purneftegaz_hours== 0) ? null : acceptance_Purneftegaz_hours; }
            set
            {
                acceptance_Purneftegaz_hours = value;
                OnPropertyChanged("Acceptance_Purneftegaz_hours");
            }
        }
        public double? Acceptance_Yangpur_days
        {
            get { return (acceptance_Yangpur_days== 0) ? null : acceptance_Yangpur_days; }
            set
            {
                acceptance_Yangpur_days = value;
                OnPropertyChanged("Acceptance_Yangpur_days");
            }
        }
        public double? Acceptance_Purneft_days
        {
            get { return (acceptance_Purneft_days== 0) ? null : acceptance_Purneft_days; }
            set
            {
                acceptance_Purneft_days = value;
                OnPropertyChanged("Acceptance_Purneft_days");
            }
        }
        public double? Acceptance_Purneft_hours
        {
            get { return (acceptance_Purneft_hours== 0) ? null : acceptance_Purneft_hours; }
            set
            {
                acceptance_Purneft_hours = value;
                OnPropertyChanged("Acceptance_Purneft_hours");
            }
        }
        public double? Acceptance_Total_days
        {
            get { return (acceptance_Total_days== 0) ? null : acceptance_Total_days; }
            set
            {
                acceptance_Total_days = value;
                OnPropertyChanged("Acceptance_Total_days");
            }
        }
        public double? Acceptance_Total_hours
        {
            get { return (acceptance_Total_hours== 0) ? null : acceptance_Total_hours; }
            set
            {
                acceptance_Total_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Fat_PNG
        {
            get { return (fat_PNG== 0) ? null : fat_PNG; }
            set
            {
                fat_PNG = value;
                OnPropertyChanged("Fat_PNG");
            }
        }
        public double? SOG_Reduce
        {
            get { return (sOG_Reduce == 0) ? null : sOG_Reduce; }
            set
            {
                sOG_Reduce = value;
                OnPropertyChanged("SOG_Reduce");
            }
        }
        public double? SHFLY_Production_days
        {
            get { return (sHFLY_Production_days == 0) ? null : sHFLY_Production_days; }
            set
            {
                sHFLY_Production_days = value;
                OnPropertyChanged("SHFLY_Production_days");
            }
        }
        #endregion
        #region Col2
        public double? SHFLY_Production_hours
        {
            get { return (sHFLY_Production_hours== 0) ? null : sHFLY_Production_hours; }
            set
            {
                sHFLY_Production_hours = value;
                OnPropertyChanged("SHFLY_Production_hours");
            }
        }
        public double? SOGProduction_Factory_hours
        {
            get { return (sOGProduction_Factory_hours== 0) ? null : sOGProduction_Factory_hours; }
            set
            {
                sOGProduction_Factory_hours = value;
                OnPropertyChanged("SOGProduction_Factory_hours");
            }
        }
        public double? Etan_Percent
        {
            get { return (etan_Percent== 0) ? null : etan_Percent; }
            set
            {
                etan_Percent = value;
                OnPropertyChanged("Etan_Percent");
            }
        }
        public double? Etan_Record
        {
            get { return (etan_Record== 0) ? null : etan_Record; }
            set
            {
                etan_Record = value;
                OnPropertyChanged("Etan_Record");
            }
        }
        public double? SOGProduction_Magistral_days
        {
            get { return (sOGProduction_Magistral_days== 0) ? null : sOGProduction_Magistral_days; }
            set
            {
                sOGProduction_Magistral_days = value;
                OnPropertyChanged("SOGProduction_Magistral_days");
            }
        }
        public double? SOGProduction_Magistral_hours
        {
            get { return (sOGProduction_Magistral_hours== 0) ? null : sOGProduction_Magistral_hours; }
            set
            {
                sOGProduction_Magistral_hours = value;
                OnPropertyChanged("SOGProduction_Magistral_hours");
            }
        }
        public double? SOGProduction_Factory_days
        {
            get { return (sOGProduction_Factory_days== 0) ? null : sOGProduction_Factory_days; }
            set
            {
                sOGProduction_Factory_days = value;
                OnPropertyChanged("SOGProduction_Factory_days");
            }
        }

        #endregion
        #region Col3
       
        
        #endregion
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
