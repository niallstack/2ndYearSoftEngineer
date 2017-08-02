namespace CarSys
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.mobTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.sNameTxt = new System.Windows.Forms.TextBox();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.Mob = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.custTxt = new System.Windows.Forms.TextBox();
            this.cust = new System.Windows.Forms.Label();
            this.dobTxt = new System.Windows.Forms.TextBox();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Accounts = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCarAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintServiceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Repairs = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncomeAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobTxt
            // 
            this.mobTxt.BackColor = System.Drawing.SystemColors.Info;
            this.mobTxt.Location = new System.Drawing.Point(213, 232);
            this.mobTxt.Name = "mobTxt";
            this.mobTxt.Size = new System.Drawing.Size(150, 20);
            this.mobTxt.TabIndex = 36;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.SystemColors.Info;
            this.emailTxt.Location = new System.Drawing.Point(213, 196);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(150, 20);
            this.emailTxt.TabIndex = 35;
            // 
            // sNameTxt
            // 
            this.sNameTxt.BackColor = System.Drawing.SystemColors.Info;
            this.sNameTxt.Location = new System.Drawing.Point(213, 125);
            this.sNameTxt.Name = "sNameTxt";
            this.sNameTxt.Size = new System.Drawing.Size(149, 20);
            this.sNameTxt.TabIndex = 33;
            // 
            // fNameTxt
            // 
            this.fNameTxt.BackColor = System.Drawing.SystemColors.Info;
            this.fNameTxt.Location = new System.Drawing.Point(213, 88);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(113, 20);
            this.fNameTxt.TabIndex = 32;
            this.fNameTxt.TextChanged += new System.EventHandler(this.custTxt_TextChanged);
            // 
            // Mob
            // 
            this.Mob.AutoSize = true;
            this.Mob.BackColor = System.Drawing.Color.Black;
            this.Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Mob.ForeColor = System.Drawing.SystemColors.Control;
            this.Mob.Location = new System.Drawing.Point(52, 235);
            this.Mob.Name = "Mob";
            this.Mob.Size = new System.Drawing.Size(75, 17);
            this.Mob.TabIndex = 31;
            this.Mob.Text = "Mobile No:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Black;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email.ForeColor = System.Drawing.SystemColors.Control;
            this.email.Location = new System.Drawing.Point(52, 199);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 17);
            this.email.TabIndex = 30;
            this.email.Text = "Email:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.Color.Black;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DOB.ForeColor = System.Drawing.SystemColors.Control;
            this.DOB.Location = new System.Drawing.Point(52, 163);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(151, 17);
            this.DOB.TabIndex = 29;
            this.DOB.Text = "DOB(DD-MMM-YYYY):";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.BackColor = System.Drawing.Color.Black;
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sname.ForeColor = System.Drawing.SystemColors.Control;
            this.Sname.Location = new System.Drawing.Point(52, 128);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(101, 17);
            this.Sname.TabIndex = 28;
            this.Sname.Text = "Second Name:";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.BackColor = System.Drawing.Color.Black;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Fname.ForeColor = System.Drawing.SystemColors.Control;
            this.Fname.Location = new System.Drawing.Point(52, 91);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(80, 17);
            this.Fname.TabIndex = 27;
            this.Fname.Text = "First Name:";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(180, 273);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(117, 29);
            this.Submit.TabIndex = 37;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // custTxt
            // 
            this.custTxt.BackColor = System.Drawing.SystemColors.Info;
            this.custTxt.Enabled = false;
            this.custTxt.Location = new System.Drawing.Point(213, 51);
            this.custTxt.Name = "custTxt";
            this.custTxt.Size = new System.Drawing.Size(62, 20);
            this.custTxt.TabIndex = 38;
            this.custTxt.TextChanged += new System.EventHandler(this.custTxt_TextChanged_1);
            // 
            // cust
            // 
            this.cust.AutoSize = true;
            this.cust.BackColor = System.Drawing.Color.Black;
            this.cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cust.ForeColor = System.Drawing.SystemColors.Control;
            this.cust.Location = new System.Drawing.Point(52, 54);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(53, 17);
            this.cust.TabIndex = 39;
            this.cust.Text = "CustID:";
            // 
            // dobTxt
            // 
            this.dobTxt.BackColor = System.Drawing.SystemColors.Info;
            this.dobTxt.Location = new System.Drawing.Point(213, 160);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(84, 20);
            this.dobTxt.TabIndex = 40;
            this.dobTxt.TextChanged += new System.EventHandler(this.dobTxt_TextChanged);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(439, 27);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(41, 39);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 41;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Staff,
            this.Customers,
            this.Accounts,
            this.Repairs});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(492, 24);
            this.MenuBar.TabIndex = 42;
            this.MenuBar.Text = "MenuStrip";
            // 
            // Staff
            // 
            this.Staff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStaffToolStripMenuItem,
            this.EditStaffToolStripMenuItem,
            this.RemoveStaffToolStripMenuItem,
            this.ListStaffToolStripMenuItem});
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(43, 20);
            this.Staff.Text = "Staff";
            // 
            // AddStaffToolStripMenuItem
            // 
            this.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem";
            this.AddStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.AddStaffToolStripMenuItem.Text = "Add Staff";
            this.AddStaffToolStripMenuItem.Click += new System.EventHandler(this.AddStaffToolStripMenuItem_Click_2);
            // 
            // EditStaffToolStripMenuItem
            // 
            this.EditStaffToolStripMenuItem.Name = "EditStaffToolStripMenuItem";
            this.EditStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.EditStaffToolStripMenuItem.Text = "Edit Staff";
            this.EditStaffToolStripMenuItem.Click += new System.EventHandler(this.EditStaffToolStripMenuItem_Click_1);
            // 
            // RemoveStaffToolStripMenuItem
            // 
            this.RemoveStaffToolStripMenuItem.Name = "RemoveStaffToolStripMenuItem";
            this.RemoveStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.RemoveStaffToolStripMenuItem.Text = "Remove Staff";
            this.RemoveStaffToolStripMenuItem.Click += new System.EventHandler(this.RemoveStaffToolStripMenuItem_Click_1);
            // 
            // ListStaffToolStripMenuItem
            // 
            this.ListStaffToolStripMenuItem.Name = "ListStaffToolStripMenuItem";
            this.ListStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ListStaffToolStripMenuItem.Text = "List Staff";
            this.ListStaffToolStripMenuItem.Click += new System.EventHandler(this.ListStaffToolStripMenuItem_Click_1);
            // 
            // Customers
            // 
            this.Customers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripMenuItem,
            this.EditCustomerToolStripMenuItem,
            this.RemoveCustomerToolStripMenuItem,
            this.ListCustomersToolStripMenuItem});
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(76, 20);
            this.Customers.Text = "Customers";
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.AddCustomerToolStripMenuItem.Text = "Add Customer";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click_1);
            // 
            // EditCustomerToolStripMenuItem
            // 
            this.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem";
            this.EditCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.EditCustomerToolStripMenuItem.Text = "Edit Customer";
            this.EditCustomerToolStripMenuItem.Click += new System.EventHandler(this.EditCustomerToolStripMenuItem_Click_1);
            // 
            // RemoveCustomerToolStripMenuItem
            // 
            this.RemoveCustomerToolStripMenuItem.Name = "RemoveCustomerToolStripMenuItem";
            this.RemoveCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.RemoveCustomerToolStripMenuItem.Text = "Remove Customer";
            this.RemoveCustomerToolStripMenuItem.Click += new System.EventHandler(this.RemoveCustomerToolStripMenuItem_Click_1);
            // 
            // ListCustomersToolStripMenuItem
            // 
            this.ListCustomersToolStripMenuItem.Name = "ListCustomersToolStripMenuItem";
            this.ListCustomersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ListCustomersToolStripMenuItem.Text = "List Customers";
            this.ListCustomersToolStripMenuItem.Click += new System.EventHandler(this.ListCustomersToolStripMenuItem_Click_1);
            // 
            // Accounts
            // 
            this.Accounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCarAccountToolStripMenuItem,
            this.PrintServiceHistoryToolStripMenuItem});
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(69, 20);
            this.Accounts.Text = "Accounts";
            // 
            // OpenCarAccountToolStripMenuItem
            // 
            this.OpenCarAccountToolStripMenuItem.Name = "OpenCarAccountToolStripMenuItem";
            this.OpenCarAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenCarAccountToolStripMenuItem.Text = "Open Car Account";
            this.OpenCarAccountToolStripMenuItem.Click += new System.EventHandler(this.OpenCarAccountToolStripMenuItem_Click_1);
            // 
            // PrintServiceHistoryToolStripMenuItem
            // 
            this.PrintServiceHistoryToolStripMenuItem.Name = "PrintServiceHistoryToolStripMenuItem";
            this.PrintServiceHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PrintServiceHistoryToolStripMenuItem.Text = "Print Service History";
            this.PrintServiceHistoryToolStripMenuItem.Click += new System.EventHandler(this.PrintServiceHistoryToolStripMenuItem_Click_1);
            // 
            // Repairs
            // 
            this.Repairs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordRepairToolStripMenuItem,
            this.CompleteRepairToolStripMenuItem,
            this.IncomeAnalysisToolStripMenuItem});
            this.Repairs.Name = "Repairs";
            this.Repairs.Size = new System.Drawing.Size(57, 20);
            this.Repairs.Text = "Repairs";
            // 
            // RecordRepairToolStripMenuItem
            // 
            this.RecordRepairToolStripMenuItem.Name = "RecordRepairToolStripMenuItem";
            this.RecordRepairToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RecordRepairToolStripMenuItem.Text = "Record Repair";
            this.RecordRepairToolStripMenuItem.Click += new System.EventHandler(this.RecordRepairToolStripMenuItem_Click_1);
            // 
            // CompleteRepairToolStripMenuItem
            // 
            this.CompleteRepairToolStripMenuItem.Name = "CompleteRepairToolStripMenuItem";
            this.CompleteRepairToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CompleteRepairToolStripMenuItem.Text = "Complete Repair";
            this.CompleteRepairToolStripMenuItem.Click += new System.EventHandler(this.CompleteRepairToolStripMenuItem_Click_1);
            // 
            // IncomeAnalysisToolStripMenuItem
            // 
            this.IncomeAnalysisToolStripMenuItem.Name = "IncomeAnalysisToolStripMenuItem";
            this.IncomeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.IncomeAnalysisToolStripMenuItem.Text = "Income Analysis";
            this.IncomeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.IncomeAnalysisToolStripMenuItem_Click_1);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 341);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.dobTxt);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.custTxt);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.mobTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.sNameTxt);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.Mob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Fname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox mobTxt;
        internal System.Windows.Forms.TextBox emailTxt;
        internal System.Windows.Forms.TextBox sNameTxt;
        internal System.Windows.Forms.TextBox fNameTxt;
        internal System.Windows.Forms.Label Mob;
        internal System.Windows.Forms.Label email;
        internal System.Windows.Forms.Label DOB;
        internal System.Windows.Forms.Label Sname;
        internal System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox custTxt;
        internal System.Windows.Forms.Label cust;
        internal System.Windows.Forms.TextBox dobTxt;
        private System.Windows.Forms.PictureBox HomeBtn;
        internal System.Windows.Forms.MenuStrip MenuBar;
        internal System.Windows.Forms.ToolStripMenuItem Staff;
        internal System.Windows.Forms.ToolStripMenuItem AddStaffToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditStaffToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveStaffToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ListStaffToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Customers;
        internal System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditCustomerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveCustomerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ListCustomersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Accounts;
        internal System.Windows.Forms.ToolStripMenuItem OpenCarAccountToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PrintServiceHistoryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Repairs;
        internal System.Windows.Forms.ToolStripMenuItem RecordRepairToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CompleteRepairToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem IncomeAnalysisToolStripMenuItem;
    }
}