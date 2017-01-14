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
    public partial class BankTypes : Form
    {
        ConnectionClass con;
        public BankTypes()
        {
            InitializeComponent();
            con = new ConnectionClass();
            loadData();
        }

        private void loadData()
        {
            FunctionsClass x = new FunctionsClass();
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newBankAccount.Text))
            {
                #region save
                con.startConnection();
                String sql = "insert into bank_accounts (type) values ('" + newBankAccount.Text + "')";
                con.SQLUPDATE(sql,true);
                newBankAccount.Text = "";
                FunctionsClass w = new FunctionsClass();
                #endregion
            }
        }
    }
}