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
    public partial class SearchForSheeq : Form
    {
        ConnectionClass conn = new ConnectionClass();
        private List<int> photos_group;

        public SearchForSheeq()
        {
            InitializeComponent();
            photos_group = new List<int>();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SheeqNumText.Text))
            {
                try
                {
                    conn.startConnection();
                    int SheeqNum = int.Parse(SheeqNumText.Text);
                    String sql = "SELECT * FROM cheques WHERE cheque_number = " + SheeqNum + "";
                    conn.SQLCODE(sql, false);
                    if (conn.myReader.Read())
                    {
                        elmostafeedText.Text = conn.myReader["cheque_owner"].ToString();
                        cheeqeValue.Text = conn.myReader["cheque_value"].ToString();
                        dateTimePicker1.Text = conn.myReader["cheque_Esdar_Date"].ToString();
                        dateTimePicker2.Text = conn.myReader["cheque_Sarf_Date"].ToString();
                        photos_group.Add(int.Parse(conn.myReader["Group_id"].ToString()));
                    }
                    else {
                        MessageBox.Show("لا يوجد بيانات شيك بهذا الرقم");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void showGroupBtn_Click(object sender, EventArgs e)
        {
            if (photos_group.Count>0) {
                PhotosGroup pgGObj = new PhotosGroup(photos_group);
                pgGObj.ShowDialog();
            }
        }
    }
}
