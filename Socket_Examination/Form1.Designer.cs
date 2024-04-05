namespace Socket_Examination
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.DowloadList = new System.Windows.Forms.ListBox();
            this.fileList1 = new System.Windows.Forms.ListBox();
            this.LocAddrBox = new System.Windows.Forms.TextBox();
            this.Dowload = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(435, 198);
            this.FileName.Multiline = true;
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(228, 38);
            this.FileName.TabIndex = 1;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(322, 198);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(81, 38);
            this.Change.TabIndex = 2;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.change_Click);
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(9, 12);
            this.URLBox.Multiline = true;
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(307, 41);
            this.URLBox.TabIndex = 3;
            // 
            // DowloadList
            // 
            this.DowloadList.FormattingEnabled = true;
            this.DowloadList.ItemHeight = 16;
            this.DowloadList.Location = new System.Drawing.Point(12, 268);
            this.DowloadList.Name = "DowloadList";
            this.DowloadList.Size = new System.Drawing.Size(840, 164);
            this.DowloadList.TabIndex = 4;
            // 
            // fileList1
            // 
            this.fileList1.FormattingEnabled = true;
            this.fileList1.ItemHeight = 16;
            this.fileList1.Location = new System.Drawing.Point(322, 12);
            this.fileList1.Name = "fileList1";
            this.fileList1.Size = new System.Drawing.Size(541, 180);
            this.fileList1.TabIndex = 5;
            this.fileList1.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // LocAddrBox
            // 
            this.LocAddrBox.Location = new System.Drawing.Point(9, 151);
            this.LocAddrBox.Multiline = true;
            this.LocAddrBox.Name = "LocAddrBox";
            this.LocAddrBox.Size = new System.Drawing.Size(307, 41);
            this.LocAddrBox.TabIndex = 6;
            this.LocAddrBox.Click += new System.EventHandler(this.LocAddrBox_Click);
            // 
            // Dowload
            // 
            this.Dowload.Location = new System.Drawing.Point(109, 59);
            this.Dowload.Name = "Dowload";
            this.Dowload.Size = new System.Drawing.Size(92, 53);
            this.Dowload.TabIndex = 7;
            this.Dowload.Text = "Dowload";
            this.Dowload.UseVisualStyleBackColor = true;
            this.Dowload.Click += new System.EventHandler(this.Dowload_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(this.Dowload);
            this.Controls.Add(this.LocAddrBox);
            this.Controls.Add(this.fileList1);
            this.Controls.Add(this.DowloadList);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.FileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.ListBox DowloadList;
        private System.Windows.Forms.ListBox fileList1;
        private System.Windows.Forms.TextBox LocAddrBox;
        private System.Windows.Forms.Button Dowload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

