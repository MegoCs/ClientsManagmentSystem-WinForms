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
    public partial class PayQest : Form
    {
        ConnectionClass conn ;
        private int photosGroup_id;
        private int IskanIndex=0;

        public PayQest()
        {
            InitializeComponent();
            conn = new ConnectionClass();
            loadData();
            this.ActiveControl = nationalIdtext;
        }

        public int ID { get; private set; }

        private void loadData()
        {
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                if (item.Text == "اسكان")
                    IskanIndex = FunctionsClass.banksData.IndexOf(item);
                receivingAccountText.Items.Add(item);
            }
            receivingAccountText.SelectedIndex = IskanIndex;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(qestValueText.Text)&&ID!=0)
            {
                try
                {
                    int qestValue = int.Parse(qestValueText.Text);
                    String Date = datePicker.Value.ToString("yyyy/MM/dd");
                    String sql = "INSERT INTO aqsat (client_id,qest_value,qest_date,Group_id,bank_id,details) VALUES (" + ID + "," + qestValue + ",'" + Date + "'," + photosGroup_id + "," + (receivingAccountText.SelectedItem as ComboBoxItem).value + ",'"+ detailsTxt.Text+ "')";
                    conn.SQLUPDATE(sql, true);
                    qestValueText.Text = "";
                    photosGroup_id = 0;
                    detailsTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nationalIdtext.Text))
            {
                conn.startConnection();
                String sql = "select * from Clients where national_id = '" + nationalIdtext.Text + "'";
                conn.SQLCODE(sql, false);
                if (conn.myReader.Read())
                {
                    agentNameText.Text = conn.myReader["client_name"].ToString();
                    ID = int.Parse(conn.myReader["ID"].ToString());
                }
                else {
                    MessageBox.Show("لا يوجد بيانات عميل بهذا الرقم");
                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void addPhotosButton_Click(object sender, EventArgs e)
        {
            PhotosForm phF = new PhotosForm();
            phF.ShowDialog();
            photosGroup_id = phF.groupID;
        }
    }
}
