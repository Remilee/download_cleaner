using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Download_Cleaner
{
    class DownloadFolder
    {

        public string path = @"E:\Downloads";
        public void DeleteFiles()
        {
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);
                foreach (var f in files)
                {
                    File.Delete(f);
                }
            }
            else
            {
                MessageBox.Show("Папки не существует");
                Application.Run(new SelectDownloadFolder());
            }
        }
        
        public List<string> GetExtenstions()
        {
            var files = Directory.GetFiles(path);
            List<string> extenstions = new List<string>();
            foreach (var f in files)
            {
                if (!extenstions.Contains(Path.GetExtension(f)))
                {
                    extenstions.Add(Path.GetExtension(f));
                }
            }
            return extenstions;
        }
        
    }
}
