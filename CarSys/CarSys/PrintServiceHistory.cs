﻿using System;
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
    public partial class PrintServiceHistory : Form
    {
        public PrintServiceHistory()
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

        private void ListCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomer nf = new ListCustomer();
            this.Close();
            nf.Show();

        }

        private void OpenCarAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCarAccount nf = new OpenCarAccount();
            this.Close();
            nf.Show();

        }

        private void RecordRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordRepair nf = new RecordRepair();
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

        private void PrintServiceHistory_Load(object sender, EventArgs e)
        {
            /* string NiallDB = "Data Source=Oracle;User Id=t00174406;Password=gnj374fg;";
            try
            {
                //Create an instance of an Oracle Connection
                OracleConnection conn = new OracleConnection(NiallDB);

                OracleCommand cmd = new OracleCommand("SELECT * FROM Accounts", conn);


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
                grdPrint.DataSource = ds.Tables["ss"];

                //dataGridView1.DataBind();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Found");
                MessageBox.Show(ex.Message);
            }*/
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MainMenu nf = new MainMenu();
            this.Close();
            nf.Show();
        }
      /*  private void SelectPrint()
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
                String strSQL = "SELECT * FROM Repairs WHERE RegNo = " + RegTxt.Text;


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
        }*/

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            getServHis(RegTxt.Text);
        }
        private void getServHis(String strDesc)
       {
            //Define database connection string
            String oradb = "Data Source=Oracle;User Id = t00174406;Password = gnj374fg;";

            OracleConnection conn = new OracleConnection(oradb);

            //define SQL query
            String strSQL = "SELECT * FROM Repairs WHERE RegNo LIKE '" +
                RegTxt.Text + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
            grdPrint.DataSource = ds.Tables["ss"];
            //grpAllStaff.Visible = true;
        }
    }
}
