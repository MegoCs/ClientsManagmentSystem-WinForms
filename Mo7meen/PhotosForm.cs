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
    public partial class PhotosForm : Form
    {
        ConnectionClass conObj;
        public int groupID = -1;
        int phCount=0;
        private string executable ;
        string dst ;

        public PhotosForm()
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            LoadLastTrans();
            executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        }

        private void BrowsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif"
            };
            if (x.ShowDialog() == DialogResult.OK&& groupID!=-1)
            {
                string[] result = x.FileNames;               
                foreach (string y in result)
                {                
                    listBox1.Items.Add(y);
                    dst = (System.IO.Path.GetDirectoryName(executable));
                    dst += @"\Transactions\"+groupID+"-"+phCount+".png";
                    System.IO.File.Copy(y, dst, true);
                    if (!InsertNewTrans())
                    {
                        MessageBox.Show("خطأ اثناء تسجيل الملف برجاء المحاولة مره اخرى");
                        break;
                    }


                }
            }
        }

        private void LoadLastTrans()
        {
            conObj.startConnection();
            conObj.SQLCODE("select max(group_id) as oldGroupId from transactions;", false);
            while (conObj.myReader.Read())
            {
                groupID = int.Parse(conObj.myReader["oldGroupId"].ToString()) + 1;
            }
        }

        private bool InsertNewTrans()
        {
            return conObj.SQLUPDATE("insert into transactions (group_id,photo_id) values (" + groupID + "," + phCount++ + ")",true);
        }
    }
}
