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
        public ConfigForm()
        {
            InitializeComponent();
        }
        String ImgFolderPath;
        String DataFolderPath;
        String choosenFolderToSaveinto;
        private bool imgSaved;

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
            catch (Exception)
            {
                MessageBox.Show("خطأ اثناء مسح البيانات");
                throw;
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
                    String folderName = folderBrowserDialog1.SelectedPath;
                    DirectoryCopy(folderName, ImgFolderPath);
                    MessageBox.Show("تم استرجاع نسخة الصور");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DirectoryCopy(string sourceDirName, string destDirName)
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
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }
        }

        private void SaveBackUpImgFolder()
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String folderName = folderBrowserDialog1.SelectedPath;
                choosenFolderToSaveinto = folderName;
                imgSaved = true;
                DirectoryCopy(ImgFolderPath, folderName + @"/نسخة من الصور بتاريخ" + DateTime.Now.ToString("dd-MM-yyyy") + "");
                MessageBox.Show("تم حفظ نسخه الصور");
            }
        }

        private void LoadPathes()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dst = (System.IO.Path.GetDirectoryName(executable));
            ImgFolderPath = dst + @"\Transactions";
            DataFolderPath = dst + @"\Data";
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
                this.Invoke((MethodInvoker)delegate () { SaveBackUpImgFolder(); });
            }
            this.Invoke((MethodInvoker)delegate () { SaveBackUpData(); });
        }

        private void restorDataBackUpBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { RestoreDataBackUp(); });
        }

        private void restoreImgBackUpBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { RestoreImgBackUp(); });
        }

        private void clearDbFileBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { ClearDbFile(); });
            this.Invoke((MethodInvoker)delegate () { ClearImgFolder(); });
        }
    }
}
