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
        public string GetNextMonth()
        {
            var day = _thisDay;
            return day.AddMonths(1).ToString("d");
        }

        public string GetTomorrowDay()
        {
            var day = _thisDay;
            return day.AddDays(1).ToString("d");
        }

        
    }
}
