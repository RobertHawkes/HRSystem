namespace SampleCompanyHRSystem
{
    partial class frmAddAnnualLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAnnualLeave));
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAnnualLeave = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpNewAnnualLeave = new System.Windows.Forms.GroupBox();
            this.lblNewEmployeeID = new System.Windows.Forms.Label();
            this.txtNewEmployeeID = new System.Windows.Forms.TextBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblCurrentALHours = new System.Windows.Forms.Label();
            this.txtCurrentALHours = new System.Windows.Forms.TextBox();
            this.lblNewALHours = new System.Windows.Forms.Label();
            this.txtNewALHours = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAnnualLeave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpNewAnnualLeave.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(79, 13);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 0;
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
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(6, 83);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(66, 80);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 5;
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.btnSelectEmployee);
            this.grpEmployee.Controls.Add(this.dataGridView1);
            this.grpEmployee.Controls.Add(this.lblEmployeeID);
            this.grpEmployee.Controls.Add(this.txtForename);
            this.grpEmployee.Controls.Add(this.txtEmployeeID);
            this.grpEmployee.Controls.Add(this.lblForename);
            this.grpEmployee.Controls.Add(this.lblSurname);
            this.grpEmployee.Controls.Add(this.txtSurname);
            this.grpEmployee.Location = new System.Drawing.Point(12, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(364, 426);
            this.grpEmployee.TabIndex = 6;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 307);
            this.dataGridView1.TabIndex = 6;
            // 
            // grpAnnualLeave
            // 
            this.grpAnnualLeave.Controls.Add(this.dataGridView2);
            this.grpAnnualLeave.Location = new System.Drawing.Point(382, 12);
            this.grpAnnualLeave.Name = "grpAnnualLeave";
            this.grpAnnualLeave.Size = new System.Drawing.Size(406, 237);
            this.grpAnnualLeave.TabIndex = 7;
            this.grpAnnualLeave.TabStop = false;
            this.grpAnnualLeave.Text = "Current Annual Leave";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(400, 218);
            this.dataGridView2.TabIndex = 0;
            // 
            // grpNewAnnualLeave
            // 
            this.grpNewAnnualLeave.Controls.Add(this.btnAdd);
            this.grpNewAnnualLeave.Controls.Add(this.lblNewALHours);
            this.grpNewAnnualLeave.Controls.Add(this.txtNewALHours);
            this.grpNewAnnualLeave.Controls.Add(this.lblCurrentALHours);
            this.grpNewAnnualLeave.Controls.Add(this.txtCurrentALHours);
            this.grpNewAnnualLeave.Controls.Add(this.dtpToDate);
            this.grpNewAnnualLeave.Controls.Add(this.lblToDate);
            this.grpNewAnnualLeave.Controls.Add(this.dtpFromDate);
            this.grpNewAnnualLeave.Controls.Add(this.txtHoursPerWeek);
            this.grpNewAnnualLeave.Controls.Add(this.lblFromDate);
            this.grpNewAnnualLeave.Controls.Add(this.lblHoursPerWeek);
            this.grpNewAnnualLeave.Controls.Add(this.lblNewEmployeeID);
            this.grpNewAnnualLeave.Controls.Add(this.txtNewEmployeeID);
            this.grpNewAnnualLeave.Location = new System.Drawing.Point(382, 255);
            this.grpNewAnnualLeave.Name = "grpNewAnnualLeave";
            this.grpNewAnnualLeave.Size = new System.Drawing.Size(406, 183);
            this.grpNewAnnualLeave.TabIndex = 8;
            this.grpNewAnnualLeave.TabStop = false;
            this.grpNewAnnualLeave.Text = "New Annual Leave";
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
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(6, 86);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(30, 13);
            this.lblFromDate.TabIndex = 9;
            this.lblFromDate.Text = "From";
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Location = new System.Drawing.Point(98, 45);
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.ReadOnly = true;
            this.txtHoursPerWeek.Size = new System.Drawing.Size(55, 20);
            this.txtHoursPerWeek.TabIndex = 8;
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
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(42, 80);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(139, 20);
            this.dtpFromDate.TabIndex = 10;
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
            // lblCurrentALHours
            // 
            this.lblCurrentALHours.AutoSize = true;
            this.lblCurrentALHours.Location = new System.Drawing.Point(191, 16);
            this.lblCurrentALHours.Name = "lblCurrentALHours";
            this.lblCurrentALHours.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentALHours.TabIndex = 14;
            this.lblCurrentALHours.Text = "Current AL Hours";
            // 
            // txtCurrentALHours
            // 
            this.txtCurrentALHours.Location = new System.Drawing.Point(285, 13);
            this.txtCurrentALHours.Name = "txtCurrentALHours";
            this.txtCurrentALHours.ReadOnly = true;
            this.txtCurrentALHours.Size = new System.Drawing.Size(74, 20);
            this.txtCurrentALHours.TabIndex = 13;
            // 
            // lblNewALHours
            // 
            this.lblNewALHours.AutoSize = true;
            this.lblNewALHours.Location = new System.Drawing.Point(191, 48);
            this.lblNewALHours.Name = "lblNewALHours";
            this.lblNewALHours.Size = new System.Drawing.Size(76, 13);
            this.lblNewALHours.TabIndex = 16;
            this.lblNewALHours.Text = "New AL Hours";
            // 
            // txtNewALHours
            // 
            this.txtNewALHours.Location = new System.Drawing.Point(285, 45);
            this.txtNewALHours.Name = "txtNewALHours";
            this.txtNewALHours.ReadOnly = true;
            this.txtNewALHours.Size = new System.Drawing.Size(74, 20);
            this.txtNewALHours.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // frmAddAnnualLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpNewAnnualLeave);
            this.Controls.Add(this.grpAnnualLeave);
            this.Controls.Add(this.grpEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddAnnualLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Annual Leave";
            this.Load += new System.EventHandler(this.FrmAddAnnualLeave_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAnnualLeave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpNewAnnualLeave.ResumeLayout(false);
            this.grpNewAnnualLeave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpAnnualLeave;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grpNewAnnualLeave;
        private System.Windows.Forms.Label lblNewEmployeeID;
        private System.Windows.Forms.TextBox txtNewEmployeeID;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNewALHours;
        private System.Windows.Forms.TextBox txtNewALHours;
        private System.Windows.Forms.Label lblCurrentALHours;
        private System.Windows.Forms.TextBox txtCurrentALHours;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtHoursPerWeek;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.Button btnSelectEmployee;
    }
}