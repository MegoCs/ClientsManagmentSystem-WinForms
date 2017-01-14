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
    public partial class LatePaymentReport : Form
    {
        int unit_id;
        short mNumber;
        public LatePaymentReport(int un, short mNu)
        {
            InitializeComponent();
            this.unit_id = un;
            this.mNumber = mNu;
        }

        private void LatePaymentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LatePayment.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.LatePayment.DataTable1,unit_id,mNumber_);

            //this.reportViewer1.RefreshReport();
        }
    }
}
