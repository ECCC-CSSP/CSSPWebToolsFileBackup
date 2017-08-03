using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSPWebToolsFileBackup
{
    public partial class CSSPWebToolsFileBackup : Form
    {
        #region Variables
        private int NewDirCount = 0;
        private int ModifiedDirCount = 0;
        private int NewFileCount = 0;
        private int ModifiedFileCount = 0;
        private int TotalFilesCount = 0;
        private int TotalDirectoriesCount = 0;
        private int TotalSeconds = 0;
        private bool PleaseStop = false;
        private DateTime StartTime = DateTime.Now;
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public CSSPWebToolsFileBackup()
        {
            InitializeComponent();
            StartUp();
        }
        #endregion Constructors

        #region Events
        private void butStartBackup_Click(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            StartBackup();
        }
        private void butStop_Click(object sender, EventArgs e)
        {
            butStop.Text = "Stopping...";
            butStop.Refresh();
            Application.DoEvents();
            PleaseStop = true;
        }
        #endregion Events

        #region Functions private
        private void DoDir(DirectoryInfo FromDir)
        {
            TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - StartTime.Ticks);
            lblTimeSecondValue.Text = timeSpan.TotalSeconds.ToString("F0");
            TotalSeconds = (int)timeSpan.TotalSeconds;

            TotalDirectoriesCount += 1;
            lblTotalDirectoriesCount.Text = TotalDirectoriesCount.ToString();
            lblTotalDirectoriesCount.Refresh();
            lblDirValue.Text = FromDir.FullName;
            lblDirValue.Refresh();
            Application.DoEvents();

            List<FileInfo> fiFromList = FromDir.GetFiles().ToList<FileInfo>();
            DirectoryInfo ToDir = new DirectoryInfo(FromDir.FullName.Replace(textBoxStartDirectory.Text, textBoxBackupDirectory.Text) + "\\");

            if (!ToDir.Exists)
            {
                try
                {
                    ToDir.Create();
                    NewDirCount += 1;
                    lblNewDirCount.Text = NewDirCount.ToString();
                    lblNewDirCount.Refresh();
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    richTextBoxStatus.AppendText("Error Creating Directory [" + ToDir + "]\r\n");
                    richTextBoxStatus.AppendText("Error Message [" + ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""));
                    return;
                }
            }

            List<FileInfo> fiToList = ToDir.GetFiles().ToList<FileInfo>();

            int TempFileCount = 0;
            foreach (FileInfo fiFrom in fiFromList)
            {
                if (PleaseStop)
                {
                    break;
                }

                TempFileCount += 1;
                TotalFilesCount += 1;
                lblTotalFilesCount.Text = TotalFilesCount.ToString();
                lblTotalFilesCount.Refresh();

                lblStatusValue.Text = "";
                lblStatusValue.Refresh();
                Application.DoEvents();

                if ((fiFrom.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    FileInfo fiTo = (from c in fiToList
                                     where c.Name == fiFrom.Name
                                     select c).FirstOrDefault();

                    if (fiTo == null || !fiTo.Exists)
                    {
                        fiTo = new FileInfo(fiFrom.DirectoryName.Replace(textBoxStartDirectory.Text, textBoxBackupDirectory.Text) + "\\" + fiFrom.Name);

                        try
                        {
                            lblStatusValue.Text = "Copying: " + fiFrom.Name;
                            lblStatusValue.Refresh();
                            Application.DoEvents();

                            File.Copy(fiFrom.FullName, fiTo.FullName, true);
                            NewFileCount += 1;
                            lblNewFileCount.Text = NewFileCount.ToString();
                            lblNewFileCount.Refresh();
                            Application.DoEvents();
                        }
                        catch (Exception ex)
                        {
                            richTextBoxStatus.AppendText("Error copying File [" + fiTo + "]\r\n");
                            richTextBoxStatus.AppendText("Error Message [" + ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""));
                            return;
                        }
                    }
                    else
                    {
                        if (fiFrom.LastWriteTimeUtc != fiTo.LastWriteTimeUtc)
                        {
                            try
                            {
                                lblStatusValue.Text = "Copying: " + fiFrom.Name;
                                lblStatusValue.Refresh();
                                Application.DoEvents();

                                File.Copy(fiFrom.FullName, fiTo.FullName, true);
                                ModifiedFileCount += 1;
                                lblModifiedFileCount.Text = ModifiedFileCount.ToString();
                                lblModifiedFileCount.Refresh();
                                Application.DoEvents();
                            }
                            catch (Exception ex)
                            {
                                richTextBoxStatus.AppendText("Error copying File [" + fiTo + "]\r\n");
                                richTextBoxStatus.AppendText("Error Message [" + ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""));
                                return;
                            }
                        }
                    }
                }
            }

            if (TempFileCount != fiFromList.Count())
            {
                ModifiedDirCount += 1;
                lblModifiedDirCount.Text = ModifiedDirCount.ToString();
                lblModifiedDirCount.Refresh();
                Application.DoEvents();
            }

            List<DirectoryInfo> dirFromList = FromDir.GetDirectories().ToList<DirectoryInfo>();

            foreach (DirectoryInfo diFrom in dirFromList)
            {
                if (PleaseStop)
                {
                    break;
                }

                Application.DoEvents();
                if ((diFrom.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    DoDir(diFrom);
                }
            }
        }
        private void StartBackup()
        {
            butStartBackup.Enabled = false;
            butStop.Text = "Stop";
            butStop.Enabled = true;
            PleaseStop = false;
            NewFileCount = 0;
            lblNewFileCount.Text = NewFileCount.ToString();
            NewDirCount = 0;
            lblNewDirCount.Text = NewDirCount.ToString();
            ModifiedFileCount = 0;
            lblModifiedFileCount.Text = ModifiedFileCount.ToString();
            ModifiedDirCount = 0;
            lblModifiedDirCount.Text = ModifiedDirCount.ToString();
            TotalFilesCount = 0;
            lblTotalFilesCount.Text = TotalFilesCount.ToString();
            TotalDirectoriesCount = 0;
            lblTotalDirectoriesCount.Text = TotalDirectoriesCount.ToString();

            DirectoryInfo diFrom = new DirectoryInfo(textBoxStartDirectory.Text);
            if (!diFrom.Exists)
            {
                richTextBoxStatus.AppendText("Start directory [" + textBoxStartDirectory.Text + "] does not exist.");
                return;
            }

            DirectoryInfo diTo = new DirectoryInfo(textBoxBackupDirectory.Text);
            if (!diTo.Exists)
            {
                richTextBoxStatus.AppendText("Backup directory [" + textBoxBackupDirectory.Text + "] does not exist.");
                return;
            }

            lblStatusValue.Text = "Starting Backup\r\n";
            lblStatusValue.Refresh();
            Application.DoEvents();

            DirectoryInfo FromDir = new DirectoryInfo(textBoxStartDirectory.Text);

            DoDir(FromDir);

            FileInfo fi = new FileInfo(textBoxLogFileName.Text);

            DirectoryInfo di = new DirectoryInfo(fi.DirectoryName + @"\");
            if (!di.Exists)
            {
                try
                {
                    di.Create();
                }
                catch (Exception ex)
                {
                    richTextBoxStatus.AppendText(ex.Message + "\r\n");
                }
            }
            TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - StartTime.Ticks);
            lblTimeSecondValue.Text = timeSpan.TotalSeconds.ToString("F0");
            TotalSeconds = (int)timeSpan.TotalSeconds;

            lblStatusValue.Text = "Saving " + fi.FullName;
            if (!fi.Exists)
            {
                try
                {
                    StreamWriter sw = fi.AppendText();
                    sw.WriteLine("Date,# NF,# ND,# MF,# MD,# TNF,# TND, # Sec");
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") + "," + NewFileCount + "," + NewDirCount + "," + ModifiedFileCount + "," + ModifiedDirCount + "," + TotalFilesCount + "," + TotalDirectoriesCount, "," + TotalSeconds);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    richTextBoxStatus.AppendText(ex.Message + "\r\n");
                }
            }
            else
            {
                try
                {
                    StreamWriter sw = fi.AppendText();
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") + "," + NewFileCount + "," + NewDirCount + "," + ModifiedFileCount + "," + ModifiedDirCount + "," + TotalFilesCount + "," + TotalDirectoriesCount + "," + TotalSeconds);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    richTextBoxStatus.AppendText(ex.Message + "\r\n");

                    fi = new FileInfo(textBoxLogFileName.Text);
                    int newFileCount = 0;
                    while (fi.Exists)
                    {
                        newFileCount += 1;
                        fi = new FileInfo(textBoxLogFileName.Text.Replace(".csv", newFileCount.ToString() + ".csv"));
                    }

                    StreamWriter sw = fi.AppendText();
                    sw.WriteLine("Date,# NF,# ND,# MF,# MD,# TNF,# TND,# Sec");
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") + "," + NewFileCount + "," + NewDirCount + "," + ModifiedFileCount + "," + ModifiedDirCount + "," + TotalFilesCount + "," + TotalDirectoriesCount + "," + TotalSeconds);
                    sw.Close();
                }
            }

            lblStatusValue.Text = "Done... and Saved " + fi.FullName;

            butStop.Text = "Stop";
            butStop.Enabled = false;
            butStartBackup.Enabled = true;
        }
        private void StartUp()
        {
            butStartBackup.Enabled = true;
            butStop.Text = "Stop";
            butStop.Enabled = false;

            lblDirValue.Text = "";
            lblStatusValue.Text = "";
            lblNewDirCount.Text = 0.ToString();
            lblNewFileCount.Text = 0.ToString();
            lblModifiedDirCount.Text = 0.ToString();
            lblModifiedFileCount.Text = 0.ToString();
            lblTotalDirectoriesCount.Text = 0.ToString();
            lblTotalFilesCount.Text = 0.ToString();
            lblTimeSecondValue.Text = 0.ToString();
        }
        #endregion Functions private 

    }
}

