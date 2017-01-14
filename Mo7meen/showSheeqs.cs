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
    public partial class showSheeqs : Form
    {
        ConnectionClass conn;
        private List<int> photos_group;

        public showSheeqs()
        {
            conn = new ConnectionClass();
            conn.startConnection();
            InitializeComponent();
            load();
            photos_group = new List<int>();
            
        }
        public void load() 
        
        {
            String sql = "select  group_id,cheque_number AS 'رقم الشيك' , cheque_owner AS 'المستفيد' , cheque_value AS 'قيمة الشيك ' , cheque_Esdar_Date AS 'تاريخ الاصدار ' ,cheque_Sarf_Date  AS 'تاريخ الصرف'  from cheques";
            conn.SQLCODE(sql, true);
            DataTable table = new DataTable();
            conn.myAdabter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
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
