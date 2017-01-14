using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Mo7meen
{

     class FunctionsClass
    {
        public static List<ComboBoxItem> banksData = new List<ComboBoxItem>();
        public static List<ComboBoxItem> areasData = new List<ComboBoxItem>();
        public static List<ComboBoxItem> deletedCustId = new List<ComboBoxItem>();

       static private ConnectionClass con = new ConnectionClass();

        public FunctionsClass() {
            loadBankAccounts();
            loadAreaTyeps();
        }

        private void loadBankAccounts()
        {
            banksData.Clear();
            con.startConnection();
            String sql = "select id,type from bank_accounts";
            con.SQLCODE(sql, false);
            while (con.myReader.Read())
            {
                banksData.Add(new ComboBoxItem
                {
                    Text = con.myReader[1].ToString(),
                    value = con.myReader[0].ToString()
                });
            }
        }
        public static void loadAreaTyeps()
        {
            areasData.Clear();
            String sql = "select id,unit_type from units";
            con.SQLCODE(sql, false);
            while (con.myReader.Read())
            {
                areasData.Add(new ComboBoxItem
                {
                    Text = con.myReader[1].ToString(),
                    value = con.myReader[0].ToString()
                });
            }
        }
        private void loadDeletedClients()
        {
            areasData.Clear();
            String sql = "select id from Clients where deleted='y'";
            con.SQLCODE(sql, false);
            while (con.myReader.Read())
            {
                deletedCustId.Add(new ComboBoxItem
                {
                    Text = con.myReader[0].ToString(),
                    value = con.myReader[0].ToString()
                });
            }
        }
        static public void updtaeMyScriptHistory(int client_Id)
        {
            con.startConnection();
            String sql = "update ClientsUnits set RecoredState='O' where client_id=" + client_Id+"";
            con.SQLUPDATE(sql,false);
        }
    }
}
