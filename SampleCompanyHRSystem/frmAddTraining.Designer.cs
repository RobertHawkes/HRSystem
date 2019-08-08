namespace SampleCompanyHRSystem
{
    partial class frmAddTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTraining));
            this.grpTraining = new System.Windows.Forms.GroupBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblLengthOfTraining = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTraining
            // 
            this.grpTraining.Controls.Add(this.btnAdd);
            this.grpTraining.Controls.Add(this.nudCost);
            this.grpTraining.Controls.Add(this.lblCost);
            this.grpTraining.Controls.Add(this.dtpExpiryDate);
            this.grpTraining.Controls.Add(this.lblExpiryDate);
            this.grpTraining.Controls.Add(this.nudMinutes);
            this.grpTraining.Controls.Add(this.lblMinutes);
            this.grpTraining.Controls.Add(this.nudHours);
            this.grpTraining.Controls.Add(this.lblHours);
            this.grpTraining.Controls.Add(this.lblLengthOfTraining);
            this.grpTraining.Controls.Add(this.dtpDate);
            this.grpTraining.Controls.Add(this.lblDate);
            this.grpTraining.Controls.Add(this.txtCourseName);
            this.grpTraining.Controls.Add(this.lblCourseName);
            this.grpTraining.Location = new System.Drawing.Point(12, 12);
            this.grpTraining.Name = "grpTraining";
            this.grpTraining.Size = new System.Drawing.Size(352, 215);
            this.grpTraining.TabIndex = 0;
            this.grpTraining.TabStop = false;
            this.grpTraining.Text = "Training";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(6, 16);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(86, 13);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(255, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date of Training:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(98, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(139, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // lblLengthOfTraining
            // 
            this.lblLengthOfTraining.AutoSize = true;
            this.lblLengthOfTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthOfTraining.Location = new System.Drawing.Point(6, 103);
            this.lblLengthOfTraining.Name = "lblLengthOfTraining";
            this.lblLengthOfTraining.Size = new System.Drawing.Size(93, 13);
            this.lblLengthOfTraining.TabIndex = 12;
            this.lblLengthOfTraining.Text = "Length of Training";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(27, 126);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Hours";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(30, 142);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(45, 20);
            this.nudHours.TabIndex = 13;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(110, 142);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(45, 20);
            this.nudMinutes.TabIndex = 15;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(107, 126);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 14;
            this.lblMinutes.Text = "Minutes";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(76, 174);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(139, 20);
            this.dtpExpiryDate.TabIndex = 24;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(6, 178);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(64, 13);
            this.lblExpiryDate.TabIndex = 23;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(6, 75);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 25;
            this.lblCost.Text = "Cost:";
            // 
            // nudCost
            // 
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Location = new System.Drawing.Point(43, 73);
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(83, 20);
            this.nudCost.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 239);
            this.Controls.Add(this.grpTraining);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Training";
            this.grpTraining.ResumeLayout(false);
            this.grpTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTraining;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblLengthOfTraining;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnAdd;
    }
}