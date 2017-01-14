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
    public partial class Tnazol : Form
    {
        ConnectionClass c1 = new ConnectionClass();
        TnazolSuppData newclient = new TnazolSuppData();
        ErrorProvider err;
        private int motnazelID;

        public Tnazol()
        {
            InitializeComponent();
            c1.startConnection();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            newclient.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            String sql = "select * from Clients where national_id = '" + nationalIDMota.Text + "'";
            c1.SQLCODE(sql, false);

            if (c1.myReader.Read())
            {
                nameMota.Text = c1.myReader["client_name"].ToString();
                motnazelID = int.Parse(c1.myReader["id"].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //validate

            if (string.IsNullOrWhiteSpace(nationalIDMota.Text))
            {
                err = new ErrorProvider();
                err.SetError(nationalIDMota, "يجب إدخال  الرقم القومي");
            }
            else
            {           
                if ( err!= null)
                    err.Clear();
            }

            //insert into tanazolat
            if (err == null&&newclient.tm&&motnazelID!=0)
            {
                try
                {
                    String motanazaElleh = newclient.nationalIdFunc;
                    String subquery = "select ID from Clients where national_id='" + motanazaElleh + "'";
                    c1.SQLCODE(subquery, false);
                    int ToID = 0;
                    int unitType = 0;
                    while (c1.myReader.Read())
                    {
                        ToID = int.Parse(c1.myReader["ID"].ToString());
                    }

                    if (ToID!=0 && motnazelID!=0)
                    {
                        String da = tanazolDate.Value.ToString("yyyy/MM/dd");
                        String query = "insert into tanazolat (from_id,to_id,tanazol_date) values (" + motnazelID + "," + ToID + ",#" + da + "#)";
                        c1.SQLUPDATE(query, false);

                        String updateSql1 = "update Clients set TnazolState ='F' where national_id='" + nationalIDMota.Text.ToString() + "'";
                        c1.SQLUPDATE(updateSql1, false);
                        String updateSql2 = "update Clients set TnazolState ='T' where national_id='" + motanazaElleh + "'";
                        c1.SQLUPDATE(updateSql2, false);

                        String unitTypeTanazolSql = "select * from ClientsUnits where client_id=" + motnazelID;
                        c1.SQLCODE(unitTypeTanazolSql, false);
                        if (c1.myReader.Read())
                        {
                            unitType = int.Parse(c1.myReader["unit_id"].ToString());
                        }
                        FunctionsClass.updtaeMyScriptHistory(motnazelID);

                        String sql2 = "insert into ClientsUnits(client_id,unit_id,RecoredState)values(" + ToID + "," + unitType + ",'N')";
                        c1.SQLUPDATE(sql2, true); 
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                }
            }
            else
            {
                MessageBox.Show("يوجد خطأ, اما انك لم تدخل بيانات العميل الجديد او أنك لم تدخل الرقم القومي للعميل القديم ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
