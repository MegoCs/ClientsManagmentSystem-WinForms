using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo7meen
{
    public partial class TkhcesForm : Form
    {
        ConnectionClass conObj;
        DataTable dtValid, dtNotValid;
        
        public TkhcesForm()
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            conObj.startConnection();
        }
        private String tableName;

        private void button1_Click(object sender, EventArgs e)
        {
            if (t5sesTypeCombo.SelectedIndex != -1 && !String.IsNullOrEmpty(t5sesValue.Text))
            {
                try
                {
                    #region Functionality Code
                    int tkhsesValue = int.Parse(t5sesValue.Text);
                    int typeID = int.Parse((t5sesTypeCombo.SelectedItem as ComboBoxItem).value);
                    this.T5SES_TableAdapter.Fill(this.T5sesUsers.T5SES_Table, typeID,tkhsesValue);
                    this.DataTable1TableAdapter.Fill(this.T5sesUsersValid.DataTable1, typeID, tkhsesValue);
                    this.reportViewer1.RefreshReport();
                    this.reportViewer2.RefreshReport();
                    #endregion
                    reportViewer1.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                }
            }
        }

        private void displayHideBtn_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = !reportViewer2.Visible;
            reportViewer1.Visible = !reportViewer1.Visible;
        }

        private void TkhcesForm_Load(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                t5sesTypeCombo.Items.Add(item);
            }
            this.reportViewer2.RefreshReport();
        }
    }
}
