using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.utils
{
    public static class DateTranslater
    {
        public static string[] GetDateString(DateTime time)
        {
            string mounths;
            switch(time.Month)
            {
                case 1 : mounths = "января"; break;
                case 2: mounths = "февраля"; break;
                case 3: mounths = "марта"; break;
                case 4: mounths = "апреля"; break;
                case 5: mounths = "мая"; break;
                case 6: mounths = "июня"; break;
                case 7: mounths = "июля"; break;
                case 8: mounths = "августа"; break;
                case 9: mounths = "сентября"; break;
                case 10: mounths = "октября"; break;
                case 11: mounths = "ноября"; break;
                case 12: mounths = "декабря"; break;
                default: mounths = ""; break;
            }
            return new string[] { String.Format("{0} {1} {2}", time.Day, mounths, time.Year), String.Format("{0}:{1}",time.Hour,time.Minute)};

        }
        public static string GetMYString(DateTime time)
        {
            string mounths;
            switch (time.Month)
            {
                case 1: mounths = "Январь"; break;
                case 2: mounths = "Февраль"; break;
                case 3: mounths = "Март"; break;
                case 4: mounths = "Апрель"; break;
                case 5: mounths = "Май"; break;
                case 6: mounths = "Июнь"; break;
                case 7: mounths = "Июль"; break;
                case 8: mounths = "Август"; break;
                case 9: mounths = "Сентябрь"; break;
                case 10: mounths = "Октябрь"; break;
                case 11: mounths = "Ноябрь"; break;
                case 12: mounths = "Декабрь"; break;
                default: mounths = ""; break;
            }
            
            return String.Format("{0} {1}", mounths, time.Year);

        }
    }
}
