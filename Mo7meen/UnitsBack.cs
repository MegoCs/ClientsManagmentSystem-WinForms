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
    public partial class UnitsBack : Form
    {
        ConnectionClass conn = new ConnectionClass();
        public UnitsBack()
        {
            InitializeComponent();
            conn.startConnection();
        }

        public int ID { get; private set; }

        private void doSome(TextBox Result,String sql2) {
            conn.SQLCODE(sql2, false);
            if (conn.myReader.Read())
                Result.Text = conn.myReader["total"].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nationalIdtext.Text))
            {
                String sql = "select * from Clients where national_id = '" + nationalIdtext.Text + "'";
                conn.SQLCODE(sql, false);
                if (conn.myReader.Read())
                {
                    agentNameText.Text = conn.myReader["client_name"].ToString();
                    ID = int.Parse(conn.myReader["ID"].ToString());

                    // return customar data
                    String sql2 = "select SUM(paid_value) As total from first_paids where client_id= " + ID + "";
                    doSome(moadmValue,sql2);
                    ifemptySet0(moadmValue);
                    sql2 = "select SUM(qest_value)AS total from aqsat where client_id= " + ID + "";
                    doSome(aqsatValue, sql2);
                    ifemptySet0(aqsatValue);
                    sql2 = "select SUM(paid_value) As total from T5sesMoney where client_id= " + ID + "";
                    doSome(otherMoney2Txt, sql2);
                    ifemptySet0(otherMoney2Txt);
                    sql2 = "select SUM(paid_value)AS total from montsben where client_id= " + ID + "";
                    doSome(otherMoney1Txt, sql2);
                    ifemptySet0(otherMoney1Txt);
                    sumValue.Text = (int.Parse(moadmValue.Text.ToString())+ int.Parse(otherMoney2Txt.Text.ToString()) + int.Parse(otherMoney1Txt.Text.ToString()) + int.Parse(aqsatValue.Text.ToString())) + "";

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لهذا الرقم");

                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void ifemptySet0(TextBox e)
        {
            if (String.IsNullOrEmpty(e.Text))
            {
                e.Text = "0";
            }
        }
        int unitIdToBack = -1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ID != 0) {
            String sql = "update Clients set check_out='Y' where national_id='" + nationalIdtext.Text + "' ";
            conn.SQLUPDATE(sql,false);

                sql = "select unit_id from ClientsUnits where client_id=" + ID + " and RecoredState='N'";
                conn.SQLCODE(sql, false);
                if (conn.myReader.Read())
                {
                    unitIdToBack = int.Parse(conn.myReader[0].ToString());
                }

                sql = "update ClientsUnits set RecoredState='C' where client_id="+ID+ " and RecoredState='N'";
                conn.SQLUPDATE(sql, false);

                sql = "update units set available_units=available_units+1 where ID="+unitIdToBack+"";
                conn.SQLUPDATE(sql, true);


                AddSheeq addObj = new AddSheeq(ID);
                addObj.ShowDialog();
                this.Close();
        }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
