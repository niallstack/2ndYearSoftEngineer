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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            StaffTxt.MaxLength = 4;
            SFnameTxt.MaxLength = 15;
            SSnameTxt.MaxLength = 35;
            SFnameTxt.MaxLength = 15;
            SEmailTxt.MaxLength = 35;
            SMobTxt.MaxLength = 18;
            string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Staff", conn);


                //Create an instance of an Oracle Command to be executed on
                //the connection string conn
                //string strSQL = "SELECT * FROM Staff, Description FROM Staff ORDER BY StaffID";
                //OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                //Create a data adapter to contain the results of the query
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Create a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Bind the DataGridView to the results (contents of the dataset)
                grdStaff.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }
            //FillGrid("StaffId"); 
        }
        /*private void FillGrid(string sortStaff)
        {
            string oradb = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                //define SQL query
                string strSQL = "SELECT * FROM Staff ORDER BY " + sortStaff;

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                grdStaff.DataSource = ds.Tables["ss"];
                // dataGridView1.DataBind();
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void optStaffId_Click(object sender, EventArgs e)
        {
            FillGrid("StaffId");
        }
        private void optName_Click(object sender, EventArgs e)
        {
            FillGrid("Name");
        }*/
      /*  private void grdStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //set column index on grid to 0 and retrieve cell value

            string strSno = grdStaff.Rows[grdStaff.CurrentCell.RowIndex].Cells[0].Value.ToString();



            //using StockNo selected in grid, retrieve details for this stock item
            getStaff(strSno);

            grpStaff.Visible = true;
            //grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value);
            //txtStockNo.Text = grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //txtStockNo.Text = grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[grdStock.CurrentCell.ColumnIndex].Value.ToString();


        }
        private void getStaff(string sno)
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //define SQL query
                strSQL = "SELECT * FROM Staff WHERE StafId = " + sno;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();

                StaffTxt.Text = dr.GetValue(0).ToString();
                SFnameTxt.Text = dr.GetValue(1).ToString();
                SSnameTxt.Text = dr.GetValue(2).ToString();
                SDobTxt.Text = dr.GetValue(3).ToString();
                SEmailTxt.Text = dr.GetValue(4).ToString();
                SMobTxt.Text = dr.GetValue(5).ToString();

                //display the details on the form
                grpStock.Visible = true;
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void btnAmend_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtDesc.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();

            }

            //Connect to Database
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            //Define SQL Query (UPDATE)
            strSQL = "UPDATE Stock SET Description = '" + txtDesc.Text +
                "', CostPrice = " + txtCostPrice.Text +
                ", SalePrice = " + txtSalePrice.Text + " WHERE StockNo = " + txtStockNo.Text;

            cmd.CommandText = strSQL;

            //Execute SQL Query
            cmd.ExecuteNonQuery();

            //Close Database
            conn.Close();

            //Display confirmation message
            MessageBox.Show("Stock Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGrid("StockNo");
            //Clear the form
            grpStock.Visible = false;

        }*/

        private void Edit_Click(object sender, EventArgs e)
        {
            UpdateStaff();

            //display confirmation message
            MessageBox.Show("Staff Member Updated");
           /* var confirmResult = MessageBox.Show("Are These The Correct Details?", "Edit", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                new MainMenu().Show();
            }*/

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

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MainMenu nf = new MainMenu();
            this.Close();
            nf.Show();
        }

        private void grdStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffIdbtn_Click(object sender, EventArgs e)
        {
            string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Staff ORDER By StaffId", conn);


                //Create an instance of an Oracle Command to be executed on
                //the connection string conn
                //string strSQL = "SELECT * FROM Staff, Description FROM Staff ORDER BY StaffID";
                //OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                //Create a data adapter to contain the results of the query
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Create a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Bind the DataGridView to the results (contents of the dataset)
                grdStaff.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }
        }

        private void Namebtn_Click(object sender, EventArgs e)
        {
            string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Staff ORDER BY Surname", conn);


                //Create an instance of an Oracle Command to be executed on
                //the connection string conn
                //string strSQL = "SELECT * FROM Staff, Description FROM Staff ORDER BY StaffID";
                //OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Specify that the command type is a string
                cmd.CommandType = CommandType.Text;

                //Create a data adapter to contain the results of the query
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Create a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Bind the DataGridView to the results (contents of the dataset)
                grdStaff.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }
        }
        private void getStaff(int intStaffNo)
        {
            try
            {
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id = t00174406;Password = gnj374fg;";

                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //define SQL query
                String strSQL = "SELECT * FROM Staff WHERE StaffID = " + intStaffNo;
                cmd.CommandText = strSQL;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    StaffTxt.Text = dr.GetValue(0).ToString();
                    SFnameTxt.Text = dr.GetValue(1).ToString();
                    SSnameTxt.Text = dr.GetValue(2).ToString();
                    SDobTxt.Text = dr.GetValue(3).ToString();
                    SEmailTxt.Text = dr.GetValue(4).ToString();
                    SMobTxt.Text = dr.GetValue(5).ToString();

                    //display the details on the form
                   // grpStaff.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Details Found");
                    //txtSearchID.Focus();
                    return;
                }

                //Close DB connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateStaff()
        {

            try
            {
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id = t00174406;Password = gnj374fg;";

                //Connect to Database
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //Define SQL Query (UPDATE)
                String strSQL = "UPDATE Staff SET Surname = '" + SSnameTxt.Text +
                    "', Forename = '" + SFnameTxt.Text +
                    "', DOB = '" + SDobTxt.Text +
                    "', Email = '" + SEmailTxt.Text + "', PhoneNo = '" + SMobTxt.Text +
                    "' WHERE StaffID = " + StaffTxt.Text;


                //Execute SQL Query


                //OracleCommand cmd = new OracleCommand(strSQL, conn); 
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                //Close Database
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void StaffTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StffId_Click(object sender, EventArgs e)
        {

        }

        private void Fname_Click(object sender, EventArgs e)
        {

        }

        private void SFnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdStaff_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SSnameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sname_Click(object sender, EventArgs e)
        {

        }

        private void DOB_Click(object sender, EventArgs e)
        {

        }

        private void SDobTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SEmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void Mob_Click(object sender, EventArgs e)
        {

        }

        private void SMobTxt_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
