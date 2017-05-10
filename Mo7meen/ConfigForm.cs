using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mo7meen
{
    public partial class ConfigForm : Form
    {
        BackgroundWorker backUpWorker = new BackgroundWorker(), restorDataWorker = new BackgroundWorker();
        String folderName;
        String ImgFolderPath;
        String DataFolderPath;
        String choosenFolderToSaveinto;
        private bool imgSaved;

        public ConfigForm()
        {
            InitializeComponent();
            backUpWorker.DoWork += BackUpWorker_DoWorkInbackGround;
            backUpWorker.RunWorkerCompleted += BackUpWorker_WorkInbackGroundCompleted;
            backUpWorker.WorkerReportsProgress = true;
            backUpWorker.ProgressChanged += BackUpWorker_ProgressChanged;

            restorDataWorker.DoWork += RestorDataWorker_DoWorkInbackGround;
            restorDataWorker.RunWorkerCompleted += RestorDataWorker_WorkInbackGroundCompleted;
            restorDataWorker.WorkerReportsProgress = true;
            restorDataWorker.ProgressChanged += RestorDataWorker_ProgressChanged;
        }

        private void RestorDataWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            restorBackUpProgressLab.Text = (e.ProgressPercentage.ToString() + "%");
            this.progressBar2.Value = e.ProgressPercentage;
        }

        private void RestorDataWorker_WorkInbackGroundCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("تم استرجاع نسخة الصور");
        }

        private void RestorDataWorker_DoWorkInbackGround(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DirectoryCopy(folderName, ImgFolderPath, restorDataWorker);
        }

        private void BackUpWorker_WorkInbackGroundCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("تم حفظ نسخه الصور");
        }

        private void BackUpWorker_DoWorkInbackGround(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DirectoryCopy(ImgFolderPath, folderName + @"/نسخة من الصور بتاريخ" + DateTime.Now.ToString("dd-MM-yyyy") + "", worker);
        }

        private void BackUpWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgressLab.Text = (e.ProgressPercentage.ToString() + "%");
            this.progressBar1.Value = e.ProgressPercentage;
        }

        public string CurrentRuntimePath { get; private set; }

        private void SaveBackUpData()
        {
            try
            {
                SaveFileDialog SaveFD1 = new SaveFileDialog();
                string FileName = "";
                SaveFD1.InitialDirectory = choosenFolderToSaveinto;
                SaveFD1.FileName = "نسخةملف بيانات بتاريخ" + DateTime.Now.ToString("dd-MM-yyyy") + ".accdb";
                SaveFD1.Title = "Backup";
                SaveFD1.DefaultExt = "accdb";
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;
                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {
                    FileName = SaveFD1.FileName;
                    System.IO.File.Copy(DataFolderPath + @"\M7kamaDB.accdb", FileName, true);
                    MessageBox.Show("تم عمل النسخة !", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشكله فى الاعدادات");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }

        private void RestoreDataBackUp()
        {
            try
            {
                OpenFileDialog SaveFD12 = new OpenFileDialog();
                SaveFD12.InitialDirectory = "C:";
                SaveFD12.FileName = "";
                SaveFD12.Title = "Choose Backup file to Restore ";
                SaveFD12.DefaultExt = "accdb";
                SaveFD12.Filter = "Ms-Access Files (*.accdb)|*.accdb";
                SaveFD12.FilterIndex = 1;
                SaveFD12.RestoreDirectory = true;
                if (SaveFD12.ShowDialog() == DialogResult.OK)
                {
                    string src = SaveFD12.FileName;
                    System.IO.File.Copy(src, DataFolderPath + @"\M7kamaDB.accdb", true);
                    MessageBox.Show("تم استرجاع البيانات بنجاح !", "Backup Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = SaveFD12.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اثناء تحميل البيانات!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }

        private void ClearDbFile()
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد بدا عملية جديدة برجاء الاختفاظ بنسخه البيانات  قبل بدا فتره جديدة", "تأكيد بدا عملية جديدة الان", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ConnectionClass conObj = new ConnectionClass();
                conObj.startConnection();
                try
                {
                    #region Delete all the prev Data
                    String sql = "delete from aqsat";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from cheques";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from Clients";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from ClientsUnits";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from units";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from first_paids";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from montsben";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from T5sesMoney";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from tanazolat";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from transactions where group_id <> 0";
                    conObj.SQLUPDATE(sql, true);
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ اثناء مسح البيانات القديمة !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
        }

        private void ClearImgFolder()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("تاكيد مسح جميع الملفات و الصور برجاء الاحتفاظ بنسخ احتياطية", "تأكيد بدا مسح الملفات القديمة", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DirectoryInfo dir = new DirectoryInfo(ImgFolderPath);
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        file.Delete();
                    }
                    MessageBox.Show("تم مسح بيانات النسخة القديمة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اثناء مسح البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");
            }
        }

        long GetDirectorySize(string p)
        {
            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles(p, "*.*");

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size
            return b;
        }

        private void RestoreImgBackUp()
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderName = folderBrowserDialog1.SelectedPath;
                    restorDataWorker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }

        void DirectoryCopy(string sourceDirName, string destDirName, BackgroundWorker worker)
        {
            try
            {
                // Get the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                int totalFiles = files.Count(), transferdIndex = 0;
                foreach (FileInfo file in files)
                {
                    float progress = ((transferdIndex + 1) * 100) / totalFiles;
                    worker.ReportProgress(Convert.ToInt32(progress));
                    transferdIndex++;
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, true);
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");
                MessageBox.Show("خطأ اثناء النقل");
            }
        }

        private void SaveBackUpImgFolder()
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                choosenFolderToSaveinto = folderName;
                imgSaved = true;
                backUpWorker.RunWorkerAsync();
            }
        }

        private void LoadPathes()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dst = (System.IO.Path.GetDirectoryName(executable));
            ImgFolderPath = dst + @"\Transactions";
            DataFolderPath = dst + @"\Data";
            CurrentRuntimePath = dst;
            if (GetDirectorySize(ImgFolderPath) / 1000000000 > 1)
                sizeLab.Text = "" + (GetDirectorySize(ImgFolderPath) / 1000000000);
            else
                sizeLab.Text = "1";
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { LoadPathes(); });
        }

        private void saveBackUpBtn_Click(object sender, EventArgs e)
        {
            if (backUpImgs.Checked)
            {
                SaveBackUpImgFolder();
            }
            SaveBackUpData();
        }

        private void restorDataBackUpBtn_Click(object sender, EventArgs e)
        {
            RestoreDataBackUp();
        }

        private void restoreImgBackUpBtn_Click(object sender, EventArgs e)
        {
            RestoreImgBackUp();
        }

        private void clearDbFileBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { ClearDbFile(); });
            this.Invoke((MethodInvoker)delegate () { ClearImgFolder(); });
        }

        private void copyLogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFD1 = new SaveFileDialog();
                string FileName = "";
                SaveFD1.InitialDirectory = choosenFolderToSaveinto;
                SaveFD1.FileName = "Logs " + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
                SaveFD1.Title = "Backup";
                SaveFD1.DefaultExt = "txt";
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;
                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {
                    FileName = SaveFD1.FileName;
                    System.IO.File.Copy(CurrentRuntimePath + @"\Logs.txt", FileName, true);
                    MessageBox.Show("تم نقل نسخه ملف الاخطاء", "ملف الاخطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشكله فى الاعدادات");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }
    }
}
