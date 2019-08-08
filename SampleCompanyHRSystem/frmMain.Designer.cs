namespace SampleCompanyHRSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSearchForAnEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddAnEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddSickness = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemProcessEmployeeAsLeaver = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAnnualLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAnnualLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnnualLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemViewService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAssignEmployeeToService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddAService = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemViewTrainingRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddTrainingDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRecordTrainingAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEqualityComission = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewServiceUsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiceUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemUser,
            this.mnuItemEmployee,
            this.mnuItemService,
            this.areaToolStripMenuItem,
            this.mnuItemTraining,
            this.mnuItemEqualityComission,
            this.serviceUserToolStripMenuItem,
            this.mnuItemReport});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 2;
            // 
            // mnuItemUser
            // 
            this.mnuItemUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemLogin,
            this.mnuItemLogout,
            this.mnuItemQuit});
            this.mnuItemUser.Name = "mnuItemUser";
            this.mnuItemUser.Size = new System.Drawing.Size(42, 20);
            this.mnuItemUser.Text = "User";
            // 
            // mnuItemLogin
            // 
            this.mnuItemLogin.Name = "mnuItemLogin";
            this.mnuItemLogin.Size = new System.Drawing.Size(115, 22);
            this.mnuItemLogin.Text = "Login";
            this.mnuItemLogin.Click += new System.EventHandler(this.mnuItemLogin_Click);
            // 
            // mnuItemLogout
            // 
            this.mnuItemLogout.Name = "mnuItemLogout";
            this.mnuItemLogout.Size = new System.Drawing.Size(115, 22);
            this.mnuItemLogout.Text = "Log out";
            this.mnuItemLogout.Click += new System.EventHandler(this.mnuItemLogout_Click);
            // 
            // mnuItemQuit
            // 
            this.mnuItemQuit.Name = "mnuItemQuit";
            this.mnuItemQuit.Size = new System.Drawing.Size(115, 22);
            this.mnuItemQuit.Text = "Quit";
            this.mnuItemQuit.Click += new System.EventHandler(this.mnuItemQuit_Click);
            // 
            // mnuItemEmployee
            // 
            this.mnuItemEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSearchForAnEmployee,
            this.mnuItemAddAnEmployee,
            this.mnuItemAddSickness,
            this.mnuItemProcessEmployeeAsLeaver,
            this.mnuItemAnnualLeave});
            this.mnuItemEmployee.Name = "mnuItemEmployee";
            this.mnuItemEmployee.Size = new System.Drawing.Size(71, 20);
            this.mnuItemEmployee.Text = "Employee";
            // 
            // mnuItemSearchForAnEmployee
            // 
            this.mnuItemSearchForAnEmployee.Name = "mnuItemSearchForAnEmployee";
            this.mnuItemSearchForAnEmployee.Size = new System.Drawing.Size(220, 22);
            this.mnuItemSearchForAnEmployee.Text = "View Employees";
            this.mnuItemSearchForAnEmployee.Click += new System.EventHandler(this.MnuItemSearchForAnEmployee_Click);
            // 
            // mnuItemAddAnEmployee
            // 
            this.mnuItemAddAnEmployee.Name = "mnuItemAddAnEmployee";
            this.mnuItemAddAnEmployee.Size = new System.Drawing.Size(220, 22);
            this.mnuItemAddAnEmployee.Text = "Add an Employee";
            this.mnuItemAddAnEmployee.Click += new System.EventHandler(this.mnuItemAddAnEmployee_Click);
            // 
            // mnuItemAddSickness
            // 
            this.mnuItemAddSickness.Name = "mnuItemAddSickness";
            this.mnuItemAddSickness.Size = new System.Drawing.Size(220, 22);
            this.mnuItemAddSickness.Text = "Add Sickness";
            this.mnuItemAddSickness.Click += new System.EventHandler(this.MnuItemAddSickness_Click);
            // 
            // mnuItemProcessEmployeeAsLeaver
            // 
            this.mnuItemProcessEmployeeAsLeaver.Name = "mnuItemProcessEmployeeAsLeaver";
            this.mnuItemProcessEmployeeAsLeaver.Size = new System.Drawing.Size(220, 22);
            this.mnuItemProcessEmployeeAsLeaver.Text = "Process Employee as Leaver";
            this.mnuItemProcessEmployeeAsLeaver.Click += new System.EventHandler(this.MnuItemProcessEmployeeAsLeaver_Click);
            // 
            // mnuItemAnnualLeave
            // 
            this.mnuItemAnnualLeave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAnnualLeaveToolStripMenuItem,
            this.addAnnualLeaveToolStripMenuItem});
            this.mnuItemAnnualLeave.Name = "mnuItemAnnualLeave";
            this.mnuItemAnnualLeave.Size = new System.Drawing.Size(220, 22);
            this.mnuItemAnnualLeave.Text = "Annual Leave";
            // 
            // viewAnnualLeaveToolStripMenuItem
            // 
            this.viewAnnualLeaveToolStripMenuItem.Name = "viewAnnualLeaveToolStripMenuItem";
            this.viewAnnualLeaveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewAnnualLeaveToolStripMenuItem.Text = "View Annual Leave";
            this.viewAnnualLeaveToolStripMenuItem.Click += new System.EventHandler(this.ViewAnnualLeaveToolStripMenuItem_Click);
            // 
            // addAnnualLeaveToolStripMenuItem
            // 
            this.addAnnualLeaveToolStripMenuItem.Name = "addAnnualLeaveToolStripMenuItem";
            this.addAnnualLeaveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addAnnualLeaveToolStripMenuItem.Text = "Add Annual Leave";
            this.addAnnualLeaveToolStripMenuItem.Click += new System.EventHandler(this.AddAnnualLeaveToolStripMenuItem_Click);
            // 
            // mnuItemService
            // 
            this.mnuItemService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemViewService,
            this.mnuItemAssignEmployeeToService,
            this.mnuItemAddAService});
            this.mnuItemService.Name = "mnuItemService";
            this.mnuItemService.Size = new System.Drawing.Size(56, 20);
            this.mnuItemService.Text = "Service";
            // 
            // mnuItemViewService
            // 
            this.mnuItemViewService.Name = "mnuItemViewService";
            this.mnuItemViewService.Size = new System.Drawing.Size(218, 22);
            this.mnuItemViewService.Text = "View Services";
            this.mnuItemViewService.Click += new System.EventHandler(this.MnuItemViewService_Click);
            // 
            // mnuItemAssignEmployeeToService
            // 
            this.mnuItemAssignEmployeeToService.Name = "mnuItemAssignEmployeeToService";
            this.mnuItemAssignEmployeeToService.Size = new System.Drawing.Size(218, 22);
            this.mnuItemAssignEmployeeToService.Text = "Assign Employee to Service";
            this.mnuItemAssignEmployeeToService.Click += new System.EventHandler(this.MnuItemAssignEmployeeToService_Click);
            // 
            // mnuItemAddAService
            // 
            this.mnuItemAddAService.Name = "mnuItemAddAService";
            this.mnuItemAddAService.Size = new System.Drawing.Size(218, 22);
            this.mnuItemAddAService.Text = "Add a Service";
            this.mnuItemAddAService.Click += new System.EventHandler(this.MnuItemAddAService_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAreasToolStripMenuItem,
            this.editServicesToolStripMenuItem});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // viewAreasToolStripMenuItem
            // 
            this.viewAreasToolStripMenuItem.Name = "viewAreasToolStripMenuItem";
            this.viewAreasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.viewAreasToolStripMenuItem.Text = "View Areas";
            // 
            // editServicesToolStripMenuItem
            // 
            this.editServicesToolStripMenuItem.Name = "editServicesToolStripMenuItem";
            this.editServicesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editServicesToolStripMenuItem.Text = "Edit Services";
            // 
            // mnuItemTraining
            // 
            this.mnuItemTraining.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemViewTrainingRecords,
            this.mnuItemAddTrainingDate,
            this.mnuItemRecordTrainingAttendance});
            this.mnuItemTraining.Name = "mnuItemTraining";
            this.mnuItemTraining.Size = new System.Drawing.Size(61, 20);
            this.mnuItemTraining.Text = "Training";
            // 
            // mnuItemViewTrainingRecords
            // 
            this.mnuItemViewTrainingRecords.Name = "mnuItemViewTrainingRecords";
            this.mnuItemViewTrainingRecords.Size = new System.Drawing.Size(218, 22);
            this.mnuItemViewTrainingRecords.Text = "View Training records";
            this.mnuItemViewTrainingRecords.Click += new System.EventHandler(this.MnuItemViewTrainingRecords_Click);
            // 
            // mnuItemAddTrainingDate
            // 
            this.mnuItemAddTrainingDate.Name = "mnuItemAddTrainingDate";
            this.mnuItemAddTrainingDate.Size = new System.Drawing.Size(218, 22);
            this.mnuItemAddTrainingDate.Text = "Add Training date";
            this.mnuItemAddTrainingDate.Click += new System.EventHandler(this.mnuItemAddTrainingDate_Click);
            // 
            // mnuItemRecordTrainingAttendance
            // 
            this.mnuItemRecordTrainingAttendance.Name = "mnuItemRecordTrainingAttendance";
            this.mnuItemRecordTrainingAttendance.Size = new System.Drawing.Size(218, 22);
            this.mnuItemRecordTrainingAttendance.Text = "Record Training attendance";
            this.mnuItemRecordTrainingAttendance.Click += new System.EventHandler(this.mnuItemRecordTrainingAttendance_Click);
            // 
            // mnuItemEqualityComission
            // 
            this.mnuItemEqualityComission.Name = "mnuItemEqualityComission";
            this.mnuItemEqualityComission.Size = new System.Drawing.Size(131, 20);
            this.mnuItemEqualityComission.Text = "Equality Commission";
            // 
            // serviceUserToolStripMenuItem
            // 
            this.serviceUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewServiceUsersToolStripMenuItem1,
            this.addServiceUserToolStripMenuItem1});
            this.serviceUserToolStripMenuItem.Name = "serviceUserToolStripMenuItem";
            this.serviceUserToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.serviceUserToolStripMenuItem.Text = "Service User";
            // 
            // viewServiceUsersToolStripMenuItem1
            // 
            this.viewServiceUsersToolStripMenuItem1.Name = "viewServiceUsersToolStripMenuItem1";
            this.viewServiceUsersToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.viewServiceUsersToolStripMenuItem1.Text = "View Service Users";
            // 
            // addServiceUserToolStripMenuItem1
            // 
            this.addServiceUserToolStripMenuItem1.Name = "addServiceUserToolStripMenuItem1";
            this.addServiceUserToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.addServiceUserToolStripMenuItem1.Text = "Add Service User";
            // 
            // mnuItemReport
            // 
            this.mnuItemReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.trainingToolStripMenuItem});
            this.mnuItemReport.Name = "mnuItemReport";
            this.mnuItemReport.Size = new System.Drawing.Size(54, 20);
            this.mnuItemReport.Text = "Report";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = global::SampleCompanyHRSystem.Properties.Resources.HRIcon;
            this.picCompanyLogo.Location = new System.Drawing.Point(609, 68);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(54, 51);
            this.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompanyLogo.TabIndex = 3;
            this.picCompanyLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCompanyLogo);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR System";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuItemService;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTraining;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReport;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSearchForAnEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddAnEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuItemProcessEmployeeAsLeaver;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAnnualLeave;
        private System.Windows.Forms.ToolStripMenuItem viewAnnualLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnnualLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewService;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAssignEmployeeToService;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddAService;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewTrainingRecords;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddTrainingDate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUser;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRecordTrainingAttendance;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddSickness;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEqualityComission;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewServiceUsersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addServiceUserToolStripMenuItem1;
        private System.Windows.Forms.PictureBox picCompanyLogo;
    }
}