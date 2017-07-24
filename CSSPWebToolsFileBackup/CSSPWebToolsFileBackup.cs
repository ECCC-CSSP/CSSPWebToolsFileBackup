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
        public CSSPWebToolsFileBackup()
        {
            InitializeComponent();
        }

        private void butStartBackup_Click(object sender, EventArgs e)
        {
            lblStatusValue.Text = "Starting Backup\r\n";
            lblStatusValue.Refresh();
            Application.DoEvents();

            DirectoryInfo FromDir = new DirectoryInfo(textBoxStartDirectory.Text);

            DoDir(FromDir);
        }
        private void DoDir(DirectoryInfo FromDir)
        {
            lblStatusValue.Text = "Doing: " + FromDir + " directory";
            lblStatusValue.Refresh();
            Application.DoEvents();

            List<FileInfo> fiFromList = FromDir.GetFiles().ToList<FileInfo>();

            foreach (FileInfo fiFrom in fiFromList)
            {
                lblStatusValue.Text = "Doing: " + fiFrom.FullName;
                lblStatusValue.Refresh();
                Application.DoEvents();

                DirectoryInfo ToDir = new DirectoryInfo(fiFrom.DirectoryName.Replace(textBoxStartDirectory.Text, textBoxBackupDirectory.Text) + "\\");
                if (!ToDir.Exists)
                {
                    try
                    {
                        ToDir.Create();
                    }
                    catch (Exception ex)
                    {
                        richTextBoxStatus.AppendText("Error Creating Directory [" + ToDir + "]\r\n");
                        richTextBoxStatus.AppendText("Error Message [" + ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""));
                        return;
                    }
                }

                if ((fiFrom.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    FileInfo fiTo = new FileInfo(fiFrom.DirectoryName.Replace(textBoxStartDirectory.Text, textBoxBackupDirectory.Text) + "\\" + fiFrom.Name);
                    if (!fiTo.Exists)
                    {
                        try
                        {
                            lblStatusValue.Text = "Copying: " + fiFrom.FullName;
                            lblStatusValue.Refresh();
                            Application.DoEvents();

                            File.Copy(fiFrom.FullName, fiTo.FullName, true);
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
                                lblStatusValue.Text = "Copying: " + fiFrom.FullName;
                                lblStatusValue.Refresh();
                                Application.DoEvents();

                                File.Copy(fiFrom.FullName, fiTo.FullName, true);
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

            List<DirectoryInfo> dirFromList = FromDir.GetDirectories().ToList<DirectoryInfo>();

            foreach (DirectoryInfo diFrom in dirFromList)
            {
                Application.DoEvents();
                if ((diFrom.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    DoDir(diFrom);
                }
            }
        }

    }
}
