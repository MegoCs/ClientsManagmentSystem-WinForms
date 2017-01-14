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
    public partial class Mo2damat : Form
    {
        ConnectionClass conn = new ConnectionClass();
        int ID = -1;
        private int IskanIndex;

        public Mo2damat()
        {
            InitializeComponent();
            conn.startConnection();
            loadData();
            this.ActiveControl = nationalIdtext;

        }
        private void loadData()
        {
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                if (item.Text == "اسكان")
                    IskanIndex = FunctionsClass.banksData.IndexOf(item);
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = IskanIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nationalIdtext.Text))
            {
                String sql = "select * from Clients where national_id = '" + nationalIdtext.Text + "'";
                conn.SQLCODE(sql, false);
                if (conn.myReader.Read())
                {
                    groupBox2.Enabled = true;
                    agentNameText.Text = conn.myReader["client_name"].ToString();
                    ID = int.Parse(conn.myReader["ID"].ToString());
                    String sql2 = "select SUM(paid_value) As total from first_paids where client_id =" + ID + "";
                    conn.SQLCODE(sql2, false);
                    if (conn.myReader.Read())
                        moadmValue.Text = conn.myReader["total"].ToString();
                }
                else {
                    MessageBox.Show("لا يوجد عميل بهذا الرقم");
                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newValue.Text) && ID != -1)
            {
                int new_value = Int32.Parse(newValue.Text);
                String Data = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                String sql = "INSERT INTO first_paids (client_id,paid_value,paid_date,bank_id,details) VALUES (" + ID + "," + new_value + ",'" + Data + "'," + int.Parse((comboBox1.SelectedItem as ComboBoxItem).value) + ",'"+ detailsTxt.Text+ "') ";
                conn.SQLUPDATE(sql,true);
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }
    }
}
