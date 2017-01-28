using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mo7meen
{
    public partial class EditeSheeque : Form
    {
        ConnectionClass conn;
        bool found = false;
        public EditeSheeque()
        {
            InitializeComponent();
            conn = new ConnectionClass();
        }
        int ID;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sheeqNumText.Text))
            {
                try
                {
                    conn.startConnection();
                    double SheeqNum = double.Parse(sheeqNumText.Text);
                    String sql = "SELECT * FROM cheques WHERE cheque_number = " + SheeqNum + "";
                    conn.SQLCODE(sql, false);
                    if (conn.myReader.Read())
                    {
                        found = true;
                        sheequeOwner_text.Text = conn.myReader["cheque_owner"].ToString();
                        valueText.Text = conn.myReader["cheque_value"].ToString();
                        dateTimePickerEsdar.Text = conn.myReader["cheque_Esdar_Date"].ToString();
                        dateTimePicker1Sarf.Text = conn.myReader["cheque_Sarf_Date"].ToString();
                        ID = int.Parse(conn.myReader["ID"].ToString());
                        sheqNumUpdate.Text = sheeqNumText.Text;
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات بهذا الرقم");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف اتمام البيانات");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (found)
            {
                String nubmber = sheqNumUpdate.Text;
                String mostafed = sheequeOwner_text.Text;
                int sheeque_value = int.Parse(valueText.Text);
                String DateEsdar = dateTimePickerEsdar.Value.ToString("yyyy/MM/dd");
                String DateSarf = dateTimePicker1Sarf.Value.ToString("yyyy/MM/dd");
                String sql = "update cheques set cheque_number = " + nubmber + ", cheque_owner = '" + mostafed + "',cheque_value=" + sheeque_value + ",cheque_Esdar_Date='" + DateEsdar + "',cheque_Sarf_Date='" + DateSarf + "' where ID = " + ID + "";
                conn.SQLUPDATE(sql,true);
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (found)
            {
                String sql = "delete from cheques where ID = " + ID + " ";
                conn.SQLUPDATE(sql,true);
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }       
    }
}