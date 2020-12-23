using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    public class PlanNGP : INotifyPropertyChanged
    {
        /*
    CREATE TABLE "PlanNGP" (
	"ID"	INTEGER NOT NULL,
	"Date"	TEXT,
	"Acceptance_Nyaganneftegaz_days"	REAL,
	"Acceptance_Nyaganneftegaz_hours"	REAL,
	"Acceptance_Lykoil_days"	REAL,
	"Acceptance_Lykoil_hours"	REAL,
	"Acceptance_Total_days"	REAL,
	"Acceptance_Total_hours"	REAL,
	"Fat_PNG"	REAL,
	"SOG_Reduce"	REAL,
	"PBTProduction_Factory_days"	REAL,
	"PBTProduction_Factory_hours"	REAL,
	"BGSProduction_Factory_days"	REAL,
	"BGSProduction_Factory_hours"	REAL,
	"PTProduction_Factory_days"	REAL,
	"PTProduction_Factory_hours"	REAL,
	"SOGProduction_Factory_days"	REAL,
	"SOGProduction_Factory_hours"	REAL,
	"SOGProduction_Magistral_days"	REAL,
	"SOGProduction_Magistral_hours"	REAL,
	PRIMARY KEY("ID" AUTOINCREMENT)
)
         */

        public int ID { get; set; }
        private string date;
        private double? acceptance_Nyaganneftegaz_days;
        private double? acceptance_Nyaganneftegaz_hours;
        private double? acceptance_Lykoil_days;
        private double? acceptance_Lykoil_hours;
        private double? acceptance_Total_days;
        private double? acceptance_Total_hours;
        private double? fat_PNG;
        private double? sOG_Reduce;
        private double? pBTProduction_Factory_days;
        private double? pBTProduction_Factory_hours;
        private double? bGSProduction_Factory_days;
        private double? bGSProduction_Factory_hours;
        private double? pTProduction_Factory_days;
        private double? pTProduction_Factory_hours;
        private double? sOGProduction_Factory_days;
        private double? sOGProduction_Factory_hours;
        private double? sOGProduction_Magistral_days;
        private double? sOGProduction_Magistral_hours;

        public double? PTProduction_Factory_days
        {
            get { return (pTProduction_Factory_days == 0) ? null : pTProduction_Factory_days; }
            set
            {
                pTProduction_Factory_days = value;
                OnPropertyChanged("PTProduction_Factory_days");
            }
        }
        public double? PTProduction_Factory_hours
        {
            get { return (pTProduction_Factory_hours == 0) ? null : pTProduction_Factory_hours; }
            set
            {
                pTProduction_Factory_hours = value;
                OnPropertyChanged("PTProduction_Factory_hours");
            }
        }

        public double? PBTProduction_Factory_days
        {
            get { return (pBTProduction_Factory_days == 0) ? null : pBTProduction_Factory_days; }
            set
            {
                pBTProduction_Factory_days = value;
                OnPropertyChanged("PBTProduction_Factory_days");
            }
        }
        public double? PBTProduction_Factory_hours
        {
            get { return (pBTProduction_Factory_hours == 0) ? null : pBTProduction_Factory_hours; }
            set
            {
                pBTProduction_Factory_hours = value;
                OnPropertyChanged("PBTProduction_Factory_hours");
            }
        }
        public double? BGSProduction_Factory_days
        {
            get { return (bGSProduction_Factory_days == 0) ? null : bGSProduction_Factory_days; }
            set
            {
                bGSProduction_Factory_days = value;
                OnPropertyChanged("BGSProduction_Factory_days");
            }
        }
        public double? BGSProduction_Factory_hours
        {
            get { return (bGSProduction_Factory_hours == 0) ? null : bGSProduction_Factory_hours; }
            set
            {
                bGSProduction_Factory_hours = value;
                OnPropertyChanged("BOGProduction_Factory_hours");
            }
        }
        #region Col1
        public double? Acceptance_Nyaganneftegaz_days
        {
            get { return (acceptance_Nyaganneftegaz_days == 0) ? null : acceptance_Nyaganneftegaz_days; }
            set
            {
                acceptance_Nyaganneftegaz_days = value;
                OnPropertyChanged("Acceptance_Nyaganneftegaz_days");
            }
        }
        public double? Acceptance_Lykoil_hours
        {
            get { return (acceptance_Lykoil_hours == 0) ? null : acceptance_Lykoil_hours; }
            set
            {
                acceptance_Lykoil_hours = value;
                OnPropertyChanged("Acceptance_Lykoil_hours");
            }
        }
        public double? Acceptance_Nyaganneftegaz_hours
        {
            get { return (acceptance_Nyaganneftegaz_hours== 0) ? null : acceptance_Nyaganneftegaz_hours; }
            set
            {
                acceptance_Nyaganneftegaz_hours = value;
                OnPropertyChanged("Acceptance_Nyaganneftegaz_hours");
            }
        }
        public double? Acceptance_Lykoil_days
        {
            get { return (acceptance_Lykoil_days== 0) ? null : acceptance_Lykoil_days; }
            set
            {
                acceptance_Lykoil_days = value;
                OnPropertyChanged("Acceptance_Lykoil_days");
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
     
        #endregion
        #region Col2

        public double? SOGProduction_Factory_hours
        {
            get { return (sOGProduction_Factory_hours== 0) ? null : sOGProduction_Factory_hours; }
            set
            {
                sOGProduction_Factory_hours = value;
                OnPropertyChanged("SOGProduction_Factory_hours");
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
