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
    public partial class ControlPanel : Form
    {
        ConnectionClass con = new ConnectionClass();
        String priv;
        ClientReportForm clientReportObj;
        public ControlPanel(String prev)
        {         
            InitializeComponent();
            con.startConnection();
            priv = prev;
            addpriv();
            clientReportObj = new ClientReportForm();
        }

        #region Buttons Actions And Forms Mapping
        
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برجاء اختيار القسط من بحث الاقساط");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SearchForSheeq searchForSheeqObj = new SearchForSheeq();
            searchForSheeqObj.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TkhcesForm tkhcesObj = new TkhcesForm();
            tkhcesObj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PayQest payQest = new PayQest();
            payQest.ShowDialog();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            FunctionsClass fc = new FunctionsClass();
        }

        private void reportAboutClient_Click(object sender, EventArgs e)
        {
            clientReportObj.ShowDialog();
        }

        private void ta5sees2_Click(object sender, EventArgs e)
        {
            T5cesPayment t5 = new T5cesPayment();
            t5.ShowDialog();
        }

        private void montasbeen2_Click(object sender, EventArgs e)
        {
            AddEntsabMoney addEntsab = new AddEntsabMoney();
            addEntsab.ShowDialog();
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            EditeClient eC = new EditeClient();
            eC.Show();
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            EditeSheeque eS = new EditeSheeque();
            eS.ShowDialog();
        }

        private void tanazol_Click(object sender, EventArgs e)
        {
            Tnazol tn = new Tnazol();
            tn.ShowDialog();
        }

        private void moqdemat_Click(object sender, EventArgs e)
        {
            Mo2damat mm = new Mo2damat();
            mm.ShowDialog();
        }

        private void sa7b_Click(object sender, EventArgs e)
        {
            UnitsBack ub = new UnitsBack();
            ub.ShowDialog();
        }

        private void bankAccounts_Click(object sender, EventArgs e)
        {
            BankTypes bt = new BankTypes();
            bt.ShowDialog();
        }

        private void addSheeq_Click(object sender, EventArgs e)
        {
            AddSheeq aS = new AddSheeq(-1);
            aS.ShowDialog();
        }

        private void transferUnit_Click(object sender, EventArgs e)
        {
            TransferUnit tu = new TransferUnit();
            tu.ShowDialog();
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            ConfigForm c = new ConfigForm();
            c.ShowDialog();
        }
       
        public bool found(String str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    return true;
            }
            return false;
        }

        public void addpriv()
        {
            #region PriviSection
            if (found(priv, '0'))
            {
                addEmployee.Enabled = true;
            }
            if (found(priv, '1'))
            {
                addUnits.Enabled = true;   
            }
            if (found(priv, '2'))
            {
                addNewUnit.Enabled = true;
            }
            if (found(priv, '3'))
            {
                addClient.Enabled = true;
            }
            if (found(priv, '4'))
            {
                reportAboutClient.Enabled = true;
            }
            if (found(priv, '5'))
            {
                gard.Enabled = true;
                MoneyByYearBtn.Enabled = true;
            }
            if (found(priv, '6'))
            {
                searchCHeques.Enabled = true;
            }
            if (found(priv, '7'))
            {
                searchQest.Enabled = true;
                manageEntsabAndFirstBtn.Enabled = true;
            }
            if (found(priv, '8'))
            {
                showCheque.Enabled = true;
            }
            if (found(priv, '9'))
            {
                ta5sees.Enabled = true;
            }
            if (found(priv, 'a'))
            {
                sadadTa5sees.Enabled = true;
                recivePaymebntBtn.Enabled = true;
            }
            if (found(priv, 'b'))
            {
                montasbeen.Enabled = true;
                managmentMoneyPayBtn.Enabled = true;
            }
            if (found(priv, 'c'))
            {
                editClients.Enabled = true;
            }
            if (found(priv, 'd'))
            {
                editCheques.Enabled = true;
            }
            if (found(priv, 'e'))
            {
                editQrst.Enabled = true;
            }
            if (found(priv, 'f'))
            {
                unitMas7ooba.Enabled = true;
            }
            if (found(priv, 'g'))
            {
                tanazol.Enabled = true;
            }
            if (found(priv, 'h'))
            {
                moqdemat.Enabled = true;
            }
            if (found(priv, 'i'))
            {
                sa7b.Enabled = true;
            }
            if (found(priv, 'j'))
            {
                payQest.Enabled = true;
            }
            if (found(priv, 'k'))
            {
                bankAccounts.Enabled = true;
            }
            if (found(priv, 'l'))
            {
                addSheeq.Enabled = true;
            }
            if (found(priv, 'm'))
            {
                transferUnit.Enabled = true;
            }
            if (found(priv, 'n'))
            {
                settings.Enabled = true;
            }



            #endregion
        }

        private void showSheecBtn_Click(object sender, EventArgs e)
        {
            showSheeqs ss = new showSheeqs();
            ss.ShowDialog();
        }

        private void add3_Click(object sender, EventArgs e)
        {
                AddEmployee addemp = new AddEmployee();
                addemp.ShowDialog();
        }

        private void NewClientBtn_Click(object sender, EventArgs e)
        {
            SellingOpreation sellingOpreationObj = new SellingOpreation();
            sellingOpreationObj.ShowDialog();
        }

        private void GardBtn_Click(object sender, EventArgs e)
        {
            Gard g = new Gard();
            g.ShowDialog();
        }

        private void AddNewItems_Click(object sender, EventArgs e)
        {
            AddNewItems add = new AddNewItems();
            add.ShowDialog();
        }

        private void SearchQestBtn_Click(object sender, EventArgs e)
        {
            SearchQest search = new SearchQest();
            search.ShowDialog();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            NewItem item = new NewItem();
            item.ShowDialog();
        }
        
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
           
                CheckOutList checkOut = new CheckOutList();
                checkOut.ShowDialog();
        }

        private void recivePaymebntBtn_Click(object sender, EventArgs e)
        {
            RecivePayments rePay = new RecivePayments();
            rePay.ShowDialog();
        }

        private void managmentMoneyPayBtn_Click(object sender, EventArgs e)
        {
            ManagmentPaymentForm manPay = new ManagmentPaymentForm();
            manPay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MontasbenMoneyManager obj = new MontasbenMoneyManager();
            obj.ShowDialog();
        }
        #endregion

        private void MoneyByYearBtn_Click(object sender, EventArgs e)
        {
            PaymentByYearReportFormManager obj = new PaymentByYearReportFormManager();
            obj.Show();
        }
    }
}
