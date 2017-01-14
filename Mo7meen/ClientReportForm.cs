using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mo7meen
{

    public partial class ClientReportForm : Form
    {
        int client_id;
        TabPage e1, e2;
        ConnectionClass conObj;
        #region Printing Assembly
        private System.IO.Stream streamToPrint;
        string streamType;
        private PrintDocument printDoc = new PrintDocument();
        private int partnerID=-1;

        public string TnazolState { get; private set; }

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );
        #endregion
        public ClientReportForm()
        {
            InitializeComponent();
            conObj = new ConnectionClass();

        }
        private void ClientReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LatePayment.DataTable1' table. You can move, or remove it, as needed.
            EmpNameLab.Text = SessionInfo.empName;
            todayDateLab.Text=DateTime.Now.ToString("dd/MM/yyy");
        }

        private void fillReportBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nationalSearch.Text))
            {
                conObj.startConnection();
                String sql = "SELECT units.unit_price,units.unit_type, Clients.client_name,Clients.receivingPayments, ClientsUnits.ID as joinid, Clients.membership_id, Clients.phone_number, Clients.address, Clients.deleted, Clients.national_id, Clients.montaseb, Clients.delivered,Clients.ID, Clients.unit_number, Clients.tour_number, Clients.check_out, Clients.description, Clients.TnazolState FROM ((Clients INNER JOIN ClientsUnits ON Clients.ID = ClientsUnits.client_id) INNER JOIN units ON ClientsUnits.unit_id = units.ID) WHERE(Clients.national_id = '" + nationalSearch.Text+"') ORDER BY ClientsUnits.ID DESC";
                conObj.SQLCODE(sql, false);
                if (conObj.myReader.Read())
                {
                    #region Load Client Data

                    #region Display Basic Info About the Client
                    client_id = int.Parse(conObj.myReader["id"].ToString());
                    client_NameTxt.Text = conObj.myReader["client_name"].ToString();
                    client_PhoneTxt.Text = conObj.myReader["phone_number"].ToString();
                    client_NationalTxt.Text = conObj.myReader["national_id"].ToString();

                    if (conObj.myReader["membership_id"].ToString() == "0")
                        client_MemberShipTxt.Text = "";
                    else
                    client_MemberShipTxt.Text = conObj.myReader["membership_id"].ToString();

                    client_AddressTxt.Text = conObj.myReader["address"].ToString();
                    client_TourNumTxt.Text = conObj.myReader["tour_number"].ToString();
                    client_UnitNumTxt.Text = conObj.myReader["unit_number"].ToString();
                    recivePaymentValueTxt.Text= conObj.myReader["receivingPayments"].ToString();
                    unitPriceTxt.Text = conObj.myReader["unit_price"].ToString();
                    unitPriceTxt.Text = conObj.myReader["unit_price"].ToString();
                    unitTypeLab.Text= conObj.myReader["unit_type"].ToString();
                    #endregion

                    #region check Entsab State and Sum of It`s Money
                    TnazolState = conObj.myReader["TnazolState"].ToString();
                    if (conObj.myReader["montaseb"].ToString() == "Y")
                    {
                        entsabCheckBox.Checked = true;
                        sql = "select sum(paid_value) from montsben where client_id=" + client_id + " and PaymentType=0";
                        loadOneCell(sql, entsabPaid_ValueTxt);
                        if (String.IsNullOrEmpty(entsabPaid_ValueTxt.Text))
                            entsabPaid_ValueTxt.Text = "0";

                        sql = "select sum(paid_value) from montsben where client_id=" + client_id + " and PaymentType=1";
                        loadOneCell(sql, entsabManagPaid_ValueTxt);
                        if (String.IsNullOrEmpty(entsabManagPaid_ValueTxt.Text))
                            entsabManagPaid_ValueTxt.Text = "0";

                    }
                    else
                    {
                        EntsabGroup.Visible = false;
                    }
                    #endregion

                    #region check Tnazol State and Partner
                    if (TnazolState != "n" && TnazolState != "N")
                    {
                        if (TnazolState == "T" || TnazolState == "t")
                        {
                            sql = "SELECT client_name,ID FROM Clients WHERE(ID =(SELECT From_id FROM tanazolat WHERE(to_id = " + client_id + ")))";
                            motnazelCheckBox.Checked = false;
                            motnazelToCheckBox.Checked = true;
                            conObj.SQLCODE(sql, false);
                            if (conObj.myReader.Read())
                            {
                                tnazolPartenterTxt.Text = conObj.myReader[0].ToString();
                                partnerID = int.Parse(conObj.myReader[1].ToString());
                            }
                        }
                        if (TnazolState == "F" || TnazolState == "f")
                        {
                            sql = "SELECT client_name FROM Clients WHERE(ID =(SELECT to_id FROM tanazolat WHERE(from_id = " + client_id + ")))";
                            motnazelCheckBox.Checked = true;
                            motnazelToCheckBox.Checked = false;
                            loadOneCell(sql, tnazolPartenterTxt);
                        }
                    }
                    else {
                        TnazolGroup.Visible = false;
                    }
                    #endregion

                    #region Load Paid Fist Values Sum
                    sql = "select sum(paid_value) from first_paids HAVING client_id=" + client_id + " OR client_id=" + partnerID + "";
                    loadOneCell(sql, client_Firstpaid_SumTxt);
                    if (String.IsNullOrEmpty(client_Firstpaid_SumTxt.Text))
                        client_Firstpaid_SumTxt.Text = "0";
                    #endregion

                    #region Load T5ses Money sum
                    sql = "select sum(paid_value) from T5sesMoney HAVING client_id=" + client_id + " OR client_id=" + partnerID + "";
                    loadOneCell(sql, client_T5ses_SumTxt);
                    if (String.IsNullOrEmpty(client_T5ses_SumTxt.Text))
                        client_T5ses_SumTxt.Text = "0";
                    #endregion

                    #region Load Aqsat Total Sum
                    sql = "select sum(qest_value) from aqsat HAVING client_id=" + client_id + " OR client_id=" + partnerID + "";
                    loadOneCell(sql, client_Aqsat_SumTxt);
                    if (String.IsNullOrEmpty(client_Aqsat_SumTxt.Text))
                        client_Aqsat_SumTxt.Text = "0";
                    #endregion

                    #region Sum All data and Display them
                    int tmp = int.Parse(client_Firstpaid_SumTxt.Text);
                    tmp += int.Parse(client_T5ses_SumTxt.Text);
                    tmp += int.Parse(client_Aqsat_SumTxt.Text);
                    tmp += int.Parse(recivePaymentValueTxt.Text);
                    client_Total_SumTxt.Text = tmp.ToString();
                    unitRestPriceTxt.Text = (int.Parse(unitPriceTxt.Text) - tmp).ToString();
                    thePercentValueTxt.Text = (0.05 * int.Parse(unitPriceTxt.Text)).ToString();
                    #endregion

                    #endregion
                }
                else {
                    MessageBox.Show("لا يوجد بيانات لهذا العميل");
                }
            }
        }

        private void loadOneCell(string sql, TextBox Lcd)
        {
            conObj.SQLCODE(sql, false);
            if (conObj.myReader.Read())
            {
                Lcd.Text = conObj.myReader[0].ToString();
            }
        }

        #region Printing Functions
        private void PrintMinReportBtn_Click(object sender, EventArgs e)
        {
            this.ActiveControl = EmpNameLab;
            if (client_NameTxt.Text!="") {
                VisbleContolrsForPrint(false);
                #region PrintCalling
                Graphics g1 = this.tabControl1.TabPages[0].CreateGraphics();
                Image MyImage = new Bitmap(this.tabControl1.TabPages[0].ClientRectangle.Width, this.tabControl1.TabPages[0].ClientRectangle.Height, g1);
                Graphics g2 = Graphics.FromImage(MyImage);
                IntPtr dc1 = g1.GetHdc();
                IntPtr dc2 = g2.GetHdc();
                BitBlt(dc2, 0, 0, this.tabControl1.TabPages[0].ClientRectangle.Width, this.tabControl1.TabPages[0].ClientRectangle.Height, dc1, 0, 0, 13369376);
                g1.ReleaseHdc(dc1);
                g2.ReleaseHdc(dc2);
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string srcPath = (System.IO.Path.GetDirectoryName(executable));
                srcPath += @"\Data\PrintPage.jpg";
                MyImage.Save(srcPath, ImageFormat.Jpeg);
                FileStream fileStream = new FileStream(srcPath, FileMode.Open, FileAccess.Read);
                StartPrint(fileStream, "Image");
                fileStream.Close();
                if (System.IO.File.Exists(srcPath))
                {
                    System.IO.File.Delete(srcPath);
                }
                #endregion
                VisbleContolrsForPrint(true);
            }
        }

        private void VisbleContolrsForPrint(bool v)
        {
            nationalLabel.Visible = v;
            nationalSearch.Visible = v;
            subbDetailsGroup.Visible = v;
            PrintMinReportBtn.Visible = v;
            fillReportBtn.Visible = v;
            percentDisplayCheck.Visible = v;
            if (!v)
            {
                e1 = tabControl1.TabPages[1];
                e2 = tabControl1.TabPages[2];
                tabControl1.TabPages.RemoveAt(1);
                tabControl1.TabPages.RemoveAt(1);
            }
            else
            {
                tabControl1.TabPages.Add(e1);
                tabControl1.TabPages.Add(e2);            
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }
        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDoc;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        #endregion

        private void moadmReport_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)delegate {
                SubbReportsViwer subView = new SubbReportsViwer(client_id, partnerID);
                subView.Text = "تقرير تفصيلى للاقساط و المقدمات";
                subView.Show();
             });
        }

        private void percentDisplayCheck_CheckedChanged(object sender, EventArgs e)
        {
            thePercentValueTxt.Visible = percentDisplayCheck.Checked;
            thePercentValueLab.Visible= percentDisplayCheck.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LatePaymentReport lPr = new LatePaymentReport(1, 1);
            lPr.ShowDialog();
        }

        private void LoadGeneralData()
        {
            try
            {
                conObj.startConnection();
                String sql = "SELECT Clients.client_name as 'اسم العميل', Clients.national_id as 'الرقم القومى', Clients.membership_id as 'رقم العضوية', Clients.phone_number as 'رقم التليفون', units.unit_type as 'نوع الوحدة' FROM((Clients INNER JOIN ClientsUnits ON Clients.ID = ClientsUnits.client_id) INNER JOIN units ON ClientsUnits.unit_id = units.ID) WHERE(ClientsUnits.RecoredState = 'N')";
                conObj.SQLCODE(sql, true);
                DataTable dtNotValid = new DataTable();
                conObj.myAdabter.Fill(dtNotValid);
                dataGridView1.DataSource = dtNotValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اثناء تحميل البيانات");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==1)
            {
                LoadGeneralData();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                if(unitTypeComb_LateTab.Items.Count==0)
                foreach (ComboBoxItem item in FunctionsClass.areasData)
                {
                    unitTypeComb_LateTab.Items.Add(item);
                }
            }
        }

        private void priceAndRestDisplayChk_CheckedChanged(object sender, EventArgs e)
        {
            unitPriceTxt.Visible = priceAndRestDisplayChk.Checked;
            unitPriceLab.Visible = priceAndRestDisplayChk.Checked;

            unitRestPriceTxt.Visible = priceAndRestDisplayChk.Checked;
            unitRestLab.Visible = priceAndRestDisplayChk.Checked;

        }

        private void showLateReportBtn_Click(object sender, EventArgs e)
        {
            if (unitTypeComb_LateTab.SelectedIndex != -1)
            {
                this.DataTable1TableAdapter.Fill(this.LatePayment.DataTable1, double.Parse((unitTypeComb_LateTab.SelectedItem as ComboBoxItem).value), short.Parse(mNumComb_LateTab.Value.ToString()));

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
