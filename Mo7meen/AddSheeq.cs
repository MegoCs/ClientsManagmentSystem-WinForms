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
    public partial class AddSheeq : Form
    {
        ConnectionClass conn;

        public int photosGroup_id { get; set; }
        int client_id=-1;
        public AddSheeq(int cli_ID)
        {
            InitializeComponent();
            conn = new ConnectionClass();
            client_id = cli_ID;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sheeqNumText.Text) && !String.IsNullOrEmpty(sheequeOwner_text.Text) && !String.IsNullOrEmpty(valueText.Text))
            {
                conn.startConnection();
                try
                {
                    double sheeque_num = double.Parse(sheeqNumText.Text);
                    String sheeque_name = sheequeOwner_text.Text;
                    int sheeque_value = int.Parse(valueText.Text);
                    String DateEsdar = dateTimePickerEsdar.Value.ToString("yyyy/MM/dd");
                    String DateSarf = dateTimePicker1Sarf.Value.ToString("yyyy/MM/dd");
                    String sql = "INSERT INTO cheques (cheque_number,cheque_owner,cheque_value,cheque_Esdar_Date,Group_id,cheque_Sarf_Date,client_id) VALUES (" + sheeque_num + ",'" + sheeque_name + "'," + sheeque_value + ",'" + DateEsdar + "'," + photosGroup_id + ",'" + DateSarf + "',"+client_id+") ";
                    conn.SQLUPDATE(sql,true);
                }
                catch (Exception ex){
                    MessageBox.Show("خطأ اتمام البيانات");
                    Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");
                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void addPhotosButton_Click(object sender, EventArgs e)
        {
            PhotosForm phF = new PhotosForm();
            phF.ShowDialog();
            photosGroup_id = phF.groupID;
        }
    }
}
