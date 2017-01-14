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
    public partial class TnazolSuppData : Form
    {
        ErrorProvider[] err = new ErrorProvider[6];
        bool[] arr = new bool[6];
        ConnectionClass c1 = new ConnectionClass();
     //   private string _nationalId;
        bool tmam=false;
        public string nationalIdFunc
        {
            get { return nationalId.Text; }
            set {  }
        }

        public bool tm
        {
            get {
                return tmam;
            }
            set { }
        }


        private bool checkfull(bool[] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] == false)
                {
                    return false;
                }
            }
            return true;
        }

        public TnazolSuppData()
        {
            c1.startConnection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //validate
            #region ay 5ara w 5las

            if (string.IsNullOrWhiteSpace(clientName.Text))
            {

                err[0] = new ErrorProvider();
                err[0].SetError(clientName, "يجب إدخال إسم العميل ");
                arr[0] = false;

            }
            else
            {
                arr[0] = true;
                if (err[0] != null)
                    err[0].Clear();
            }


            if (string.IsNullOrWhiteSpace(nationalId.Text))
            {
                err[1] = new ErrorProvider();
                err[1].SetError(nationalId, "يجب إدخال رقم البطاقة ");
                arr[1] = false;
                //     z=false;
            }
            else
            {
                // z=true;
                if (err[1] != null)
                    err[1].Clear();
                arr[1] = true;
            }


            if (string.IsNullOrWhiteSpace(membershipId.Text) && !entsabCheck.Checked)
            {
                err[2] = new ErrorProvider();
                err[2].SetError(membershipId, "يجب إدخال رقم العضوية ");
                // z=false;
                arr[2] = false;
            }
            else
            {
                //z=true;
                if (err[2] != null)
                    err[2].Clear();
                arr[2] = true;
            }


            if (string.IsNullOrWhiteSpace(phoneNumber.Text))
            {
                err[3] = new ErrorProvider();
                err[3].SetError(phoneNumber, "يجب إدخال رقم ادخال رقم التليفون ");
                //z=false;
                arr[3] = false;
            }
            else
            {
                //z=true;
                if (err[3] != null)
                    err[3].Clear();
                arr[3] = true;
            }


            if (string.IsNullOrWhiteSpace(address.Text))
            {
                err[4] = new ErrorProvider();
                err[4].SetError(address, "يجب إدخال  العنوان");
                //z=false;
                arr[4] = false;
            }
            else
            {
                //z=true;

                if (err[4] != null)
                    err[4].Clear();

                //   unitTypeErr = null;

                arr[4] = true;
            }
            #endregion

            if (checkfull(arr))
            {
                if(entsabCheck.Checked)
                {
                    String sqlInsert = "insert into Clients(membership_id,client_name,phone_number,address,national_id,deleted,montaseb,delivered,check_out,description)"
                    + "values(0,'" + clientName.Text + "','" + phoneNumber.Text + "','" + address.Text + "','" + nationalId.Text + "','N','Y','N'," + "'N','" + description.Text + "')";
                    c1.SQLUPDATE(sqlInsert,true);
                }
                else
                {
                    try
                    {
                        String sqlInsert = "insert into Clients(membership_id,client_name,phone_number,address,national_id,deleted,montaseb,delivered,check_out,description)"
                                    + "values(" + int.Parse(membershipId.Text) + ",'" + clientName.Text + "','" + phoneNumber.Text + "','" + address.Text + "','" + nationalId.Text + "','N','N','N'," + "'N','" + description.Text + "')";
                        c1.SQLUPDATE(sqlInsert, true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("خطأ ف العملية");
                    }
                }
                tmam = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("يوجد حقول فارغة ");
            }
        }

        private void entsabCheck_CheckedChanged(object sender, EventArgs e)
        {
            membershipId.Enabled = !entsabCheck.Checked;
        }
    }
}
