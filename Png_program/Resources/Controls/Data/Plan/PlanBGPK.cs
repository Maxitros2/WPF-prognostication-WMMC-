using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.Data.Plan
{
    public class PlanBGPK {
        /*
    CREATE TABLE "PlanBGPKs" (
	"ID"	INTEGER NOT NULL,
	"Date"	TEXT,
	"Acceptance_SNG_days"	REAL,
	"Acceptance_SNG_hours"	REAL,
	"Acceptance_NG_days"	REAL,
	"Acceptance_NG_hours"	REAL,
	"Acceptance_VGPP_days"	REAL,
	"Acceptance_VGPP_hours"	REAL,
    "Acceptance_Rysneft_days"	REAL,
	"Acceptance_Rysneft_hours"	REAL,
    "Acceptance_VNG_days"	REAL,
	"Acceptance_VNG_hours"	REAL,
    "Acceptance_VGPPNG_SN"	REAL,
	"Acceptance_VGPPNG_Lose"	REAL,
    "Acceptance_VGPPNG_ProduceBGS"	REAL,
    "Acceptance_VGPPNG_SupplyVGPZ"	REAL,
    "Acceptance_VGPPNG_SupplyBGPK"	REAL,
    "Acceptance_VGPPNG_SupplyNVGPK"	REAL,
    "Acceptance_BKS_days"	REAL,
	"Acceptance_BKS_hours"	REAL,
    "Acceptance_VNG1_days"	REAL,
	"Acceptance_VNG1_hours"	REAL,
    "Acceptance_Negysneft_days"	REAL,
	"Acceptance_Negysneft_hours"	REAL,
    "Acceptance_BKSNG_SN"	REAL,
	"Acceptance_BKSNG_Lose"	REAL,
    "Acceptance_BKSNG_SupplyBGPK"	REAL,
    "Acceptance_BKSNG_SupplyNVGPK"	REAL,
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
        private double? acceptance_SNG_days;
        private double? acceptance_SNG_hours;
        private double? acceptance_NG_days;
        private double? acceptance_NG_hours;
        private double? acceptance_VGPP_days;
        private double? acceptance_VGPP_hours;
        private double? acceptance_Rysneft_days;
        private double? acceptance_Rysneft_hours;
        private double? acceptance_VNG_days;
        private double? acceptance_VNG_hours;
        private double? acceptance_VGPPNG_SN;
        private double? acceptance_VGPPNG_Lose;
        private double? acceptance_VGPPNG_ProduceBGS;
        private double? acceptance_VGPPNG_SupplyVGPZ;
        private double? acceptance_VGPPNG_SupplyBGPK;
        private double? acceptance_VGPPNG_SupplyNVGPK;
        private double? acceptance_BKS_days;
        private double? acceptance_BKS_hours;
        private double? acceptance_VNG1_days;
        private double? acceptance_VNG1_hours;
        private double? acceptance_Negysneft_days;
        private double? acceptance_Negysneft_hours;
        private double? acceptance_BKSNG_SN;
        private double? acceptance_BKSNG_Lose;
        private double? acceptance_BKSNG_SupplyBGPK;
        private double? acceptance_BKSNG_SupplyNVGPK;
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
        public double? Acceptance_BKSNG_SupplyNVGPK
        {
            get { return (acceptance_BKSNG_SupplyNVGPK == 0) ? null : acceptance_BKSNG_SupplyNVGPK; }
            set
            {
                acceptance_BKSNG_SupplyNVGPK = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_BKSNG_SupplyBGPK
        {
            get { return (acceptance_BKSNG_SupplyBGPK == 0) ? null : acceptance_BKSNG_SupplyBGPK; }
            set
            {
                acceptance_BKSNG_SupplyBGPK = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_BKSNG_Lose
        {
            get { return (acceptance_BKSNG_Lose == 0) ? null : acceptance_BKSNG_Lose; }
            set
            {
                acceptance_BKSNG_Lose = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_BKSNG_SN
        {
            get { return (acceptance_BKSNG_SN == 0) ? null : acceptance_BKSNG_SN; }
            set
            {
                acceptance_BKSNG_SN = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_Negysneft_hours
        {
            get { return (acceptance_Negysneft_hours == 0) ? null : acceptance_Negysneft_hours; }
            set
            {
                acceptance_Negysneft_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_Negysneft_days
        {
            get { return (acceptance_Negysneft_days == 0) ? null : acceptance_Negysneft_days; }
            set
            {
                acceptance_Negysneft_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VNG1_hours
        {
            get { return (acceptance_VNG1_hours == 0) ? null : acceptance_VNG1_hours; }
            set
            {
                acceptance_VNG1_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VNG1_days
        {
            get { return (acceptance_VNG1_days == 0) ? null : acceptance_VNG1_days; }
            set
            {
                acceptance_VNG1_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_BKS_hours
        {
            get { return (acceptance_BKS_hours == 0) ? null : acceptance_BKS_hours; }
            set
            {
                acceptance_BKS_hours = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_BKS_days
        {
            get { return (acceptance_BKS_days == 0) ? null : acceptance_BKS_days; }
            set
            {
                acceptance_BKS_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VGPPNG_SupplyNVGPK
        {
            get { return (acceptance_VGPPNG_SupplyNVGPK == 0) ? null : acceptance_VGPPNG_SupplyNVGPK; }
            set
            {
                acceptance_VGPPNG_SupplyNVGPK = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VGPPNG_SupplyBGPK
        {
            get { return (acceptance_VGPPNG_SupplyBGPK == 0) ? null : acceptance_VGPPNG_SupplyBGPK; }
            set
            {
                acceptance_VGPPNG_SupplyBGPK = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VGPPNG_SupplyVGPZ
        {
            get { return (acceptance_VGPPNG_SupplyVGPZ == 0) ? null : acceptance_VGPPNG_SupplyVGPZ; }
            set
            {
                acceptance_VGPPNG_SupplyVGPZ = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VGPPNG_ProduceBGS
        {
            get { return (acceptance_VGPPNG_ProduceBGS == 0) ? null : acceptance_VGPPNG_ProduceBGS; }
            set
            {
                acceptance_VGPPNG_ProduceBGS = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VGPPNG_SN
        {
            get { return (acceptance_VGPPNG_SN == 0) ? null : acceptance_VGPPNG_SN; }
            set
            {
                acceptance_VGPPNG_SN = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VGPPNG_Lose
        {
            get { return (acceptance_VGPPNG_Lose == 0) ? null : acceptance_VGPPNG_Lose; }
            set
            {
                acceptance_VGPPNG_Lose = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VNG_days
        {
            get { return (acceptance_VNG_days == 0) ? null : acceptance_VNG_days; }
            set
            {
                acceptance_VNG_days = value;
                OnPropertyChanged("Acceptance_Total_hours");
            }
        }
        public double? Acceptance_VNG_hours
        {
            get { return (acceptance_VNG_hours == 0) ? null : acceptance_VNG_hours; }
            set
            {
                acceptance_VNG_hours = value;
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
        public double? Acceptance_NG_days
        {
            get { return (acceptance_NG_days == 0) ? null : acceptance_NG_days; }
            set
            {
                acceptance_NG_days = value;
                OnPropertyChanged("Acceptance_GPNNNG_hours");
            }
        }
        public double? Acceptance_NG_hours
        {
            get { return (acceptance_NG_hours == 0) ? null : acceptance_NG_hours; }
            set
            {
                acceptance_NG_hours = value;
                OnPropertyChanged("Acceptance_YAKE_days");
            }
        }
        public double? Acceptance_VGPP_days
        {
            get { return (acceptance_VGPP_days == 0) ? null : acceptance_VGPP_days; }
            set
            {
                acceptance_VGPP_days = value;
                OnPropertyChanged("Acceptance_HKS_days");
            }
        }
        public double? Acceptance_VGPP_hours
        {
            get { return (acceptance_VGPP_hours == 0) ? null : acceptance_VGPP_hours; }
            set
            {
                acceptance_VGPP_hours = value;
                OnPropertyChanged("Acceptance_HKS_hours");
            }
        }
        public double? Acceptance_Rysneft_days
        {
            get { return (acceptance_Rysneft_days == 0) ? null : acceptance_Rysneft_days; }
            set
            {
                acceptance_Rysneft_days = value;
                OnPropertyChanged("Acceptance_Total_days");
            }
        }
        public double? Acceptance_Rysneft_hours
        {
            get { return (acceptance_Rysneft_hours == 0) ? null : acceptance_Rysneft_hours; }
            set
            {
                acceptance_Rysneft_hours = value;
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