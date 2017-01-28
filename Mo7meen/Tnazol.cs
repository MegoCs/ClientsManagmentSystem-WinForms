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
        TnazolSuppData newclient;
        ErrorProvider err;
        private int motnazelID;

        public bool MotnazelToComplete { get; internal set; }
        public string MotnazelToNationalId { get; internal set; }

        public Tnazol()
        {
            InitializeComponent();
            c1.startConnection();
             newclient = new TnazolSuppData(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newclient.ShowDialog();
            if (this.MotnazelToComplete && !string.IsNullOrEmpty(MotnazelToNationalId))
                button4.Enabled = true;
            else
                MessageBox.Show("لم يتم حفظ بيانات المتنازل اليه");
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            String sql = "select * from Clients where national_id = '" + nationalIDMota.Text + "'  and check_out='N' and TnazolState ='N'";
            c1.SQLCODE(sql, false);

            if (c1.myReader.Read())
            {
                nameMota.Text = c1.myReader["client_name"].ToString();
                motnazelID = int.Parse(c1.myReader["id"].ToString());
            }
            else {
                MessageBox.Show("لا يوجد عضو بهذا الرقم يمكنه التنازل");
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
            if (err == null&&MotnazelToComplete&&motnazelID!=0&&!string.IsNullOrEmpty(MotnazelToNationalId))
            {
                try
                {
                    String motanazaElleh = MotnazelToNationalId;
                    String subquery = "select ID from Clients where national_id='" + motanazaElleh + "'";
                    c1.SQLCODE(subquery, false);
                    int ToID = 0;
                    int unitType = 0;
                    while (c1.myReader.Read())
                    {
                        ToID = int.Parse(c1.myReader["ID"].ToString());
                    }

                    if (ToID != 0 && motnazelID != 0)
                    {
                        String da = tanazolDate.Value.ToString("yyyy/MM/dd");
                        String query1 = "insert into tanazolat (from_id,to_id,tanazol_date) values (" + motnazelID + "," + ToID + ",#" + da + "#)";
                        if (c1.SQLUPDATE(query1, false))
                        {

                            String query2 = "update Clients set TnazolState ='F' where id=" + motnazelID + "";
                            c1.SQLUPDATE(query2, false);
                            String query3 = "update Clients set TnazolState ='T' where id=" + ToID + "";
                            c1.SQLUPDATE(query3, false);
                            //We need to update aqsat history to be with the new client ID
                            String query4 = "update aqsat set client_id=" + ToID + ",details='تم نقل القسط بعد التنازل' where client_id=" + motnazelID + "";
                            c1.SQLUPDATE(query4, false);
                            String query5 = "update first_paids set client_id=" + ToID + " where client_id=" + motnazelID + "";
                            c1.SQLUPDATE(query5, false);
                            String query6 = "update T5sesMoney set client_id =" + ToID + " where client_id=" + motnazelID + "";
                            c1.SQLUPDATE(query6, false);
                            //
                            String unitTypeTanazolSql = "select * from ClientsUnits where client_id=" + motnazelID+ " ORDER BY ClientsUnits.ID DESC";
                            c1.SQLCODE(unitTypeTanazolSql, false);
                            if (c1.myReader.Read())
                            {
                                unitType = int.Parse(c1.myReader["unit_id"].ToString());
                            }
                            String sql2 = "insert into ClientsUnits(client_id,unit_id,RecoredState)values(" + ToID + "," + unitType + ",'N')";
                            c1.SQLUPDATE(sql2, true);
                            FunctionsClass.updtaeMyScriptHistory(motnazelID);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");
                }
            }
            else
            {
                MessageBox.Show("يوجد خطأ, اما انك لم تدخل بيانات العميل الجديد او أنك لم تدخل الرقم القومي للعميل القديم ");
            }
        }

    }
}
