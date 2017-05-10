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
    public partial class T5cesPayment : Form
    {
        ConnectionClass conObj;
        private int clientId;
        private int IskanIndex;

        public int GroupId { get; private set; }

        public T5cesPayment()
        {
            conObj = new ConnectionClass();
            InitializeComponent();
            loadBankCombo();
            this.ActiveControl = nationalIdtext;
        }

        private void loadBankCombo()
        {
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                if (item.Text == "اسكان")
                    IskanIndex = FunctionsClass.banksData.IndexOf(item);
                banksCombo.Items.Add(item);
            }
            banksCombo.SelectedIndex = IskanIndex;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            conObj.startConnection();
            String qury = "select id,client_name from Clients where national_id='" + nationalIdtext.Text + "' and TnazolState <>'F' and check_out='N' and stopState='N'";
            conObj.SQLCODE(qury, false);
            if (conObj.myReader.Read())
            {
                custNameText.Text = conObj.myReader[1].ToString();
                clientId = int.Parse(conObj.myReader[0].ToString());
            }
            else {
                MessageBox.Show(" برجاء مراجعة الرقم القومى للعميل لا يوجد عميل منتسب بهذا الرقم القومى");
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (custNameText.Text != "" && banksCombo.SelectedItem != null)
            {
                conObj.startConnection();   
                int new_value = Int32.Parse(paidValue.Text);
                String Data = datePicker.Value.ToString("yyyy/MM/dd");
                String sql = "INSERT INTO T5sesMoney (client_id,paid_value,paid_date,bank_id,Group_id,details) VALUES (" + clientId + "," + new_value + ",'" + Data + "'," + int.Parse((banksCombo.SelectedItem as ComboBoxItem).value) + "," + GroupId + ",'"+ detailsTxt.Text+ "') ";
                conObj.SQLUPDATE(sql,true);
            }
            else {
                MessageBox.Show("رجاء اتمام البيانات اولاً");
            }
        }

        private void addTransBtn_Click(object sender, EventArgs e)
        {
            PhotosForm phF = new PhotosForm();
            phF.ShowDialog();
            GroupId = phF.groupID;
        }
    }
}
