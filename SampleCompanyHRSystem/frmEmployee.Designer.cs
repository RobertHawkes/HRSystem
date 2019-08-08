namespace SampleCompanyHRSystem
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.grpEmployeeImage = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
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
            this.grpEmployeeAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.mtbMobNo = new System.Windows.Forms.MaskedTextBox();
            this.lblMobNo = new System.Windows.Forms.Label();
            this.grpBackground = new System.Windows.Forms.GroupBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cmbEthnicOrigin = new System.Windows.Forms.ComboBox();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblEthnicOrigin = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblMartialStatus = new System.Windows.Forms.Label();
            this.grpDisabled = new System.Windows.Forms.GroupBox();
            this.dgvDisability = new System.Windows.Forms.DataGridView();
            this.grpTraining = new System.Windows.Forms.GroupBox();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.grpDisciplinary = new System.Windows.Forms.GroupBox();
            this.dgvDisciplinary = new System.Windows.Forms.DataGridView();
            this.grpCommunity = new System.Windows.Forms.GroupBox();
            this.cmbCommunity = new System.Windows.Forms.ComboBox();
            this.lblCommunity = new System.Windows.Forms.Label();
            this.grpService = new System.Windows.Forms.GroupBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.grpQualifications = new System.Windows.Forms.GroupBox();
            this.dgvQualification = new System.Windows.Forms.DataGridView();
            this.grpContract = new System.Windows.Forms.GroupBox();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.grpLeaver = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkLeaverConfirm = new System.Windows.Forms.CheckBox();
            this.grpAppraisal = new System.Windows.Forms.GroupBox();
            this.dgvAppraisal = new System.Windows.Forms.DataGridView();
            this.grpEmployeeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEmployeeDetails.SuspendLayout();
            this.grpEmployeeAddress.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpBackground.SuspendLayout();
            this.grpDisabled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisability)).BeginInit();
            this.grpTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.grpDisciplinary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinary)).BeginInit();
            this.grpCommunity.SuspendLayout();
            this.grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.grpQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualification)).BeginInit();
            this.grpContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.grpLeaver.SuspendLayout();
            this.grpAppraisal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppraisal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployeeImage
            // 
            this.grpEmployeeImage.Controls.Add(this.btnDelete);
            this.grpEmployeeImage.Controls.Add(this.btnUpload);
            this.grpEmployeeImage.Controls.Add(this.pictureBox1);
            this.grpEmployeeImage.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeImage.Name = "grpEmployeeImage";
            this.grpEmployeeImage.Size = new System.Drawing.Size(130, 253);
            this.grpEmployeeImage.TabIndex = 0;
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
            this.btnUpload.Location = new System.Drawing.Point(6, 210);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(53, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpEmployeeDetails
            // 
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
            this.grpEmployeeDetails.Size = new System.Drawing.Size(194, 253);
            this.grpEmployeeDetails.TabIndex = 1;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Details";
            // 
            // mtbDOB
            // 
            this.mtbDOB.Location = new System.Drawing.Point(45, 219);
            this.mtbDOB.Mask = "00/00/0000";
            this.mtbDOB.Name = "mtbDOB";
            this.mtbDOB.Size = new System.Drawing.Size(100, 20);
            this.mtbDOB.TabIndex = 15;
            this.mtbDOB.ValidatingType = typeof(System.DateTime);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(6, 222);
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
            this.txtInitials.Location = new System.Drawing.Point(51, 187);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 11;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(6, 190);
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
            // grpEmployeeAddress
            // 
            this.grpEmployeeAddress.Controls.Add(this.txtAddress);
            this.grpEmployeeAddress.Location = new System.Drawing.Point(348, 12);
            this.grpEmployeeAddress.Name = "grpEmployeeAddress";
            this.grpEmployeeAddress.Size = new System.Drawing.Size(235, 114);
            this.grpEmployeeAddress.TabIndex = 2;
            this.grpEmployeeAddress.TabStop = false;
            this.grpEmployeeAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(3, 16);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 95);
            this.txtAddress.TabIndex = 3;
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.mtbTelNo);
            this.grpContact.Controls.Add(this.lblTelNo);
            this.grpContact.Controls.Add(this.mtbMobNo);
            this.grpContact.Controls.Add(this.lblMobNo);
            this.grpContact.Location = new System.Drawing.Point(348, 133);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(235, 114);
            this.grpContact.TabIndex = 3;
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
            // grpBackground
            // 
            this.grpBackground.Controls.Add(this.cmbSex);
            this.grpBackground.Controls.Add(this.cmbMaritalStatus);
            this.grpBackground.Controls.Add(this.cmbEthnicOrigin);
            this.grpBackground.Controls.Add(this.cmbNationality);
            this.grpBackground.Controls.Add(this.lblNationality);
            this.grpBackground.Controls.Add(this.lblEthnicOrigin);
            this.grpBackground.Controls.Add(this.lblSex);
            this.grpBackground.Controls.Add(this.lblMartialStatus);
            this.grpBackground.Location = new System.Drawing.Point(348, 253);
            this.grpBackground.Name = "grpBackground";
            this.grpBackground.Size = new System.Drawing.Size(235, 129);
            this.grpBackground.TabIndex = 4;
            this.grpBackground.TabStop = false;
            this.grpBackground.Text = "Background";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(43, 97);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(90, 21);
            this.cmbSex.TabIndex = 23;
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Location = new System.Drawing.Point(89, 70);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(140, 21);
            this.cmbMaritalStatus.TabIndex = 22;
            // 
            // cmbEthnicOrigin
            // 
            this.cmbEthnicOrigin.FormattingEnabled = true;
            this.cmbEthnicOrigin.Location = new System.Drawing.Point(85, 39);
            this.cmbEthnicOrigin.Name = "cmbEthnicOrigin";
            this.cmbEthnicOrigin.Size = new System.Drawing.Size(144, 21);
            this.cmbEthnicOrigin.TabIndex = 21;
            // 
            // cmbNationality
            // 
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Location = new System.Drawing.Point(74, 13);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(155, 21);
            this.cmbNationality.TabIndex = 20;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(9, 16);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(59, 13);
            this.lblNationality.TabIndex = 18;
            this.lblNationality.Text = "Nationality:";
            // 
            // lblEthnicOrigin
            // 
            this.lblEthnicOrigin.AutoSize = true;
            this.lblEthnicOrigin.Location = new System.Drawing.Point(9, 42);
            this.lblEthnicOrigin.Name = "lblEthnicOrigin";
            this.lblEthnicOrigin.Size = new System.Drawing.Size(70, 13);
            this.lblEthnicOrigin.TabIndex = 14;
            this.lblEthnicOrigin.Text = "Ethnic Origin:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(9, 100);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 16;
            this.lblSex.Text = "Sex:";
            // 
            // lblMartialStatus
            // 
            this.lblMartialStatus.AutoSize = true;
            this.lblMartialStatus.Location = new System.Drawing.Point(9, 73);
            this.lblMartialStatus.Name = "lblMartialStatus";
            this.lblMartialStatus.Size = new System.Drawing.Size(74, 13);
            this.lblMartialStatus.TabIndex = 15;
            this.lblMartialStatus.Text = "Marital Status:";
            // 
            // grpDisabled
            // 
            this.grpDisabled.Controls.Add(this.dgvDisability);
            this.grpDisabled.Location = new System.Drawing.Point(589, 311);
            this.grpDisabled.Name = "grpDisabled";
            this.grpDisabled.Size = new System.Drawing.Size(441, 87);
            this.grpDisabled.TabIndex = 5;
            this.grpDisabled.TabStop = false;
            this.grpDisabled.Text = "Disability";
            // 
            // dgvDisability
            // 
            this.dgvDisability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisability.Location = new System.Drawing.Point(3, 16);
            this.dgvDisability.Name = "dgvDisability";
            this.dgvDisability.Size = new System.Drawing.Size(435, 68);
            this.dgvDisability.TabIndex = 0;
            this.dgvDisability.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDisability_CellContentClick);
            // 
            // grpTraining
            // 
            this.grpTraining.Controls.Add(this.dgvTraining);
            this.grpTraining.Location = new System.Drawing.Point(589, 12);
            this.grpTraining.Name = "grpTraining";
            this.grpTraining.Size = new System.Drawing.Size(441, 149);
            this.grpTraining.TabIndex = 6;
            this.grpTraining.TabStop = false;
            this.grpTraining.Text = "Training";
            // 
            // dgvTraining
            // 
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraining.Location = new System.Drawing.Point(3, 16);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.Size = new System.Drawing.Size(435, 130);
            this.dgvTraining.TabIndex = 0;
            // 
            // grpDisciplinary
            // 
            this.grpDisciplinary.Controls.Add(this.dgvDisciplinary);
            this.grpDisciplinary.Location = new System.Drawing.Point(12, 271);
            this.grpDisciplinary.Name = "grpDisciplinary";
            this.grpDisciplinary.Size = new System.Drawing.Size(330, 179);
            this.grpDisciplinary.TabIndex = 6;
            this.grpDisciplinary.TabStop = false;
            this.grpDisciplinary.Text = "Disciplinary";
            // 
            // dgvDisciplinary
            // 
            this.dgvDisciplinary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisciplinary.Location = new System.Drawing.Point(3, 16);
            this.dgvDisciplinary.Name = "dgvDisciplinary";
            this.dgvDisciplinary.Size = new System.Drawing.Size(324, 160);
            this.dgvDisciplinary.TabIndex = 0;
            // 
            // grpCommunity
            // 
            this.grpCommunity.Controls.Add(this.cmbCommunity);
            this.grpCommunity.Controls.Add(this.lblCommunity);
            this.grpCommunity.Location = new System.Drawing.Point(348, 388);
            this.grpCommunity.Name = "grpCommunity";
            this.grpCommunity.Size = new System.Drawing.Size(235, 62);
            this.grpCommunity.TabIndex = 7;
            this.grpCommunity.TabStop = false;
            this.grpCommunity.Text = "Community";
            // 
            // cmbCommunity
            // 
            this.cmbCommunity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommunity.FormattingEnabled = true;
            this.cmbCommunity.Items.AddRange(new object[] {
            "Protestant",
            "Roman Catholic",
            "Protestant (R)",
            "Roman Catholic (R)"});
            this.cmbCommunity.Location = new System.Drawing.Point(71, 24);
            this.cmbCommunity.Name = "cmbCommunity";
            this.cmbCommunity.Size = new System.Drawing.Size(155, 21);
            this.cmbCommunity.TabIndex = 25;
            // 
            // lblCommunity
            // 
            this.lblCommunity.AutoSize = true;
            this.lblCommunity.Location = new System.Drawing.Point(6, 27);
            this.lblCommunity.Name = "lblCommunity";
            this.lblCommunity.Size = new System.Drawing.Size(61, 13);
            this.lblCommunity.TabIndex = 24;
            this.lblCommunity.Text = "Community:";
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.dgvService);
            this.grpService.Location = new System.Drawing.Point(12, 456);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(571, 132);
            this.grpService.TabIndex = 8;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service";
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(3, 16);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(565, 113);
            this.dgvService.TabIndex = 0;
            // 
            // grpQualifications
            // 
            this.grpQualifications.Controls.Add(this.dgvQualification);
            this.grpQualifications.Location = new System.Drawing.Point(592, 404);
            this.grpQualifications.Name = "grpQualifications";
            this.grpQualifications.Size = new System.Drawing.Size(438, 181);
            this.grpQualifications.TabIndex = 6;
            this.grpQualifications.TabStop = false;
            this.grpQualifications.Text = "Qualifications";
            // 
            // dgvQualification
            // 
            this.dgvQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQualification.Location = new System.Drawing.Point(3, 16);
            this.dgvQualification.Name = "dgvQualification";
            this.dgvQualification.Size = new System.Drawing.Size(432, 162);
            this.dgvQualification.TabIndex = 0;
            // 
            // grpContract
            // 
            this.grpContract.Controls.Add(this.dgvContract);
            this.grpContract.Location = new System.Drawing.Point(12, 594);
            this.grpContract.Name = "grpContract";
            this.grpContract.Size = new System.Drawing.Size(832, 180);
            this.grpContract.TabIndex = 9;
            this.grpContract.TabStop = false;
            this.grpContract.Text = "Contract";
            // 
            // dgvContract
            // 
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.Location = new System.Drawing.Point(3, 16);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.Size = new System.Drawing.Size(826, 161);
            this.dgvContract.TabIndex = 0;
            // 
            // grpLeaver
            // 
            this.grpLeaver.Controls.Add(this.chkLeaverConfirm);
            this.grpLeaver.Controls.Add(this.button1);
            this.grpLeaver.Location = new System.Drawing.Point(850, 594);
            this.grpLeaver.Name = "grpLeaver";
            this.grpLeaver.Size = new System.Drawing.Size(180, 177);
            this.grpLeaver.TabIndex = 1;
            this.grpLeaver.TabStop = false;
            this.grpLeaver.Text = "Leaver";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chkLeaverConfirm
            // 
            this.chkLeaverConfirm.AutoSize = true;
            this.chkLeaverConfirm.Location = new System.Drawing.Point(6, 29);
            this.chkLeaverConfirm.Name = "chkLeaverConfirm";
            this.chkLeaverConfirm.Size = new System.Drawing.Size(174, 69);
            this.chkLeaverConfirm.TabIndex = 1;
            this.chkLeaverConfirm.Text = "I confirm that I want to process \r\nthis employee as a leaver and\r\nunderstand that" +
    " it will impact\r\non their use of the system and\r\nconforms with company policy\r\n";
            this.chkLeaverConfirm.UseVisualStyleBackColor = true;
            // 
            // grpAppraisal
            // 
            this.grpAppraisal.Controls.Add(this.dgvAppraisal);
            this.grpAppraisal.Location = new System.Drawing.Point(589, 164);
            this.grpAppraisal.Name = "grpAppraisal";
            this.grpAppraisal.Size = new System.Drawing.Size(441, 141);
            this.grpAppraisal.TabIndex = 10;
            this.grpAppraisal.TabStop = false;
            this.grpAppraisal.Text = "Appraisal";
            this.grpAppraisal.Enter += new System.EventHandler(this.GrpAppraisal_Enter);
            // 
            // dgvAppraisal
            // 
            this.dgvAppraisal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppraisal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppraisal.Location = new System.Drawing.Point(3, 16);
            this.dgvAppraisal.Name = "dgvAppraisal";
            this.dgvAppraisal.Size = new System.Drawing.Size(435, 122);
            this.dgvAppraisal.TabIndex = 0;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 786);
            this.Controls.Add(this.grpAppraisal);
            this.Controls.Add(this.grpLeaver);
            this.Controls.Add(this.grpContract);
            this.Controls.Add(this.grpQualifications);
            this.Controls.Add(this.grpService);
            this.Controls.Add(this.grpCommunity);
            this.Controls.Add(this.grpDisciplinary);
            this.Controls.Add(this.grpTraining);
            this.Controls.Add(this.grpDisabled);
            this.Controls.Add(this.grpBackground);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpEmployeeAddress);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.grpEmployeeImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.grpEmployeeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            this.grpEmployeeAddress.ResumeLayout(false);
            this.grpEmployeeAddress.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpBackground.ResumeLayout(false);
            this.grpBackground.PerformLayout();
            this.grpDisabled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisability)).EndInit();
            this.grpTraining.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.grpDisciplinary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinary)).EndInit();
            this.grpCommunity.ResumeLayout(false);
            this.grpCommunity.PerformLayout();
            this.grpService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.grpQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualification)).EndInit();
            this.grpContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.grpLeaver.ResumeLayout(false);
            this.grpLeaver.PerformLayout();
            this.grpAppraisal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppraisal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
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
        private System.Windows.Forms.GroupBox grpEmployeeAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.MaskedTextBox mtbTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.MaskedTextBox mtbMobNo;
        private System.Windows.Forms.Label lblMobNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpBackground;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.ComboBox cmbEthnicOrigin;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblEthnicOrigin;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblMartialStatus;
        private System.Windows.Forms.GroupBox grpDisabled;
        private System.Windows.Forms.MaskedTextBox mtbDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DataGridView dgvDisability;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox grpTraining;
        private System.Windows.Forms.DataGridView dgvTraining;
        private System.Windows.Forms.GroupBox grpDisciplinary;
        private System.Windows.Forms.DataGridView dgvDisciplinary;
        private System.Windows.Forms.GroupBox grpCommunity;
        private System.Windows.Forms.ComboBox cmbCommunity;
        private System.Windows.Forms.Label lblCommunity;
        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.GroupBox grpQualifications;
        private System.Windows.Forms.DataGridView dgvQualification;
        private System.Windows.Forms.GroupBox grpContract;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.GroupBox grpLeaver;
        private System.Windows.Forms.CheckBox chkLeaverConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpAppraisal;
        private System.Windows.Forms.DataGridView dgvAppraisal;
    }
}