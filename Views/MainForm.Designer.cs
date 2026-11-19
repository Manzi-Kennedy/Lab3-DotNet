namespace TaskLink.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabBrowse = new System.Windows.Forms.TabPage();
            this.tabMine = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.dgvBrowse = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.pnlBrowseBottom = new System.Windows.Forms.Panel();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnClaim = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpHelping = new System.Windows.Forms.GroupBox();
            this.grpPosted = new System.Windows.Forms.GroupBox();
            this.dgvPosted = new System.Windows.Forms.DataGridView();
            this.pnlPostedBtns = new System.Windows.Forms.Panel();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnRateHelper = new System.Windows.Forms.Button();
            this.dgvHelping = new System.Windows.Forms.DataGridView();
            this.pnlHelpingBtns = new System.Windows.Forms.Panel();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnRatePoster = new System.Windows.Forms.Button();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.pnlProfileTop = new System.Windows.Forms.Panel();
            this.lblProfileInfo = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.pnlAdminBtns = new System.Windows.Forms.Panel();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnRefreshAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.tabs.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tabBrowse.SuspendLayout();
            this.tabMine.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlBrowseBottom.SuspendLayout();
            this.grpHelping.SuspendLayout();
            this.grpPosted.SuspendLayout();
            this.pnlPostedBtns.SuspendLayout();
            this.pnlHelpingBtns.SuspendLayout();
            this.pnlProfileTop.SuspendLayout();
            this.pnlAdminBtns.SuspendLayout();
            this.SuspendLayout();
            // tabs
            this.tabs.Name = "tabs";
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // pnlHeader
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 44;
            this.pnlHeader.TabIndex = 1;
            // lblWelcome
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Location = new System.Drawing.Point(12, 13);
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TabIndex = 2;
            // btnLogout
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Size = new System.Drawing.Size(90, 44);
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // tabBrowse
            this.tabBrowse.Name = "tabBrowse";
            this.tabBrowse.Text = "Browse tasks";
            // tabMine
            this.tabMine.Name = "tabMine";
            this.tabMine.Text = "My tasks";
            // tabProfile
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Text = "Profile";
            // tabAdmin
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Text = "Admin";
            // dgvBrowse
            this.dgvBrowse.Name = "dgvBrowse";
            this.dgvBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBrowse.ReadOnly = true;
            this.dgvBrowse.AllowUserToAddRows = false;
            this.dgvBrowse.AllowUserToDeleteRows = false;
            this.dgvBrowse.MultiSelect = false;
            this.dgvBrowse.RowHeadersVisible = false;
            this.dgvBrowse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrowse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrowse.TabIndex = 8;
            this.dgvBrowse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrowse_CellDoubleClick);
            // pnlFilter
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Height = 50;
            this.pnlFilter.TabIndex = 9;
            // pnlBrowseBottom
            this.pnlBrowseBottom.Name = "pnlBrowseBottom";
            this.pnlBrowseBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBrowseBottom.Height = 46;
            this.pnlBrowseBottom.TabIndex = 10;
            // txtKeyword
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Location = new System.Drawing.Point(12, 14);
            this.txtKeyword.PlaceholderText = "Keyword (title/description)";
            this.txtKeyword.Size = new System.Drawing.Size(200, 23);
            this.txtKeyword.TabIndex = 11;
            // cmbCategory
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Location = new System.Drawing.Point(224, 14);
            this.cmbCategory.Size = new System.Drawing.Size(150, 23);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.TabIndex = 12;
            // txtLocation
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Location = new System.Drawing.Point(386, 14);
            this.txtLocation.PlaceholderText = "Location";
            this.txtLocation.Size = new System.Drawing.Size(150, 23);
            this.txtLocation.TabIndex = 13;
            // cmbSort
            this.cmbSort.Items.AddRange(new object[] { "Newest first", "Deadline soonest" });
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Location = new System.Drawing.Point(548, 14);
            this.cmbSort.Size = new System.Drawing.Size(140, 23);
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.TabIndex = 14;
            // btnSearch
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(700, 11);
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // btnClear
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(786, 11);
            this.btnClear.Size = new System.Drawing.Size(80, 28);
            this.btnClear.TabIndex = 16;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // btnPrev
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Text = "< Prev";
            this.btnPrev.Location = new System.Drawing.Point(12, 8);
            this.btnPrev.Size = new System.Drawing.Size(80, 30);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // lblPage
            this.lblPage.Name = "lblPage";
            this.lblPage.Text = "Page 1/1";
            this.lblPage.Location = new System.Drawing.Point(102, 16);
            this.lblPage.AutoSize = true;
            this.lblPage.TabIndex = 18;
            // btnNext
            this.btnNext.Name = "btnNext";
            this.btnNext.Text = "Next >";
            this.btnNext.Location = new System.Drawing.Point(190, 8);
            this.btnNext.Size = new System.Drawing.Size(80, 30);
            this.btnNext.TabIndex = 19;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // btnDetails
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Text = "View details";
            this.btnDetails.Location = new System.Drawing.Point(560, 8);
            this.btnDetails.Size = new System.Drawing.Size(110, 30);
            this.btnDetails.TabIndex = 20;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // btnClaim
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Text = "Claim task";
            this.btnClaim.Location = new System.Drawing.Point(680, 8);
            this.btnClaim.Size = new System.Drawing.Size(110, 30);
            this.btnClaim.TabIndex = 21;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // btnReport
            this.btnReport.Name = "btnReport";
            this.btnReport.Text = "Report task";
            this.btnReport.Location = new System.Drawing.Point(800, 8);
            this.btnReport.Size = new System.Drawing.Size(110, 30);
            this.btnReport.TabIndex = 22;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // grpHelping
            this.grpHelping.Name = "grpHelping";
            this.grpHelping.Text = "Tasks I am helping with";
            this.grpHelping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHelping.TabIndex = 23;
            // grpPosted
            this.grpPosted.Name = "grpPosted";
            this.grpPosted.Text = "Tasks I posted";
            this.grpPosted.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPosted.Height = 270;
            this.grpPosted.TabIndex = 24;
            // dgvPosted
            this.dgvPosted.Name = "dgvPosted";
            this.dgvPosted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosted.ReadOnly = true;
            this.dgvPosted.AllowUserToAddRows = false;
            this.dgvPosted.AllowUserToDeleteRows = false;
            this.dgvPosted.MultiSelect = false;
            this.dgvPosted.RowHeadersVisible = false;
            this.dgvPosted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosted.TabIndex = 25;
            // pnlPostedBtns
            this.pnlPostedBtns.Name = "pnlPostedBtns";
            this.pnlPostedBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPostedBtns.Height = 40;
            this.pnlPostedBtns.TabIndex = 26;
            // btnNewTask
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Text = "New task";
            this.btnNewTask.Location = new System.Drawing.Point(8, 6);
            this.btnNewTask.Size = new System.Drawing.Size(100, 28);
            this.btnNewTask.TabIndex = 27;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // btnEditTask
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.Location = new System.Drawing.Point(114, 6);
            this.btnEditTask.Size = new System.Drawing.Size(100, 28);
            this.btnEditTask.TabIndex = 28;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // btnCancelTask
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Text = "Cancel task";
            this.btnCancelTask.Location = new System.Drawing.Point(220, 6);
            this.btnCancelTask.Size = new System.Drawing.Size(100, 28);
            this.btnCancelTask.TabIndex = 29;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // btnComplete
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Text = "Mark completed";
            this.btnComplete.Location = new System.Drawing.Point(326, 6);
            this.btnComplete.Size = new System.Drawing.Size(120, 28);
            this.btnComplete.TabIndex = 30;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // btnRateHelper
            this.btnRateHelper.Name = "btnRateHelper";
            this.btnRateHelper.Text = "Rate helper";
            this.btnRateHelper.Location = new System.Drawing.Point(452, 6);
            this.btnRateHelper.Size = new System.Drawing.Size(110, 28);
            this.btnRateHelper.TabIndex = 31;
            this.btnRateHelper.Click += new System.EventHandler(this.btnRateHelper_Click);
            // dgvHelping
            this.dgvHelping.Name = "dgvHelping";
            this.dgvHelping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHelping.ReadOnly = true;
            this.dgvHelping.AllowUserToAddRows = false;
            this.dgvHelping.AllowUserToDeleteRows = false;
            this.dgvHelping.MultiSelect = false;
            this.dgvHelping.RowHeadersVisible = false;
            this.dgvHelping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHelping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHelping.TabIndex = 32;
            // pnlHelpingBtns
            this.pnlHelpingBtns.Name = "pnlHelpingBtns";
            this.pnlHelpingBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHelpingBtns.Height = 40;
            this.pnlHelpingBtns.TabIndex = 33;
            // btnWithdraw
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Location = new System.Drawing.Point(8, 6);
            this.btnWithdraw.Size = new System.Drawing.Size(110, 28);
            this.btnWithdraw.TabIndex = 34;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // btnRatePoster
            this.btnRatePoster.Name = "btnRatePoster";
            this.btnRatePoster.Text = "Rate poster";
            this.btnRatePoster.Location = new System.Drawing.Point(124, 6);
            this.btnRatePoster.Size = new System.Drawing.Size(110, 28);
            this.btnRatePoster.TabIndex = 35;
            this.btnRatePoster.Click += new System.EventHandler(this.btnRatePoster_Click);
            // dgvReviews
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.MultiSelect = false;
            this.dgvReviews.RowHeadersVisible = false;
            this.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReviews.TabIndex = 36;
            // pnlProfileTop
            this.pnlProfileTop.Name = "pnlProfileTop";
            this.pnlProfileTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileTop.Height = 190;
            this.pnlProfileTop.TabIndex = 37;
            // lblProfileInfo
            this.lblProfileInfo.Name = "lblProfileInfo";
            this.lblProfileInfo.Location = new System.Drawing.Point(12, 10);
            this.lblProfileInfo.Size = new System.Drawing.Size(500, 100);
            this.lblProfileInfo.Text = "Profile";
            this.lblProfileInfo.TabIndex = 38;
            // txtProfileName
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Location = new System.Drawing.Point(12, 125);
            this.txtProfileName.PlaceholderText = "Name";
            this.txtProfileName.Size = new System.Drawing.Size(200, 23);
            this.txtProfileName.TabIndex = 39;
            // txtNewPassword
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Location = new System.Drawing.Point(222, 125);
            this.txtNewPassword.PlaceholderText = "New password (blank = keep)";
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Size = new System.Drawing.Size(220, 23);
            this.txtNewPassword.TabIndex = 40;
            // btnSaveProfile
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Text = "Save changes";
            this.btnSaveProfile.Location = new System.Drawing.Point(452, 122);
            this.btnSaveProfile.Size = new System.Drawing.Size(120, 29);
            this.btnSaveProfile.TabIndex = 41;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // dgvReports
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.ReadOnly = true;
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.MultiSelect = false;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.TabIndex = 42;
            // pnlAdminBtns
            this.pnlAdminBtns.Name = "pnlAdminBtns";
            this.pnlAdminBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminBtns.Height = 44;
            this.pnlAdminBtns.TabIndex = 43;
            // btnDismiss
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Text = "Dismiss report";
            this.btnDismiss.Location = new System.Drawing.Point(8, 8);
            this.btnDismiss.Size = new System.Drawing.Size(130, 28);
            this.btnDismiss.TabIndex = 44;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // btnRemoveTask
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.Location = new System.Drawing.Point(144, 8);
            this.btnRemoveTask.Size = new System.Drawing.Size(120, 28);
            this.btnRemoveTask.TabIndex = 45;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // btnDeactivate
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Text = "Deactivate poster";
            this.btnDeactivate.Location = new System.Drawing.Point(270, 8);
            this.btnDeactivate.Size = new System.Drawing.Size(150, 28);
            this.btnDeactivate.TabIndex = 46;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // btnRefreshAdmin
            this.btnRefreshAdmin.Name = "btnRefreshAdmin";
            this.btnRefreshAdmin.Text = "Refresh";
            this.btnRefreshAdmin.Location = new System.Drawing.Point(426, 8);
            this.btnRefreshAdmin.Size = new System.Drawing.Size(90, 28);
            this.btnRefreshAdmin.TabIndex = 47;
            this.btnRefreshAdmin.Click += new System.EventHandler(this.btnRefreshAdmin_Click);
            // add controls
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pnlHeader);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.tabs.Controls.Add(this.tabBrowse);
            this.tabs.Controls.Add(this.tabMine);
            this.tabs.Controls.Add(this.tabProfile);
            this.tabs.Controls.Add(this.tabAdmin);
            this.tabBrowse.Controls.Add(this.dgvBrowse);
            this.tabBrowse.Controls.Add(this.pnlFilter);
            this.tabBrowse.Controls.Add(this.pnlBrowseBottom);
            this.pnlFilter.Controls.Add(this.txtKeyword);
            this.pnlFilter.Controls.Add(this.cmbCategory);
            this.pnlFilter.Controls.Add(this.txtLocation);
            this.pnlFilter.Controls.Add(this.cmbSort);
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.btnClear);
            this.pnlBrowseBottom.Controls.Add(this.btnPrev);
            this.pnlBrowseBottom.Controls.Add(this.lblPage);
            this.pnlBrowseBottom.Controls.Add(this.btnNext);
            this.pnlBrowseBottom.Controls.Add(this.btnDetails);
            this.pnlBrowseBottom.Controls.Add(this.btnClaim);
            this.pnlBrowseBottom.Controls.Add(this.btnReport);
            this.tabMine.Controls.Add(this.grpHelping);
            this.tabMine.Controls.Add(this.grpPosted);
            this.grpPosted.Controls.Add(this.dgvPosted);
            this.grpPosted.Controls.Add(this.pnlPostedBtns);
            this.pnlPostedBtns.Controls.Add(this.btnNewTask);
            this.pnlPostedBtns.Controls.Add(this.btnEditTask);
            this.pnlPostedBtns.Controls.Add(this.btnCancelTask);
            this.pnlPostedBtns.Controls.Add(this.btnComplete);
            this.pnlPostedBtns.Controls.Add(this.btnRateHelper);
            this.grpHelping.Controls.Add(this.dgvHelping);
            this.grpHelping.Controls.Add(this.pnlHelpingBtns);
            this.pnlHelpingBtns.Controls.Add(this.btnWithdraw);
            this.pnlHelpingBtns.Controls.Add(this.btnRatePoster);
            this.tabProfile.Controls.Add(this.dgvReviews);
            this.tabProfile.Controls.Add(this.pnlProfileTop);
            this.pnlProfileTop.Controls.Add(this.lblProfileInfo);
            this.pnlProfileTop.Controls.Add(this.txtProfileName);
            this.pnlProfileTop.Controls.Add(this.txtNewPassword);
            this.pnlProfileTop.Controls.Add(this.btnSaveProfile);
            this.tabAdmin.Controls.Add(this.dgvReports);
            this.tabAdmin.Controls.Add(this.pnlAdminBtns);
            this.pnlAdminBtns.Controls.Add(this.btnDismiss);
            this.pnlAdminBtns.Controls.Add(this.btnRemoveTask);
            this.pnlAdminBtns.Controls.Add(this.btnDeactivate);
            this.pnlAdminBtns.Controls.Add(this.btnRefreshAdmin);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Text = "TaskLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabs.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabBrowse.ResumeLayout(false);
            this.tabMine.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlBrowseBottom.ResumeLayout(false);
            this.pnlBrowseBottom.PerformLayout();
            this.grpHelping.ResumeLayout(false);
            this.grpHelping.PerformLayout();
            this.grpPosted.ResumeLayout(false);
            this.grpPosted.PerformLayout();
            this.pnlPostedBtns.ResumeLayout(false);
            this.pnlPostedBtns.PerformLayout();
            this.pnlHelpingBtns.ResumeLayout(false);
            this.pnlHelpingBtns.PerformLayout();
            this.pnlProfileTop.ResumeLayout(false);
            this.pnlProfileTop.PerformLayout();
            this.pnlAdminBtns.ResumeLayout(false);
            this.pnlAdminBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabBrowse;
        private System.Windows.Forms.TabPage tabMine;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.DataGridView dgvBrowse;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlBrowseBottom;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpHelping;
        private System.Windows.Forms.GroupBox grpPosted;
        private System.Windows.Forms.DataGridView dgvPosted;
        private System.Windows.Forms.Panel pnlPostedBtns;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnCancelTask;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnRateHelper;
        private System.Windows.Forms.DataGridView dgvHelping;
        private System.Windows.Forms.Panel pnlHelpingBtns;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnRatePoster;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.Panel pnlProfileTop;
        private System.Windows.Forms.Label lblProfileInfo;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Panel pnlAdminBtns;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnRefreshAdmin;
    }
}
