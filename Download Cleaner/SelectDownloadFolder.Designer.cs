namespace Download_Cleaner
{
    partial class SelectDownloadFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_select_folder = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.path_invisible = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label_select_folder
            // 
            this.label_select_folder.AutoSize = true;
            this.label_select_folder.Location = new System.Drawing.Point(26, 27);
            this.label_select_folder.Name = "label_select_folder";
            this.label_select_folder.Size = new System.Drawing.Size(153, 13);
            this.label_select_folder.TabIndex = 0;
            this.label_select_folder.Text = "Выберите папку для очистки";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(250, 27);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Открыть";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(26, 63);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(82, 13);
            this.label_path.TabIndex = 2;
            this.label_path.Text = "Путь до папки:";
            this.label_path.Visible = false;
            // 
            // path_invisible
            // 
            this.path_invisible.AutoSize = true;
            this.path_invisible.Location = new System.Drawing.Point(247, 63);
            this.path_invisible.Name = "path_invisible";
            this.path_invisible.Size = new System.Drawing.Size(0, 13);
            this.path_invisible.TabIndex = 3;
            this.path_invisible.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(250, 90);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SelectDownloadFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 132);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.path_invisible);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label_select_folder);
            this.Name = "SelectDownloadFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initialization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_select_folder;
        private System.Windows.Forms.FolderBrowserDialog selectDownloadFolder;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Label path_invisible;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
    }
}