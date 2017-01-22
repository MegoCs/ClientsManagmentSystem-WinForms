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
    public partial class CheckOutList : Form
    {
        ConnectionClass conObj; 
        public CheckOutList()
        {
            InitializeComponent();
            conObj = new ConnectionClass();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            LoadCheckOut();
        }


        private void LoadCheckOut()
        {
            if (unitTypes.SelectedIndex != -1)
            {
                try {
                    conObj.startConnection();
                    String sql = "SELECT  Clients.client_name as 'العميل المنسحب' ,units.unit_type as 'نوع الوحدة' ,cheques.cheque_value as 'قيمة الشيك' , cheques.cheque_number as 'رقم الشيك', cheques.cheque_owner as 'مستفيد الشيك', cheques.cheque_Esdar_Date as 'تاريخ السحب' FROM(((Clients INNER JOIN ClientsUnits ON Clients.ID = ClientsUnits.client_id) INNER JOIN cheques ON Clients.ID = cheques.ID) INNER JOIN units ON ClientsUnits.unit_id = units.ID) WHERE(units.unit_type = " + int.Parse((unitTypes.SelectedItem as ComboBoxItem).Text) + " and ClientsUnits.RecoredState='C')";
                    conObj.SQLCODE(sql, true);
                    DataTable dtNotValid = new DataTable();
                    conObj.myAdabter.Fill(dtNotValid);
                    dataGridView1.DataSource = dtNotValid;
                }
                catch (Exception ex) {
                    MessageBox.Show("خطأ اثناء تحميل البيانات");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");
                }
            }

        }

        private void LoadData() {

            FunctionsClass x = new FunctionsClass();
            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                unitTypes.Items.Add(item);
            }
        }

        private void CheckOutList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
