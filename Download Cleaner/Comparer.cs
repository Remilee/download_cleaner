using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_Cleaner
{
    internal class Comparer
    {
        
        public bool Compare_dates()
        {
            var set = new Settings();
            var dates = new Dates();
            var dloader = new DownloadFolder();
            var cleaningDate = set.GetCleaningDate();
            var today = dates.GetTodayDay();
            if (today == cleaningDate)
            {
                return true;
                
            }
            else return false;
        }
    }
}
