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
    public partial class PaymentByYearReportFormManager : Form
    {
        ConnectionClass conn = new ConnectionClass();
        BackgroundWorker worker;
        public PaymentByYearReportFormManager()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWorkInbackGround;
            worker.RunWorkerCompleted += worker_WorkInbackGroundCompleted;
            //worker.WorkerReportsProgress = true;
            //worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        private void worker_WorkInbackGroundCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void worker_DoWorkInbackGround(object sender, DoWorkEventArgs e)
        {
            // TODO: This line of code loads data into the 'TotalPaymentByYear.PaymentByYearDbSet' table. You can move, or remove it, as needed.
            this.PaymentByYearDbSetTableAdapter.Fill(this.TotalPaymentByYear.PaymentByYearDbSet);
        }

        private void PaymentByYearReportFormManager_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            conn.startConnection();
            int ID=-1;
            try
            {
                if (!String.IsNullOrEmpty(national_id.Text))
                {

                    String sql = "select * from Clients where national_id = '" + national_id.Text + "' and deleted = 'N' and Clients.check_out = 'N'";
                    conn.SQLCODE(sql, false);
                    if (conn.myReader.Read())
                    {
                        clientName.Text = conn.myReader["client_name"].ToString();
                        ID = int.Parse(conn.myReader["ID"].ToString());

                        String sql2 = @"SELECT client_name as 'الاسم', client_id, SUM(PAIDVALUE) AS 'اجمالي المدفوع في السنه', DatePart('yyyy', [YEAR]) AS 'السنه'
                                    FROM (SELECT Clients.client_name, aqsat.client_id, aqsat.qest_value AS PAIDVALUE, aqsat.qest_date AS [YEAR]
                                    FROM (aqsat LEFT OUTER JOIN Clients ON aqsat.client_id = Clients.ID)
                                    UNION
                                    SELECT Clients_2.client_name, first_paids.client_id, first_paids.paid_value AS FIRSTSUM, first_paids.paid_date AS [YEAR]
                                    FROM (first_paids LEFT OUTER JOIN
                                                   Clients Clients_2 ON first_paids.client_id = Clients_2.ID)
                                    UNION
                                    SELECT Clients_1.client_name, T5sesMoney.client_id, T5sesMoney.paid_value AS MONTSEBSUM, T5sesMoney.paid_date AS [YEAR]
                                    FROM (Clients Clients_1 INNER JOIN
                                    T5sesMoney ON T5sesMoney.client_id = Clients_1.ID)) temp
                                    GROUP BY client_name, client_id, DatePart('yyyy', [YEAR])
                                    HAVING        (client_id = " + ID + ") ORDER BY client_id ";

                        conn.SQLCODE(sql2, true);
                        DataTable table = new DataTable();
                        conn.myAdabter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[1].Visible = false;
                        //dataGridView1.Rows[0].Cells[0]

                        for (int i = 1; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = "";
                        }

                    }
                    else { MessageBox.Show("لا يوجد عضو بهذا الرقم القومي "); }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف البيانات المدخلة");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString() + " InnerException: " + ex.InnerException + " ExceptionMessage: " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

            }
        }

        private void LoadReportBtn_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
