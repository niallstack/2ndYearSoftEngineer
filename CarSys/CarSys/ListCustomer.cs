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
    public partial class ListCustomer : Form
    {
        public ListCustomer()
        {
            InitializeComponent();
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

        private void Customers_Click(object sender, EventArgs e)
        {

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


        private void ListCustomer_Load(object sender, EventArgs e)
        {
            string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Customer", conn);


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
                grdCustomer.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }
           /* string oradb = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Creating an instance of an oracle Connection
                OracleConnection conn = new OracleConnection(oradb);


                //Creating an instance of an Oracle Command to be executed on the connection
                OracleCommand cmd = new OracleCommand("SELECT * FROM Customer", conn);

                //Specifing the command type here as a String
                cmd.CommandType = CommandType.Text;
                conn.Open();

                //Creating a data adapter to contain the results
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Creating a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Binding the dataDridView to the results
                grdCustomer.DataSource = ds.Tables["cc"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Found");
                MessageBox.Show(ex.Message);
            }*/
        }
        /*private void FillGrid(string sortCust)
        {
            string oradb = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                //define SQL query
                string strSQL = "SELECT * FROM Customer "; //ORDER BY " + sortCust;

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                grdCustomer.DataSource = ds.Tables["ss"];
                // dataGridView1.DataBind();
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }
        private void optCustId_Click(object sender, EventArgs e)
        {
            FillGrid("CustId");
        }
        private void optCName_Click(object sender, EventArgs e)
        {
            FillGrid("Name");
        }*/
      /*  private void FillGrid(string sortCust)
        {
            string oradb = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                OracleConnection conn = new OracleConnection(oradb);

                //define SQL query
                string strSQL = "SELECT * FROM Customer ORDER BY " + sortCust;

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.CommandType = CommandType.Text;
                conn.Open();
                da.Fill(ds, "ss");
                grdCustomer.DataSource = ds.Tables["ss"];
                // dataGridView1.DataBind();
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }*/
       /* private void optCustId_Click(object sender, EventArgs e)
        {
            FillGrid("CustId");
        }
        private void optCname_Click(object sender, EventArgs e)
        {
            FillGrid("Cname");
        }*/

        private void ListCustomer_Load_1(object sender, EventArgs e)
        {
            string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Customer", conn);


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
                grdCustomer.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }
            /*string oradb = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Creating an instance of an oracle Connection
                OracleConnection conn = new OracleConnection(oradb);


                //Creating an instance of an Oracle Command to be executed on the connection
                OracleCommand cmd = new OracleCommand("SELECT * FROM Customer", conn);

                //Specifing the command type here as a String
                cmd.CommandType = CommandType.Text;
                conn.Open();

                //Creating a data adapter to contain the results
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Creating a dataset to hold the records returned by the query
                DataSet ds = new DataSet();

                //Fill the dataset with the contents of the data adapter
                da.Fill(ds, "ss");

                //Binding the dataDridView to the results
                grdCustomer.DataSource = ds.Tables["cc"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Records Found");
                MessageBox.Show(ex.Message);
            }*/
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MainMenu nf = new MainMenu();
            this.Close();
            nf.Show();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustIdbtn_Click(object sender, EventArgs e)
        {
            string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Customer ORDER BY CustId", conn);


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
                grdCustomer.DataSource = ds.Tables["ss"];

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

                OracleCommand cmd = new OracleCommand("SELECT * FROM Customer ORDER BY CSurname", conn);


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
                grdCustomer.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
