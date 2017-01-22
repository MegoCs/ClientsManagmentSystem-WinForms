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
    public partial class TransferUnit : Form
    {
        ConnectionClass c1 = new ConnectionClass();
        ErrorProvider err, unitErr;
        int clientId = 0;
        public TransferUnit()
        {
            InitializeComponent();
            c1.startConnection();
            FunctionsClass.loadAreaTyeps();
            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                unitType.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String sql = "select * from Clients where national_id = '" + nationalIdText.Text + "'";
            c1.SQLCODE(sql, false);

            int sumOfMoney = 0;
            char t = 'm';
            int ut = 0;
            while (c1.myReader.Read())
            {
                nameText.Text = c1.myReader["client_name"].ToString();
                clientId = int.Parse(c1.myReader["ID"].ToString());
                t = char.Parse(c1.myReader["montaseb"].ToString());
            }

            String subquery = "select unit_id from ClientsUnits where client_id=" + clientId + "";
            c1.SQLCODE(subquery, false);
            while (c1.myReader.Read())
            {
                ut = int.Parse(c1.myReader["unit_id"].ToString());
            }
            currentUnitState.Text = AreaOfUnitID(ut) + "";

            //moqdam
            String sqlmoqdm = "select SUM(paid_value) as moqdm from first_paids where client_id=" + clientId;
            c1.SQLCODE(sqlmoqdm, false);
            if (c1.myReader.Read())
            {
                if (!String.IsNullOrEmpty(c1.myReader["moqdm"].ToString()))
                    sumOfMoney += int.Parse(c1.myReader["moqdm"].ToString());
            }

            sqlmoqdm = "select SUM(qest_value) as aqsat from aqsat where client_id=" + clientId;
            c1.SQLCODE(sqlmoqdm, false);
            if (c1.myReader.Read())
            {
                if (!String.IsNullOrEmpty(c1.myReader["aqsat"].ToString()))
                    sumOfMoney += int.Parse(c1.myReader["aqsat"].ToString());
            }

            //montas

            if (t == 'Y')
            {
                sqlmoqdm = "select SUM(paid_value) as mon from montsben where client_id=" + clientId;
                c1.SQLCODE(sqlmoqdm, false);
                if (c1.myReader.Read())
                {
                    if (!String.IsNullOrEmpty(c1.myReader["mon"].ToString()))
                        sumOfMoney += int.Parse(c1.myReader["mon"].ToString());
                }

            }
            thePaidMoney.Text = sumOfMoney + "";
        }

        private string AreaOfUnitID(int id)
        {
            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                if (int.Parse(item.value) == id)
                {
                    return item.Text;
                }
            }
            return null;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (clientId != 0)
            {
                #region Func
                if (string.IsNullOrWhiteSpace(nationalIdText.Text))
                {
                    err = new ErrorProvider();
                    err.SetError(nationalIdText, "يجب إدخال  الرقم القومي");
                }
                else
                {
                    if (err != null)
                        err.Clear();
                }

                if (string.IsNullOrWhiteSpace(unitType.Text))
                {
                    unitErr = new ErrorProvider();
                    err.SetError(unitType, "يجب إدخال نوع الوحدة المحول إليها  ");
                }
                else
                {
                    if (unitErr != null)
                        unitErr.Clear();
                }

                //Sql commands  

                if (!string.IsNullOrWhiteSpace(unitType.Text) && !string.IsNullOrWhiteSpace(nationalIdText.Text) && unitType.Text != currentUnitState.Text)
                {
                    try
                    {
                        String selectUnit = "select ID from units where unit_type=" + int.Parse(unitType.Text.ToString());
                        c1.SQLCODE(selectUnit, false);
                        int unittyperetrie = 0;
                        while (c1.myReader.Read())
                        {
                            unittyperetrie = int.Parse(c1.myReader["ID"].ToString());
                        }
                        FunctionsClass.updtaeMyScriptHistory(clientId);
                        String sqlupdateToOld = "update ClientsUnits set RecoredState='O' where (client_id=" + clientId + " and RecoredState='N')";
                        c1.SQLUPDATE(sqlupdateToOld, false);

                        String sqlinsert = "insert into ClientsUnits(client_id,unit_id,RecoredState)values(" + clientId + "," + unittyperetrie + ",'N')";
                        c1.SQLUPDATE(sqlinsert, false);
                        
                        String updateUnitsSql = "update units set available_units=available_units-1 where unit_type=" + int.Parse(unitType.Text);
                        c1.SQLUPDATE(updateUnitsSql, false);
                        updateUnitsSql = "update units set available_units=available_units+1 where unit_type=" + int.Parse(currentUnitState.Text);
                        c1.SQLUPDATE(updateUnitsSql, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ ف البيانات المدخلة");
                        Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                    }

                    //clear all errors
                    if (unitErr != null)
                        unitErr.Clear();
                    if (err != null)
                        err.Clear();
                }
                else
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                }
            }
            #endregion
        }
    }
}
