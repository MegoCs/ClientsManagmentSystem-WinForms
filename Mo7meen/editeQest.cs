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
    public partial class editeQest : Form
    {
        public int ID;
     
        ConnectionClass conn = new ConnectionClass();
        private object groupId;
        private string OpreationTable = "";

        public editeQest(String qestVAlue2, String qestDate2,string details, String bank7esab2 ,int ID2, int groupId)
        {
            InitializeComponent();
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                comboBox1.Items.Add(item);
            }
            conn.startConnection();
           
            value.Text = qestVAlue2;
            dateTimePicker1.Text = qestDate2;
            comboBox1.Text = bank7esab2;
            detailsTxt.Text = details;
            ID = ID2;
            this.groupId = groupId;
            if (groupId == 0)
                addAttachmentBtn.Enabled = true;
        }

        public editeQest(string qestVAlue2, string qestDate2, string details, string bank7esab2, int ID2, int groupId, string OpreationTable)
        {
            InitializeComponent();
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                comboBox1.Items.Add(item);
            }
            conn.startConnection();

            value.Text = qestVAlue2;
            dateTimePicker1.Text = qestDate2;
            comboBox1.Text = bank7esab2;
            detailsTxt.Text = details;
            ID = ID2;
            this.groupId = groupId;
            if (groupId == 0)
                addAttachmentBtn.Enabled = true;
            this.OpreationTable = OpreationTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int bankId = 0;
                bankId = int.Parse((comboBox1.SelectedItem as ComboBoxItem).value.ToString());
                String sql;

                if (OpreationTable == "first_paids")
                    sql = "UPDATE first_paids set paid_value = " + int.Parse(value.Text.ToString()) + ",details='" + detailsTxt.Text + "',paid_date = '" + dateTimePicker1.Value.ToString() + "', bank_id= " + bankId + ",Group_id=" + groupId + " where ID = " + ID;
                else if (OpreationTable == "Montsben")
                    sql = "UPDATE montsben set paid_value = " + int.Parse(value.Text.ToString()) + ",details='" + detailsTxt.Text + "',paid_date = '" + dateTimePicker1.Value.ToString() + "', bank_id= " + bankId + ",Group_id=" + groupId + " where ID = " + ID;
                else 
                    sql = "UPDATE aqsat set qest_value = " + int.Parse(value.Text.ToString()) + ",details='" + detailsTxt.Text + "',qest_date = '" + dateTimePicker1.Value.ToString() + "', bank_id= " + bankId + ",Group_id=" + groupId + " where ID = " + ID;

                conn.SQLUPDATE(sql, true);
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql;

            if (OpreationTable == "first_paids")
                sql = "delete from first_paids where ID = " + ID;
            else if (OpreationTable == "Montsben")
                sql = "delete from montsben where ID = " + ID;
            else
                sql = "delete from aqsat where ID = " + ID;

            conn.SQLUPDATE(sql, true);
        }

        private void addAttachmentBtn_Click(object sender, EventArgs e)
        {
            PhotosForm phF = new PhotosForm();
            phF.ShowDialog();
            groupId = phF.groupID;
        }
    }
}
