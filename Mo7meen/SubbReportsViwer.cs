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
    public partial class SubbReportsViwer : Form
    {
        private double passed_Client_ID;
        private double partnerID;
        public SubbReportsViwer(double id,double partID)
        {
            InitializeComponent();
            this.passed_Client_ID = id;
            partnerID = partID;
        }

        private void SubbReportsViwer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.aqsat' table. You can move, or remove it, as needed.
            this.aqsatTableAdapter.Fill(this.DataSet1.aqsat, passed_Client_ID.ToString(), partnerID.ToString());
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1, passed_Client_ID.ToString(), partnerID.ToString());
            // TODO: This line of code loads data into the 'DataSet1.aqsat' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
        }
    }
}
