namespace SampleCompanyHRSystem
{
    partial class frmAddTrainingAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrainingAttendance));
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.grpTraining = new System.Windows.Forms.GroupBox();
            this.btnSelectTraining = new System.Windows.Forms.Button();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.lblTrainingID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grpAddedEmployees = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.grpTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.grpAddedEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnRemoveEmployee);
            this.grpEmployee.Controls.Add(this.btnSelectEmployee);
            this.grpEmployee.Controls.Add(this.dgvEmployee);
            this.grpEmployee.Controls.Add(this.lblEmployeeID);
            this.grpEmployee.Controls.Add(this.txtForename);
            this.grpEmployee.Controls.Add(this.txtEmployeeID);
            this.grpEmployee.Controls.Add(this.lblForename);
            this.grpEmployee.Controls.Add(this.lblSurname);
            this.grpEmployee.Controls.Add(this.txtSurname);
            this.grpEmployee.Location = new System.Drawing.Point(382, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(364, 426);
            this.grpEmployee.TabIndex = 7;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(196, 21);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(75, 75);
            this.btnSelectEmployee.TabIndex = 18;
            this.btnSelectEmployee.Text = "Add Employee";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 119);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(364, 307);
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
            // grpTraining
            // 
            this.grpTraining.Controls.Add(this.dtpDate);
            this.grpTraining.Controls.Add(this.btnSelectTraining);
            this.grpTraining.Controls.Add(this.dgvTraining);
            this.grpTraining.Controls.Add(this.lblTrainingID);
            this.grpTraining.Controls.Add(this.textBox2);
            this.grpTraining.Controls.Add(this.lblDate);
            this.grpTraining.Controls.Add(this.lblTitle);
            this.grpTraining.Controls.Add(this.textBox3);
            this.grpTraining.Location = new System.Drawing.Point(12, 12);
            this.grpTraining.Name = "grpTraining";
            this.grpTraining.Size = new System.Drawing.Size(364, 426);
            this.grpTraining.TabIndex = 8;
            this.grpTraining.TabStop = false;
            this.grpTraining.Text = "Training";
            // 
            // btnSelectTraining
            // 
            this.btnSelectTraining.Location = new System.Drawing.Point(283, 22);
            this.btnSelectTraining.Name = "btnSelectTraining";
            this.btnSelectTraining.Size = new System.Drawing.Size(75, 75);
            this.btnSelectTraining.TabIndex = 18;
            this.btnSelectTraining.Text = "Select Training";
            this.btnSelectTraining.UseVisualStyleBackColor = true;
            // 
            // dgvTraining
            // 
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Location = new System.Drawing.Point(0, 119);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.Size = new System.Drawing.Size(364, 307);
            this.dgvTraining.TabIndex = 6;
            // 
            // lblTrainingID
            // 
            this.lblTrainingID.AutoSize = true;
            this.lblTrainingID.Location = new System.Drawing.Point(6, 16);
            this.lblTrainingID.Name = "lblTrainingID";
            this.lblTrainingID.Size = new System.Drawing.Size(59, 13);
            this.lblTrainingID.TabIndex = 1;
            this.lblTrainingID.Text = "Training ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Training Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(83, 77);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(143, 20);
            this.dtpDate.TabIndex = 19;
            // 
            // grpAddedEmployees
            // 
            this.grpAddedEmployees.Controls.Add(this.dataGridView1);
            this.grpAddedEmployees.Location = new System.Drawing.Point(12, 444);
            this.grpAddedEmployees.Name = "grpAddedEmployees";
            this.grpAddedEmployees.Size = new System.Drawing.Size(734, 158);
            this.grpAddedEmployees.TabIndex = 9;
            this.grpAddedEmployees.TabStop = false;
            this.grpAddedEmployees.Text = "Added Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(283, 21);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(75, 75);
            this.btnRemoveEmployee.TabIndex = 19;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // frmAddTrainingAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 612);
            this.Controls.Add(this.grpAddedEmployees);
            this.Controls.Add(this.grpTraining);
            this.Controls.Add(this.grpEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddTrainingAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Training Attendance";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.grpTraining.ResumeLayout(false);
            this.grpTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.grpAddedEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox grpTraining;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSelectTraining;
        private System.Windows.Forms.DataGridView dgvTraining;
        private System.Windows.Forms.Label lblTrainingID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox grpAddedEmployees;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemoveEmployee;
    }
}