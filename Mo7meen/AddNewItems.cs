using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo7meen
{
    public partial class AddNewItems : Form
    {
        
        ConnectionClass conn;
        public AddNewItems()
        {
            InitializeComponent();
            conn = new ConnectionClass();
            initTyeps();
        }

        private void initTyeps()
        {
            // load here items from dbTable then through it to combobox
            FunctionsClass x= new FunctionsClass();
            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                comboBox1.Items.Add(item);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && !String.IsNullOrEmpty(avaliableQuntity_txt.Text))
            {
                try
                {
                    conn.startConnection();
                    int unitID = int.Parse((comboBox1.SelectedItem as ComboBoxItem).value.ToString());
                    int quntity = int.Parse(avaliableQuntity_txt.Text);
                    int price = int.Parse(unitPriceTxt.Text);
                    String query = "UPDATE units SET available_units =available_units +" + quntity + " , unit_price="+price+" where ID=" + unitID + " ";
                    conn.SQLUPDATE(query,true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By ["+SessionInfo.empName+"]" );
                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }
    }
}
