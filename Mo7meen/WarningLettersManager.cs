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
    public partial class WarningLettersManager : Form
    {
        ConnectionClass Dbonj;
        private int photosGroup_id;

        public WarningLettersManager()
        {
            InitializeComponent();
            Dbonj = new ConnectionClass();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ClearFormValues();
            try
            {
                if (!string.IsNullOrEmpty(letterNumberTxt.Text))
                {

                    Dbonj.startConnection();
                    Dbonj.SQLCODE("select * from WarningLetters where LetterNumber=" + letterNumberTxt.Text + "", false);
                    if (Dbonj.myReader.Read())
                    {
                        subjectTxt.Text = Dbonj.myReader["LetterSubject"].ToString();
                        notesTxt.Text = Dbonj.myReader["LetterNotes"].ToString();
                        replyTxt.Text = Dbonj.myReader["LetterReply"].ToString();
                        LetterType.Text = Dbonj.myReader["LetterType"].ToString();
                        dateTimePicker1.Text = Dbonj.myReader["LetterDate"].ToString();
                        photosGroup_id = int.Parse(Dbonj.myReader["group_id"].ToString());
                        attchmentsBtn.Enabled = true;
                        saveUpdateBtn.Enabled = true;
                        deleteLetterBtn.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات بهذا الرقم");
                    } 
                }
                else
                    MessageBox.Show("برجاء البحث برقم الخطاب");
            }
            catch (Exception ex) {
                MessageBox.Show("خطأ ف البيانات المدخلة");
                Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString() + " InnerException: " + ex.InnerException + " ExceptionMessage: " + ex.Message + ". [" + this.Name + "] By [" + SessionInfo.empName + "]");
            }
        }

        private void attchmentsBtn_Click(object sender, EventArgs e)
        {
            if (photosGroup_id != 0)
            {
                var list = new List<int>();
                list.Add(photosGroup_id);
                PhotosGroup pgGObj = new PhotosGroup(list);
                pgGObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد ملفات المختارة");
            }
        }

        private void deleteLetterBtn_Click(object sender, EventArgs e)
        {
            Dbonj.SQLUPDATE("delete from WarningLetters where LetterNumber=" + letterNumberTxt.Text + " ",true);
            ClearFormValues();
        }

        private void ClearFormValues()
        {
            attchmentsBtn.Enabled = false;
            saveUpdateBtn.Enabled = false;
            deleteLetterBtn.Enabled = false;
            subjectTxt.Text = "";
            replyTxt.Text = "";
            notesTxt.Text = "";
        }

        private void saveUpdateBtn_Click(object sender, EventArgs e)
        {
            Dbonj.SQLUPDATE("update WarningLetters set LetterSubject='"+subjectTxt.Text+"',LetterNotes='"+notesTxt.Text+ "',LetterReply='"+replyTxt.Text+ "' where LetterNumber="+letterNumberTxt.Text+"", true);
        }
    }
}
