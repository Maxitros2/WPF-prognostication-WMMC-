using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data
{
    public class PlanVGPZ : INotifyPropertyChanged
    {
        /*
    CREATE TABLE "PlanVGPZs" (
	"ID"	INTEGER NOT NULL,
	"Date"	TEXT,
	"Acceptance_GPNNNG_days"	REAL,
	"Acceptance_GPNNNG_hours"	REAL,
	"Acceptance_NGVGPP_days"	REAL,
	"Acceptance_NGVGPP_hours"	REAL,
	"Acceptance_VyaKC_days"	REAL,
	"Acceptance_VyaKC_hours"	REAL,
    "Acceptance_VyaKCNG_SN"	REAL,
	"Acceptance_VyaKCNG_Lose"	REAL,
	"Acceptance_VyaKCNG_SupplyMGPZ"	REAL,
	"Acceptance_TotalFactory_days"	REAL,
	"Acceptance_TotalFactory_hours"	REAL,
    "Acceptance_TotalComplex_days"	REAL,
	"Acceptance_TotalComplex_hours"	REAL,
	"Fat_PNG"	REAL,
	"SOG_Reduce"	REAL,
	"SHFLY_Production_days"	REAL,
	"SHFLY_Production_hours"	REAL,
	"Etan_Percent"	REAL,
	"Etan_Record"	REAL,
	"SOGProduction_Complex_days"	REAL,
	"SOGProduction_Complex_hours"	REAL,
	"SOGProduction_Factory_days"	REAL,
	"SOGProduction_Factory_hours"	REAL,
	"SOGProduction_Magistral_days"	REAL,
	"SOGProduction_Magistral_hours"	REAL,
	PRIMARY KEY("ID" AUTOINCREMENT)
)
)
         */

        public int ID { get; set; }
        private string date;
        private double? acceptance_GPNNNG_days;
        private double? acceptance_GPNNNG_hours;
        private double? acceptance_NGVGPP_days;
        private double? acceptance_NGVGPP_hours;
        private double? acceptance_VyaKC_days;
        private double? acceptance_VyaKC_hours;
        private double? acceptance_VyaKCNG_SN;
        private double? acceptance_VyaKCNG_Lose;
        private double? acceptance_VyaKCNG_SupplyMGPZ;
        private double? acceptance_TotalFactory_days;
        private double? acceptance_TotalFactory_hours;
        private double? acceptance_TotalComplex_days;
        private double? acceptance_TotalComplex_hours;
        private double? fat_PNG;
        private double? sOG_Reduce;
        private double? sHFLY_Production_days;
        private double? sHFLY_Production_hours;
        private double? etan_Percent;
        private double? etan_Record;
        private double? sOGProduction_Complex_days;
        private double? sOGProduction_Complex_hours;
        private double? sOGProduction_Factory_days;
        private double? sOGProduction_Factory_hours;
        private double? sOGProduction_Magistral_days;
        private double? sOGProduction_Magistral_hours;


        #region Col1
        public double? Acceptance_VyaKCNG_SN
        {
            get { return (acceptance_VyaKCNG_SN == 0) ? null : acceptance_VyaKCNG_SN; }
            set
            {
                acceptance_VyaKCNG_SN = value;
                OnPropertyChanged("Acceptance_VyaKCNG_SN");
            }
        }
        public double? Acceptance_VyaKCNG_Lose
        {
            get { return (acceptance_VyaKCNG_Lose == 0) ? null : acceptance_VyaKCNG_Lose; }
            set
            {
                acceptance_VyaKCNG_Lose = value;
                OnPropertyChanged("Acceptance_VyaKCNG_Lose");
            }
        }
        public double? Acceptance_VyaKCNG_SupplyMGPZ
        {
            get { return (acceptance_VyaKCNG_SupplyMGPZ == 0) ? null : acceptance_VyaKCNG_SupplyMGPZ; }
            set
            {
                acceptance_VyaKCNG_SupplyMGPZ = value;
                OnPropertyChanged("Acceptance_VyaKCNG_SupplyMGPZ");
            }
        }
        public double? Acceptance_GPNNNG_days
        {
            get { return (acceptance_GPNNNG_days == 0) ? null : acceptance_GPNNNG_days; }
            set
            {
                acceptance_GPNNNG_days = value;
                OnPropertyChanged("Acceptance_GPNNNG_days");
            }
        }
        public double? Acceptance_NGVGPP_hours
        {
            get { return (acceptance_NGVGPP_hours == 0) ? null : acceptance_NGVGPP_hours; }
            set
            {
                acceptance_NGVGPP_hours = value;
                OnPropertyChanged("Acceptance_NGVGPP_hours");
            }
        }
        public double? Acceptance_GPNNNG_hours
        {
            get { return (acceptance_GPNNNG_hours== 0) ? null : acceptance_GPNNNG_hours; }
            set
            {
                acceptance_GPNNNG_hours = value;
                OnPropertyChanged("Acceptance_GPNNNG_hours");
            }
        }
        public double? Acceptance_NGVGPP_days
        {
            get { return (acceptance_NGVGPP_days== 0) ? null : acceptance_NGVGPP_days; }
            set
            {
                acceptance_NGVGPP_days = value;
                OnPropertyChanged("Acceptance_NGVGPP_days");
            }
        }
        public double? Acceptance_VyaKC_days
        {
            get { return (acceptance_VyaKC_days== 0) ? null : acceptance_VyaKC_days; }
            set
            {
                acceptance_VyaKC_days = value;
                OnPropertyChanged("Acceptance_VyaKC_days");
            }
        }
        public double? Acceptance_VyaKC_hours
        {
            get { return (acceptance_VyaKC_hours== 0) ? null : acceptance_VyaKC_hours; }
            set
            {
                acceptance_VyaKC_hours = value;
                OnPropertyChanged("Acceptance_VyaKC_hours");
            }
        }
        public double? Acceptance_TotalComplex_hours
        {
            get { return (acceptance_TotalComplex_hours == 0) ? null : acceptance_TotalComplex_hours; }
            set
            {
                acceptance_TotalComplex_hours = value;
                OnPropertyChanged("Acceptance_TotalComplex_hours");
            }
        }
        public double? Acceptance_TotalComplex_days
        {
            get { return (acceptance_TotalComplex_days == 0) ? null : acceptance_TotalComplex_days; }
            set
            {
                acceptance_TotalComplex_days = value;
                OnPropertyChanged("Acceptance_TotalComplex_days");
            }
        }
        public double? Acceptance_TotalFactory_hours
        {
            get { return (acceptance_TotalFactory_hours == 0) ? null : acceptance_TotalFactory_hours; }
            set
            {
                acceptance_TotalFactory_hours = value;
                OnPropertyChanged("Acceptance_TotalFactory_hours");
            }
        }
        public double? Acceptance_TotalFactory_days
        {
            get { return (acceptance_TotalFactory_days == 0) ? null : acceptance_TotalFactory_days; }
            set
            {
                acceptance_TotalFactory_days = value;
                OnPropertyChanged("Acceptance_TotalFactory_days");
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
        public double? SOGProduction_Complex_days
        {
            get { return (sOGProduction_Complex_days == 0) ? null : sOGProduction_Complex_days; }
            set
            {
                sOGProduction_Complex_days = value;
                OnPropertyChanged("SOGProduction_Complex_days");
            }
        }
        public double? SOGProduction_Complex_hours
        {
            get { return (sOGProduction_Complex_hours == 0) ? null : sOGProduction_Complex_hours; }
            set
            {
                sOGProduction_Complex_hours = value;
                OnPropertyChanged("SOGProduction_Complex_hours");
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
