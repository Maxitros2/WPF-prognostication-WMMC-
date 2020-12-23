using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data.Plan
{
    public class PlanNVGPK
    {
        /*
    CREATE TABLE "PlanNVGPKs" (
	"ID"	INTEGER NOT NULL,
	"Date"	TEXT,
	"Acceptance_SNG_days"	REAL,
	"Acceptance_SNG_hours"	REAL,
	"Acceptance_HKS_days"	REAL,
	"Acceptance_HKS_hours"	REAL,
	"Acceptance_SNMNG_days"	REAL,
	"Acceptance_SNMNG_hours"	REAL,
    "Acceptance_Soverskoe_days"	REAL,
	"Acceptance_Soverskoe_hours"	REAL,
    "Acceptance_PNG_days"	REAL,
	"Acceptance_PNG_hours"	REAL,
    "Acceptance_NG_days"	REAL,
	"Acceptance_NG_hours"	REAL,
    "Acceptance_TKS_days"	REAL,
    "Acceptance_TKS_hours"	REAL,
    "Acceptance_SNG1_days"	REAL,
    "Acceptance_SNG1_hours"	REAL,
    "Acceptance_NNP_days"	REAL,
	"Acceptance_NNP_hours"	REAL,
    "Acceptance_TKSNG_SN"	REAL,
	"Acceptance_TKSNG_Lose"	REAL,
    "Acceptance_TKSNG_SupplyBGPK"	REAL,
    "Acceptance_TKSNG_SupplyNVGPK"	REAL,
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
    "BGS"	REAL,
	"NekondBKS"	REAL,
    "PT"	REAL,
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
        private double? acceptance_SNG_days;
        private double? acceptance_SNG_hours;
        private double? acceptance_HKS_days;
        private double? acceptance_HKS_hours;
        private double? acceptance_SNMNG_days;
        private double? acceptance_SNMNG_hours;
        private double? acceptance_Soverskoe_days;
        private double? acceptance_Soverskoe_hours;
        private double? acceptance_PNG_days;
        private double? acceptance_PNG_hours;
        private double? acceptance_NG_days;
        private double? acceptance_NG_hours;
        private double? acceptance_TKS_days;
        private double? acceptance_TKS_hours;
        private double? acceptance_SNG1_days;
        private double? acceptance_SNG1_hours;
        private double? acceptance_NNP_days;
        private double? acceptance_NNP_hours;
        private double? acceptance_TKSNG_SN;
        private double? acceptance_TKSNG_Lose;
        private double? acceptance_TKSNG_SupplyBGPK;
        private double? acceptance_TKSNG_SupplyNVGPK;
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
        private double? bGS;
        private double? nekondBKS;
        private double? pT;
        private double? sOGProduction_Complex_days;
        private double? sOGProduction_Complex_hours;
        private double? sOGProduction_Factory_days;
        private double? sOGProduction_Factory_hours;
        private double? sOGProduction_Magistral_days;
        private double? sOGProduction_Magistral_hours;


        #region Col1
        public double? Acceptance_TotalComplex_hours
        {
            get { return (acceptance_TotalComplex_hours == 0) ? null : acceptance_TotalComplex_hours; }
            set
            {
                acceptance_TotalComplex_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TotalComplex_days
        {
            get { return (acceptance_TotalComplex_days == 0) ? null : acceptance_TotalComplex_days; }
            set
            {
                acceptance_TotalComplex_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TotalFactory_hours
        {
            get { return (acceptance_TotalFactory_hours == 0) ? null : acceptance_TotalFactory_hours; }
            set
            {
                acceptance_TotalFactory_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TotalFactory_days
        {
            get { return (acceptance_TotalFactory_days == 0) ? null : acceptance_TotalFactory_days; }
            set
            {
                acceptance_TotalFactory_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TKSNG_SupplyNVGPK
        {
            get { return (acceptance_TKSNG_SupplyNVGPK == 0) ? null : acceptance_TKSNG_SupplyNVGPK; }
            set
            {
                acceptance_TKSNG_SupplyNVGPK = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TKSNG_SupplyBGPK
        {
            get { return (acceptance_TKSNG_SupplyBGPK == 0) ? null : acceptance_TKSNG_SupplyBGPK; }
            set
            {
                acceptance_TKSNG_SupplyBGPK = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TKSNG_Lose
        {
            get { return (acceptance_TKSNG_Lose == 0) ? null : acceptance_TKSNG_Lose; }
            set
            {
                acceptance_TKSNG_Lose = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TKSNG_SN
        {
            get { return (acceptance_TKSNG_SN == 0) ? null : acceptance_TKSNG_SN; }
            set
            {
                acceptance_TKSNG_SN = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }       
        public double? BGS
        {
            get { return (bGS == 0) ? null : bGS; }
            set
            {
                bGS = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? NekondBKS
        {
            get { return (nekondBKS == 0) ? null : nekondBKS; }
            set
            {
                nekondBKS = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? PT
        {
            get { return (pT == 0) ? null : pT; }
            set
            {
                pT = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_NNP_hours
        {
            get { return (acceptance_NNP_hours == 0) ? null : acceptance_NNP_hours; }
            set
            {
                acceptance_NNP_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_NNP_days
        {
            get { return (acceptance_NNP_days == 0) ? null : acceptance_NNP_days; }
            set
            {
                acceptance_NNP_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_SNG1_hours
        {
            get { return (acceptance_SNG1_hours == 0) ? null : acceptance_SNG1_hours; }
            set
            {
                acceptance_SNG1_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_SNG1_days
        {
            get { return (acceptance_SNG1_days == 0) ? null : acceptance_SNG1_days; }
            set
            {
                acceptance_SNG1_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TKS_hours
        {
            get { return (acceptance_TKS_hours == 0) ? null : acceptance_TKS_hours; }
            set
            {
                acceptance_TKS_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_TKS_days
        {
            get { return (acceptance_TKS_days == 0) ? null : acceptance_TKS_days; }
            set
            {
                acceptance_TKS_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_NG_days
        {
            get { return (acceptance_NG_days == 0) ? null : acceptance_NG_days; }
            set
            {
                acceptance_NG_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_NG_hours
        {
            get { return (acceptance_NG_hours == 0) ? null : acceptance_NG_hours; }
            set
            {
                acceptance_NG_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_PNG_days
        {
            get { return (acceptance_PNG_days == 0) ? null : acceptance_PNG_days; }
            set
            {
                acceptance_PNG_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_PNG_hours
        {
            get { return (acceptance_PNG_hours == 0) ? null : acceptance_PNG_hours; }
            set
            {
                acceptance_PNG_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_SNG_days
        {
            get { return (acceptance_SNG_days == 0) ? null : acceptance_SNG_days; }
            set
            {
                acceptance_SNG_days = value;
                OnPropertyChanged("Acceptance_GPNNNG_days");
            }
        }
        public double? Acceptance_SNG_hours
        {
            get { return (acceptance_SNG_hours == 0) ? null : acceptance_SNG_hours; }
            set
            {
                acceptance_SNG_hours = value;
                OnPropertyChanged("Acceptance_YAKE_hours");
            }
        }
        public double? Acceptance_HKS_days
        {
            get { return (acceptance_HKS_days == 0) ? null : acceptance_HKS_days; }
            set
            {
                acceptance_HKS_days = value;
                OnPropertyChanged("Acceptance_GPNNNG_hours");
            }
        }
        public double? Acceptance_HKS_hours
        {
            get { return (acceptance_HKS_hours == 0) ? null : acceptance_HKS_hours; }
            set
            {
                acceptance_HKS_hours = value;
                OnPropertyChanged("Acceptance_YAKE_days");
            }
        }
        public double? Acceptance_SNMNG_days
        {
            get { return (acceptance_SNMNG_days == 0) ? null : acceptance_SNMNG_days; }
            set
            {
                acceptance_SNMNG_days = value;
                OnPropertyChanged("Acceptance_HKS_days");
            }
        }
        public double? Acceptance_SNMNG_hours
        {
            get { return (acceptance_SNMNG_hours == 0) ? null : acceptance_SNMNG_hours; }
            set
            {
                acceptance_SNMNG_hours = value;
                OnPropertyChanged("Acceptance_HKS_hours");
            }
        }
        public double? Acceptance_Soverskoe_days
        {
            get { return (acceptance_Soverskoe_days == 0) ? null : acceptance_Soverskoe_days; }
            set
            {
                acceptance_Soverskoe_days = value;
                OnPropertyChanged("Acceptance_Total_days");
            }
        }
        public double? Acceptance_Soverskoe_hours
        {
            get { return (acceptance_Soverskoe_hours == 0) ? null : acceptance_Soverskoe_hours; }
            set
            {
                acceptance_Soverskoe_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Fat_PNG
        {
            get { return (fat_PNG == 0) ? null : fat_PNG; }
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
            get { return (sHFLY_Production_hours == 0) ? null : sHFLY_Production_hours; }
            set
            {
                sHFLY_Production_hours = value;
                OnPropertyChanged("SHFLY_Production_hours");
            }
        }
        public double? SOGProduction_Factory_hours
        {
            get { return (sOGProduction_Factory_hours == 0) ? null : sOGProduction_Factory_hours; }
            set
            {
                sOGProduction_Factory_hours = value;
                OnPropertyChanged("SOGProduction_Factory_hours");
            }
        }
        public double? Etan_Percent
        {
            get { return (etan_Percent == 0) ? null : etan_Percent; }
            set
            {
                etan_Percent = value;
                OnPropertyChanged("Etan_Percent");
            }
        }
        public double? Etan_Record
        {
            get { return (etan_Record == 0) ? null : etan_Record; }
            set
            {
                etan_Record = value;
                OnPropertyChanged("Etan_Record");
            }
        }
        public double? SOGProduction_Magistral_days
        {
            get { return (sOGProduction_Magistral_days == 0) ? null : sOGProduction_Magistral_days; }
            set
            {
                sOGProduction_Magistral_days = value;
                OnPropertyChanged("SOGProduction_Magistral_days");
            }
        }
        public double? SOGProduction_Magistral_hours
        {
            get { return (sOGProduction_Magistral_hours == 0) ? null : sOGProduction_Magistral_hours; }
            set
            {
                sOGProduction_Magistral_hours = value;
                OnPropertyChanged("SOGProduction_Magistral_hours");
            }
        }
        public double? SOGProduction_Factory_days
        {
            get { return (sOGProduction_Factory_days == 0) ? null : sOGProduction_Factory_days; }
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
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}