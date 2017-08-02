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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        private void getNextStaffIdNo()
        {
            try
            {
                String NiallDB = "Data Source=Oracle; User ID=t00174406; password=gnj374fg";
                OracleConnection conn = new OracleConnection(NiallDB);
                OracleCommand cmd = new OracleCommand("SELECT MAX(StaffId) FROM Staff", conn);

                conn.Open();

                if (cmd.ExecuteScalar().ToString().Equals(""))
                {
                    StaffTxt.Text = String.Format("1", "0000");
                }
                else
                {
                    StaffTxt.Text = String.Format(((decimal)cmd.ExecuteScalar() + 1).ToString(), "0000");
                }
                conn.Close(); 
            }
            catch(OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
           // new MainMenu().Show();
            //this.Hide();

            if (StaffTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StaffTxt.Focus();
                return;
            }
            if (SFnameTxt.Text == "")
            {
                MessageBox.Show("The first name field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SFnameTxt.Focus();
                return;
            }
            if (SSnameTxt.Text == "")
            {
                MessageBox.Show("The second name field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SSnameTxt.Focus();
                return;
            }
            if (SDobTxt.Text == "")
            {
                MessageBox.Show("The date of birth field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SDobTxt.Focus();
                return;
            }
            if (SMobTxt.Text == "")
            {
                MessageBox.Show("The mobile number field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SMobTxt.Focus();
                return;
            }

            
            try
            {
                String NiallDB = "Data Source=Oracle;User Id = t00174406;Password = gnj374fg;";
                OracleConnection conn = new OracleConnection(NiallDB);

                String strSQL = "INSERT INTO Staff VALUES (" + StaffTxt.Text + ",'" + SFnameTxt.Text +
                "','" + SSnameTxt.Text + "','" + SDobTxt.Text + "','" + SEmailTxt.Text + "','" + SMobTxt.Text + "')";

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
            MessageBox.Show("Staff Added", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getNextStaffIdNo();
            clear();
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

        private void RecordRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordRepair nf = new RecordRepair();
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


        private void AddStaff_Load(object sender, EventArgs e)
        {
            getNextStaffIdNo();
            SFnameTxt.MaxLength = 15;
            SSnameTxt.MaxLength = 35;
            SFnameTxt.MaxLength = 15;
            SEmailTxt.MaxLength = 35;
            SMobTxt.MaxLength = 18;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu nf = new MainMenu();
            this.Close();
            nf.Show();
        }

        private void SFnameTxt_TextChanged(object sender, EventArgs e)
        {
            TextBox SFnameTxt = new TextBox();
            // Set the maximum length of text in the control to eight.
            SFnameTxt.MaxLength = 15;
        }
        private void clear()
        {
            SFnameTxt.Text = String.Empty;
        }
    }
}
