﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Download_Cleaner
{
    class DownloadFolder
    {
        public string Path = "test";
        public void DeleteFiles()
        {
            if (Directory.Exists(Path))
            {
                var files = Directory.GetFiles(Path);
                foreach (var f in files)
                {
                    File.Delete(f);
                }
            }
            else
            {
                //Папка не существует
            }
        }
    }
}
