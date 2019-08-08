namespace SampleCompanyHRSystem
{
    partial class frmAddQualification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQualification));
            this.grpNewQualification = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNewEmployeeID = new System.Windows.Forms.Label();
            this.txtNewEmployeeID = new System.Windows.Forms.TextBox();
            this.grpQualification = new System.Windows.Forms.GroupBox();
            this.dgvQualification = new System.Windows.Forms.DataGridView();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblQualificationType = new System.Windows.Forms.Label();
            this.cmbQualificationType = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.grpNewQualification.SuspendLayout();
            this.grpQualification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualification)).BeginInit();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewQualification
            // 
            this.grpNewQualification.Controls.Add(this.cmbGrade);
            this.grpNewQualification.Controls.Add(this.lblGrade);
            this.grpNewQualification.Controls.Add(this.cmbSubject);
            this.grpNewQualification.Controls.Add(this.cmbQualificationType);
            this.grpNewQualification.Controls.Add(this.lblSubject);
            this.grpNewQualification.Controls.Add(this.btnAdd);
            this.grpNewQualification.Controls.Add(this.lblQualificationType);
            this.grpNewQualification.Controls.Add(this.lblNewEmployeeID);
            this.grpNewQualification.Controls.Add(this.txtNewEmployeeID);
            this.grpNewQualification.Location = new System.Drawing.Point(382, 255);
            this.grpNewQualification.Name = "grpNewQualification";
            this.grpNewQualification.Size = new System.Drawing.Size(488, 264);
            this.grpNewQualification.TabIndex = 14;
            this.grpNewQualification.TabStop = false;
            this.grpNewQualification.Text = "New Qualification";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblNewEmployeeID
            // 
            this.lblNewEmployeeID.AutoSize = true;
            this.lblNewEmployeeID.Location = new System.Drawing.Point(6, 16);
            this.lblNewEmployeeID.Name = "lblNewEmployeeID";
            this.lblNewEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblNewEmployeeID.TabIndex = 7;
            this.lblNewEmployeeID.Text = "Employee ID";
            // 
            // txtNewEmployeeID
            // 
            this.txtNewEmployeeID.Location = new System.Drawing.Point(79, 13);
            this.txtNewEmployeeID.Name = "txtNewEmployeeID";
            this.txtNewEmployeeID.ReadOnly = true;
            this.txtNewEmployeeID.Size = new System.Drawing.Size(74, 20);
            this.txtNewEmployeeID.TabIndex = 6;
            // 
            // grpQualification
            // 
            this.grpQualification.Controls.Add(this.dgvQualification);
            this.grpQualification.Location = new System.Drawing.Point(382, 12);
            this.grpQualification.Name = "grpQualification";
            this.grpQualification.Size = new System.Drawing.Size(488, 237);
            this.grpQualification.TabIndex = 13;
            this.grpQualification.TabStop = false;
            this.grpQualification.Text = "Current Qualifications";
            // 
            // dgvQualification
            // 
            this.dgvQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQualification.Location = new System.Drawing.Point(3, 16);
            this.dgvQualification.Name = "dgvQualification";
            this.dgvQualification.Size = new System.Drawing.Size(482, 218);
            this.dgvQualification.TabIndex = 0;
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnSelectEmployee);
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
            this.grpEmployee.TabIndex = 12;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(232, 21);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(75, 75);
            this.btnSelectEmployee.TabIndex = 18;
            this.btnSelectEmployee.Text = "Select Employee";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
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
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 125);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Subject";
            // 
            // lblQualificationType
            // 
            this.lblQualificationType.AutoSize = true;
            this.lblQualificationType.Location = new System.Drawing.Point(6, 48);
            this.lblQualificationType.Name = "lblQualificationType";
            this.lblQualificationType.Size = new System.Drawing.Size(92, 13);
            this.lblQualificationType.TabIndex = 7;
            this.lblQualificationType.Text = "Qualification Type";
            // 
            // cmbQualificationType
            // 
            this.cmbQualificationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbQualificationType.FormattingEnabled = true;
            this.cmbQualificationType.Location = new System.Drawing.Point(104, 45);
            this.cmbQualificationType.Name = "cmbQualificationType";
            this.cmbQualificationType.Size = new System.Drawing.Size(121, 21);
            this.cmbQualificationType.TabIndex = 20;
            // 
            // cmbSubject
            // 
            this.cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(55, 122);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 21);
            this.cmbSubject.TabIndex = 21;
            // 
            // cmbGrade
            // 
            this.cmbGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(48, 199);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 21);
            this.cmbGrade.TabIndex = 23;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(6, 202);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 22;
            this.lblGrade.Text = "Grade";
            // 
            // frmAddQualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 532);
            this.Controls.Add(this.grpNewQualification);
            this.Controls.Add(this.grpQualification);
            this.Controls.Add(this.grpEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddQualification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Qualification";
            this.grpNewQualification.ResumeLayout(false);
            this.grpNewQualification.PerformLayout();
            this.grpQualification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualification)).EndInit();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewQualification;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNewEmployeeID;
        private System.Windows.Forms.TextBox txtNewEmployeeID;
        private System.Windows.Forms.GroupBox grpQualification;
        private System.Windows.Forms.DataGridView dgvQualification;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbQualificationType;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblQualificationType;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label lblGrade;
    }
}