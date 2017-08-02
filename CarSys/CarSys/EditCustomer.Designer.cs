namespace CarSys
{
    partial class EditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
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
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.Namebtn = new System.Windows.Forms.Button();
            this.StaffIdbtn = new System.Windows.Forms.Button();
            this.Custid = new System.Windows.Forms.Label();
            this.CustTxt = new System.Windows.Forms.TextBox();
            this.SSnameTxt = new System.Windows.Forms.TextBox();
            this.SFnameTxt = new System.Windows.Forms.TextBox();
            this.Sname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.SDobTxt = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.SEmailTxt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.Editbtn = new System.Windows.Forms.Button();
            this.SMobTxt = new System.Windows.Forms.TextBox();
            this.Mob = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
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
            this.MenuBar.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuBar.Size = new System.Drawing.Size(1310, 35);
            this.MenuBar.TabIndex = 6;
            this.MenuBar.Text = "MenuStrip1";
            // 
            // Staff
            // 
            this.Staff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStaffToolStripMenuItem,
            this.EditStaffToolStripMenuItem,
            this.RemoveStaffToolStripMenuItem,
            this.ListStaffToolStripMenuItem});
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(61, 29);
            this.Staff.Text = "Staff";
            // 
            // AddStaffToolStripMenuItem
            // 
            this.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem";
            this.AddStaffToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.AddStaffToolStripMenuItem.Text = "Add Staff";
            this.AddStaffToolStripMenuItem.Click += new System.EventHandler(this.AddStaffToolStripMenuItem_Click);
            // 
            // EditStaffToolStripMenuItem
            // 
            this.EditStaffToolStripMenuItem.Name = "EditStaffToolStripMenuItem";
            this.EditStaffToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.EditStaffToolStripMenuItem.Text = "Edit Staff";
            this.EditStaffToolStripMenuItem.Click += new System.EventHandler(this.EditStaffToolStripMenuItem_Click);
            // 
            // RemoveStaffToolStripMenuItem
            // 
            this.RemoveStaffToolStripMenuItem.Name = "RemoveStaffToolStripMenuItem";
            this.RemoveStaffToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.RemoveStaffToolStripMenuItem.Text = "Remove Staff";
            this.RemoveStaffToolStripMenuItem.Click += new System.EventHandler(this.RemoveStaffToolStripMenuItem_Click);
            // 
            // ListStaffToolStripMenuItem
            // 
            this.ListStaffToolStripMenuItem.Name = "ListStaffToolStripMenuItem";
            this.ListStaffToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.ListStaffToolStripMenuItem.Text = "List Staff";
            this.ListStaffToolStripMenuItem.Click += new System.EventHandler(this.ListStaffToolStripMenuItem_Click);
            // 
            // Customers
            // 
            this.Customers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripMenuItem,
            this.EditCustomerToolStripMenuItem,
            this.RemoveCustomerToolStripMenuItem,
            this.ListCustomersToolStripMenuItem});
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(109, 29);
            this.Customers.Text = "Customers";
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.AddCustomerToolStripMenuItem.Text = "Add Customer";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // EditCustomerToolStripMenuItem
            // 
            this.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem";
            this.EditCustomerToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.EditCustomerToolStripMenuItem.Text = "Edit Customer";
            this.EditCustomerToolStripMenuItem.Click += new System.EventHandler(this.EditCustomerToolStripMenuItem_Click);
            // 
            // RemoveCustomerToolStripMenuItem
            // 
            this.RemoveCustomerToolStripMenuItem.Name = "RemoveCustomerToolStripMenuItem";
            this.RemoveCustomerToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.RemoveCustomerToolStripMenuItem.Text = "Remove Customer";
            this.RemoveCustomerToolStripMenuItem.Click += new System.EventHandler(this.RemoveCustomerToolStripMenuItem_Click);
            // 
            // ListCustomersToolStripMenuItem
            // 
            this.ListCustomersToolStripMenuItem.Name = "ListCustomersToolStripMenuItem";
            this.ListCustomersToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.ListCustomersToolStripMenuItem.Text = "List Customers";
            this.ListCustomersToolStripMenuItem.Click += new System.EventHandler(this.ListCustomersToolStripMenuItem_Click);
            // 
            // Accounts
            // 
            this.Accounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCarAccountToolStripMenuItem,
            this.PrintServiceHistoryToolStripMenuItem});
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(97, 29);
            this.Accounts.Text = "Accounts";
            // 
            // OpenCarAccountToolStripMenuItem
            // 
            this.OpenCarAccountToolStripMenuItem.Name = "OpenCarAccountToolStripMenuItem";
            this.OpenCarAccountToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.OpenCarAccountToolStripMenuItem.Text = "Open Car Account";
            this.OpenCarAccountToolStripMenuItem.Click += new System.EventHandler(this.OpenCarAccountToolStripMenuItem_Click);
            // 
            // PrintServiceHistoryToolStripMenuItem
            // 
            this.PrintServiceHistoryToolStripMenuItem.Name = "PrintServiceHistoryToolStripMenuItem";
            this.PrintServiceHistoryToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.PrintServiceHistoryToolStripMenuItem.Text = "Print Service History";
            this.PrintServiceHistoryToolStripMenuItem.Click += new System.EventHandler(this.PrintServiceHistoryToolStripMenuItem_Click);
            // 
            // Repairs
            // 
            this.Repairs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecordRepairToolStripMenuItem,
            this.CompleteRepairToolStripMenuItem,
            this.IncomeAnalysisToolStripMenuItem});
            this.Repairs.Name = "Repairs";
            this.Repairs.Size = new System.Drawing.Size(82, 29);
            this.Repairs.Text = "Repairs";
            // 
            // RecordRepairToolStripMenuItem
            // 
            this.RecordRepairToolStripMenuItem.Name = "RecordRepairToolStripMenuItem";
            this.RecordRepairToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.RecordRepairToolStripMenuItem.Text = "Record Repair";
            this.RecordRepairToolStripMenuItem.Click += new System.EventHandler(this.RecordRepairToolStripMenuItem_Click);
            // 
            // CompleteRepairToolStripMenuItem
            // 
            this.CompleteRepairToolStripMenuItem.Name = "CompleteRepairToolStripMenuItem";
            this.CompleteRepairToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.CompleteRepairToolStripMenuItem.Text = "Complete Repair";
            this.CompleteRepairToolStripMenuItem.Click += new System.EventHandler(this.CompleteRepairToolStripMenuItem_Click);
            // 
            // IncomeAnalysisToolStripMenuItem
            // 
            this.IncomeAnalysisToolStripMenuItem.Name = "IncomeAnalysisToolStripMenuItem";
            this.IncomeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.IncomeAnalysisToolStripMenuItem.Text = "Income Analysis";
            this.IncomeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.IncomeAnalysisToolStripMenuItem_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(1235, 40);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(62, 60);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 71;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Location = new System.Drawing.Point(267, 122);
            this.grdCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.Size = new System.Drawing.Size(910, 302);
            this.grdCustomer.TabIndex = 78;
            // 
            // Namebtn
            // 
            this.Namebtn.Location = new System.Drawing.Point(45, 208);
            this.Namebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Namebtn.Name = "Namebtn";
            this.Namebtn.Size = new System.Drawing.Size(141, 54);
            this.Namebtn.TabIndex = 82;
            this.Namebtn.Text = "Name";
            this.Namebtn.UseVisualStyleBackColor = true;
            this.Namebtn.Click += new System.EventHandler(this.Namebtn_Click);
            // 
            // StaffIdbtn
            // 
            this.StaffIdbtn.Location = new System.Drawing.Point(45, 122);
            this.StaffIdbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffIdbtn.Name = "StaffIdbtn";
            this.StaffIdbtn.Size = new System.Drawing.Size(141, 54);
            this.StaffIdbtn.TabIndex = 81;
            this.StaffIdbtn.Text = "StaffId";
            this.StaffIdbtn.UseVisualStyleBackColor = true;
            this.StaffIdbtn.Click += new System.EventHandler(this.StaffIdbtn_Click);
            // 
            // Custid
            // 
            this.Custid.AutoSize = true;
            this.Custid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Custid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Custid.ForeColor = System.Drawing.SystemColors.Control;
            this.Custid.Location = new System.Drawing.Point(430, 495);
            this.Custid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Custid.Name = "Custid";
            this.Custid.Size = new System.Drawing.Size(74, 25);
            this.Custid.TabIndex = 84;
            this.Custid.Text = "StaffId:";
            // 
            // CustTxt
            // 
            this.CustTxt.BackColor = System.Drawing.SystemColors.Info;
            this.CustTxt.ForeColor = System.Drawing.Color.Black;
            this.CustTxt.Location = new System.Drawing.Point(582, 494);
            this.CustTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustTxt.Name = "CustTxt";
            this.CustTxt.Size = new System.Drawing.Size(300, 26);
            this.CustTxt.TabIndex = 83;
            // 
            // SSnameTxt
            // 
            this.SSnameTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SSnameTxt.Location = new System.Drawing.Point(581, 589);
            this.SSnameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SSnameTxt.Name = "SSnameTxt";
            this.SSnameTxt.Size = new System.Drawing.Size(356, 26);
            this.SSnameTxt.TabIndex = 88;
            // 
            // SFnameTxt
            // 
            this.SFnameTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SFnameTxt.Location = new System.Drawing.Point(582, 541);
            this.SFnameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SFnameTxt.Name = "SFnameTxt";
            this.SFnameTxt.Size = new System.Drawing.Size(300, 26);
            this.SFnameTxt.TabIndex = 87;
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sname.ForeColor = System.Drawing.SystemColors.Control;
            this.Sname.Location = new System.Drawing.Point(430, 590);
            this.Sname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(143, 25);
            this.Sname.TabIndex = 86;
            this.Sname.Text = "Second Name:";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Fname.ForeColor = System.Drawing.SystemColors.Control;
            this.Fname.Location = new System.Drawing.Point(430, 542);
            this.Fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(112, 25);
            this.Fname.TabIndex = 85;
            this.Fname.Text = "First Name:";
            // 
            // SDobTxt
            // 
            this.SDobTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SDobTxt.Location = new System.Drawing.Point(581, 636);
            this.SDobTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SDobTxt.Name = "SDobTxt";
            this.SDobTxt.Size = new System.Drawing.Size(284, 26);
            this.SDobTxt.TabIndex = 90;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DOB.ForeColor = System.Drawing.SystemColors.Control;
            this.DOB.Location = new System.Drawing.Point(430, 637);
            this.DOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(61, 25);
            this.DOB.TabIndex = 89;
            this.DOB.Text = "DOB:";
            // 
            // SEmailTxt
            // 
            this.SEmailTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SEmailTxt.Location = new System.Drawing.Point(582, 684);
            this.SEmailTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SEmailTxt.Name = "SEmailTxt";
            this.SEmailTxt.Size = new System.Drawing.Size(421, 26);
            this.SEmailTxt.TabIndex = 92;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email.ForeColor = System.Drawing.SystemColors.Control;
            this.email.Location = new System.Drawing.Point(430, 685);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(66, 25);
            this.email.TabIndex = 91;
            this.email.Text = "Email:";
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(654, 809);
            this.Editbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(176, 45);
            this.Editbtn.TabIndex = 95;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // SMobTxt
            // 
            this.SMobTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SMobTxt.Location = new System.Drawing.Point(582, 735);
            this.SMobTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SMobTxt.Name = "SMobTxt";
            this.SMobTxt.Size = new System.Drawing.Size(380, 26);
            this.SMobTxt.TabIndex = 94;
            // 
            // Mob
            // 
            this.Mob.AutoSize = true;
            this.Mob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Mob.ForeColor = System.Drawing.SystemColors.Control;
            this.Mob.Location = new System.Drawing.Point(430, 736);
            this.Mob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mob.Name = "Mob";
            this.Mob.Size = new System.Drawing.Size(106, 25);
            this.Mob.TabIndex = 93;
            this.Mob.Text = "Mobile No:";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1310, 1039);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.SMobTxt);
            this.Controls.Add(this.Mob);
            this.Controls.Add(this.SEmailTxt);
            this.Controls.Add(this.email);
            this.Controls.Add(this.SDobTxt);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.SSnameTxt);
            this.Controls.Add(this.SFnameTxt);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Custid);
            this.Controls.Add(this.CustTxt);
            this.Controls.Add(this.Namebtn);
            this.Controls.Add(this.StaffIdbtn);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox HomeBtn;
        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.Button Namebtn;
        private System.Windows.Forms.Button StaffIdbtn;
        internal System.Windows.Forms.Label Custid;
        internal System.Windows.Forms.TextBox CustTxt;
        internal System.Windows.Forms.TextBox SSnameTxt;
        internal System.Windows.Forms.TextBox SFnameTxt;
        internal System.Windows.Forms.Label Sname;
        internal System.Windows.Forms.Label Fname;
        internal System.Windows.Forms.TextBox SDobTxt;
        internal System.Windows.Forms.Label DOB;
        internal System.Windows.Forms.TextBox SEmailTxt;
        internal System.Windows.Forms.Label email;
        private System.Windows.Forms.Button Editbtn;
        internal System.Windows.Forms.TextBox SMobTxt;
        internal System.Windows.Forms.Label Mob;
    }
}