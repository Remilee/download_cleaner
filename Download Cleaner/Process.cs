using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Download_Cleaner
{
    class Process
    {
        //Первоначальная загрузка

        //Спрашиваем папку Downloads

        
        string pathFile = "dates.txt";
        //string downloadFolder = @"E:\Downloads";
        string downloadFolder = "test";
        public Process()
        {
            
        }
        public string Execute()
        {
            string message = "null";
            //Загрузка сегодняшней даты
            DateTime thisDay = DateTime.Today;
            var day = thisDay;
            
            string today = thisDay.ToString("d");
            //Чтение файла с последней датой (датой, когда нужно производить очистку)
            if (System.IO.File.Exists(pathFile))
            {
                string[] data = System.IO.File.ReadAllLines(pathFile);
                string dateOfClean = data.Last();
                string lastDateOfClean;
                if (data.Count() == 1)
                {
                    lastDateOfClean = null;
                }
                else if (data.Count() > 1)
                {
                    lastDateOfClean = data[data.Length - 1];
                }
                 
                //если сегодня - выполнять
                if (dateOfClean == today || (today.CompareTo(dateOfClean) > 0))
                {
                    if (Directory.Exists(downloadFolder))
                    {
                        string[] files = Directory.GetFiles(downloadFolder);
                        foreach (string f in files)
                        {
                            System.IO.File.Delete(f);
                        }
                        //добавляем новую дату (через месяц)
                        using (StreamWriter strw = new StreamWriter(pathFile))
                        {

                            strw.WriteLine(day.AddMonths(1).ToString("d"));
                        }
                    }


                }
                //если прошло, то тоже выполнять

            }
            return message;
        }
        void CreateFile(string today)
        {
            using (StreamWriter sw = System.IO.File.CreateText(pathFile))
            {
                sw.WriteLine(today);
                
            }

        }
        
        
        
    }
}
