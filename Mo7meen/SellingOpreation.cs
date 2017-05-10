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

    public partial class SellingOpreation : Form
    {


        ConnectionClass c1;
        Color redColor = Color.FromArgb(255, 0, 0);
        ErrorProvider nameErr, nationalIdErr, phoneErr, membershipIdErr, addressErr, unitTypeErr, entesabMoneyErr, entesabAccErr;
        bool[] arr = new bool[13];
        private int photosGroup_id;
        private int IskanIndex;

        private void button3_Click(object sender, EventArgs e)
        {
            PhotosForm phF = new PhotosForm();
            phF.ShowDialog();
            photosGroup_id = phF.groupID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SellingOpreation()
        {
            InitializeComponent();
            c1 = new ConnectionClass(); ;
            c1.startConnection();
            loadData();
        }

        private bool checkfull(bool[] arr)
        {
            for (int i = 0; i < 6; i++)
            {
                if (arr[i] == false)
                {
                    return false;
                }
            }
            if (entsabCheck.Checked)
            {
                if (arr[7] == false || arr[9] == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void loadData()
        {
            FunctionsClass x = new FunctionsClass();
            foreach (ComboBoxItem item in FunctionsClass.banksData)
            {
                if (item.Text == "اسكان")
                    IskanIndex = FunctionsClass.banksData.IndexOf(item);
                accountType.Items.Add(item);
                intesabAccount.Items.Add(item);
            }
            intesabAccount.SelectedIndex = IskanIndex;
            accountType.SelectedIndex = IskanIndex;




            foreach (ComboBoxItem item in FunctionsClass.areasData)
            {
                unitType.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Validation Region
            //validation
            {
                if (string.IsNullOrWhiteSpace(clientName.Text))
                {

                    nameErr = new ErrorProvider();
                    nameErr.SetError(clientName, "يجب إدخال إسم العميل ");
                    arr[0] = false;

                }
                else
                {
                    //     z=true;
                    arr[0] = true;
                    if (nameErr != null)
                        nameErr.Clear();
                }


                if (InsertNationalIdChecker(nationalId.Text) || string.IsNullOrWhiteSpace(nationalId.Text) || (nationalId.Text.Length != 14 && nationalId.Text.Length != 16))
                {

                    nationalIdErr = new ErrorProvider();
                    nationalIdErr.SetError(nationalId, "خطأ متعلق بالرقم القومى متواجد قبل ذلك او ليس 14 رقم او 16 فى حاله اكتر من وحده");
                    arr[1] = false;
                }
                else
                {
                    // z=true;
                    if (nationalIdErr != null)
                        nationalIdErr.Clear();
                    arr[1] = true;
                }


                if (string.IsNullOrWhiteSpace(membershipId.Text) && !entsabCheck.Checked)
                {
                    membershipIdErr = new ErrorProvider();
                    membershipIdErr.SetError(membershipId, "يجب إدخال رقم العضوية ");
                    // z=false;
                    arr[2] = false;
                }
                else
                {
                    //z=true;
                    if (membershipIdErr != null)
                        membershipIdErr.Clear();
                    arr[2] = true;
                }


                if (string.IsNullOrWhiteSpace(phoneNumber.Text))
                {
                    phoneErr = new ErrorProvider();
                    phoneErr.SetError(phoneNumber, "يجب إدخال رقم ادخال رقم التليفون ");
                    //z=false;
                    arr[3] = false;
                }
                else
                {
                    //z=true;
                    if (phoneErr != null)
                        phoneErr.Clear();
                    arr[3] = true;
                }


                if (string.IsNullOrWhiteSpace(address.Text))
                {
                    addressErr = new ErrorProvider();
                    addressErr.SetError(address, "يجب إدخال  العنوان");
                    //z=false;
                    arr[4] = false;
                }
                else
                {
                    //z=true;

                    if (addressErr != null)
                        addressErr.Clear();

                    //   unitTypeErr = null;

                    arr[4] = true;
                }


                if (string.IsNullOrWhiteSpace(unitType.Text))
                {
                    unitTypeErr = new ErrorProvider();
                    unitTypeErr.SetError(unitType, "يجب إدخال  نوع الوحدة");
                    //z=false;
                    arr[5] = false;
                }
                else
                {
                    //z=true;


                    if (unitTypeErr != null)
                        unitTypeErr.Clear();
                    arr[5] = true;
                }

                if (entsabCheck.Checked)
                {
                    if (string.IsNullOrWhiteSpace(intesabValue.Text))
                    {
                        entesabMoneyErr = new ErrorProvider();
                        entesabMoneyErr.SetError(intesabValue, "يجب إدخال قيمة المبلغ المدفوع للإنتساب ");
                        //z=false;
                        arr[7] = false;
                    }
                    else
                    {
                        //z=true;

                        if (entesabMoneyErr != null)
                            entesabMoneyErr.Clear();
                        arr[7] = true;
                    }

                    if (string.IsNullOrWhiteSpace(intesabAccount.Text))
                    {
                        entesabAccErr = new ErrorProvider();
                        entesabAccErr.SetError(intesabAccount, "يجب إدخال نوع الحساب ");
                        //z=false;
                        arr[9] = false;
                    }
                    else
                    {
                        //z=true;

                        if (entesabAccErr != null)
                            entesabAccErr.Clear();
                        arr[9] = true;
                    }

                }


            }
            #endregion

            if (checkfull(arr))
            {
                try
                {
                    #region insert in Clients Table
                    if (entsabCheck.Checked)
                    {
                        membershipId.Text = "0";
                    }
                    String sqlInsert = "insert into Clients(membership_id,client_name,phone_number,address,national_id,deleted,montaseb,delivered,check_out,description,Group_id,TnazolState)"
                        + "values(" + int.Parse(membershipId.Text) + ",'" + clientName.Text + "','" + phoneNumber.Text + "','" + address.Text + "','" + nationalId.Text + "','N','N','N','N','" + description.Text + "'," + photosGroup_id + ",'N')";
                    if(c1.SQLUPDATE(sqlInsert, false));
                    #endregion
                    { 
                    #region return the inserted id
                    String subquery = "select * from Clients where national_id='" + nationalId.Text + "'";
                    c1.SQLCODE(subquery, false);
                    int clientId = 0;
                    while (c1.myReader.Read())
                    {
                        clientId = int.Parse(c1.myReader["ID"].ToString());
                    }
                    #endregion

                    #region insert in Clients Units Table
                    int unitId = int.Parse((unitType.SelectedItem as ComboBoxItem).value);
                    String sql2 = "insert into ClientsUnits(client_id,unit_id,RecoredState)values(" + clientId + "," + unitId + ",'N')";
                    c1.SQLUPDATE(sql2, false);
                    #endregion

                    if (int.Parse(moqademValue.Text) > int.Parse("0"))
                    {
                        #region insert Mo2dam data if not empty
                        String da = moqademDate.Value.ToString("yyyy/MM/dd");
                        String moqademSql = "insert into first_paids (client_id,paid_value,paid_date,bank_id) values (" + clientId + "," + int.Parse(moqademValue.Text) + ",#" + da + "#," + int.Parse((accountType.SelectedItem as ComboBoxItem).value) + ")";
                        c1.SQLUPDATE(moqademSql, false);
                        #endregion

                    }
                    if (entsabCheck.Checked)
                    {
                        #region insert Entsab Data if checked
                        String da1 = intesabDate.Value.ToString("yyyy/MM/dd");
                        String moqademSql = "insert into montsben (client_id,paid_value,paid_date,bank_id) values (" + clientId + "," + int.Parse(intesabValue.Text) + ",#" + da1 + "#," + int.Parse((intesabAccount.SelectedItem as ComboBoxItem).value) + ")";
                        c1.SQLUPDATE(moqademSql, false);
                        String updatesql = "update Clients set montaseb='Y',membership_id =0 where ID=" + clientId;
                        c1.SQLUPDATE(updatesql, false);
                        #endregion
                    }

                    #region Decreas Available Units
                    int avaiableunits = 0;
                    String unitsSql = "select available_units from units where unit_type=" + int.Parse(unitType.Text);
                    c1.SQLCODE(unitsSql, false);
                    if (c1.myReader.Read())
                    {
                        avaiableunits = int.Parse(c1.myReader["available_units"].ToString());
                    }
                    avaiableunits--;
                    String updateUnitsSql = "update units set available_units=" + avaiableunits + " where unit_type=" + int.Parse(unitType.Text);
                    c1.SQLUPDATE(updateUnitsSql, true);

                    if (avaiableunits < 0)
                    {
                        MessageBox.Show("تم الحجز لكن عدد الوحدات غير كاافي ");
                    }
                    clearFormData();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف البيانات المدخلة");
                    Logger.WriteLog("[" + DateTime.Now + "] ExceptionString: " + ex.ToString()+ " InnerException: "+ex.InnerException + " ExceptionMessage: "+ex.Message+". [" + this.Name + "] By [" + SessionInfo.empName + "]");

                }
                #endregion

                #region Idk What is this 
                if (nameErr != null)
                    nameErr.Clear();

                if (nationalIdErr != null)
                    nationalIdErr.Clear();

                if (membershipIdErr != null)
                    membershipIdErr.Clear();

                if (phoneErr != null)
                    phoneErr.Clear();


                if (addressErr != null)
                    addressErr.Clear();

                if (unitTypeErr != null)
                    unitTypeErr.Clear();

                if (entesabMoneyErr != null)
                    entesabMoneyErr.Clear();

                if (entesabAccErr != null)
                    entesabAccErr.Clear();
                #endregion
            }
            else
            {
                MessageBox.Show("خطأ متعلق بالبيانات");
            }
        }

        private bool InsertNationalIdChecker(string text)
        {
            c1.SQLCODE("select * from clients where national_id='" + text + "'", false);
            if (c1.myReader.Read())
            {
                return true;
            }
            return false;
        }

        private void clearFormData()
        {
            membershipId.Text = "";
            clientName.Text = "";
            phoneNumber.Text = "";
            address.Text = "";
            nationalId.Text = "";
            description.Text = "";
            photosGroup_id = 0;
        }

        private void entsabCheck_CheckedChanged(object sender, EventArgs e)
        {
            intesabValue.Enabled = entsabCheck.Checked;
            membershipId.Enabled = !entsabCheck.Checked;
            intesabAccount.Enabled = entsabCheck.Checked;
            intesabDate.Enabled = entsabCheck.Checked;
        }

        private void clientName_Validated(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
