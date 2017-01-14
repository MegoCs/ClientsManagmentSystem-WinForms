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
    public partial class editeQest : Form
    {
        public int ID;
     
        ConnectionClass conn = new ConnectionClass();
          
        public editeQest(String qestVAlue2, String qestDate2, String bank7esab2 ,int ID2)
        {
            InitializeComponent();
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                comboBox1.Items.Add(item);
            }
            conn.startConnection();
           
            value.Text = qestVAlue2;
            dateTimePicker1.Text = qestDate2;
            comboBox1.Text = bank7esab2;
            ID = ID2;
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            int bankId=0;
            
            bankId= int.Parse((comboBox1.SelectedItem as ComboBoxItem).value.ToString());

            String sql = "UPDATE aqsat set qest_value = " + int.Parse(value.Text.ToString()) + ",qest_date = '" + dateTimePicker1.Value.ToString() + "', bank_id= " + bankId + " where ID = " + ID;
            conn.SQLUPDATE(sql,true);
        }
    }
}
