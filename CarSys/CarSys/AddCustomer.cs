using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace CarSys
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void getNextCustIdNo()
        {
            try
            {
                String NiallDB = "Data Source=Oracle; User ID=t00174406; password=gnj374fg";
                OracleConnection conn = new OracleConnection(NiallDB);
                OracleCommand cmd = new OracleCommand("SELECT MAX(CustId) FROM Customer", conn);

                conn.Open();

                if (cmd.ExecuteScalar().ToString().Equals(""))
                {
                    custTxt.Text = String.Format("1", "0000");
                }
                else
                {
                    custTxt.Text = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");
                }
                conn.Close(); 
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //new MainMenu().Show();
            //this.Hide();
            if (custTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                custTxt.Focus();
                return;
            }
            if (fNameTxt.Text == "")
            {
                MessageBox.Show("The first name field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fNameTxt.Focus();
                return;
            }
            if (sNameTxt.Text == "")
            {
                MessageBox.Show("The second name field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sNameTxt.Focus();
                return;
            }
            if (dobTxt.Text == "")
            {
                MessageBox.Show("The date of birth field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dobTxt.Focus();
                return;
            }
            if (mobTxt.Text == "")
            {
                MessageBox.Show("The mobile number field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mobTxt.Focus();
                return;
            }
            try
            {
                String NiallDB = "Data Source=Oracle;User Id = t00174406;Password = gnj374fg;";
                OracleConnection conn = new OracleConnection(NiallDB);

                String strSQL = "INSERT INTO Customer VALUES (" + custTxt.Text + ",'" + fNameTxt.Text +
                "','" + sNameTxt.Text + "','" + dobTxt.Text + "','" + emailTxt.Text + "','" + mobTxt.Text + "')";

               // MessageBox.Show(strSQL);

                conn.Open();

                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Customer Added", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);



            getNextCustIdNo();
        }

        private void AddStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddStaff nf = new AddStaff();
            this.Close();
            nf.Show();
            
        }

        private void EditStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStaff nf = new EditStaff();
            this.Close();
            nf.Show();
            
        }

        private void RemoveStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStaff nf = new RemoveStaff();
            this.Close();
            nf.Show(); 
            
        }

        private void ListStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStaff nf = new ListStaff();
            this.Close();
            nf.Show();
            
        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer nf = new AddCustomer();
            this.Close();
            nf.Show();
            
        }

        private void EditCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomer nf = new EditCustomer();
            this.Close();
            nf.Show();
            
        }

        private void RemoveCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCustomer nf = new RemoveCustomer();
            this.Close();
            nf.Show();
            
        }

        private void OpenCarAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCarAccount nf = new OpenCarAccount();
            this.Close();
            nf.Show();
            
        }

        private void ListCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomer nf = new ListCustomer();
            this.Close();
            nf.Show();
          
        }

        private void PrintServiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintServiceHistory nf = new PrintServiceHistory();
            this.Close();
            nf.Show();
            
        }

       

        

       

        private void CompleteRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteRepair nf = new CompleteRepair();
            this.Close();
            nf.Show();
           
        }
        
        

        private void IncomeAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeAnalysis nf = new IncomeAnalysis();
            this.Close();
            nf.Show();
            
        }


        private void AddCustomer_Load(object sender, EventArgs e)
        {
            getNextCustIdNo();
            fNameTxt.MaxLength = 15;
            sNameTxt.MaxLength = 35;
            emailTxt.MaxLength = 35;
            mobTxt.MaxLength = 18;
        }

        private void MenuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void custTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MainMenu nf = new MainMenu();
            this.Close();
            nf.Show();
        }

        private void RecordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuBar_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //IGNORE!!
        }

        private void AddStaffToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            AddStaff nf = new AddStaff();
            this.Close();
            nf.Show();
        }

        private void EditStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditStaff nf = new EditStaff();
            this.Close();
            nf.Show();
        }

        private void RemoveStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RemoveStaff nf = new RemoveStaff();
            this.Close();
            nf.Show();
        }

        private void ListStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListStaff nf = new ListStaff();
            this.Close();
            nf.Show();
        }

        private void AddCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddCustomer nf = new AddCustomer();
            this.Close();
            nf.Show();
        }

        private void EditCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditCustomer nf = new EditCustomer();
            this.Close();
            nf.Show();
        }

        private void RemoveCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RemoveCustomer nf = new RemoveCustomer();
            this.Close();
            nf.Show();
        }

        private void ListCustomersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListCustomer nf = new ListCustomer();
            this.Close();
            nf.Show();
        }

        private void OpenCarAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenCarAccount nf = new OpenCarAccount();
            this.Close();
            nf.Show();
        }

        private void PrintServiceHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintServiceHistory nf = new PrintServiceHistory();
            this.Close();
            nf.Show();
        }

        private void RecordRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RecordRepair nf = new RecordRepair();
            this.Close();
            nf.Show();
        }

        

        private void CompleteRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CompleteRepair nf = new CompleteRepair();
            this.Close();
            nf.Show();
        }

       

        private void IncomeAnalysisToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IncomeAnalysis nf = new IncomeAnalysis();
            this.Close();
            nf.Show();

        }

        private void custTxt_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dobTxt_TextChanged(object sender, EventArgs e)
        {

        }

        
       
    }
}
