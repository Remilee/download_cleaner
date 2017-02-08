using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Cleaner
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            var dloader = new DownloadFolder();
            var date = new Dates();
            var set = new Settings();
            if (!set.FileExists())
            {
                set.CreateSetFile();
                Application.Run(new SelectDownloadFolder());
            }
            else if (set.FileExists())
            {
                if (set.GetMode() == "1")
                {
                    var comp = new Comparer();
                    if (comp.Compare_dates()) 
                    {
                        var uInter = new UserInteraction();
                        if (uInter.AskUserAnswer())
                        {
                            //спросить про расширения
                                //окно с типами с checkbox-ами
                                //выделенное дропнуть
                            //dloader.DeleteFiles();
                            set.InsertNewDate(date.GetNextMonth());
                        }
                        else
                        {
                            set.InsertNewDate(date.GetTomorrowDay());
                            
                        }
                    }
                    else
                    {
                        //забить
                    }
                }
            }
        }

    }
}
