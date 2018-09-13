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
    public partial class WarningLettersReportForm : Form
    {
        private int client_id;

        public WarningLettersReportForm()
        {
            InitializeComponent();
        }

        public WarningLettersReportForm(int client_id)
        {
            InitializeComponent();
            this.client_id = client_id;
        }

        private void WarningLettersReportForm_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.WarningLettersReportDataSet.DataTable1,client_id);
            this.reportViewer1.RefreshReport();
        }
    }
}
