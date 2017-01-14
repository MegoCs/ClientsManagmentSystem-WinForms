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
    public partial class Gard : Form
    {
        ConnectionClass conn;
        List<int> unitsId = new List<int>();
        List<int> ClientsCount = new List<int>();
        List<int> availList = new List<int>();
        public Gard()
        {
            InitializeComponent();
            conn = new ConnectionClass();
            conn.startConnection();
            loadAreas();
            load();
            loadAvailableUnits();
        }

        private void loadAreas()
        {
            FunctionsClass e = new FunctionsClass();
            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                comboBox1.Items.Add(item);
            }
            loadUnitsClientsCount();
        }

        private void loadAvailableUnits()
        {
            String sql = "select unit_type , available_units from units ";
            conn.SQLCODE(sql, false);
            while (conn.myReader.Read())
            {
                availUnitsCombo.Items.Add(conn.myReader[0].ToString());
                availList.Add(int.Parse(conn.myReader[1].ToString()));
            }
        }
        private void dosome(TextBox LCD,String sql)
        {
            conn.SQLCODE(sql, false);
            if (conn.myReader.Read())
            {
                LCD.Text = conn.myReader["total"].ToString();
            }
        }
        public void load() 
        {
            String sql = "select count(*) As total from Clients WHERE  (check_out = 'n')";
            dosome(clientNumber, sql);
            sql = "select SUM(paid_value) As total from first_paids WHERE (client_id NOT IN (SELECT ID FROM  Clients WHERE(check_out = 'y')))";
            dosome(mo2damat, sql);
            sql = "select SUM(qest_value) As total from aqsat WHERE (client_id NOT IN (SELECT ID FROM  Clients WHERE(check_out = 'y')))";
            dosome(aqsat, sql);
            sql = "select SUM(paid_value) As total from T5sesMoney WHERE (client_id NOT IN (SELECT ID FROM  Clients WHERE(check_out = 'y')))";
            dosome(t5ses, sql);
            

        }

        void loadUnitsClientsCount()
        {
            String sql = "SELECT unit_id, COUNT(client_id) AS ClientsCount FROM ClientsUnits WHERE(RecoredState = 'N') GROUP BY unit_id";
            conn.SQLCODE(sql, false);
            while (conn.myReader.Read())
            {
                unitsId.Add(int.Parse(conn.myReader[0].ToString()));
                ClientsCount.Add(int.Parse(conn.myReader[1].ToString()));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            custNumperUnit.Text = "0";
            for (int i = 0; i < unitsId.Count; i++)
            {
                if (unitsId[i] == int.Parse((comboBox1.SelectedItem as ComboBoxItem).value)) {
                    custNumperUnit.Text = ClientsCount[i].ToString();
                }
            }
            if (String.IsNullOrEmpty(custNumperUnit.Text))
                custNumperUnit.Text = "0";
        }

        private void availUnitsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availUnitsCombo.SelectedIndex!=-1)
            {
                availUnitsTxt.Text = availList[availUnitsCombo.SelectedIndex].ToString(); 
            }
        }
    }
}
