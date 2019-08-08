namespace SampleCompanyHRSystem
{
    partial class frmViewAnnualLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAnnualLeave));
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.grpAnnualLeave = new System.Windows.Forms.GroupBox();
            this.dgvAnnualLeave = new System.Windows.Forms.DataGridView();
            this.lblCurrentALHours = new System.Windows.Forms.Label();
            this.txtCurrentALHours = new System.Windows.Forms.TextBox();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.lblNewEmployeeID = new System.Windows.Forms.Label();
            this.txtNewEmployeeID = new System.Windows.Forms.TextBox();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.grpAnnualLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnualLeave)).BeginInit();
            this.SuspendLayout();
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
            this.grpEmployee.Size = new System.Drawing.Size(364, 426);
            this.grpEmployee.TabIndex = 7;
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
            this.dgvEmployee.Location = new System.Drawing.Point(6, 119);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(352, 301);
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
            // grpAnnualLeave
            // 
            this.grpAnnualLeave.Controls.Add(this.lblCurrentALHours);
            this.grpAnnualLeave.Controls.Add(this.txtCurrentALHours);
            this.grpAnnualLeave.Controls.Add(this.txtHoursPerWeek);
            this.grpAnnualLeave.Controls.Add(this.lblHoursPerWeek);
            this.grpAnnualLeave.Controls.Add(this.lblNewEmployeeID);
            this.grpAnnualLeave.Controls.Add(this.txtNewEmployeeID);
            this.grpAnnualLeave.Controls.Add(this.dgvAnnualLeave);
            this.grpAnnualLeave.Location = new System.Drawing.Point(382, 12);
            this.grpAnnualLeave.Name = "grpAnnualLeave";
            this.grpAnnualLeave.Size = new System.Drawing.Size(406, 426);
            this.grpAnnualLeave.TabIndex = 8;
            this.grpAnnualLeave.TabStop = false;
            this.grpAnnualLeave.Text = "Annual Leave";
            // 
            // dgvAnnualLeave
            // 
            this.dgvAnnualLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnualLeave.Location = new System.Drawing.Point(3, 16);
            this.dgvAnnualLeave.Name = "dgvAnnualLeave";
            this.dgvAnnualLeave.Size = new System.Drawing.Size(397, 339);
            this.dgvAnnualLeave.TabIndex = 0;
            // 
            // lblCurrentALHours
            // 
            this.lblCurrentALHours.AutoSize = true;
            this.lblCurrentALHours.Location = new System.Drawing.Point(199, 379);
            this.lblCurrentALHours.Name = "lblCurrentALHours";
            this.lblCurrentALHours.Size = new System.Drawing.Size(96, 13);
            this.lblCurrentALHours.TabIndex = 22;
            this.lblCurrentALHours.Text = "Current AL Amount";
            // 
            // txtCurrentALHours
            // 
            this.txtCurrentALHours.Location = new System.Drawing.Point(301, 376);
            this.txtCurrentALHours.Name = "txtCurrentALHours";
            this.txtCurrentALHours.ReadOnly = true;
            this.txtCurrentALHours.Size = new System.Drawing.Size(74, 20);
            this.txtCurrentALHours.TabIndex = 21;
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Location = new System.Drawing.Point(115, 393);
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.ReadOnly = true;
            this.txtHoursPerWeek.Size = new System.Drawing.Size(55, 20);
            this.txtHoursPerWeek.TabIndex = 20;
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(23, 396);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(86, 13);
            this.lblHoursPerWeek.TabIndex = 18;
            this.lblHoursPerWeek.Text = "Hours Per Week";
            // 
            // lblNewEmployeeID
            // 
            this.lblNewEmployeeID.AutoSize = true;
            this.lblNewEmployeeID.Location = new System.Drawing.Point(23, 364);
            this.lblNewEmployeeID.Name = "lblNewEmployeeID";
            this.lblNewEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblNewEmployeeID.TabIndex = 19;
            this.lblNewEmployeeID.Text = "Employee ID";
            // 
            // txtNewEmployeeID
            // 
            this.txtNewEmployeeID.Location = new System.Drawing.Point(96, 361);
            this.txtNewEmployeeID.Name = "txtNewEmployeeID";
            this.txtNewEmployeeID.ReadOnly = true;
            this.txtNewEmployeeID.Size = new System.Drawing.Size(74, 20);
            this.txtNewEmployeeID.TabIndex = 17;
            // 
            // frmViewAnnualLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAnnualLeave);
            this.Controls.Add(this.grpEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewAnnualLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Annual Leave";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.grpAnnualLeave.ResumeLayout(false);
            this.grpAnnualLeave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnualLeave)).EndInit();
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
        private System.Windows.Forms.GroupBox grpAnnualLeave;
        private System.Windows.Forms.DataGridView dgvAnnualLeave;
        private System.Windows.Forms.Label lblCurrentALHours;
        private System.Windows.Forms.TextBox txtCurrentALHours;
        private System.Windows.Forms.TextBox txtHoursPerWeek;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.Label lblNewEmployeeID;
        private System.Windows.Forms.TextBox txtNewEmployeeID;
    }
}