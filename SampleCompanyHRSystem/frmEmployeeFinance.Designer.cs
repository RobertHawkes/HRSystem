namespace SampleCompanyHRSystem
{
    partial class frmEmployeeFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeFinance));
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.mtbMobNo = new System.Windows.Forms.MaskedTextBox();
            this.lblMobNo = new System.Windows.Forms.Label();
            this.grpEmployeeAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtNINO = new System.Windows.Forms.TextBox();
            this.lblNINO = new System.Windows.Forms.Label();
            this.mtbDOB = new System.Windows.Forms.MaskedTextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtKnownAs = new System.Windows.Forms.TextBox();
            this.lblKnownAs = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.grpEmployeeImage = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.grpStaffContact = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.mtbStaffMobNo = new System.Windows.Forms.MaskedTextBox();
            this.lblStaffMobNo = new System.Windows.Forms.Label();
            this.grpContract = new System.Windows.Forms.GroupBox();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.grpAbsence = new System.Windows.Forms.GroupBox();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSickness = new System.Windows.Forms.GroupBox();
            this.dgvSickness = new System.Windows.Forms.DataGridView();
            this.grpBank = new System.Windows.Forms.GroupBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankAddress = new System.Windows.Forms.TextBox();
            this.lblBankAddress = new System.Windows.Forms.Label();
            this.mtbBankTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblBankTelNo = new System.Windows.Forms.Label();
            this.mtbBankAccountNo = new System.Windows.Forms.MaskedTextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.mtbBankSortCode = new System.Windows.Forms.MaskedTextBox();
            this.lblBankSortCode = new System.Windows.Forms.Label();
            this.lblBankNameOfAccount = new System.Windows.Forms.Label();
            this.txtBankNameOfAccount = new System.Windows.Forms.TextBox();
            this.grpContact.SuspendLayout();
            this.grpEmployeeAddress.SuspendLayout();
            this.grpEmployeeDetails.SuspendLayout();
            this.grpEmployeeImage.SuspendLayout();
            this.grpStaffContact.SuspendLayout();
            this.grpContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.grpAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSickness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSickness)).BeginInit();
            this.grpBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.mtbTelNo);
            this.grpContact.Controls.Add(this.lblTelNo);
            this.grpContact.Controls.Add(this.mtbMobNo);
            this.grpContact.Controls.Add(this.lblMobNo);
            this.grpContact.Location = new System.Drawing.Point(348, 161);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(235, 114);
            this.grpContact.TabIndex = 7;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // mtbTelNo
            // 
            this.mtbTelNo.Location = new System.Drawing.Point(63, 51);
            this.mtbTelNo.Mask = "00000000000";
            this.mtbTelNo.Name = "mtbTelNo";
            this.mtbTelNo.Size = new System.Drawing.Size(87, 20);
            this.mtbTelNo.TabIndex = 7;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(9, 54);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(42, 13);
            this.lblTelNo.TabIndex = 6;
            this.lblTelNo.Text = "Tel No:";
            // 
            // mtbMobNo
            // 
            this.mtbMobNo.Location = new System.Drawing.Point(63, 21);
            this.mtbMobNo.Mask = "00000000000";
            this.mtbMobNo.Name = "mtbMobNo";
            this.mtbMobNo.Size = new System.Drawing.Size(87, 20);
            this.mtbMobNo.TabIndex = 5;
            // 
            // lblMobNo
            // 
            this.lblMobNo.AutoSize = true;
            this.lblMobNo.Location = new System.Drawing.Point(9, 24);
            this.lblMobNo.Name = "lblMobNo";
            this.lblMobNo.Size = new System.Drawing.Size(48, 13);
            this.lblMobNo.TabIndex = 4;
            this.lblMobNo.Text = "Mob No:";
            // 
            // grpEmployeeAddress
            // 
            this.grpEmployeeAddress.Controls.Add(this.txtAddress);
            this.grpEmployeeAddress.Location = new System.Drawing.Point(348, 12);
            this.grpEmployeeAddress.Name = "grpEmployeeAddress";
            this.grpEmployeeAddress.Size = new System.Drawing.Size(235, 143);
            this.grpEmployeeAddress.TabIndex = 6;
            this.grpEmployeeAddress.TabStop = false;
            this.grpEmployeeAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(3, 16);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 124);
            this.txtAddress.TabIndex = 3;
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.txtTaxCode);
            this.grpEmployeeDetails.Controls.Add(this.lblTaxCode);
            this.grpEmployeeDetails.Controls.Add(this.txtNINO);
            this.grpEmployeeDetails.Controls.Add(this.lblNINO);
            this.grpEmployeeDetails.Controls.Add(this.mtbDOB);
            this.grpEmployeeDetails.Controls.Add(this.lblDOB);
            this.grpEmployeeDetails.Controls.Add(this.txtKnownAs);
            this.grpEmployeeDetails.Controls.Add(this.lblKnownAs);
            this.grpEmployeeDetails.Controls.Add(this.txtInitials);
            this.grpEmployeeDetails.Controls.Add(this.lblInitials);
            this.grpEmployeeDetails.Controls.Add(this.txtSurname);
            this.grpEmployeeDetails.Controls.Add(this.lblSurname);
            this.grpEmployeeDetails.Controls.Add(this.txtMiddleName);
            this.grpEmployeeDetails.Controls.Add(this.lblMiddleName);
            this.grpEmployeeDetails.Controls.Add(this.txtTitle);
            this.grpEmployeeDetails.Controls.Add(this.lblTitle);
            this.grpEmployeeDetails.Controls.Add(this.txtID);
            this.grpEmployeeDetails.Controls.Add(this.lblID);
            this.grpEmployeeDetails.Controls.Add(this.txtForename);
            this.grpEmployeeDetails.Controls.Add(this.lblForename);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(148, 12);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(194, 304);
            this.grpEmployeeDetails.TabIndex = 5;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Details";
            // 
            // txtNINO
            // 
            this.txtNINO.Location = new System.Drawing.Point(51, 243);
            this.txtNINO.Name = "txtNINO";
            this.txtNINO.Size = new System.Drawing.Size(100, 20);
            this.txtNINO.TabIndex = 17;
            // 
            // lblNINO
            // 
            this.lblNINO.AutoSize = true;
            this.lblNINO.Location = new System.Drawing.Point(6, 246);
            this.lblNINO.Name = "lblNINO";
            this.lblNINO.Size = new System.Drawing.Size(38, 13);
            this.lblNINO.TabIndex = 16;
            this.lblNINO.Text = "NI No:";
            // 
            // mtbDOB
            // 
            this.mtbDOB.Location = new System.Drawing.Point(45, 212);
            this.mtbDOB.Mask = "00/00/0000";
            this.mtbDOB.Name = "mtbDOB";
            this.mtbDOB.Size = new System.Drawing.Size(100, 20);
            this.mtbDOB.TabIndex = 15;
            this.mtbDOB.ValidatingType = typeof(System.DateTime);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(6, 215);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(33, 13);
            this.lblDOB.TabIndex = 14;
            this.lblDOB.Text = "DOB:";
            // 
            // txtKnownAs
            // 
            this.txtKnownAs.Location = new System.Drawing.Point(69, 72);
            this.txtKnownAs.Name = "txtKnownAs";
            this.txtKnownAs.Size = new System.Drawing.Size(100, 20);
            this.txtKnownAs.TabIndex = 13;
            // 
            // lblKnownAs
            // 
            this.lblKnownAs.AutoSize = true;
            this.lblKnownAs.Location = new System.Drawing.Point(6, 75);
            this.lblKnownAs.Name = "lblKnownAs";
            this.lblKnownAs.Size = new System.Drawing.Size(58, 13);
            this.lblKnownAs.TabIndex = 12;
            this.lblKnownAs.Text = "Known As:";
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(51, 180);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 11;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(6, 183);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(39, 13);
            this.lblInitials.TabIndex = 10;
            this.lblInitials.Text = "Initials:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(69, 156);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 9;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 159);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(82, 129);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 7;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(6, 132);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(42, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(33, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(69, 98);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 1;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(6, 101);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // grpEmployeeImage
            // 
            this.grpEmployeeImage.Controls.Add(this.btnDelete);
            this.grpEmployeeImage.Controls.Add(this.btnUpload);
            this.grpEmployeeImage.Controls.Add(this.pictureBox1);
            this.grpEmployeeImage.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeImage.Name = "grpEmployeeImage";
            this.grpEmployeeImage.Size = new System.Drawing.Size(130, 299);
            this.grpEmployeeImage.TabIndex = 4;
            this.grpEmployeeImage.TabStop = false;
            this.grpEmployeeImage.Text = "Image";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(65, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(3, 210);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(53, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(68, 271);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(100, 20);
            this.txtTaxCode.TabIndex = 19;
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.AutoSize = true;
            this.lblTaxCode.Location = new System.Drawing.Point(6, 274);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(56, 13);
            this.lblTaxCode.TabIndex = 18;
            this.lblTaxCode.Text = "Tax Code:";
            // 
            // grpStaffContact
            // 
            this.grpStaffContact.Controls.Add(this.textBox2);
            this.grpStaffContact.Controls.Add(this.lblStaffEmail);
            this.grpStaffContact.Controls.Add(this.mtbStaffMobNo);
            this.grpStaffContact.Controls.Add(this.lblStaffMobNo);
            this.grpStaffContact.Location = new System.Drawing.Point(589, 168);
            this.grpStaffContact.Name = "grpStaffContact";
            this.grpStaffContact.Size = new System.Drawing.Size(235, 77);
            this.grpStaffContact.TabIndex = 10;
            this.grpStaffContact.TabStop = false;
            this.grpStaffContact.Text = "Staff Contact";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 9;
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Location = new System.Drawing.Point(9, 51);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(60, 13);
            this.lblStaffEmail.TabIndex = 8;
            this.lblStaffEmail.Text = "Staff Email:";
            // 
            // mtbStaffMobNo
            // 
            this.mtbStaffMobNo.Location = new System.Drawing.Point(88, 21);
            this.mtbStaffMobNo.Mask = "00000000000";
            this.mtbStaffMobNo.Name = "mtbStaffMobNo";
            this.mtbStaffMobNo.Size = new System.Drawing.Size(87, 20);
            this.mtbStaffMobNo.TabIndex = 5;
            // 
            // lblStaffMobNo
            // 
            this.lblStaffMobNo.AutoSize = true;
            this.lblStaffMobNo.Location = new System.Drawing.Point(9, 24);
            this.lblStaffMobNo.Name = "lblStaffMobNo";
            this.lblStaffMobNo.Size = new System.Drawing.Size(73, 13);
            this.lblStaffMobNo.TabIndex = 4;
            this.lblStaffMobNo.Text = "Staff Mob No:";
            // 
            // grpContract
            // 
            this.grpContract.Controls.Add(this.dgvContract);
            this.grpContract.Location = new System.Drawing.Point(12, 424);
            this.grpContract.Name = "grpContract";
            this.grpContract.Size = new System.Drawing.Size(346, 180);
            this.grpContract.TabIndex = 11;
            this.grpContract.TabStop = false;
            this.grpContract.Text = "Contract";
            // 
            // dgvContract
            // 
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.Location = new System.Drawing.Point(3, 16);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.Size = new System.Drawing.Size(340, 161);
            this.dgvContract.TabIndex = 0;
            // 
            // grpAbsence
            // 
            this.grpAbsence.Controls.Add(this.dgvAbsence);
            this.grpAbsence.Location = new System.Drawing.Point(364, 424);
            this.grpAbsence.Name = "grpAbsence";
            this.grpAbsence.Size = new System.Drawing.Size(213, 180);
            this.grpAbsence.TabIndex = 12;
            this.grpAbsence.TabStop = false;
            this.grpAbsence.Text = "Absence";
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbsence.Location = new System.Drawing.Point(3, 16);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.Size = new System.Drawing.Size(207, 161);
            this.dgvAbsence.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpSickness
            // 
            this.grpSickness.Controls.Add(this.dgvSickness);
            this.grpSickness.Location = new System.Drawing.Point(583, 424);
            this.grpSickness.Name = "grpSickness";
            this.grpSickness.Size = new System.Drawing.Size(213, 180);
            this.grpSickness.TabIndex = 13;
            this.grpSickness.TabStop = false;
            this.grpSickness.Text = "Sickness";
            // 
            // dgvSickness
            // 
            this.dgvSickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSickness.Location = new System.Drawing.Point(3, 16);
            this.dgvSickness.Name = "dgvSickness";
            this.dgvSickness.Size = new System.Drawing.Size(207, 161);
            this.dgvSickness.TabIndex = 0;
            // 
            // grpBank
            // 
            this.grpBank.Controls.Add(this.txtBankNameOfAccount);
            this.grpBank.Controls.Add(this.mtbBankSortCode);
            this.grpBank.Controls.Add(this.lblBankNameOfAccount);
            this.grpBank.Controls.Add(this.mtbBankAccountNo);
            this.grpBank.Controls.Add(this.lblBankSortCode);
            this.grpBank.Controls.Add(this.mtbBankTelNo);
            this.grpBank.Controls.Add(this.lblAccountNo);
            this.grpBank.Controls.Add(this.txtBankAddress);
            this.grpBank.Controls.Add(this.lblBankTelNo);
            this.grpBank.Controls.Add(this.lblBankAddress);
            this.grpBank.Controls.Add(this.txtBankName);
            this.grpBank.Controls.Add(this.lblBankName);
            this.grpBank.Location = new System.Drawing.Point(861, 334);
            this.grpBank.Name = "grpBank";
            this.grpBank.Size = new System.Drawing.Size(277, 336);
            this.grpBank.TabIndex = 11;
            this.grpBank.TabStop = false;
            this.grpBank.Text = "Bank";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(6, 16);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(38, 13);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Name:";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(50, 13);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(179, 20);
            this.txtBankName.TabIndex = 10;
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.Location = new System.Drawing.Point(60, 44);
            this.txtBankAddress.Multiline = true;
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(179, 76);
            this.txtBankAddress.TabIndex = 12;
            // 
            // lblBankAddress
            // 
            this.lblBankAddress.AutoSize = true;
            this.lblBankAddress.Location = new System.Drawing.Point(6, 47);
            this.lblBankAddress.Name = "lblBankAddress";
            this.lblBankAddress.Size = new System.Drawing.Size(48, 13);
            this.lblBankAddress.TabIndex = 11;
            this.lblBankAddress.Text = "Address:";
            // 
            // mtbBankTelNo
            // 
            this.mtbBankTelNo.Location = new System.Drawing.Point(60, 134);
            this.mtbBankTelNo.Mask = "00000000000";
            this.mtbBankTelNo.Name = "mtbBankTelNo";
            this.mtbBankTelNo.Size = new System.Drawing.Size(87, 20);
            this.mtbBankTelNo.TabIndex = 11;
            // 
            // lblBankTelNo
            // 
            this.lblBankTelNo.AutoSize = true;
            this.lblBankTelNo.Location = new System.Drawing.Point(6, 137);
            this.lblBankTelNo.Name = "lblBankTelNo";
            this.lblBankTelNo.Size = new System.Drawing.Size(42, 13);
            this.lblBankTelNo.TabIndex = 10;
            this.lblBankTelNo.Text = "Tel No:";
            // 
            // mtbBankAccountNo
            // 
            this.mtbBankAccountNo.Location = new System.Drawing.Point(79, 164);
            this.mtbBankAccountNo.Mask = "00000000";
            this.mtbBankAccountNo.Name = "mtbBankAccountNo";
            this.mtbBankAccountNo.Size = new System.Drawing.Size(87, 20);
            this.mtbBankAccountNo.TabIndex = 15;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(6, 167);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 14;
            this.lblAccountNo.Text = "Account No:";
            // 
            // mtbBankSortCode
            // 
            this.mtbBankSortCode.Location = new System.Drawing.Point(60, 194);
            this.mtbBankSortCode.Mask = "00-00-00";
            this.mtbBankSortCode.Name = "mtbBankSortCode";
            this.mtbBankSortCode.Size = new System.Drawing.Size(87, 20);
            this.mtbBankSortCode.TabIndex = 11;
            // 
            // lblBankSortCode
            // 
            this.lblBankSortCode.AutoSize = true;
            this.lblBankSortCode.Location = new System.Drawing.Point(6, 197);
            this.lblBankSortCode.Name = "lblBankSortCode";
            this.lblBankSortCode.Size = new System.Drawing.Size(48, 13);
            this.lblBankSortCode.TabIndex = 10;
            this.lblBankSortCode.Text = "Mob No:";
            // 
            // lblBankNameOfAccount
            // 
            this.lblBankNameOfAccount.AutoSize = true;
            this.lblBankNameOfAccount.Location = new System.Drawing.Point(6, 228);
            this.lblBankNameOfAccount.Name = "lblBankNameOfAccount";
            this.lblBankNameOfAccount.Size = new System.Drawing.Size(93, 13);
            this.lblBankNameOfAccount.TabIndex = 14;
            this.lblBankNameOfAccount.Text = "Name of Account:";
            // 
            // txtBankNameOfAccount
            // 
            this.txtBankNameOfAccount.Location = new System.Drawing.Point(105, 225);
            this.txtBankNameOfAccount.Name = "txtBankNameOfAccount";
            this.txtBankNameOfAccount.Size = new System.Drawing.Size(134, 20);
            this.txtBankNameOfAccount.TabIndex = 16;
            // 
            // frmEmployeeFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 831);
            this.Controls.Add(this.grpBank);
            this.Controls.Add(this.grpSickness);
            this.Controls.Add(this.grpAbsence);
            this.Controls.Add(this.grpContract);
            this.Controls.Add(this.grpStaffContact);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpEmployeeAddress);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.grpEmployeeImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee - Finance";
            this.Load += new System.EventHandler(this.FrmEmployeeFinance_Load);
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpEmployeeAddress.ResumeLayout(false);
            this.grpEmployeeAddress.PerformLayout();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            this.grpEmployeeImage.ResumeLayout(false);
            this.grpStaffContact.ResumeLayout(false);
            this.grpStaffContact.PerformLayout();
            this.grpContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.grpAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSickness.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSickness)).EndInit();
            this.grpBank.ResumeLayout(false);
            this.grpBank.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.MaskedTextBox mtbMobNo;
        private System.Windows.Forms.Label lblMobNo;
        private System.Windows.Forms.GroupBox grpEmployeeAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.TextBox txtNINO;
        private System.Windows.Forms.Label lblNINO;
        private System.Windows.Forms.MaskedTextBox mtbDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtKnownAs;
        private System.Windows.Forms.Label lblKnownAs;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.GroupBox grpEmployeeImage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpStaffContact;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.MaskedTextBox mtbStaffMobNo;
        private System.Windows.Forms.Label lblStaffMobNo;
        private System.Windows.Forms.GroupBox grpContract;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.GroupBox grpAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.GroupBox grpSickness;
        private System.Windows.Forms.DataGridView dgvSickness;
        private System.Windows.Forms.GroupBox grpBank;
        private System.Windows.Forms.MaskedTextBox mtbBankTelNo;
        private System.Windows.Forms.TextBox txtBankAddress;
        private System.Windows.Forms.Label lblBankTelNo;
        private System.Windows.Forms.Label lblBankAddress;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.MaskedTextBox mtbBankAccountNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.MaskedTextBox mtbBankSortCode;
        private System.Windows.Forms.Label lblBankSortCode;
        private System.Windows.Forms.TextBox txtBankNameOfAccount;
        private System.Windows.Forms.Label lblBankNameOfAccount;
    }
}