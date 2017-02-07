using System;
using System.Windows.Forms;
using System.IO;

namespace Download_Cleaner
{
    public partial class SelectDownloadFolder : Form
    {
        public SelectDownloadFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = null;
            DialogResult result = selectFolder.ShowDialog();
            if (result == DialogResult.OK)
                {
                    path = selectFolder.SelectedPath;
                    label_path.Visible = true;
                    path_invisible.Visible = true;
                    path_invisible.Text = path;
                    buttonOK.Visible = true;
                }
            var dfolder = new DownloadFolder();
            dfolder.Path = path;


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
