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
    public partial class AddEmployee : Form
    {
        private String privi = "";
        ConnectionClass con = new ConnectionClass();

        public AddEmployee()
        {

            InitializeComponent();
            con.startConnection();
        }

        private void addAndEntercheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(employeeNameText.Text) && !String.IsNullOrEmpty(userNameText.Text) && !String.IsNullOrEmpty(passwordText.Text))
                {
                    #region PriviSectionAssign
                    if (addEmployeeCH.Checked)
                    {
                        privi += "0";
                    }
                    if (addUnitsCH.Checked)
                    {
                        privi += "1";
                    }
                    if (addNewUnitsCh.Checked)
                    {
                        privi += "2";
                    }
                    if (addClientCH.Checked)
                    {
                        privi += "3";
                    }
                    if (reportCH.Checked)
                    {
                        privi += "4";
                    }
                    if (gardCH.Checked)
                    {
                        privi += "5";
                    }
                    if (searchChequeCH.Checked)
                    {
                        privi += "6";
                    }
                    if (searchQestCH.Checked)
                    {
                        privi += "7";
                    }
                    if (showChequeCH.Checked)
                    {
                        privi += "8";
                    }
                    if (ta5seesCH.Checked)
                    {
                        privi += "9";
                    }
                    if (sadadTa5seesCH.Checked)
                    {
                        privi += "a";
                    }
                    if (montasebeenCH.Checked)
                    {
                        privi += "b";
                    }
                    if (EditClientsDataCH.Checked)
                    {
                        privi += "c";
                    }
                    if (EditChequesCH.Checked)
                    {
                        privi += "d";
                    }

                    if (editAqsatCH.Checked)
                    {
                        privi += "e";
                    }
                    if (unitMas7oobaCH.Checked)
                    {
                        privi += "f";
                    }
                    if (tanazolCH.Checked)
                    {
                        privi += "g";
                    }
                    if (moqdematCH.Checked)
                    {
                        privi += "h";
                    }
                    if (sa7bCH.Checked)
                    {
                        privi += "i";
                    }
                    if (payQestCH.Checked)
                    {
                        privi += "j";
                    }
                    if (bankAccountsCH.Checked)
                    {
                        privi += "k";
                    }
                    if (addChequeCH.Checked)
                    {
                        privi += "l";
                    }
                    if (transeferUnitCH.Checked)
                    {
                        privi += "m";
                    }
                    if (settingsCH.Checked)
                    {
                        privi += "n";
                    }


                    #endregion
                    // MessageBox.Show(privi);
                    String sql = "insert into employees (employee_name,user_name,user_password,privlages)values('" + employeeNameText.Text + "','" + userNameText.Text + "','" + passwordText.Text + "','" + privi + "')";
                    con.SQLUPDATE(sql, true);
                }
                else
                {
                    MessageBox.Show("برجاء اتمام البيانات");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف العملية");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "]");
            }
        }


        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jkshgk d = new jkshgk();
            d.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gardCH_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
