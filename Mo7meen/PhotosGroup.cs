using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo7meen
{

    public partial class PhotosGroup : Form
    {

        private int [] group_id;
        ConnectionClass conObj;
        List<String> photosNames;
        int nowDisplay=0;
        private string currentDiplayed;

        public string ImgFolderPath { get; private set; }

        public PhotosGroup(List<int> group_id)
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            this.group_id = group_id.ToArray();
            photosNames = new List<string>();
            loadGroup();
            initDisplay();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dst = (System.IO.Path.GetDirectoryName(executable));
            ImgFolderPath = dst + @"\Transactions";
        }

        private void initDisplay()
        {
            saveBtn.Enabled = false;
            if (photosNames.Count > 0)
            {
                pictureBox1.Image = Image.FromFile("Transactions/" + photosNames[0] + ".png");
                currentDiplayed = photosNames[0];
                saveBtn.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void loadGroup()
        {
            conObj.startConnection();
            String inList = string.Join(",", group_id);
            if (!String.IsNullOrEmpty(inList)) {
                String sql = "select * from transactions where group_id in (" + inList + ")";
                conObj.SQLCODE(sql, false);
                while (conObj.myReader.Read())
                {
                    photosNames.Add(conObj.myReader["group_id"] + "-" + conObj.myReader["photo_id"]);
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            SrcToggelImage(1);
        }

        private void SrcToggelImage(int v)
        {
            if (nowDisplay + v < photosNames.Count && nowDisplay + v >= 0)
            {
                pictureBox1.Image = Image.FromFile("Transactions/" + photosNames[nowDisplay + v] + ".png");
                currentDiplayed = photosNames[nowDisplay + v];
                nowDisplay += v;
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            SrcToggelImage(-1);

        }

        private void replace_Click(object sender, EventArgs e)
        {
             
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {       
            try
            {
                SaveFileDialog SaveFD1 = new SaveFileDialog();
                string FileName = "";
                SaveFD1.FileName = "نسخة من بيان القسط.png";
                SaveFD1.Title = "حفظ";
                SaveFD1.DefaultExt = "png";
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;
                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {
                    FileName = SaveFD1.FileName;
                    System.IO.File.Copy(ImgFolderPath + @"\" + currentDiplayed + ".png", FileName, true);
                    MessageBox.Show("تم حفظ الصورة!", "بيان قسط", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
