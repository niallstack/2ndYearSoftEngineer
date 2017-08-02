namespace CarSys
{
    partial class PrintServiceHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintServiceHistory));
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
            this.grdPrint = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RegTxt = new System.Windows.Forms.TextBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrint)).BeginInit();
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
            this.MenuBar.Size = new System.Drawing.Size(880, 35);
            this.MenuBar.TabIndex = 10;
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
            this.HomeBtn.Location = new System.Drawing.Point(805, 40);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(62, 60);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 78;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // grdPrint
            // 
            this.grdPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrint.Location = new System.Drawing.Point(59, 212);
            this.grdPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdPrint.Name = "grdPrint";
            this.grdPrint.Size = new System.Drawing.Size(756, 302);
            this.grdPrint.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(152, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "RegNO:";
            // 
            // RegTxt
            // 
            this.RegTxt.BackColor = System.Drawing.SystemColors.Info;
            this.RegTxt.Location = new System.Drawing.Point(243, 86);
            this.RegTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegTxt.Name = "RegTxt";
            this.RegTxt.Size = new System.Drawing.Size(379, 26);
            this.RegTxt.TabIndex = 81;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(308, 137);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(226, 35);
            this.SelectBtn.TabIndex = 82;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // PrintServiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 688);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.RegTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdPrint);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintServiceHistory";
            this.Text = "PrintCarServiceHistory";
            this.Load += new System.EventHandler(this.PrintServiceHistory_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrint)).EndInit();
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
        private System.Windows.Forms.DataGridView grdPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegTxt;
        private System.Windows.Forms.Button SelectBtn;
    }
}