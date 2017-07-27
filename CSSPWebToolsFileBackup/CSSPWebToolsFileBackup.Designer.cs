namespace CSSPWebToolsFileBackup
{
    partial class CSSPWebToolsFileBackup
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelTopTop = new System.Windows.Forms.Panel();
            this.textBoxLogFileName = new System.Windows.Forms.TextBox();
            this.lblLogFileName = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.lblTotalFilesCount = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotalDirectoriesCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblModifiedFileCount = new System.Windows.Forms.Label();
            this.lblNewFileCount = new System.Windows.Forms.Label();
            this.lblModifiedFile = new System.Windows.Forms.Label();
            this.lblNewFile = new System.Windows.Forms.Label();
            this.lblModifiedDirCount = new System.Windows.Forms.Label();
            this.lblNewDirCount = new System.Windows.Forms.Label();
            this.lblModifiedDir = new System.Windows.Forms.Label();
            this.lblNewDir = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblDirectories = new System.Windows.Forms.Label();
            this.butStartBackup = new System.Windows.Forms.Button();
            this.textBoxBackupDirectory = new System.Windows.Forms.TextBox();
            this.textBoxStartDirectory = new System.Windows.Forms.TextBox();
            this.lblBackupDirectory = new System.Windows.Forms.Label();
            this.lblStartDirectory = new System.Windows.Forms.Label();
            this.panelTopBottom = new System.Windows.Forms.Panel();
            this.lblDirValue = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTopTop.SuspendLayout();
            this.panelTopBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelTopTop);
            this.splitContainer1.Panel1.Controls.Add(this.panelTopBottom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxStatus);
            this.splitContainer1.Size = new System.Drawing.Size(908, 573);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelTopTop
            // 
            this.panelTopTop.Controls.Add(this.textBoxLogFileName);
            this.panelTopTop.Controls.Add(this.lblLogFileName);
            this.panelTopTop.Controls.Add(this.butStop);
            this.panelTopTop.Controls.Add(this.lblTotalFilesCount);
            this.panelTopTop.Controls.Add(this.lblTotal2);
            this.panelTopTop.Controls.Add(this.lblTotalDirectoriesCount);
            this.panelTopTop.Controls.Add(this.lblTotal);
            this.panelTopTop.Controls.Add(this.lblModifiedFileCount);
            this.panelTopTop.Controls.Add(this.lblNewFileCount);
            this.panelTopTop.Controls.Add(this.lblModifiedFile);
            this.panelTopTop.Controls.Add(this.lblNewFile);
            this.panelTopTop.Controls.Add(this.lblModifiedDirCount);
            this.panelTopTop.Controls.Add(this.lblNewDirCount);
            this.panelTopTop.Controls.Add(this.lblModifiedDir);
            this.panelTopTop.Controls.Add(this.lblNewDir);
            this.panelTopTop.Controls.Add(this.lblFiles);
            this.panelTopTop.Controls.Add(this.lblDirectories);
            this.panelTopTop.Controls.Add(this.butStartBackup);
            this.panelTopTop.Controls.Add(this.textBoxBackupDirectory);
            this.panelTopTop.Controls.Add(this.textBoxStartDirectory);
            this.panelTopTop.Controls.Add(this.lblBackupDirectory);
            this.panelTopTop.Controls.Add(this.lblStartDirectory);
            this.panelTopTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopTop.Location = new System.Drawing.Point(0, 0);
            this.panelTopTop.Name = "panelTopTop";
            this.panelTopTop.Size = new System.Drawing.Size(908, 160);
            this.panelTopTop.TabIndex = 0;
            // 
            // textBoxLogFileName
            // 
            this.textBoxLogFileName.Location = new System.Drawing.Point(284, 74);
            this.textBoxLogFileName.Name = "textBoxLogFileName";
            this.textBoxLogFileName.Size = new System.Drawing.Size(599, 20);
            this.textBoxLogFileName.TabIndex = 20;
            this.textBoxLogFileName.Text = "C:\\FileBackup\\Log.csv";
            // 
            // lblLogFileName
            // 
            this.lblLogFileName.AutoSize = true;
            this.lblLogFileName.Location = new System.Drawing.Point(235, 74);
            this.lblLogFileName.Name = "lblLogFileName";
            this.lblLogFileName.Size = new System.Drawing.Size(47, 13);
            this.lblLogFileName.TabIndex = 19;
            this.lblLogFileName.Text = "Log File:";
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(32, 60);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(120, 23);
            this.butStop.TabIndex = 18;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // lblTotalFilesCount
            // 
            this.lblTotalFilesCount.AutoSize = true;
            this.lblTotalFilesCount.Location = new System.Drawing.Point(444, 138);
            this.lblTotalFilesCount.Name = "lblTotalFilesCount";
            this.lblTotalFilesCount.Size = new System.Drawing.Size(41, 13);
            this.lblTotalFilesCount.TabIndex = 17;
            this.lblTotalFilesCount.Text = "[empty]";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(388, 138);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(34, 13);
            this.lblTotal2.TabIndex = 16;
            this.lblTotal2.Text = "Total:";
            // 
            // lblTotalDirectoriesCount
            // 
            this.lblTotalDirectoriesCount.AutoSize = true;
            this.lblTotalDirectoriesCount.Location = new System.Drawing.Point(444, 115);
            this.lblTotalDirectoriesCount.Name = "lblTotalDirectoriesCount";
            this.lblTotalDirectoriesCount.Size = new System.Drawing.Size(41, 13);
            this.lblTotalDirectoriesCount.TabIndex = 15;
            this.lblTotalDirectoriesCount.Text = "[empty]";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(388, 115);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // lblModifiedFileCount
            // 
            this.lblModifiedFileCount.AutoSize = true;
            this.lblModifiedFileCount.Location = new System.Drawing.Point(287, 138);
            this.lblModifiedFileCount.Name = "lblModifiedFileCount";
            this.lblModifiedFileCount.Size = new System.Drawing.Size(41, 13);
            this.lblModifiedFileCount.TabIndex = 13;
            this.lblModifiedFileCount.Text = "[empty]";
            // 
            // lblNewFileCount
            // 
            this.lblNewFileCount.AutoSize = true;
            this.lblNewFileCount.Location = new System.Drawing.Point(130, 138);
            this.lblNewFileCount.Name = "lblNewFileCount";
            this.lblNewFileCount.Size = new System.Drawing.Size(41, 13);
            this.lblNewFileCount.TabIndex = 12;
            this.lblNewFileCount.Text = "[empty]";
            // 
            // lblModifiedFile
            // 
            this.lblModifiedFile.AutoSize = true;
            this.lblModifiedFile.Location = new System.Drawing.Point(231, 138);
            this.lblModifiedFile.Name = "lblModifiedFile";
            this.lblModifiedFile.Size = new System.Drawing.Size(50, 13);
            this.lblModifiedFile.TabIndex = 11;
            this.lblModifiedFile.Text = "Modified:";
            // 
            // lblNewFile
            // 
            this.lblNewFile.AutoSize = true;
            this.lblNewFile.Location = new System.Drawing.Point(92, 138);
            this.lblNewFile.Name = "lblNewFile";
            this.lblNewFile.Size = new System.Drawing.Size(32, 13);
            this.lblNewFile.TabIndex = 10;
            this.lblNewFile.Text = "New:";
            // 
            // lblModifiedDirCount
            // 
            this.lblModifiedDirCount.AutoSize = true;
            this.lblModifiedDirCount.Location = new System.Drawing.Point(287, 115);
            this.lblModifiedDirCount.Name = "lblModifiedDirCount";
            this.lblModifiedDirCount.Size = new System.Drawing.Size(41, 13);
            this.lblModifiedDirCount.TabIndex = 9;
            this.lblModifiedDirCount.Text = "[empty]";
            // 
            // lblNewDirCount
            // 
            this.lblNewDirCount.AutoSize = true;
            this.lblNewDirCount.Location = new System.Drawing.Point(130, 115);
            this.lblNewDirCount.Name = "lblNewDirCount";
            this.lblNewDirCount.Size = new System.Drawing.Size(41, 13);
            this.lblNewDirCount.TabIndex = 8;
            this.lblNewDirCount.Text = "[empty]";
            // 
            // lblModifiedDir
            // 
            this.lblModifiedDir.AutoSize = true;
            this.lblModifiedDir.Location = new System.Drawing.Point(231, 115);
            this.lblModifiedDir.Name = "lblModifiedDir";
            this.lblModifiedDir.Size = new System.Drawing.Size(50, 13);
            this.lblModifiedDir.TabIndex = 7;
            this.lblModifiedDir.Text = "Modified:";
            // 
            // lblNewDir
            // 
            this.lblNewDir.AutoSize = true;
            this.lblNewDir.Location = new System.Drawing.Point(92, 115);
            this.lblNewDir.Name = "lblNewDir";
            this.lblNewDir.Size = new System.Drawing.Size(32, 13);
            this.lblNewDir.TabIndex = 6;
            this.lblNewDir.Text = "New:";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(17, 138);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 5;
            this.lblFiles.Text = "Files:";
            // 
            // lblDirectories
            // 
            this.lblDirectories.AutoSize = true;
            this.lblDirectories.Location = new System.Drawing.Point(16, 115);
            this.lblDirectories.Name = "lblDirectories";
            this.lblDirectories.Size = new System.Drawing.Size(60, 13);
            this.lblDirectories.TabIndex = 4;
            this.lblDirectories.Text = "Directories:";
            // 
            // butStartBackup
            // 
            this.butStartBackup.Location = new System.Drawing.Point(32, 13);
            this.butStartBackup.Name = "butStartBackup";
            this.butStartBackup.Size = new System.Drawing.Size(120, 23);
            this.butStartBackup.TabIndex = 3;
            this.butStartBackup.Text = "Start Backup";
            this.butStartBackup.UseVisualStyleBackColor = true;
            this.butStartBackup.Click += new System.EventHandler(this.butStartBackup_Click);
            // 
            // textBoxBackupDirectory
            // 
            this.textBoxBackupDirectory.Location = new System.Drawing.Point(284, 39);
            this.textBoxBackupDirectory.Name = "textBoxBackupDirectory";
            this.textBoxBackupDirectory.Size = new System.Drawing.Size(599, 20);
            this.textBoxBackupDirectory.TabIndex = 2;
            this.textBoxBackupDirectory.Text = "\\\\int.ec.gc.ca\\SHARES\\M\\MQEM_NATIONAL\\Charles_E_Drive_Backup\\inetpub\\wwwroot\\cssp" +
    "webtools\\";
            // 
            // textBoxStartDirectory
            // 
            this.textBoxStartDirectory.Location = new System.Drawing.Point(284, 13);
            this.textBoxStartDirectory.Name = "textBoxStartDirectory";
            this.textBoxStartDirectory.Size = new System.Drawing.Size(599, 20);
            this.textBoxStartDirectory.TabIndex = 1;
            this.textBoxStartDirectory.Text = "E:\\inetpub\\wwwroot\\csspwebtools\\";
            // 
            // lblBackupDirectory
            // 
            this.lblBackupDirectory.AutoSize = true;
            this.lblBackupDirectory.Location = new System.Drawing.Point(190, 44);
            this.lblBackupDirectory.Name = "lblBackupDirectory";
            this.lblBackupDirectory.Size = new System.Drawing.Size(92, 13);
            this.lblBackupDirectory.TabIndex = 0;
            this.lblBackupDirectory.Text = "Backup Directory:";
            // 
            // lblStartDirectory
            // 
            this.lblStartDirectory.AutoSize = true;
            this.lblStartDirectory.Location = new System.Drawing.Point(205, 13);
            this.lblStartDirectory.Name = "lblStartDirectory";
            this.lblStartDirectory.Size = new System.Drawing.Size(77, 13);
            this.lblStartDirectory.TabIndex = 0;
            this.lblStartDirectory.Text = "Start Directory:";
            // 
            // panelTopBottom
            // 
            this.panelTopBottom.Controls.Add(this.lblDirValue);
            this.panelTopBottom.Controls.Add(this.lblDir);
            this.panelTopBottom.Controls.Add(this.lblStatusValue);
            this.panelTopBottom.Controls.Add(this.lblStatusText);
            this.panelTopBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTopBottom.Location = new System.Drawing.Point(0, 160);
            this.panelTopBottom.Name = "panelTopBottom";
            this.panelTopBottom.Size = new System.Drawing.Size(908, 47);
            this.panelTopBottom.TabIndex = 1;
            // 
            // lblDirValue
            // 
            this.lblDirValue.AutoSize = true;
            this.lblDirValue.Location = new System.Drawing.Point(58, 7);
            this.lblDirValue.Name = "lblDirValue";
            this.lblDirValue.Size = new System.Drawing.Size(22, 13);
            this.lblDirValue.TabIndex = 3;
            this.lblDirValue.Text = "OK";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(29, 7);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(23, 13);
            this.lblDir.TabIndex = 2;
            this.lblDir.Text = "Dir:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(58, 26);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(22, 13);
            this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "OK";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(12, 26);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(40, 13);
            this.lblStatusText.TabIndex = 0;
            this.lblStatusText.Text = "Status:";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(908, 362);
            this.richTextBoxStatus.TabIndex = 0;
            this.richTextBoxStatus.Text = "";
            // 
            // CSSPWebToolsFileBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CSSPWebToolsFileBackup";
            this.Text = "CSSP Web Tools File Backup";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTopTop.ResumeLayout(false);
            this.panelTopTop.PerformLayout();
            this.panelTopBottom.ResumeLayout(false);
            this.panelTopBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelTopTop;
        private System.Windows.Forms.Button butStartBackup;
        private System.Windows.Forms.TextBox textBoxBackupDirectory;
        private System.Windows.Forms.TextBox textBoxStartDirectory;
        private System.Windows.Forms.Label lblBackupDirectory;
        private System.Windows.Forms.Label lblStartDirectory;
        private System.Windows.Forms.Panel panelTopBottom;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Label lblModifiedFileCount;
        private System.Windows.Forms.Label lblNewFileCount;
        private System.Windows.Forms.Label lblModifiedFile;
        private System.Windows.Forms.Label lblNewFile;
        private System.Windows.Forms.Label lblModifiedDirCount;
        private System.Windows.Forms.Label lblNewDirCount;
        private System.Windows.Forms.Label lblModifiedDir;
        private System.Windows.Forms.Label lblNewDir;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblDirectories;
        private System.Windows.Forms.Label lblDirValue;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblTotalFilesCount;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblTotalDirectoriesCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.TextBox textBoxLogFileName;
        private System.Windows.Forms.Label lblLogFileName;
    }
}

