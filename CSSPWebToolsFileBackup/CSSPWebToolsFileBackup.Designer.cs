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
            this.panelTopBottom = new System.Windows.Forms.Panel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStartDirectory = new System.Windows.Forms.Label();
            this.lblBackupDirectory = new System.Windows.Forms.Label();
            this.textBoxStartDirectory = new System.Windows.Forms.TextBox();
            this.textBoxBackupDirectory = new System.Windows.Forms.TextBox();
            this.butStartBackup = new System.Windows.Forms.Button();
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
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelTopTop
            // 
            this.panelTopTop.Controls.Add(this.butStartBackup);
            this.panelTopTop.Controls.Add(this.textBoxBackupDirectory);
            this.panelTopTop.Controls.Add(this.textBoxStartDirectory);
            this.panelTopTop.Controls.Add(this.lblBackupDirectory);
            this.panelTopTop.Controls.Add(this.lblStartDirectory);
            this.panelTopTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopTop.Location = new System.Drawing.Point(0, 0);
            this.panelTopTop.Name = "panelTopTop";
            this.panelTopTop.Size = new System.Drawing.Size(908, 136);
            this.panelTopTop.TabIndex = 0;
            // 
            // panelTopBottom
            // 
            this.panelTopBottom.Controls.Add(this.lblStatusValue);
            this.panelTopBottom.Controls.Add(this.lblStatusText);
            this.panelTopBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTopBottom.Location = new System.Drawing.Point(0, 136);
            this.panelTopBottom.Name = "panelTopBottom";
            this.panelTopBottom.Size = new System.Drawing.Size(908, 28);
            this.panelTopBottom.TabIndex = 1;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(12, 8);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(40, 13);
            this.lblStatusText.TabIndex = 0;
            this.lblStatusText.Text = "Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(58, 8);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(22, 13);
            this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "OK";
            // 
            // lblStartDirectory
            // 
            this.lblStartDirectory.AutoSize = true;
            this.lblStartDirectory.Location = new System.Drawing.Point(190, 13);
            this.lblStartDirectory.Name = "lblStartDirectory";
            this.lblStartDirectory.Size = new System.Drawing.Size(77, 13);
            this.lblStartDirectory.TabIndex = 0;
            this.lblStartDirectory.Text = "Start Directory:";
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
            // textBoxStartDirectory
            // 
            this.textBoxStartDirectory.Location = new System.Drawing.Point(284, 13);
            this.textBoxStartDirectory.Name = "textBoxStartDirectory";
            this.textBoxStartDirectory.Size = new System.Drawing.Size(599, 20);
            this.textBoxStartDirectory.TabIndex = 1;
            this.textBoxStartDirectory.Text = "E:\\inetpub\\wwwroot\\csspwebtools\\";
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
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(908, 405);
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
    }
}

