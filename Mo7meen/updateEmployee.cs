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
    public partial class updateEmployee : Form
    {
        public String employeeName;
        ConnectionClass c = new ConnectionClass();
        String priv;
        public bool found(String str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    return true;
            }
            return false;
        }
        public void upPriv()
        {
            if (found(priv, '0'))
            {
                addEmployeeCH.Checked = true;
            }
         
            if (found(priv,'1'))
            {
                addUnitsCH.Checked = true;
            }
            if (found(priv, '2'))
            {
                addNewUnitsCh.Checked = true;
            }
            if (found(priv, '3'))
            {
                addClientCH.Checked = true;
            }
            if (found(priv, '4'))
            {
                reportCH.Checked= true;
            }
            if (found(priv, '5'))
            {
                gardCH.Checked = true;
            }
            if (found(priv, '6'))
            {
                searchChequeCH.Checked =true;
            }
            if (found(priv, '7'))
            {
                searchQestCH.Checked = true;
            }
            if (found(priv, '8'))
            {
                showChequeCH.Checked = true;
            }
            if (found(priv, '9'))
            {
                ta5seesCH.Checked = true;
            }
            if (found(priv, 'a'))
            {
                sadadTa5seesCH.Checked = true;
            }
            if (found(priv, 'b'))
            {
                montasebeenCH.Checked = true;
            }
            if (found(priv, 'c'))
            {
                EditClientsDataCH.Checked = true;
            }
            if (found(priv, 'd'))
            {
                EditChequesCH.Checked = true;
            }

            if (found(priv, 'e'))
            {
                editAqsatCH.Checked = true;
            }
            if (found(priv, 'f'))
            {
                unitMas7oobaCH.Checked = true;
            }
            if (found(priv, 'g'))
            {
                tanazolCH.Checked = true;
            }
            if (found(priv, 'h'))
            {
                moqdematCH.Checked = true;
            }
            if (found(priv, 'i'))
            {
                sa7bCH.Checked = true;
            }
            if (found(priv, 'j'))
            {
                payQestCH.Checked = true;
            }
            if (found(priv, 'k'))
            {
               bankAccountsCH.Checked = true;
            }
            if (found(priv, 'l'))
            {
                addChequeCH.Checked = true;
            }
            if (found(priv, 'm'))
            {
                transeferUnitCH.Checked = true;
            }
            if (found(priv, 'n'))
            {
                settingsCH.Checked = true;
            }
        }
        public updateEmployee(String EmName)
        {
            InitializeComponent();
            c.startConnection();
            employeeName = EmName;
            String sqlaya = "select*from employees where employee_name='" + employeeName + "'";
            c.SQLCODE(sqlaya, false);
            if (c.myReader.Read())
            {
                employeeNameText.Text = employeeName;
                employeeNameText.Enabled = false;
                userNameText.Text = c.myReader["user_name"].ToString();
                passwordText.Text = c.myReader["user_password"].ToString();
                priv = c.myReader["privlages"].ToString();
                upPriv();
            }
            else {
                MessageBox.Show("لا توجد بيانات لهذا العميل");
                this.Close();
            }
        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            String privi="";
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

            String upSq = "update employees set user_Name='" + userNameText.Text.ToString() + "',user_password='" + passwordText.Text.ToString() + "',privlages='" + privi+"'where employee_name='"+employeeNameText.Text.ToString()+"'";
            c.SQLUPDATE(upSq,true);
        }
    }
}
