using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Cleaner
{
    class UserInteraction
    {
        public bool AskUserAnswer()
        {
            DialogResult result = MessageBox.Show("Удалить файлы загрузки?", "DownloadCleaner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
