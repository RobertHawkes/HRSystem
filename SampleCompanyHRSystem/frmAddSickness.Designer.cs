namespace SampleCompanyHRSystem
{
    partial class frmAddSickness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSickness));
            this.grpNewSickness = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.lblNewEmployeeID = new System.Windows.Forms.Label();
            this.txtNewEmployeeID = new System.Windows.Forms.TextBox();
            this.grpSickness = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSickLineReceived = new System.Windows.Forms.Label();
            this.chkDoctorsNote = new System.Windows.Forms.CheckBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkSelfCert = new System.Windows.Forms.CheckBox();
            this.lblSelfCert = new System.Windows.Forms.Label();
            this.grpNewSickness.SuspendLayout();
            this.grpSickness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewSickness
            // 
            this.grpNewSickness.Controls.Add(this.chkSelfCert);
            this.grpNewSickness.Controls.Add(this.lblSelfCert);
            this.grpNewSickness.Controls.Add(this.textBox1);
            this.grpNewSickness.Controls.Add(this.lblReason);
            this.grpNewSickness.Controls.Add(this.chkDoctorsNote);
            this.grpNewSickness.Controls.Add(this.lblSickLineReceived);
            this.grpNewSickness.Controls.Add(this.btnAdd);
            this.grpNewSickness.Controls.Add(this.dtpToDate);
            this.grpNewSickness.Controls.Add(this.lblToDate);
            this.grpNewSickness.Controls.Add(this.dtpFromDate);
            this.grpNewSickness.Controls.Add(this.txtHoursPerWeek);
            this.grpNewSickness.Controls.Add(this.lblFromDate);
            this.grpNewSickness.Controls.Add(this.lblHoursPerWeek);
            this.grpNewSickness.Controls.Add(this.lblNewEmployeeID);
            this.grpNewSickness.Controls.Add(this.txtNewEmployeeID);
            this.grpNewSickness.Location = new System.Drawing.Point(382, 255);
            this.grpNewSickness.Name = "grpNewSickness";
            this.grpNewSickness.Size = new System.Drawing.Size(488, 264);
            this.grpNewSickness.TabIndex = 11;
            this.grpNewSickness.TabStop = false;
            this.grpNewSickness.Text = "New Sickness";
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
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(42, 121);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(139, 20);
            this.dtpToDate.TabIndex = 12;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(6, 127);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(20, 13);
            this.lblToDate.TabIndex = 11;
            this.lblToDate.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(42, 80);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(139, 20);
            this.dtpFromDate.TabIndex = 10;
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Location = new System.Drawing.Point(98, 45);
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.ReadOnly = true;
            this.txtHoursPerWeek.Size = new System.Drawing.Size(55, 20);
            this.txtHoursPerWeek.TabIndex = 8;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(6, 86);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(30, 13);
            this.lblFromDate.TabIndex = 9;
            this.lblFromDate.Text = "From";
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(6, 48);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(86, 13);
            this.lblHoursPerWeek.TabIndex = 7;
            this.lblHoursPerWeek.Text = "Hours Per Week";
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
            // grpSickness
            // 
            this.grpSickness.Controls.Add(this.dataGridView2);
            this.grpSickness.Location = new System.Drawing.Point(382, 12);
            this.grpSickness.Name = "grpSickness";
            this.grpSickness.Size = new System.Drawing.Size(488, 237);
            this.grpSickness.TabIndex = 10;
            this.grpSickness.TabStop = false;
            this.grpSickness.Text = "Current Sickness";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(482, 218);
            this.dataGridView2.TabIndex = 0;
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
            this.grpEmployee.TabIndex = 9;
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
            // lblSickLineReceived
            // 
            this.lblSickLineReceived.AutoSize = true;
            this.lblSickLineReceived.Location = new System.Drawing.Point(262, 16);
            this.lblSickLineReceived.Name = "lblSickLineReceived";
            this.lblSickLineReceived.Size = new System.Drawing.Size(119, 13);
            this.lblSickLineReceived.TabIndex = 18;
            this.lblSickLineReceived.Text = "Doctors Note Received";
            // 
            // chkDoctorsNote
            // 
            this.chkDoctorsNote.AutoSize = true;
            this.chkDoctorsNote.Location = new System.Drawing.Point(387, 16);
            this.chkDoctorsNote.Name = "chkDoctorsNote";
            this.chkDoctorsNote.Size = new System.Drawing.Size(15, 14);
            this.chkDoctorsNote.TabIndex = 19;
            this.chkDoctorsNote.UseVisualStyleBackColor = true;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(6, 158);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 20;
            this.lblReason.Text = "Reason";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 103);
            this.textBox1.TabIndex = 12;
            // 
            // chkSelfCert
            // 
            this.chkSelfCert.AutoSize = true;
            this.chkSelfCert.Location = new System.Drawing.Point(387, 52);
            this.chkSelfCert.Name = "chkSelfCert";
            this.chkSelfCert.Size = new System.Drawing.Size(15, 14);
            this.chkSelfCert.TabIndex = 22;
            this.chkSelfCert.UseVisualStyleBackColor = true;
            // 
            // lblSelfCert
            // 
            this.lblSelfCert.AutoSize = true;
            this.lblSelfCert.Location = new System.Drawing.Point(262, 52);
            this.lblSelfCert.Name = "lblSelfCert";
            this.lblSelfCert.Size = new System.Drawing.Size(96, 13);
            this.lblSelfCert.TabIndex = 21;
            this.lblSelfCert.Text = "Self Cert Received";
            // 
            // frmAddSickness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 531);
            this.Controls.Add(this.grpNewSickness);
            this.Controls.Add(this.grpSickness);
            this.Controls.Add(this.grpEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddSickness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Sickness";
            this.grpNewSickness.ResumeLayout(false);
            this.grpNewSickness.PerformLayout();
            this.grpSickness.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewSickness;
        private System.Windows.Forms.CheckBox chkSelfCert;
        private System.Windows.Forms.Label lblSelfCert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.CheckBox chkDoctorsNote;
        private System.Windows.Forms.Label lblSickLineReceived;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtHoursPerWeek;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.Label lblNewEmployeeID;
        private System.Windows.Forms.TextBox txtNewEmployeeID;
        private System.Windows.Forms.GroupBox grpSickness;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
    }
}