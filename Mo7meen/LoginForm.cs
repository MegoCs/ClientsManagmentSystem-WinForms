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
    public partial class LoginForm : Form
    {
        ConnectionClass con;
        public string userName
        {
            get { return userNameText.Text; }
            set { }
        }
        public LoginForm()
        {
            InitializeComponent();
            con = new ConnectionClass();
            this.ActiveControl = userNameText;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            con.startConnection();
            String sql = "select * from employees where user_name='" + userNameText.Text + "' and user_password='" + passwordText.Text + "'";
            con.SQLCODE(sql, false);
            if (con.myReader.Read())
            {
                SessionInfo.empName = con.myReader["employee_name"].ToString();
                SessionInfo.userName = con.myReader["user_name"].ToString();
                SessionInfo.password = con.myReader["user_password"].ToString();
                SessionInfo.privlages = con.myReader["privlages"].ToString();
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("رجاء مراجعه بيانات الدخول");
            }
        }
    }
}
