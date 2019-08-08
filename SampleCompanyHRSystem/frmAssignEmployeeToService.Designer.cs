namespace SampleCompanyHRSystem
{
    partial class frmAssignEmployeeToService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignEmployeeToService));
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.grpServiceEmployees = new System.Windows.Forms.GroupBox();
            this.dgvServiceEmployee = new System.Windows.Forms.DataGridView();
            this.grpService = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblRegisteredManagerForename = new System.Windows.Forms.Label();
            this.txtRegManForename = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.btnSelectService = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.grpServiceEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceEmployee)).BeginInit();
            this.grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.dgvEmployee);
            this.grpEmployee.Controls.Add(this.lblEmployeeID);
            this.grpEmployee.Controls.Add(this.txtForename);
            this.grpEmployee.Controls.Add(this.txtEmployeeID);
            this.grpEmployee.Controls.Add(this.lblForename);
            this.grpEmployee.Controls.Add(this.lblSurname);
            this.grpEmployee.Controls.Add(this.txtSurname);
            this.grpEmployee.Location = new System.Drawing.Point(12, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(364, 507);
            this.grpEmployee.TabIndex = 10;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 119);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(364, 388);
            this.dgvEmployee.TabIndex = 6;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(6, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(66, 80);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 5;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(79, 13);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(6, 83);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 47);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(61, 44);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // grpServiceEmployees
            // 
            this.grpServiceEmployees.Controls.Add(this.dgvServiceEmployee);
            this.grpServiceEmployees.Location = new System.Drawing.Point(12, 525);
            this.grpServiceEmployees.Name = "grpServiceEmployees";
            this.grpServiceEmployees.Size = new System.Drawing.Size(857, 273);
            this.grpServiceEmployees.TabIndex = 20;
            this.grpServiceEmployees.TabStop = false;
            this.grpServiceEmployees.Text = "Service Employees";
            // 
            // dgvServiceEmployee
            // 
            this.dgvServiceEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceEmployee.Location = new System.Drawing.Point(3, 16);
            this.dgvServiceEmployee.Name = "dgvServiceEmployee";
            this.dgvServiceEmployee.Size = new System.Drawing.Size(851, 254);
            this.dgvServiceEmployee.TabIndex = 19;
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.lblServiceName);
            this.grpService.Controls.Add(this.txtServiceName);
            this.grpService.Controls.Add(this.lblRegisteredManagerForename);
            this.grpService.Controls.Add(this.txtRegManForename);
            this.grpService.Controls.Add(this.dataGridView1);
            this.grpService.Controls.Add(this.lblServiceID);
            this.grpService.Controls.Add(this.txtServiceID);
            this.grpService.Location = new System.Drawing.Point(382, 12);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(374, 507);
            this.grpService.TabIndex = 19;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 388);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(6, 16);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(57, 13);
            this.lblServiceID.TabIndex = 1;
            this.lblServiceID.Text = "Service ID";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(79, 13);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(100, 20);
            this.txtServiceID.TabIndex = 0;
            // 
            // lblRegisteredManagerForename
            // 
            this.lblRegisteredManagerForename.AutoSize = true;
            this.lblRegisteredManagerForename.Location = new System.Drawing.Point(6, 80);
            this.lblRegisteredManagerForename.Name = "lblRegisteredManagerForename";
            this.lblRegisteredManagerForename.Size = new System.Drawing.Size(107, 13);
            this.lblRegisteredManagerForename.TabIndex = 2;
            this.lblRegisteredManagerForename.Text = "Reg. Man. Forename";
            // 
            // txtRegManForename
            // 
            this.txtRegManForename.Location = new System.Drawing.Point(120, 77);
            this.txtRegManForename.Name = "txtRegManForename";
            this.txtRegManForename.Size = new System.Drawing.Size(100, 20);
            this.txtRegManForename.TabIndex = 3;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(6, 47);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 19;
            this.lblServiceName.Text = "Service Name";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(87, 44);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(100, 20);
            this.txtServiceName.TabIndex = 20;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.btnSelectService);
            this.grpOperations.Controls.Add(this.btnSelectEmployee);
            this.grpOperations.Controls.Add(this.btnRemoveEmployee);
            this.grpOperations.Controls.Add(this.btnAddEmployee);
            this.grpOperations.Location = new System.Drawing.Point(762, 12);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(107, 507);
            this.grpOperations.TabIndex = 21;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Operations";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 345);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(95, 75);
            this.btnAddEmployee.TabIndex = 19;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(6, 426);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(95, 75);
            this.btnRemoveEmployee.TabIndex = 20;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(6, 19);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(95, 75);
            this.btnSelectEmployee.TabIndex = 21;
            this.btnSelectEmployee.Text = "Select Employee";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSelectService
            // 
            this.btnSelectService.Location = new System.Drawing.Point(6, 100);
            this.btnSelectService.Name = "btnSelectService";
            this.btnSelectService.Size = new System.Drawing.Size(95, 75);
            this.btnSelectService.TabIndex = 22;
            this.btnSelectService.Text = "Select Service";
            this.btnSelectService.UseVisualStyleBackColor = true;
            // 
            // frmAssignEmployeeToService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 810);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.grpService);
            this.Controls.Add(this.grpServiceEmployees);
            this.Controls.Add(this.grpEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAssignEmployeeToService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Employee to Service";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.grpServiceEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceEmployee)).EndInit();
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox grpServiceEmployees;
        private System.Windows.Forms.DataGridView dgvServiceEmployee;
        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblRegisteredManagerForename;
        private System.Windows.Forms.TextBox txtRegManForename;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnSelectService;
        private System.Windows.Forms.Button btnSelectEmployee;
    }
}