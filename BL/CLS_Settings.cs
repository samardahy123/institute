using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institute.BL
{
    class CLS_Settings
    {

        public static String date2String(DateTime d)
        {
            String day = d.Day.ToString();
            String month = d.Month.ToString();
            String year = d.Year.ToString();
            return year + "-" + month + "-" + day;
        }
        public static String time2String(DateTime d)
        {
            String hour = d.Hour.ToString();
            String minute = d.Minute.ToString();
            return hour + ":" + minute;
        }
    }
}
