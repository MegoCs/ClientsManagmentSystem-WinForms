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
        public PhotosGroup(List<int> group_id)
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            this.group_id = group_id.ToArray();
            photosNames = new List<string>();
            loadGroup();
            initDisplay();
        }

        private void initDisplay()
        {
            if (photosNames.Count > 0)
            {
                pictureBox1.Image = Image.FromFile("Transactions/" + photosNames[0] + ".png");
            }
        }

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
                nowDisplay += v;
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            SrcToggelImage(-1);
        }
    }
}
