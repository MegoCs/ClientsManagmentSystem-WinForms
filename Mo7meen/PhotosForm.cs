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
        int phCount=-1;
        int IdToInsert = 0;
        public PhotosForm()
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            loadLastTrans();
        }

        private void browsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Multiselect = true;
            x.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            if (x.ShowDialog() == DialogResult.OK)
            {
                string[] result = x.FileNames;               
                foreach (string y in result)
                {                
                    listBox1.Items.Add(y);
                    string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string dst = (System.IO.Path.GetDirectoryName(executable));
                    dst += @"\Transactions\"+groupID+"-"+phCount+".png";
                    System.IO.File.Copy(y, dst, true);                  
                    insertNewTrans();
                }
            }
        }

        private void loadLastTrans()
        {
            conObj.startConnection();
            conObj.SQLCODE("select max(group_id) as b,max(photo_id) as c from transactions;", false);
            while (conObj.myReader.Read())
            {
                groupID = int.Parse(conObj.myReader["b"].ToString()) + 1;
                phCount = int.Parse(conObj.myReader["c"].ToString()) + 1;
            }
        }

        private void insertNewTrans()
        {
            conObj.SQLUPDATE("insert into transactions (group_id,photo_id) values (" + groupID + "," + phCount++ + ")",true);
        }
    }
}
