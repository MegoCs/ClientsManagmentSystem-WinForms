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
    public partial class MontasbenMoneyManager : Form
    {
        ConnectionClass conn;
        List<int> photos_group;
        public MontasbenMoneyManager()
        {

            InitializeComponent();
            conn = new ConnectionClass();
            photos_group = new List<int>();
        }

        private void searchChange_CheckedChanged(object sender, EventArgs e)
        {
            national_id.Enabled = (national_id.Enabled) ? false : true;
            clientName.Enabled = (clientName.Enabled) ? false : true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            conn.startConnection();

            if (!String.IsNullOrEmpty(national_id.Text))
            {
                String sql = "select * from Clients where national_id = '" + national_id.Text + "' and deleted = 'N' and Clients.check_out = 'N' and stopState='N'";
                conn.SQLCODE(sql, false);
                if (conn.myReader.Read())
                {
                    clientName.Text = conn.myReader["client_name"].ToString();

                    int client_ID = int.Parse(conn.myReader["ID"].ToString());
                    if (mo2dmatRadio.Checked)
                    {
                        sql = "SELECT first_paids.details as 'التفاصيل',paid_value as 'القيمة المدفوعة', bank_accounts.type as 'الحساب المستلم',paid_date AS 'تاريخ السداد',Clients.client_name as 'اسم العميل' ,first_paids.group_id,first_paids.ID FROM((first_paids INNER JOIN bank_accounts ON first_paids.bank_id = bank_accounts.ID) INNER JOIN Clients ON (first_paids.client_id = Clients.ID and Clients.check_out = 'N' and stopState='N')) where first_paids.client_id = " + client_ID + " order by paid_date";
                    }
                    else
                    {
                        int PaymentType = (type0Radio.Checked) ? 0 : 1;
                        sql = "SELECT montsben.details as 'التفاصيل',paid_value as 'القيمة المدفوعة', bank_accounts.type as 'الحساب المستلم',paid_date AS 'تاريخ السداد',Clients.client_name as 'اسم العميل' ,montsben.group_id,montsben.ID FROM((montsben INNER JOIN bank_accounts ON montsben.bank_id = bank_accounts.ID) INNER JOIN Clients ON (montsben.client_id = Clients.ID and Clients.check_out = 'N')) where PaymentType=" + PaymentType + " and montsben.client_id = " + client_ID + " order by paid_date";
                    }
                    conn.SQLCODE(sql, true);
                        DataTable table = new DataTable();
                        conn.myAdabter.Fill(table);
                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[4].Visible = false;
                    
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {    // editeQest edite = new editeQest();
                if (dataGridView1.SelectedRows.Count == 1) // make sure user select at least 1 row 
                {
                    String bankSystem = dataGridView1.SelectedRows[0].Cells[2].Value + String.Empty;
                    String qestDate = dataGridView1.SelectedRows[0].Cells[3].Value + String.Empty;
                    String qestValue = dataGridView1.SelectedRows[0].Cells[1].Value + String.Empty;
                    string qestDetails = dataGridView1.SelectedRows[0].Cells[0].Value + String.Empty;
                    int idToSearch = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    int groupId = (!string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells["group_id"].Value.ToString()))?int.Parse(dataGridView1.SelectedRows[0].Cells["group_id"].Value.ToString()):0;

                    editeQest edite2;
                    if (!mo2dmatRadio.Checked)
                    edite2 = new editeQest(qestValue, qestDate, qestDetails, bankSystem, idToSearch, groupId, "Montsben");
                    else
                    edite2 = new editeQest(qestValue, qestDate, qestDetails, bankSystem, idToSearch, groupId, "first_paids");
                    edite2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("برجاء اختيار البيان للتعديل");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى العملية");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString() + " InnerException: " + ex.InnerException + " ExceptionMessage: " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");
            }
        }

        private void showImagesBtn_Click(object sender, EventArgs e)
        {
            loadPhotosList();
            if (photos_group.Count > 0)
            {
                PhotosGroup pgGObj = new PhotosGroup(photos_group);
                pgGObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد ملفات للاقساط المختارة");
            }
        }

        private void loadPhotosList()
        {
            if (photos_group.Count > 0)
                photos_group.Clear();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (!String.IsNullOrEmpty(item.Cells["group_id"].Value.ToString()))
                {
                    if (int.Parse(item.Cells["group_id"].Value.ToString()) != 0)
                        photos_group.Add(int.Parse(item.Cells["group_id"].Value.ToString()));
                }
            }
        }
    }
}
