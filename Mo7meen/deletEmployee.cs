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
    public partial class jkshgk : Form
    {
        ConnectionClass con = new ConnectionClass();
        public jkshgk()
        {
            InitializeComponent();
            con.startConnection();
        }

        private void getData(AutoCompleteStringCollection dataCollection)
        {

            DataSet ds = new DataSet();
          
            String sql = "SELECT DISTINCT [employee_name] from [employees]";
          
                con.SQLCODE(sql, true);
                con.myAdabter.Fill(ds);
                con.myAdabter.Dispose();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }

        }

        private void deletEmployee_Load(object sender, EventArgs e)
        {
            Name.AutoCompleteMode = AutoCompleteMode.Suggest;
            Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection);
            Name.AutoCompleteCustomSource = DataCollection;
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من مسح هذا العميل ؟", "نأكد من المسح", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String deleteSql = "DELETE FROM employees WHERE employee_name='" + Name.Text.ToString() + "'";
                con.SQLUPDATE(deleteSql,true);

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }         
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateEmployee ue = new updateEmployee(Name.Text.ToString());
                ue.ShowDialog();
            }
            catch (Exception ex) {
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }
    }
}
