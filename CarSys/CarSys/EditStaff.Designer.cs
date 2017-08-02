namespace CarSys
{
    partial class EditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStaff));
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
            this.SMobTxt = new System.Windows.Forms.TextBox();
            this.SEmailTxt = new System.Windows.Forms.TextBox();
            this.SSnameTxt = new System.Windows.Forms.TextBox();
            this.SFnameTxt = new System.Windows.Forms.TextBox();
            this.Mob = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.Editbtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.StaffTxt = new System.Windows.Forms.TextBox();
            this.StffId = new System.Windows.Forms.Label();
            this.SDobTxt = new System.Windows.Forms.TextBox();
            this.grdStaff = new System.Windows.Forms.DataGridView();
            this.Namebtn = new System.Windows.Forms.Button();
            this.StaffIdbtn = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaff)).BeginInit();
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
            this.MenuBar.Size = new System.Drawing.Size(873, 24);
            this.MenuBar.TabIndex = 3;
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
            this.Staff.Size = new System.Drawing.Size(43, 20);
            this.Staff.Text = "Staff";
            // 
            // AddStaffToolStripMenuItem
            // 
            this.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem";
            this.AddStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.AddStaffToolStripMenuItem.Text = "Add Staff";
            this.AddStaffToolStripMenuItem.Click += new System.EventHandler(this.AddStaffToolStripMenuItem_Click);
            // 
            // EditStaffToolStripMenuItem
            // 
            this.EditStaffToolStripMenuItem.Name = "EditStaffToolStripMenuItem";
            this.EditStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.EditStaffToolStripMenuItem.Text = "Edit Staff";
            this.EditStaffToolStripMenuItem.Click += new System.EventHandler(this.EditStaffToolStripMenuItem_Click);
            // 
            // RemoveStaffToolStripMenuItem
            // 
            this.RemoveStaffToolStripMenuItem.Name = "RemoveStaffToolStripMenuItem";
            this.RemoveStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.RemoveStaffToolStripMenuItem.Text = "Remove Staff";
            this.RemoveStaffToolStripMenuItem.Click += new System.EventHandler(this.RemoveStaffToolStripMenuItem_Click);
            // 
            // ListStaffToolStripMenuItem
            // 
            this.ListStaffToolStripMenuItem.Name = "ListStaffToolStripMenuItem";
            this.ListStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
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
            this.Customers.Size = new System.Drawing.Size(76, 20);
            this.Customers.Text = "Customers";
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.AddCustomerToolStripMenuItem.Text = "Add Customer";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // EditCustomerToolStripMenuItem
            // 
            this.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem";
            this.EditCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.EditCustomerToolStripMenuItem.Text = "Edit Customer";
            this.EditCustomerToolStripMenuItem.Click += new System.EventHandler(this.EditCustomerToolStripMenuItem_Click);
            // 
            // RemoveCustomerToolStripMenuItem
            // 
            this.RemoveCustomerToolStripMenuItem.Name = "RemoveCustomerToolStripMenuItem";
            this.RemoveCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.RemoveCustomerToolStripMenuItem.Text = "Remove Customer";
            this.RemoveCustomerToolStripMenuItem.Click += new System.EventHandler(this.RemoveCustomerToolStripMenuItem_Click);
            // 
            // ListCustomersToolStripMenuItem
            // 
            this.ListCustomersToolStripMenuItem.Name = "ListCustomersToolStripMenuItem";
            this.ListCustomersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ListCustomersToolStripMenuItem.Text = "List Customers";
            this.ListCustomersToolStripMenuItem.Click += new System.EventHandler(this.ListCustomersToolStripMenuItem_Click);
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
            this.OpenCarAccountToolStripMenuItem.Click += new System.EventHandler(this.OpenCarAccountToolStripMenuItem_Click);
            // 
            // PrintServiceHistoryToolStripMenuItem
            // 
            this.PrintServiceHistoryToolStripMenuItem.Name = "PrintServiceHistoryToolStripMenuItem";
            this.PrintServiceHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.Repairs.Size = new System.Drawing.Size(57, 20);
            this.Repairs.Text = "Repairs";
            // 
            // RecordRepairToolStripMenuItem
            // 
            this.RecordRepairToolStripMenuItem.Name = "RecordRepairToolStripMenuItem";
            this.RecordRepairToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RecordRepairToolStripMenuItem.Text = "Record Repair";
            this.RecordRepairToolStripMenuItem.Click += new System.EventHandler(this.RecordRepairToolStripMenuItem_Click);
            // 
            // CompleteRepairToolStripMenuItem
            // 
            this.CompleteRepairToolStripMenuItem.Name = "CompleteRepairToolStripMenuItem";
            this.CompleteRepairToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CompleteRepairToolStripMenuItem.Text = "Complete Repair";
            this.CompleteRepairToolStripMenuItem.Click += new System.EventHandler(this.CompleteRepairToolStripMenuItem_Click);
            // 
            // IncomeAnalysisToolStripMenuItem
            // 
            this.IncomeAnalysisToolStripMenuItem.Name = "IncomeAnalysisToolStripMenuItem";
            this.IncomeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.IncomeAnalysisToolStripMenuItem.Text = "Income Analysis";
            this.IncomeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.IncomeAnalysisToolStripMenuItem_Click);
            // 
            // SMobTxt
            // 
            this.SMobTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SMobTxt.Location = new System.Drawing.Point(423, 476);
            this.SMobTxt.Name = "SMobTxt";
            this.SMobTxt.Size = new System.Drawing.Size(160, 20);
            this.SMobTxt.TabIndex = 36;
            this.SMobTxt.TextChanged += new System.EventHandler(this.SMobTxt_TextChanged);
            // 
            // SEmailTxt
            // 
            this.SEmailTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SEmailTxt.Location = new System.Drawing.Point(423, 453);
            this.SEmailTxt.Name = "SEmailTxt";
            this.SEmailTxt.Size = new System.Drawing.Size(220, 20);
            this.SEmailTxt.TabIndex = 35;
            this.SEmailTxt.TextChanged += new System.EventHandler(this.SEmailTxt_TextChanged);
            // 
            // SSnameTxt
            // 
            this.SSnameTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SSnameTxt.Location = new System.Drawing.Point(423, 406);
            this.SSnameTxt.Name = "SSnameTxt";
            this.SSnameTxt.Size = new System.Drawing.Size(220, 20);
            this.SSnameTxt.TabIndex = 33;
            this.SSnameTxt.TextChanged += new System.EventHandler(this.SSnameTxt_TextChanged);
            // 
            // SFnameTxt
            // 
            this.SFnameTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SFnameTxt.Location = new System.Drawing.Point(423, 383);
            this.SFnameTxt.Name = "SFnameTxt";
            this.SFnameTxt.Size = new System.Drawing.Size(141, 20);
            this.SFnameTxt.TabIndex = 32;
            this.SFnameTxt.TextChanged += new System.EventHandler(this.SFnameTxt_TextChanged);
            // 
            // Mob
            // 
            this.Mob.AutoSize = true;
            this.Mob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Mob.ForeColor = System.Drawing.SystemColors.Control;
            this.Mob.Location = new System.Drawing.Point(307, 477);
            this.Mob.Name = "Mob";
            this.Mob.Size = new System.Drawing.Size(75, 17);
            this.Mob.TabIndex = 31;
            this.Mob.Text = "Mobile No:";
            this.Mob.Click += new System.EventHandler(this.Mob_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email.ForeColor = System.Drawing.SystemColors.Control;
            this.email.Location = new System.Drawing.Point(307, 454);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 17);
            this.email.TabIndex = 30;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DOB.ForeColor = System.Drawing.SystemColors.Control;
            this.DOB.Location = new System.Drawing.Point(307, 430);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(42, 17);
            this.DOB.TabIndex = 29;
            this.DOB.Text = "DOB:";
            this.DOB.Click += new System.EventHandler(this.DOB_Click);
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sname.ForeColor = System.Drawing.SystemColors.Control;
            this.Sname.Location = new System.Drawing.Point(307, 407);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(101, 17);
            this.Sname.TabIndex = 28;
            this.Sname.Text = "Second Name:";
            this.Sname.Click += new System.EventHandler(this.Sname_Click);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Fname.ForeColor = System.Drawing.SystemColors.Control;
            this.Fname.Location = new System.Drawing.Point(307, 383);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(80, 17);
            this.Fname.TabIndex = 27;
            this.Fname.Text = "First Name:";
            this.Fname.Click += new System.EventHandler(this.Fname_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(491, 530);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(117, 29);
            this.Editbtn.TabIndex = 37;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Edit_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(823, 26);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(41, 39);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 73;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // StaffTxt
            // 
            this.StaffTxt.BackColor = System.Drawing.SystemColors.Info;
            this.StaffTxt.Location = new System.Drawing.Point(423, 359);
            this.StaffTxt.Name = "StaffTxt";
            this.StaffTxt.Size = new System.Drawing.Size(51, 20);
            this.StaffTxt.TabIndex = 74;
            this.StaffTxt.TextChanged += new System.EventHandler(this.StaffTxt_TextChanged);
            // 
            // StffId
            // 
            this.StffId.AutoSize = true;
            this.StffId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StffId.ForeColor = System.Drawing.SystemColors.Control;
            this.StffId.Location = new System.Drawing.Point(307, 360);
            this.StffId.Name = "StffId";
            this.StffId.Size = new System.Drawing.Size(52, 17);
            this.StffId.TabIndex = 75;
            this.StffId.Text = "StaffId:";
            this.StffId.Click += new System.EventHandler(this.StffId_Click);
            // 
            // SDobTxt
            // 
            this.SDobTxt.BackColor = System.Drawing.SystemColors.Info;
            this.SDobTxt.Location = new System.Drawing.Point(423, 430);
            this.SDobTxt.Name = "SDobTxt";
            this.SDobTxt.Size = new System.Drawing.Size(106, 20);
            this.SDobTxt.TabIndex = 76;
            this.SDobTxt.TextChanged += new System.EventHandler(this.SDobTxt_TextChanged);
            // 
            // grdStaff
            // 
            this.grdStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStaff.Location = new System.Drawing.Point(220, 110);
            this.grdStaff.Name = "grdStaff";
            this.grdStaff.Size = new System.Drawing.Size(607, 196);
            this.grdStaff.TabIndex = 77;
            this.grdStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStaff_CellContentClick_1);
            // 
            // Namebtn
            // 
            this.Namebtn.Location = new System.Drawing.Point(99, 166);
            this.Namebtn.Name = "Namebtn";
            this.Namebtn.Size = new System.Drawing.Size(94, 35);
            this.Namebtn.TabIndex = 80;
            this.Namebtn.Text = "Name";
            this.Namebtn.UseVisualStyleBackColor = true;
            this.Namebtn.Click += new System.EventHandler(this.Namebtn_Click);
            // 
            // StaffIdbtn
            // 
            this.StaffIdbtn.Location = new System.Drawing.Point(99, 110);
            this.StaffIdbtn.Name = "StaffIdbtn";
            this.StaffIdbtn.Size = new System.Drawing.Size(94, 35);
            this.StaffIdbtn.TabIndex = 79;
            this.StaffIdbtn.Text = "StaffId";
            this.StaffIdbtn.UseVisualStyleBackColor = true;
            this.StaffIdbtn.Click += new System.EventHandler(this.StaffIdbtn_Click);
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 675);
            this.Controls.Add(this.Namebtn);
            this.Controls.Add(this.StaffIdbtn);
            this.Controls.Add(this.grdStaff);
            this.Controls.Add(this.SDobTxt);
            this.Controls.Add(this.StffId);
            this.Controls.Add(this.StaffTxt);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.SMobTxt);
            this.Controls.Add(this.SEmailTxt);
            this.Controls.Add(this.SSnameTxt);
            this.Controls.Add(this.SFnameTxt);
            this.Controls.Add(this.Mob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStaff";
            this.Text = "EditStaff";
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaff)).EndInit();
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
        internal System.Windows.Forms.TextBox SMobTxt;
        internal System.Windows.Forms.TextBox SEmailTxt;
        internal System.Windows.Forms.TextBox SSnameTxt;
        internal System.Windows.Forms.TextBox SFnameTxt;
        internal System.Windows.Forms.Label Mob;
        internal System.Windows.Forms.Label email;
        internal System.Windows.Forms.Label DOB;
        internal System.Windows.Forms.Label Sname;
        internal System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.PictureBox HomeBtn;
        internal System.Windows.Forms.TextBox StaffTxt;
        internal System.Windows.Forms.Label StffId;
        internal System.Windows.Forms.TextBox SDobTxt;
        private System.Windows.Forms.DataGridView grdStaff;
        private System.Windows.Forms.Button Namebtn;
        private System.Windows.Forms.Button StaffIdbtn;
    }
}