namespace SampleCompanyHRSystem
{
    partial class frmAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddService));
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.mtbPostCode = new System.Windows.Forms.MaskedTextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.grpService = new System.Windows.Forms.GroupBox();
            this.grpSelectedRegisteredManager = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.dgvRegisteredManagers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.txtManagerSurname = new System.Windows.Forms.TextBox();
            this.lblManagerSurname = new System.Windows.Forms.Label();
            this.txtManagerForename = new System.Windows.Forms.TextBox();
            this.lblManagerForename = new System.Windows.Forms.Label();
            this.grpService.SuspendLayout();
            this.grpSelectedRegisteredManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(6, 19);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(77, 13);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service Name:";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(89, 16);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(160, 20);
            this.txtServiceName.TabIndex = 1;
            // 
            // mtbPostCode
            // 
            this.mtbPostCode.Location = new System.Drawing.Point(68, 162);
            this.mtbPostCode.Mask = ">LCCC 9LL";
            this.mtbPostCode.Name = "mtbPostCode";
            this.mtbPostCode.Size = new System.Drawing.Size(134, 20);
            this.mtbPostCode.TabIndex = 31;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(6, 165);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(56, 13);
            this.lblPostcode.TabIndex = 30;
            this.lblPostcode.Text = "PostCode:";
            // 
            // cmbCounty
            // 
            this.cmbCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Londonderry",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cmbCounty.Location = new System.Drawing.Point(55, 131);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(121, 21);
            this.cmbCounty.Sorted = true;
            this.cmbCounty.TabIndex = 29;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(6, 134);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 28;
            this.lblCounty.Text = "County:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(49, 101);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(93, 20);
            this.txtTown.TabIndex = 27;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(6, 104);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 26;
            this.lblTown.Text = "Town:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(69, 72);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(131, 20);
            this.txtAddress2.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 46);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 13);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address 1:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(6, 75);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(57, 13);
            this.lblAddress2.TabIndex = 24;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(69, 43);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(131, 20);
            this.txtAddress1.TabIndex = 23;
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.txtManagerForename);
            this.grpService.Controls.Add(this.lblManagerForename);
            this.grpService.Controls.Add(this.txtManagerSurname);
            this.grpService.Controls.Add(this.lblManagerSurname);
            this.grpService.Controls.Add(this.txtManagerID);
            this.grpService.Controls.Add(this.btnAdd);
            this.grpService.Controls.Add(this.lblManagerID);
            this.grpService.Controls.Add(this.lblServiceName);
            this.grpService.Controls.Add(this.mtbPostCode);
            this.grpService.Controls.Add(this.txtServiceName);
            this.grpService.Controls.Add(this.lblPostcode);
            this.grpService.Controls.Add(this.lblAddress);
            this.grpService.Controls.Add(this.cmbCounty);
            this.grpService.Controls.Add(this.txtAddress1);
            this.grpService.Controls.Add(this.lblCounty);
            this.grpService.Controls.Add(this.lblAddress2);
            this.grpService.Controls.Add(this.txtTown);
            this.grpService.Controls.Add(this.txtAddress2);
            this.grpService.Controls.Add(this.lblTown);
            this.grpService.Location = new System.Drawing.Point(12, 12);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(322, 318);
            this.grpService.TabIndex = 32;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service Info";
            // 
            // grpSelectedRegisteredManager
            // 
            this.grpSelectedRegisteredManager.Controls.Add(this.btnSelect);
            this.grpSelectedRegisteredManager.Controls.Add(this.txtSurname);
            this.grpSelectedRegisteredManager.Controls.Add(this.lblSurname);
            this.grpSelectedRegisteredManager.Controls.Add(this.txtEmployeeID);
            this.grpSelectedRegisteredManager.Controls.Add(this.lblEmployeeID);
            this.grpSelectedRegisteredManager.Controls.Add(this.dgvRegisteredManagers);
            this.grpSelectedRegisteredManager.Location = new System.Drawing.Point(340, 12);
            this.grpSelectedRegisteredManager.Name = "grpSelectedRegisteredManager";
            this.grpSelectedRegisteredManager.Size = new System.Drawing.Size(448, 318);
            this.grpSelectedRegisteredManager.TabIndex = 33;
            this.grpSelectedRegisteredManager.TabStop = false;
            this.grpSelectedRegisteredManager.Text = "Select Registered Manager";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(354, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 35;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(245, 13);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(85, 20);
            this.txtSurname.TabIndex = 34;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(187, 16);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 33;
            this.lblSurname.Text = "Surname:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(82, 13);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(85, 20);
            this.txtEmployeeID.TabIndex = 32;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(6, 16);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // dgvRegisteredManagers
            // 
            this.dgvRegisteredManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredManagers.Location = new System.Drawing.Point(6, 39);
            this.dgvRegisteredManagers.Name = "dgvRegisteredManagers";
            this.dgvRegisteredManagers.Size = new System.Drawing.Size(436, 273);
            this.dgvRegisteredManagers.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtManagerID
            // 
            this.txtManagerID.Location = new System.Drawing.Point(82, 194);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.ReadOnly = true;
            this.txtManagerID.Size = new System.Drawing.Size(85, 20);
            this.txtManagerID.TabIndex = 37;
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Location = new System.Drawing.Point(6, 197);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(66, 13);
            this.lblManagerID.TabIndex = 36;
            this.lblManagerID.Text = "Manager ID:";
            // 
            // txtManagerSurname
            // 
            this.txtManagerSurname.Location = new System.Drawing.Point(109, 222);
            this.txtManagerSurname.Name = "txtManagerSurname";
            this.txtManagerSurname.ReadOnly = true;
            this.txtManagerSurname.Size = new System.Drawing.Size(112, 20);
            this.txtManagerSurname.TabIndex = 39;
            // 
            // lblManagerSurname
            // 
            this.lblManagerSurname.AutoSize = true;
            this.lblManagerSurname.Location = new System.Drawing.Point(6, 225);
            this.lblManagerSurname.Name = "lblManagerSurname";
            this.lblManagerSurname.Size = new System.Drawing.Size(97, 13);
            this.lblManagerSurname.TabIndex = 38;
            this.lblManagerSurname.Text = "Manager Surname:";
            // 
            // txtManagerForename
            // 
            this.txtManagerForename.Location = new System.Drawing.Point(114, 255);
            this.txtManagerForename.Name = "txtManagerForename";
            this.txtManagerForename.ReadOnly = true;
            this.txtManagerForename.Size = new System.Drawing.Size(112, 20);
            this.txtManagerForename.TabIndex = 41;
            // 
            // lblManagerForename
            // 
            this.lblManagerForename.AutoSize = true;
            this.lblManagerForename.Location = new System.Drawing.Point(6, 258);
            this.lblManagerForename.Name = "lblManagerForename";
            this.lblManagerForename.Size = new System.Drawing.Size(102, 13);
            this.lblManagerForename.TabIndex = 40;
            this.lblManagerForename.Text = "Manager Forename:";
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.grpSelectedRegisteredManager);
            this.Controls.Add(this.grpService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Service";
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            this.grpSelectedRegisteredManager.ResumeLayout(false);
            this.grpSelectedRegisteredManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredManagers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.MaskedTextBox mtbPostCode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.GroupBox grpSelectedRegisteredManager;
        private System.Windows.Forms.DataGridView dgvRegisteredManagers;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtManagerForename;
        private System.Windows.Forms.Label lblManagerForename;
        private System.Windows.Forms.TextBox txtManagerSurname;
        private System.Windows.Forms.Label lblManagerSurname;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.Label lblManagerID;
    }
}