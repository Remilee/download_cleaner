using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_Cleaner
{
    class Program
    {

        static void Main(string[] args)
        {
            var comp = new Comparer();
            if (comp.Compare_dates())
            {
                var set = new Settings();
                var dates = new Dates();
                var dloader = new DownloadFolder();
                dloader.DeleteFiles();
                var nextday = dates.GetNextDay();
                set.InsertNewDate();
            }
            else
            {
                //забить
            }



        }
    }
}
