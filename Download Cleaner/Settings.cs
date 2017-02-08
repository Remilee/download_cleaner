using System.Linq;
using System.IO;

namespace Download_Cleaner
{
    internal class Settings
    {
        string _path = "settings.txt";
        
        public bool FileExists()
        {
            if (File.Exists(_path))
            {
                return true;

            }
            else return false;
        }

        public void CreateSetFile()
        {
            using (FileStream fileStream = File.Create(_path));
            
            using (var stream = new StreamWriter(_path))
            {
                stream.WriteLine("1");
                var dates = new Dates();
                stream.WriteLine(dates.GetNextMonth());
            }
            
        }
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
        public void InsertNewDate(string nextDay)
        {
            using (var strw = new StreamWriter(_path, true))
            {
                strw.WriteLine(nextDay);
            }
        }

        public string GetMode()
        {
            var data = File.ReadAllLines(_path);
            var mode = data.First();
            if (mode.Contains("1"))
            {
                return "1";
            }
            else return "no data";
        }
    }
}
