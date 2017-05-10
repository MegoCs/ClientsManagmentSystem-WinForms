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
    public partial class EditeClient : Form
    {
        bool found = false;
        ConnectionClass conn;
        string stopState="N";
        String sql;
        List<int> photos_group;
        public EditeClient()
        {
            InitializeComponent();
            conn = new ConnectionClass();
            LoadCustNames();
            photos_group = new List<int>();
        }
        private void LoadCustNames() {
            try
            {
                conn.startConnection();
                String tmpSql = "SELECT client_name FROM Clients ORDER BY client_name";
                conn.SQLCODE(tmpSql, false);
                while (conn.myReader.Read())
                {
                    cust_nameComb.Items.Add(conn.myReader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اثناء تحميل البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(national_id.Text)||!String.IsNullOrEmpty(cust_nameComb.Text))
            {
                
                conn.startConnection();
                SetSqlStatment();              
                conn.SQLCODE(sql, false);
                if (conn.myReader.Read())
                {
                    photos_group = new List<int>();
                    found = true;
                    client_name.Text = conn.myReader["client_name"].ToString();
                    phoneNumber.Text = conn.myReader["phone_number"].ToString();
                    Client_address.Text = conn.myReader["address"].ToString();
                    membershipNum.Text = conn.myReader["membership_id"].ToString();
                    details_text.Text = conn.myReader["description"].ToString();
                    national_id_new.Text = conn.myReader["national_id"].ToString();
                    stopState = conn.myReader["stopState"].ToString();
                    if (stopState != "N")
                    {
                        stopDateTxt.Text = conn.myReader["stopDate"].ToString();
                        stopReasonTxt.Text = conn.myReader["stopReason"].ToString();
                        stopRadioBtn.Checked = true;
                    }
                    else {
                        stopDateTxt.Text = "";
                        stopReasonTxt.Text = "";
                        stopRadioBtn.Checked = false;

                    }
                    ID = int.Parse(conn.myReader["ID"].ToString());

                    photos_group.Add(int.Parse(conn.myReader["ID"].ToString()));
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات بهذا الرقم");
                }
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void SetSqlStatment()
        {
            if(national_id.Enabled)
            sql = "select * from Clients where national_id = '" + national_id.Text + "'";
            else
            sql = "select * from Clients where client_name = '" + cust_nameComb.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (found)
            {
                try
                {
                    if (checkBox1.Checked)
                    {
                        int unit = int.Parse(unitNumber.Text);
                        int borg = int.Parse(borgNumber.Text);
                        sql = "update Clients set unit_number = " + unit + ", tour_number = " + borg + " , delivered ='Y' where id=" + ID + " ";
                        conn.SQLUPDATE(sql, false);
                    }
                    String national = national_id_new.Text;
                    String address = Client_address.Text;
                    int client_phone = int.Parse(phoneNumber.Text);
                    String name = client_name.Text;
                    String membership = membershipNum.Text;
                    String details = details_text.Text;
                    sql = "update Clients set stopState = '" + stopState + "', stopDate = '" + stopDateTxt.Text + "' , stopReason ='" + stopReasonTxt.Text + "',client_name = '" + name + "', description='" + details + "', membership_id = '" + membership + "', phone_number= " + client_phone + ",address='" + address + "',national_id='" + national + "'  where id=" + ID + "";
                    conn.SQLUPDATE(sql, true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }
        public int ID { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {

            if (found)
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد التاكيد على مسح نهائى لجميع بيانات هذا العضو", "تأكيد مسح البيانات", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    String sql = "update units set available_units=available_units+1 where ID = (select unit_id from ClientsUnits where client_id="+ID+ " and RecoredState='N') ";
                    conn.SQLUPDATE(sql, true);


                     sql = "delete from Clients where ID = " + ID + " ";
                    conn.SQLUPDATE(sql, true);
                    ClearFormValues();
                }
            }
            else
            {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void ClearFormValues()
        {
            stopReasonTxt.Text = "";
            stopDateTxt.Text = "";
            stopRadioBtn.Checked = false;
            national_id_new.Text = "";
            Client_address.Text = "";
            client_name.Text = "";
            phoneNumber.Text = "";
            membershipNum.Text = "";
            details_text.Text = "";
            unitNumber.Text = "";
            borgNumber.Text = "";
            checkBox1.Checked = false;
        }

        private void changeSearch_CheckedChanged(object sender, EventArgs e)
        {
            cust_nameComb.Enabled = !cust_nameComb.Enabled;
            national_id.Text = "";
            cust_nameComb.SelectedIndex = -1;
            national_id.Enabled = !national_id.Enabled;
            ClearFormValues();
        }

        private void displayPhotos_Click(object sender, EventArgs e)
        {
            if (photos_group.Count > 0)
            {
                PhotosGroup pgGObj = new PhotosGroup(photos_group);
                pgGObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد ملفات المختارة");
            }
        }

        private void stopCancelBtn_Click(object sender, EventArgs e)
        {
            stopRadioBtn.Checked = false;
            stopReasonTxt.Text = "";
            stopDateTxt.Text = "";
            stopState = "N";
        }

        private void stopRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (stopRadioBtn.Checked)
                stopState = "Y";
            else
                stopState = "N";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            borgNumber.Enabled = checkBox1.Checked;
            unitNumber.Enabled = checkBox1.Checked;
        }

        private void warningLetterBtn_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !string.IsNullOrEmpty(client_name.Text))
            {
                WarningLetterDetails obj = new WarningLetterDetails(ID, client_name.Text);
                obj.ShowDialog();
            }
            else {
                MessageBox.Show("برجاء اختيار عميل");
            }
        }
    }
}
