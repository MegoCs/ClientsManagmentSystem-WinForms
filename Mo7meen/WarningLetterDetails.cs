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
    public partial class WarningLetterDetails : Form
    {
        
        private int clientID;
        private string clientName;
        private ConnectionClass Dbonj;
        private int photosGroup_id;

        public WarningLetterDetails()
        {
            InitializeComponent();
        }

        public WarningLetterDetails(int clientID, string clientName)
        {
            InitializeComponent();
            Dbonj = new ConnectionClass();
            this.clientID = clientID;
            this.clientName = clientName;
            clientNameLab.Text = clientName;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(clientName) && clientID != null && !string.IsNullOrEmpty(outboxNumberTxt.Text) && !string.IsNullOrEmpty(subjectTxt.Text))
                {
                    Dbonj.startConnection();
                    Dbonj.SQLUPDATE("insert into WarningLetters" +
                    "(LetterNumber," +
                    "LetterSubject," +
                    "LetterDate," +
                    "LetterNotes," +
                    "Letter_group_id," +
                    "LetterClient_ID" +
                    ")" +
                    " values (" +
                    "" + outboxNumberTxt.Text + "," +
                    "'" + subjectTxt.Text + "'," +
                    "'" + letterDatePicker.Value.ToString("yyyy/MM/dd") + "'," +
                    "'" + notesTxt.Text + "'," +
                    "" + photosGroup_id + "," +
                    "" + clientID + "" +
                    ")", true);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف البيانات المدخلة");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString() + " InnerException: " + ex.InnerException + " ExceptionMessage: " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");

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
