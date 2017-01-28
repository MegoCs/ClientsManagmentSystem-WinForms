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
    public partial class SearchQest : Form
    {
        ConnectionClass conn = new ConnectionClass();
        private List<int> photos_group;
        public int idToSearch = 0;

        public SearchQest()
        {
            InitializeComponent();
            photos_group = new List<int>();
            this.ActiveControl = national_id;
        }

        public int ID { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.startConnection();
            if (checkBox1.Checked)
            {
                try
                {
                    String date1 = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                    String date2 = dateTimePicker2.Value.ToString("yyyy/MM/dd");
                    String sql = "SELECT aqsat.details as 'تفاصيل الايصالات', bank_accounts.type as 'الحساب المستلم',qest_date AS 'تاريخ القسط',aqsat.qest_value as 'قيمة القسط', Clients.client_name as 'اسم العميل' ,aqsat.group_id,aqsat.ID FROM((aqsat INNER JOIN bank_accounts ON aqsat.bank_id = bank_accounts.ID) INNER JOIN Clients ON (aqsat.client_id = Clients.ID and Clients.check_out = 'N')) WHERE qest_date between #" + date1 + "# and #" + date2 + "# order by qest_date";
                    conn.SQLCODE(sql, true);
                    DataTable table = new DataTable();
                    conn.myAdabter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;

                    this.Invoke((MethodInvoker)delegate () { sumValues(3); });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
            }
            else
            {
                if (!String.IsNullOrEmpty(national_id.Text))
                {
                    String sql = "select * from Clients where national_id = '" + national_id.Text + "' and deleted = 'N' and Clients.check_out = 'N'";
                    conn.SQLCODE(sql, false);
                    if (conn.myReader.Read())
                    {
                        clientName.Text = conn.myReader["client_name"].ToString();
                        ID = int.Parse(conn.myReader["ID"].ToString());
                    }
                    else { MessageBox.Show("لا يوجد عضو بهذا الرقم القومي "); }
                    String sql2 = "select aqsat.details as 'تفاصيل الايصالات' ,bank_accounts.type as 'الحساب المستلم',qest_date AS 'تاريخ القسط',aqsat.qest_value as 'قيمة القسط' ,group_id,aqsat.ID from (aqsat INNER JOIN bank_accounts ON aqsat.bank_id = bank_accounts.ID) where client_id =" + ID + " order by qest_date";
                    conn.SQLCODE(sql2, true);
                    DataTable table = new DataTable();
                    conn.myAdabter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    this.Invoke((MethodInvoker)delegate () { sumValues(3); });
                }
                else
                {
                    MessageBox.Show("برجاء اتمام البيانات");
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBox1.Checked;
            dateTimePicker2.Enabled = checkBox1.Checked;
            national_id.Enabled = !checkBox1.Checked;
        }
        private void sumValues(int culm)
        {
            double result = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                result += Convert.ToDouble(row.Cells[culm].Value);
            }
            valuesSumLab.Text = result.ToString();
        }
        void loadPhotosList()
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {    // editeQest edite = new editeQest();
                if (dataGridView1.SelectedRows.Count == 1) // make sure user select at least 1 row 
                {
                    String bankSystem = dataGridView1.SelectedRows[0].Cells[1].Value + String.Empty;
                    String qestDate = dataGridView1.SelectedRows[0].Cells[2].Value + String.Empty;
                    String qestValue = dataGridView1.SelectedRows[0].Cells[3].Value + String.Empty;
                    string qestDetails = dataGridView1.SelectedRows[0].Cells[0].Value + String.Empty;
                    idToSearch = int.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                    int groupId = int.Parse(dataGridView1.SelectedRows[0].Cells["group_id"].Value.ToString());

                    editeQest edite2 = new editeQest(qestValue, qestDate,qestDetails, bankSystem, idToSearch, groupId);
                    edite2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("برجاء اختيار القسط للتعديل");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى العملية");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");
            }

        }
    }
}
