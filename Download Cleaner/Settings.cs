using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Download_Cleaner
{
    internal class Settings
    {
        string _path = "dates.txt";
        public string GetCleaningDate()
        {
            if (File.Exists(_path))
            {
                var data = File.ReadAllLines(_path);
                var dateOfClean = data.Last();
                return dateOfClean;
            }
            else { return null; }
        }
        public void InsertNewDate()
        {
            using (var strw = new StreamWriter(_path))
            {
                var dates = new Dates();
                strw.WriteLine(dates.GetNextDay());
            }
        }
    }
}
