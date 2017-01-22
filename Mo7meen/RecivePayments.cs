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
    public partial class RecivePayments : Form
    {
        private ConnectionClass conn;

        public RecivePayments()
        {
            InitializeComponent();
            conn = new ConnectionClass();
            this.ActiveControl = nationalIdtext;
        }

        public int ID { get; private set; }

        private void searchButton_Click(object sender, EventArgs e)
        {
            conn.startConnection();
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
                else
                {
                    MessageBox.Show("لا يوجد بيانات عميل بهذا الرقم");
                }
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(qestValueText.Text) && ID != 0)
            {
                try
                {
                    int qestValue = int.Parse(qestValueText.Text);
                    String sql = "update clients set receivingPayments =receivingPayments+"+qestValue+" where id = "+ID+"";
                    conn.SQLUPDATE(sql, true);
                    qestValueText.Text = "";
                    ID = 0;
                    agentNameText.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }
    }
}
