using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_Cleaner
{
    class Dates
    {
        DateTime _thisDay = DateTime.Today;
        public string GetTodayDay()
        {
            var day = _thisDay.ToString("d");
            return day;
        }
        public string GetNextDay()
        {
            var day = _thisDay;
            return day.AddMonths(1).ToString("d");
        }
        
    }
}
