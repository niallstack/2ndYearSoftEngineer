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
    public partial class OpenCarAccount : Form
    {
        public OpenCarAccount()
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

        private void PrintServiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintServiceHistory nf = new PrintServiceHistory();
            this.Close();
            nf.Show();

        }

        private void Repairs_Click(object sender, EventArgs e)
        {

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

        private void OpenCarAccount_Load(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MainMenu nf = new MainMenu();
            this.Close();
            nf.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           /* if (RegTxt.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegTxt.Focus();
                return;
            }*/
            try
            {
                String NiallDB = "Data Source=Oracle;User Id = t00174406;Password = gnj374fg;";
                OracleConnection conn = new OracleConnection(NiallDB);

                String strSQL = "INSERT INTO Accounts VALUES ('" + RegTxt.Text + "'," + CustTxt.Text +
                ",'" + MakeTxt.Text + "','" + ModelTxt.Text + "','" + TansmissionTxt.Text + "','" + 
                FuelTxt.Text + "'," + EngineTxt.Text + ",'" + ColourTxt.Text + "')";

                //MessageBox.Show(strSQL);

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

            MessageBox.Show("Account Added", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
