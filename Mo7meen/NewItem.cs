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
    public partial class NewItem : Form
    {
        ConnectionClass conn ;
        public NewItem()
        {
            InitializeComponent();
            conn = new ConnectionClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(area_text.Text) && !String.IsNullOrEmpty(price_txt.Text) && !String.IsNullOrEmpty(Qest_type_text.Text))
            {
                try
                {
                    conn.startConnection();
                    String area = area_text.Text;
                    int price = int.Parse(price_txt.Text);
                    int type = int.Parse(Qest_type_text.Text);
                    String sql = "INSERT INTO units (unit_type,qest_system,unit_price,available_units) VALUES (" + area + "," + type + "," + price + ",0)";
                    conn.SQLUPDATE(sql,true);
                    tryloadthis(area);
                    FunctionsClass fc = new FunctionsClass();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }
       private void tryloadthis(String area)
        {
            bool done = false;
            String sql = "select * from units where unit_type="+area+"";
            conn.SQLCODE(sql, false);
            if (conn.myReader.Read())
            {
                done = true;
            }
            if (!done) {
                tryloadthis(area);
            }
        }
    }
}
