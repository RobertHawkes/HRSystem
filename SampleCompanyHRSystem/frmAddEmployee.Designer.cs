namespace SampleCompanyHRSystem
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.mtbNINo = new System.Windows.Forms.MaskedTextBox();
            this.lblNINo = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtKnownAs = new System.Windows.Forms.TextBox();
            this.lblKnownAs = new System.Windows.Forms.Label();
            this.mtbPostCode = new System.Windows.Forms.MaskedTextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtbMobile = new System.Windows.Forms.MaskedTextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtDisabilityRegNo = new System.Windows.Forms.TextBox();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.lblDisabilityRegNo = new System.Windows.Forms.Label();
            this.lblDisabled = new System.Windows.Forms.Label();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cmbEthnicOrigin = new System.Windows.Forms.ComboBox();
            this.lblEthnicBackground = new System.Windows.Forms.Label();
            this.chkEligibleToWorkInUK = new System.Windows.Forms.CheckBox();
            this.lblEligibleToWorkInUK = new System.Windows.Forms.Label();
            this.lblWorkPermitNo = new System.Windows.Forms.Label();
            this.txtWorkPermitNo = new System.Windows.Forms.TextBox();
            this.dtpWorkPermitDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkPermitDate = new System.Windows.Forms.Label();
            this.lblPassportNo = new System.Windows.Forms.Label();
            this.lblCarRegNo = new System.Windows.Forms.Label();
            this.mtbCarRegNo = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassportNo = new System.Windows.Forms.MaskedTextBox();
            this.mtbDrivingLicenseNo = new System.Windows.Forms.MaskedTextBox();
            this.lblDrivingLicenseNo = new System.Windows.Forms.Label();
            this.dtpDrivingLicenseDate = new System.Windows.Forms.DateTimePicker();
            this.lblDrivingLicenseDate = new System.Windows.Forms.Label();
            this.cmbECCommunity = new System.Windows.Forms.ComboBox();
            this.lblECIdentifier = new System.Windows.Forms.Label();
            this.chkStatementOfEmploymentRequired = new System.Windows.Forms.CheckBox();
            this.lblStatmentOfEmploymentRequired = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.tabEthnicCommunityBackground = new System.Windows.Forms.TabPage();
            this.tabWorkEligibility = new System.Windows.Forms.TabPage();
            this.tabEqualityCommission = new System.Windows.Forms.TabPage();
            this.tabDocumentInformation = new System.Windows.Forms.TabPage();
            this.tabContactData = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.btnNext4 = new System.Windows.Forms.Button();
            this.btnNext5 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev5 = new System.Windows.Forms.Button();
            this.btnPrev4 = new System.Windows.Forms.Button();
            this.btnPrev3 = new System.Windows.Forms.Button();
            this.btnPrev2 = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabPersonalData.SuspendLayout();
            this.tabEthnicCommunityBackground.SuspendLayout();
            this.tabWorkEligibility.SuspendLayout();
            this.tabEqualityCommission.SuspendLayout();
            this.tabDocumentInformation.SuspendLayout();
            this.tabContactData.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbNINo
            // 
            this.mtbNINo.Location = new System.Drawing.Point(50, 167);
            this.mtbNINo.Mask = ">LL\\-00\\-00\\-00\\-L";
            this.mtbNINo.Name = "mtbNINo";
            this.mtbNINo.Size = new System.Drawing.Size(79, 20);
            this.mtbNINo.TabIndex = 27;
            // 
            // lblNINo
            // 
            this.lblNINo.AutoSize = true;
            this.lblNINo.Location = new System.Drawing.Point(6, 170);
            this.lblNINo.Name = "lblNINo";
            this.lblNINo.Size = new System.Drawing.Size(38, 13);
            this.lblNINo.TabIndex = 26;
            this.lblNINo.Text = "NI No:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(45, 264);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(157, 20);
            this.dtpDOB.TabIndex = 25;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(6, 267);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(33, 13);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "DOB:";
            // 
            // txtKnownAs
            // 
            this.txtKnownAs.Location = new System.Drawing.Point(64, 135);
            this.txtKnownAs.Name = "txtKnownAs";
            this.txtKnownAs.Size = new System.Drawing.Size(100, 20);
            this.txtKnownAs.TabIndex = 23;
            // 
            // lblKnownAs
            // 
            this.lblKnownAs.AutoSize = true;
            this.lblKnownAs.Location = new System.Drawing.Point(6, 138);
            this.lblKnownAs.Name = "lblKnownAs";
            this.lblKnownAs.Size = new System.Drawing.Size(58, 13);
            this.lblKnownAs.TabIndex = 22;
            this.lblKnownAs.Text = "Known As:";
            // 
            // mtbPostCode
            // 
            this.mtbPostCode.Location = new System.Drawing.Point(307, 130);
            this.mtbPostCode.Mask = ">LCCC 9LL";
            this.mtbPostCode.Name = "mtbPostCode";
            this.mtbPostCode.Size = new System.Drawing.Size(134, 20);
            this.mtbPostCode.TabIndex = 21;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(245, 133);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(56, 13);
            this.lblPostcode.TabIndex = 20;
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
            this.cmbCounty.Location = new System.Drawing.Point(294, 99);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(121, 21);
            this.cmbCounty.Sorted = true;
            this.cmbCounty.TabIndex = 19;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(245, 102);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "County:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(288, 69);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(93, 20);
            this.txtTown.TabIndex = 16;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(245, 72);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 15;
            this.lblTown.Text = "Town:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(308, 40);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(131, 20);
            this.txtAddress2.TabIndex = 14;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(245, 43);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(57, 13);
            this.lblAddress2.TabIndex = 13;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(308, 11);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(131, 20);
            this.txtAddress1.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(245, 14);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address 1:";
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(51, 166);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(56, 20);
            this.txtInitials.TabIndex = 10;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(6, 169);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(39, 13);
            this.lblInitials.TabIndex = 9;
            this.lblInitials.Text = "Initials:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(84, 71);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 8;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(6, 74);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblMiddleName.TabIndex = 7;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(69, 42);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 6;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(6, 45);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 5;
            this.lblForename.Text = "Forename:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(64, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 107);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // cmbTitle
            // 
            this.cmbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Dr"});
            this.cmbTitle.Location = new System.Drawing.Point(42, 10);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(121, 21);
            this.cmbTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 73);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 49);
            this.txtEmail.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // mtbMobile
            // 
            this.mtbMobile.Location = new System.Drawing.Point(55, 44);
            this.mtbMobile.Mask = "0000000000000";
            this.mtbMobile.Name = "mtbMobile";
            this.mtbMobile.Size = new System.Drawing.Size(139, 20);
            this.mtbMobile.TabIndex = 23;
            this.mtbMobile.ValidatingType = typeof(int);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(8, 47);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 22;
            this.lblMobile.Text = "Mobile:";
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(75, 13);
            this.mtbTelephone.Mask = "0000000000000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(119, 20);
            this.mtbTelephone.TabIndex = 21;
            this.mtbTelephone.ValidatingType = typeof(int);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(8, 16);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 20;
            this.lblTelephone.Text = "Telephone:";
            // 
            // txtDisabilityRegNo
            // 
            this.txtDisabilityRegNo.Enabled = false;
            this.txtDisabilityRegNo.Location = new System.Drawing.Point(103, 136);
            this.txtDisabilityRegNo.Name = "txtDisabilityRegNo";
            this.txtDisabilityRegNo.Size = new System.Drawing.Size(89, 20);
            this.txtDisabilityRegNo.TabIndex = 29;
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(82, 115);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkDisabled.TabIndex = 29;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // lblDisabilityRegNo
            // 
            this.lblDisabilityRegNo.AutoSize = true;
            this.lblDisabilityRegNo.Location = new System.Drawing.Point(6, 139);
            this.lblDisabilityRegNo.Name = "lblDisabilityRegNo";
            this.lblDisabilityRegNo.Size = new System.Drawing.Size(91, 13);
            this.lblDisabilityRegNo.TabIndex = 28;
            this.lblDisabilityRegNo.Text = "Disability Reg No:";
            // 
            // lblDisabled
            // 
            this.lblDisabled.AutoSize = true;
            this.lblDisabled.Location = new System.Drawing.Point(6, 116);
            this.lblDisabled.Name = "lblDisabled";
            this.lblDisabled.Size = new System.Drawing.Size(51, 13);
            this.lblDisabled.TabIndex = 27;
            this.lblDisabled.Text = "Disabled:";
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaritalStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "White European",
            "Mexican",
            "African",
            "Chinese",
            "Indian",
            "White - British",
            "Black - English",
            "Black - USA",
            "White - USA",
            "Philippine",
            "Zimbabwean",
            "Polish",
            "White - Irish",
            "Portuguese",
            "Swedish",
            "Spanish",
            "Pakistani",
            "Belarus",
            "Bangladeshi",
            "Italian",
            "Northern Irish",
            "Iranian",
            "German",
            "Scottish",
            "Berlin",
            "Hungarian",
            "French",
            "",
            "Filipino",
            "Black",
            "White",
            "Other"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(82, 83);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(110, 21);
            this.cmbMaritalStatus.TabIndex = 27;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(6, 87);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(74, 13);
            this.lblMaritalStatus.TabIndex = 26;
            this.lblMaritalStatus.Text = "Marital Status:";
            // 
            // cmbNationality
            // 
            this.cmbNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Items.AddRange(new object[] {
            "White European",
            "Mexican",
            "African",
            "Chinese",
            "Indian",
            "White - British",
            "Black - English",
            "Black - USA",
            "White - USA",
            "Philippine",
            "Zimbabwean",
            "Polish",
            "White - Irish",
            "Portuguese",
            "Swedish",
            "Spanish",
            "Pakistani",
            "Belarus",
            "Bangladeshi",
            "Italian",
            "Northern Irish",
            "Iranian",
            "German",
            "Scottish",
            "Berlin",
            "Hungarian",
            "French",
            "",
            "Filipino",
            "Black",
            "White",
            "Other"});
            this.cmbNationality.Location = new System.Drawing.Point(82, 47);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(110, 21);
            this.cmbNationality.TabIndex = 25;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(6, 51);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(59, 13);
            this.lblNationality.TabIndex = 24;
            this.lblNationality.Text = "Nationality:";
            // 
            // cmbEthnicOrigin
            // 
            this.cmbEthnicOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEthnicOrigin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEthnicOrigin.FormattingEnabled = true;
            this.cmbEthnicOrigin.Items.AddRange(new object[] {
            "White European",
            "Mexican",
            "African",
            "Chinese",
            "Indian",
            "White - British",
            "Black - English",
            "Black - USA",
            "White - USA",
            "Philippine",
            "Zimbabwean",
            "Polish",
            "White - Irish",
            "Portuguese",
            "Swedish",
            "Spanish",
            "Pakistani",
            "Belarus",
            "Bangladeshi",
            "Italian",
            "Northern Irish",
            "Iranian",
            "German",
            "Scottish",
            "Berlin",
            "Hungarian",
            "French",
            "Filipino",
            "Black",
            "White",
            "Other"});
            this.cmbEthnicOrigin.Location = new System.Drawing.Point(82, 11);
            this.cmbEthnicOrigin.Name = "cmbEthnicOrigin";
            this.cmbEthnicOrigin.Size = new System.Drawing.Size(110, 21);
            this.cmbEthnicOrigin.TabIndex = 23;
            // 
            // lblEthnicBackground
            // 
            this.lblEthnicBackground.AutoSize = true;
            this.lblEthnicBackground.Location = new System.Drawing.Point(6, 15);
            this.lblEthnicBackground.Name = "lblEthnicBackground";
            this.lblEthnicBackground.Size = new System.Drawing.Size(70, 13);
            this.lblEthnicBackground.TabIndex = 22;
            this.lblEthnicBackground.Text = "Ethnic Origin:";
            // 
            // chkEligibleToWorkInUK
            // 
            this.chkEligibleToWorkInUK.AutoSize = true;
            this.chkEligibleToWorkInUK.Location = new System.Drawing.Point(122, 14);
            this.chkEligibleToWorkInUK.Name = "chkEligibleToWorkInUK";
            this.chkEligibleToWorkInUK.Size = new System.Drawing.Size(15, 14);
            this.chkEligibleToWorkInUK.TabIndex = 31;
            this.chkEligibleToWorkInUK.UseVisualStyleBackColor = true;
            // 
            // lblEligibleToWorkInUK
            // 
            this.lblEligibleToWorkInUK.AutoSize = true;
            this.lblEligibleToWorkInUK.Location = new System.Drawing.Point(6, 15);
            this.lblEligibleToWorkInUK.Name = "lblEligibleToWorkInUK";
            this.lblEligibleToWorkInUK.Size = new System.Drawing.Size(110, 13);
            this.lblEligibleToWorkInUK.TabIndex = 30;
            this.lblEligibleToWorkInUK.Text = "Eligible to work in UK:";
            // 
            // lblWorkPermitNo
            // 
            this.lblWorkPermitNo.AutoSize = true;
            this.lblWorkPermitNo.Location = new System.Drawing.Point(6, 43);
            this.lblWorkPermitNo.Name = "lblWorkPermitNo";
            this.lblWorkPermitNo.Size = new System.Drawing.Size(85, 13);
            this.lblWorkPermitNo.TabIndex = 30;
            this.lblWorkPermitNo.Text = "Work Permit No:";
            // 
            // txtWorkPermitNo
            // 
            this.txtWorkPermitNo.Location = new System.Drawing.Point(97, 40);
            this.txtWorkPermitNo.Name = "txtWorkPermitNo";
            this.txtWorkPermitNo.Size = new System.Drawing.Size(108, 20);
            this.txtWorkPermitNo.TabIndex = 28;
            // 
            // dtpWorkPermitDate
            // 
            this.dtpWorkPermitDate.Location = new System.Drawing.Point(106, 69);
            this.dtpWorkPermitDate.Name = "dtpWorkPermitDate";
            this.dtpWorkPermitDate.Size = new System.Drawing.Size(144, 20);
            this.dtpWorkPermitDate.TabIndex = 29;
            // 
            // lblWorkPermitDate
            // 
            this.lblWorkPermitDate.AutoSize = true;
            this.lblWorkPermitDate.Location = new System.Drawing.Point(6, 72);
            this.lblWorkPermitDate.Name = "lblWorkPermitDate";
            this.lblWorkPermitDate.Size = new System.Drawing.Size(94, 13);
            this.lblWorkPermitDate.TabIndex = 28;
            this.lblWorkPermitDate.Text = "Work Permit Date:";
            // 
            // lblPassportNo
            // 
            this.lblPassportNo.AutoSize = true;
            this.lblPassportNo.Location = new System.Drawing.Point(6, 14);
            this.lblPassportNo.Name = "lblPassportNo";
            this.lblPassportNo.Size = new System.Drawing.Size(68, 13);
            this.lblPassportNo.TabIndex = 28;
            this.lblPassportNo.Text = "Passport No:";
            // 
            // lblCarRegNo
            // 
            this.lblCarRegNo.AutoSize = true;
            this.lblCarRegNo.Location = new System.Drawing.Point(6, 42);
            this.lblCarRegNo.Name = "lblCarRegNo";
            this.lblCarRegNo.Size = new System.Drawing.Size(66, 13);
            this.lblCarRegNo.TabIndex = 30;
            this.lblCarRegNo.Text = "Car Reg No:";
            // 
            // mtbCarRegNo
            // 
            this.mtbCarRegNo.Location = new System.Drawing.Point(78, 40);
            this.mtbCarRegNo.Mask = ">LA##LLL";
            this.mtbCarRegNo.Name = "mtbCarRegNo";
            this.mtbCarRegNo.Size = new System.Drawing.Size(100, 20);
            this.mtbCarRegNo.TabIndex = 31;
            // 
            // mtbPassportNo
            // 
            this.mtbPassportNo.Location = new System.Drawing.Point(80, 11);
            this.mtbPassportNo.Mask = "000000000";
            this.mtbPassportNo.Name = "mtbPassportNo";
            this.mtbPassportNo.Size = new System.Drawing.Size(100, 20);
            this.mtbPassportNo.TabIndex = 32;
            // 
            // mtbDrivingLicenseNo
            // 
            this.mtbDrivingLicenseNo.Location = new System.Drawing.Point(112, 72);
            this.mtbDrivingLicenseNo.Mask = "00000000";
            this.mtbDrivingLicenseNo.Name = "mtbDrivingLicenseNo";
            this.mtbDrivingLicenseNo.Size = new System.Drawing.Size(100, 20);
            this.mtbDrivingLicenseNo.TabIndex = 34;
            // 
            // lblDrivingLicenseNo
            // 
            this.lblDrivingLicenseNo.AutoSize = true;
            this.lblDrivingLicenseNo.Location = new System.Drawing.Point(6, 75);
            this.lblDrivingLicenseNo.Name = "lblDrivingLicenseNo";
            this.lblDrivingLicenseNo.Size = new System.Drawing.Size(100, 13);
            this.lblDrivingLicenseNo.TabIndex = 33;
            this.lblDrivingLicenseNo.Text = "Driving License No:";
            // 
            // dtpDrivingLicenseDate
            // 
            this.dtpDrivingLicenseDate.Location = new System.Drawing.Point(121, 105);
            this.dtpDrivingLicenseDate.Name = "dtpDrivingLicenseDate";
            this.dtpDrivingLicenseDate.Size = new System.Drawing.Size(123, 20);
            this.dtpDrivingLicenseDate.TabIndex = 29;
            // 
            // lblDrivingLicenseDate
            // 
            this.lblDrivingLicenseDate.AutoSize = true;
            this.lblDrivingLicenseDate.Location = new System.Drawing.Point(6, 108);
            this.lblDrivingLicenseDate.Name = "lblDrivingLicenseDate";
            this.lblDrivingLicenseDate.Size = new System.Drawing.Size(109, 13);
            this.lblDrivingLicenseDate.TabIndex = 28;
            this.lblDrivingLicenseDate.Text = "Driving License Date:";
            // 
            // cmbECCommunity
            // 
            this.cmbECCommunity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbECCommunity.FormattingEnabled = true;
            this.cmbECCommunity.Items.AddRange(new object[] {
            "Protestant",
            "Roman Catholic",
            "Protestant (R)",
            "Roman Catholic (R)"});
            this.cmbECCommunity.Location = new System.Drawing.Point(73, 10);
            this.cmbECCommunity.Name = "cmbECCommunity";
            this.cmbECCommunity.Size = new System.Drawing.Size(115, 21);
            this.cmbECCommunity.TabIndex = 31;
            // 
            // lblECIdentifier
            // 
            this.lblECIdentifier.AutoSize = true;
            this.lblECIdentifier.Location = new System.Drawing.Point(6, 14);
            this.lblECIdentifier.Name = "lblECIdentifier";
            this.lblECIdentifier.Size = new System.Drawing.Size(61, 13);
            this.lblECIdentifier.TabIndex = 30;
            this.lblECIdentifier.Text = "Community:";
            // 
            // chkStatementOfEmploymentRequired
            // 
            this.chkStatementOfEmploymentRequired.AutoSize = true;
            this.chkStatementOfEmploymentRequired.Location = new System.Drawing.Point(183, 136);
            this.chkStatementOfEmploymentRequired.Name = "chkStatementOfEmploymentRequired";
            this.chkStatementOfEmploymentRequired.Size = new System.Drawing.Size(15, 14);
            this.chkStatementOfEmploymentRequired.TabIndex = 34;
            this.chkStatementOfEmploymentRequired.UseVisualStyleBackColor = true;
            // 
            // lblStatmentOfEmploymentRequired
            // 
            this.lblStatmentOfEmploymentRequired.AutoSize = true;
            this.lblStatmentOfEmploymentRequired.Location = new System.Drawing.Point(6, 137);
            this.lblStatmentOfEmploymentRequired.Name = "lblStatmentOfEmploymentRequired";
            this.lblStatmentOfEmploymentRequired.Size = new System.Drawing.Size(171, 13);
            this.lblStatmentOfEmploymentRequired.TabIndex = 33;
            this.lblStatmentOfEmploymentRequired.Text = "Statement of Employment required:";
            // 
            // cmbSex
            // 
            this.cmbSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "White European",
            "Mexican",
            "African",
            "Chinese",
            "Indian",
            "White - British",
            "Black - English",
            "Black - USA",
            "White - USA",
            "Philippine",
            "Zimbabwean",
            "Polish",
            "White - Irish",
            "Portuguese",
            "Swedish",
            "Spanish",
            "Pakistani",
            "Belarus",
            "Bangladeshi",
            "Italian",
            "Northern Irish",
            "Iranian",
            "German",
            "Scottish",
            "Berlin",
            "Hungarian",
            "French",
            "",
            "Filipino",
            "Black",
            "White",
            "Other"});
            this.cmbSex.Location = new System.Drawing.Point(40, 228);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(110, 21);
            this.cmbSex.TabIndex = 30;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(6, 231);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 29;
            this.lblSex.Text = "Sex:";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPersonalData);
            this.tabMain.Controls.Add(this.tabEthnicCommunityBackground);
            this.tabMain.Controls.Add(this.tabWorkEligibility);
            this.tabMain.Controls.Add(this.tabEqualityCommission);
            this.tabMain.Controls.Add(this.tabDocumentInformation);
            this.tabMain.Controls.Add(this.tabContactData);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(619, 459);
            this.tabMain.TabIndex = 30;
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Controls.Add(this.btnNext);
            this.tabPersonalData.Controls.Add(this.cmbSex);
            this.tabPersonalData.Controls.Add(this.lblSex);
            this.tabPersonalData.Controls.Add(this.dtpDOB);
            this.tabPersonalData.Controls.Add(this.lblTitle);
            this.tabPersonalData.Controls.Add(this.lblDOB);
            this.tabPersonalData.Controls.Add(this.cmbTitle);
            this.tabPersonalData.Controls.Add(this.txtKnownAs);
            this.tabPersonalData.Controls.Add(this.lblSurname);
            this.tabPersonalData.Controls.Add(this.lblKnownAs);
            this.tabPersonalData.Controls.Add(this.txtSurname);
            this.tabPersonalData.Controls.Add(this.mtbPostCode);
            this.tabPersonalData.Controls.Add(this.lblForename);
            this.tabPersonalData.Controls.Add(this.lblPostcode);
            this.tabPersonalData.Controls.Add(this.txtForename);
            this.tabPersonalData.Controls.Add(this.cmbCounty);
            this.tabPersonalData.Controls.Add(this.lblMiddleName);
            this.tabPersonalData.Controls.Add(this.lblCounty);
            this.tabPersonalData.Controls.Add(this.txtMiddleName);
            this.tabPersonalData.Controls.Add(this.txtTown);
            this.tabPersonalData.Controls.Add(this.lblInitials);
            this.tabPersonalData.Controls.Add(this.lblTown);
            this.tabPersonalData.Controls.Add(this.txtInitials);
            this.tabPersonalData.Controls.Add(this.txtAddress2);
            this.tabPersonalData.Controls.Add(this.lblAddress);
            this.tabPersonalData.Controls.Add(this.lblAddress2);
            this.tabPersonalData.Controls.Add(this.txtAddress1);
            this.tabPersonalData.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalData.Size = new System.Drawing.Size(611, 433);
            this.tabPersonalData.TabIndex = 0;
            this.tabPersonalData.Text = "Personal Data";
            this.tabPersonalData.UseVisualStyleBackColor = true;
            // 
            // tabEthnicCommunityBackground
            // 
            this.tabEthnicCommunityBackground.Controls.Add(this.btnPrev);
            this.tabEthnicCommunityBackground.Controls.Add(this.btnNext2);
            this.tabEthnicCommunityBackground.Controls.Add(this.txtDisabilityRegNo);
            this.tabEthnicCommunityBackground.Controls.Add(this.chkDisabled);
            this.tabEthnicCommunityBackground.Controls.Add(this.lblDisabilityRegNo);
            this.tabEthnicCommunityBackground.Controls.Add(this.lblEthnicBackground);
            this.tabEthnicCommunityBackground.Controls.Add(this.lblDisabled);
            this.tabEthnicCommunityBackground.Controls.Add(this.cmbEthnicOrigin);
            this.tabEthnicCommunityBackground.Controls.Add(this.cmbMaritalStatus);
            this.tabEthnicCommunityBackground.Controls.Add(this.lblNationality);
            this.tabEthnicCommunityBackground.Controls.Add(this.lblMaritalStatus);
            this.tabEthnicCommunityBackground.Controls.Add(this.cmbNationality);
            this.tabEthnicCommunityBackground.Location = new System.Drawing.Point(4, 22);
            this.tabEthnicCommunityBackground.Name = "tabEthnicCommunityBackground";
            this.tabEthnicCommunityBackground.Padding = new System.Windows.Forms.Padding(3);
            this.tabEthnicCommunityBackground.Size = new System.Drawing.Size(611, 433);
            this.tabEthnicCommunityBackground.TabIndex = 1;
            this.tabEthnicCommunityBackground.Text = "Ethnic/Community Background";
            this.tabEthnicCommunityBackground.UseVisualStyleBackColor = true;
            // 
            // tabWorkEligibility
            // 
            this.tabWorkEligibility.Controls.Add(this.btnPrev2);
            this.tabWorkEligibility.Controls.Add(this.btnNext3);
            this.tabWorkEligibility.Controls.Add(this.dtpWorkPermitDate);
            this.tabWorkEligibility.Controls.Add(this.txtWorkPermitNo);
            this.tabWorkEligibility.Controls.Add(this.lblWorkPermitDate);
            this.tabWorkEligibility.Controls.Add(this.lblEligibleToWorkInUK);
            this.tabWorkEligibility.Controls.Add(this.chkEligibleToWorkInUK);
            this.tabWorkEligibility.Controls.Add(this.lblWorkPermitNo);
            this.tabWorkEligibility.Location = new System.Drawing.Point(4, 22);
            this.tabWorkEligibility.Name = "tabWorkEligibility";
            this.tabWorkEligibility.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkEligibility.Size = new System.Drawing.Size(611, 433);
            this.tabWorkEligibility.TabIndex = 2;
            this.tabWorkEligibility.Text = "Work Eligibility";
            this.tabWorkEligibility.UseVisualStyleBackColor = true;
            // 
            // tabEqualityCommission
            // 
            this.tabEqualityCommission.Controls.Add(this.btnPrev3);
            this.tabEqualityCommission.Controls.Add(this.btnNext4);
            this.tabEqualityCommission.Controls.Add(this.cmbECCommunity);
            this.tabEqualityCommission.Controls.Add(this.lblECIdentifier);
            this.tabEqualityCommission.Location = new System.Drawing.Point(4, 22);
            this.tabEqualityCommission.Name = "tabEqualityCommission";
            this.tabEqualityCommission.Padding = new System.Windows.Forms.Padding(3);
            this.tabEqualityCommission.Size = new System.Drawing.Size(611, 433);
            this.tabEqualityCommission.TabIndex = 3;
            this.tabEqualityCommission.Text = "Equality Commission";
            this.tabEqualityCommission.UseVisualStyleBackColor = true;
            // 
            // tabDocumentInformation
            // 
            this.tabDocumentInformation.Controls.Add(this.btnPrev4);
            this.tabDocumentInformation.Controls.Add(this.btnNext5);
            this.tabDocumentInformation.Controls.Add(this.mtbNINo);
            this.tabDocumentInformation.Controls.Add(this.chkStatementOfEmploymentRequired);
            this.tabDocumentInformation.Controls.Add(this.lblDrivingLicenseDate);
            this.tabDocumentInformation.Controls.Add(this.lblNINo);
            this.tabDocumentInformation.Controls.Add(this.lblPassportNo);
            this.tabDocumentInformation.Controls.Add(this.dtpDrivingLicenseDate);
            this.tabDocumentInformation.Controls.Add(this.lblCarRegNo);
            this.tabDocumentInformation.Controls.Add(this.lblStatmentOfEmploymentRequired);
            this.tabDocumentInformation.Controls.Add(this.mtbCarRegNo);
            this.tabDocumentInformation.Controls.Add(this.mtbDrivingLicenseNo);
            this.tabDocumentInformation.Controls.Add(this.mtbPassportNo);
            this.tabDocumentInformation.Controls.Add(this.lblDrivingLicenseNo);
            this.tabDocumentInformation.Location = new System.Drawing.Point(4, 22);
            this.tabDocumentInformation.Name = "tabDocumentInformation";
            this.tabDocumentInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocumentInformation.Size = new System.Drawing.Size(611, 433);
            this.tabDocumentInformation.TabIndex = 4;
            this.tabDocumentInformation.Text = "Document Information";
            this.tabDocumentInformation.UseVisualStyleBackColor = true;
            // 
            // tabContactData
            // 
            this.tabContactData.Controls.Add(this.btnPrev5);
            this.tabContactData.Controls.Add(this.btnSave);
            this.tabContactData.Controls.Add(this.txtEmail);
            this.tabContactData.Controls.Add(this.lblEmail);
            this.tabContactData.Controls.Add(this.mtbMobile);
            this.tabContactData.Controls.Add(this.lblTelephone);
            this.tabContactData.Controls.Add(this.lblMobile);
            this.tabContactData.Controls.Add(this.mtbTelephone);
            this.tabContactData.Location = new System.Drawing.Point(4, 22);
            this.tabContactData.Name = "tabContactData";
            this.tabContactData.Padding = new System.Windows.Forms.Padding(3);
            this.tabContactData.Size = new System.Drawing.Size(611, 433);
            this.tabContactData.TabIndex = 5;
            this.tabContactData.Text = "Contact Data";
            this.tabContactData.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(505, 377);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(505, 377);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(100, 50);
            this.btnNext2.TabIndex = 32;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNext3
            // 
            this.btnNext3.Location = new System.Drawing.Point(505, 377);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(100, 50);
            this.btnNext3.TabIndex = 33;
            this.btnNext3.Text = "Next";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNext4
            // 
            this.btnNext4.Location = new System.Drawing.Point(505, 377);
            this.btnNext4.Name = "btnNext4";
            this.btnNext4.Size = new System.Drawing.Size(100, 50);
            this.btnNext4.TabIndex = 34;
            this.btnNext4.Text = "Next";
            this.btnNext4.UseVisualStyleBackColor = true;
            this.btnNext4.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNext5
            // 
            this.btnNext5.Location = new System.Drawing.Point(505, 377);
            this.btnNext5.Name = "btnNext5";
            this.btnNext5.Size = new System.Drawing.Size(100, 50);
            this.btnNext5.TabIndex = 35;
            this.btnNext5.Text = "Next";
            this.btnNext5.UseVisualStyleBackColor = true;
            this.btnNext5.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrev5
            // 
            this.btnPrev5.Location = new System.Drawing.Point(6, 377);
            this.btnPrev5.Name = "btnPrev5";
            this.btnPrev5.Size = new System.Drawing.Size(100, 50);
            this.btnPrev5.TabIndex = 37;
            this.btnPrev5.Text = "Prev";
            this.btnPrev5.UseVisualStyleBackColor = true;
            this.btnPrev5.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPrev4
            // 
            this.btnPrev4.Location = new System.Drawing.Point(6, 377);
            this.btnPrev4.Name = "btnPrev4";
            this.btnPrev4.Size = new System.Drawing.Size(100, 50);
            this.btnPrev4.TabIndex = 38;
            this.btnPrev4.Text = "Prev";
            this.btnPrev4.UseVisualStyleBackColor = true;
            this.btnPrev4.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPrev3
            // 
            this.btnPrev3.Location = new System.Drawing.Point(6, 377);
            this.btnPrev3.Name = "btnPrev3";
            this.btnPrev3.Size = new System.Drawing.Size(100, 50);
            this.btnPrev3.TabIndex = 39;
            this.btnPrev3.Text = "Prev";
            this.btnPrev3.UseVisualStyleBackColor = true;
            this.btnPrev3.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPrev2
            // 
            this.btnPrev2.Location = new System.Drawing.Point(6, 377);
            this.btnPrev2.Name = "btnPrev2";
            this.btnPrev2.Size = new System.Drawing.Size(100, 50);
            this.btnPrev2.TabIndex = 40;
            this.btnPrev2.Text = "Prev";
            this.btnPrev2.UseVisualStyleBackColor = true;
            this.btnPrev2.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(6, 377);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 50);
            this.btnPrev.TabIndex = 41;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 459);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.tabMain.ResumeLayout(false);
            this.tabPersonalData.ResumeLayout(false);
            this.tabPersonalData.PerformLayout();
            this.tabEthnicCommunityBackground.ResumeLayout(false);
            this.tabEthnicCommunityBackground.PerformLayout();
            this.tabWorkEligibility.ResumeLayout(false);
            this.tabWorkEligibility.PerformLayout();
            this.tabEqualityCommission.ResumeLayout(false);
            this.tabEqualityCommission.PerformLayout();
            this.tabDocumentInformation.ResumeLayout(false);
            this.tabDocumentInformation.PerformLayout();
            this.tabContactData.ResumeLayout(false);
            this.tabContactData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.MaskedTextBox mtbMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbPostCode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbEthnicOrigin;
        private System.Windows.Forms.Label lblEthnicBackground;
        private System.Windows.Forms.TextBox txtKnownAs;
        private System.Windows.Forms.Label lblKnownAs;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.Label lblDisabled;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.MaskedTextBox mtbNINo;
        private System.Windows.Forms.Label lblNINo;
        private System.Windows.Forms.TextBox txtDisabilityRegNo;
        private System.Windows.Forms.Label lblDisabilityRegNo;
        private System.Windows.Forms.CheckBox chkEligibleToWorkInUK;
        private System.Windows.Forms.Label lblEligibleToWorkInUK;
        private System.Windows.Forms.Label lblWorkPermitNo;
        private System.Windows.Forms.DateTimePicker dtpWorkPermitDate;
        private System.Windows.Forms.TextBox txtWorkPermitNo;
        private System.Windows.Forms.Label lblWorkPermitDate;
        private System.Windows.Forms.MaskedTextBox mtbPassportNo;
        private System.Windows.Forms.MaskedTextBox mtbCarRegNo;
        private System.Windows.Forms.Label lblCarRegNo;
        private System.Windows.Forms.Label lblPassportNo;
        private System.Windows.Forms.DateTimePicker dtpDrivingLicenseDate;
        private System.Windows.Forms.MaskedTextBox mtbDrivingLicenseNo;
        private System.Windows.Forms.Label lblDrivingLicenseDate;
        private System.Windows.Forms.Label lblDrivingLicenseNo;
        private System.Windows.Forms.ComboBox cmbECCommunity;
        private System.Windows.Forms.Label lblECIdentifier;
        private System.Windows.Forms.CheckBox chkStatementOfEmploymentRequired;
        private System.Windows.Forms.Label lblStatmentOfEmploymentRequired;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPersonalData;
        private System.Windows.Forms.TabPage tabEthnicCommunityBackground;
        private System.Windows.Forms.TabPage tabWorkEligibility;
        private System.Windows.Forms.TabPage tabEqualityCommission;
        private System.Windows.Forms.TabPage tabDocumentInformation;
        private System.Windows.Forms.TabPage tabContactData;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.Button btnNext4;
        private System.Windows.Forms.Button btnNext5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev5;
        private System.Windows.Forms.Button btnPrev2;
        private System.Windows.Forms.Button btnPrev3;
        private System.Windows.Forms.Button btnPrev4;
        private System.Windows.Forms.Button btnPrev;
    }
}