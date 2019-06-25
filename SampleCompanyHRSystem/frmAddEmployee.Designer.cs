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
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.grpContactData = new System.Windows.Forms.GroupBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbMobile = new System.Windows.Forms.MaskedTextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.mtbPostCode = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpBackground = new System.Windows.Forms.GroupBox();
            this.cmbEthnicOrigin = new System.Windows.Forms.ComboBox();
            this.lblEthnicBackground = new System.Windows.Forms.Label();
            this.grpPersonalData.SuspendLayout();
            this.grpContactData.SuspendLayout();
            this.grpBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.mtbPostCode);
            this.grpPersonalData.Controls.Add(this.lblPostcode);
            this.grpPersonalData.Controls.Add(this.cmbCounty);
            this.grpPersonalData.Controls.Add(this.lblCounty);
            this.grpPersonalData.Controls.Add(this.txtTown);
            this.grpPersonalData.Controls.Add(this.lblTown);
            this.grpPersonalData.Controls.Add(this.textBox1);
            this.grpPersonalData.Controls.Add(this.lblAddress2);
            this.grpPersonalData.Controls.Add(this.textBox2);
            this.grpPersonalData.Controls.Add(this.lblAddress);
            this.grpPersonalData.Controls.Add(this.txtInitials);
            this.grpPersonalData.Controls.Add(this.lblInitials);
            this.grpPersonalData.Controls.Add(this.txtMiddleName);
            this.grpPersonalData.Controls.Add(this.lblMiddleName);
            this.grpPersonalData.Controls.Add(this.txtForename);
            this.grpPersonalData.Controls.Add(this.lblForename);
            this.grpPersonalData.Controls.Add(this.txtSurname);
            this.grpPersonalData.Controls.Add(this.lblSurname);
            this.grpPersonalData.Controls.Add(this.cmbTitle);
            this.grpPersonalData.Controls.Add(this.lblTitle);
            this.grpPersonalData.Location = new System.Drawing.Point(12, 12);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(214, 329);
            this.grpPersonalData.TabIndex = 0;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Personal Data";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(12, 267);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "County:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(55, 234);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(93, 20);
            this.txtTown.TabIndex = 16;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(12, 237);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 15;
            this.lblTown.Text = "Town:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(12, 208);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(57, 13);
            this.lblAddress2.TabIndex = 13;
            this.lblAddress2.Text = "Address 2:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 179);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address 1:";
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(57, 144);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(56, 20);
            this.txtInitials.TabIndex = 10;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(12, 147);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(39, 13);
            this.lblInitials.TabIndex = 9;
            this.lblInitials.Text = "Initials:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(90, 77);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 8;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 80);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblMiddleName.TabIndex = 7;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(75, 48);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 6;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(12, 51);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 5;
            this.lblForename.Text = "Forename:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(70, 110);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 113);
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
            this.cmbTitle.Location = new System.Drawing.Point(48, 16);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(121, 21);
            this.cmbTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
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
            this.cmbCounty.Location = new System.Drawing.Point(61, 264);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(121, 21);
            this.cmbCounty.Sorted = true;
            this.cmbCounty.TabIndex = 19;
            // 
            // grpContactData
            // 
            this.grpContactData.Controls.Add(this.txtEmail);
            this.grpContactData.Controls.Add(this.lblEmail);
            this.grpContactData.Controls.Add(this.mtbMobile);
            this.grpContactData.Controls.Add(this.lblMobile);
            this.grpContactData.Controls.Add(this.mtbTelephone);
            this.grpContactData.Controls.Add(this.lblTelephone);
            this.grpContactData.Location = new System.Drawing.Point(232, 12);
            this.grpContactData.Name = "grpContactData";
            this.grpContactData.Size = new System.Drawing.Size(176, 138);
            this.grpContactData.TabIndex = 1;
            this.grpContactData.TabStop = false;
            this.grpContactData.Text = "Contact Data";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(6, 20);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 20;
            this.lblTelephone.Text = "Telephone:";
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(73, 17);
            this.mtbTelephone.Mask = "0000000000000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(92, 20);
            this.mtbTelephone.TabIndex = 21;
            this.mtbTelephone.ValidatingType = typeof(int);
            // 
            // mtbMobile
            // 
            this.mtbMobile.Location = new System.Drawing.Point(53, 48);
            this.mtbMobile.Mask = "0000000000000";
            this.mtbMobile.Name = "mtbMobile";
            this.mtbMobile.Size = new System.Drawing.Size(112, 20);
            this.mtbMobile.TabIndex = 23;
            this.mtbMobile.ValidatingType = typeof(int);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(6, 51);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 22;
            this.lblMobile.Text = "Mobile:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(12, 298);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(56, 13);
            this.lblPostcode.TabIndex = 20;
            this.lblPostcode.Text = "PostCode:";
            // 
            // mtbPostCode
            // 
            this.mtbPostCode.Location = new System.Drawing.Point(74, 295);
            this.mtbPostCode.Mask = ">LCCC 9LL";
            this.mtbPostCode.Name = "mtbPostCode";
            this.mtbPostCode.Size = new System.Drawing.Size(134, 20);
            this.mtbPostCode.TabIndex = 21;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 77);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 49);
            this.txtEmail.TabIndex = 25;
            // 
            // grpBackground
            // 
            this.grpBackground.Controls.Add(this.cmbEthnicOrigin);
            this.grpBackground.Controls.Add(this.lblEthnicBackground);
            this.grpBackground.Location = new System.Drawing.Point(232, 156);
            this.grpBackground.Name = "grpBackground";
            this.grpBackground.Size = new System.Drawing.Size(176, 185);
            this.grpBackground.TabIndex = 26;
            this.grpBackground.TabStop = false;
            this.grpBackground.Text = "Ethnic/Community Background";
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
            "",
            "Filipino",
            "Black",
            "White",
            "Other"});
            this.cmbEthnicOrigin.Location = new System.Drawing.Point(82, 20);
            this.cmbEthnicOrigin.Name = "cmbEthnicOrigin";
            this.cmbEthnicOrigin.Size = new System.Drawing.Size(81, 21);
            this.cmbEthnicOrigin.TabIndex = 23;
            // 
            // lblEthnicBackground
            // 
            this.lblEthnicBackground.AutoSize = true;
            this.lblEthnicBackground.Location = new System.Drawing.Point(6, 24);
            this.lblEthnicBackground.Name = "lblEthnicBackground";
            this.lblEthnicBackground.Size = new System.Drawing.Size(70, 13);
            this.lblEthnicBackground.TabIndex = 22;
            this.lblEthnicBackground.Text = "Ethnic Origin:";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBackground);
            this.Controls.Add(this.grpContactData);
            this.Controls.Add(this.grpPersonalData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            this.grpContactData.ResumeLayout(false);
            this.grpContactData.PerformLayout();
            this.grpBackground.ResumeLayout(false);
            this.grpBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalData;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.GroupBox grpContactData;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.MaskedTextBox mtbMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbPostCode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpBackground;
        private System.Windows.Forms.ComboBox cmbEthnicOrigin;
        private System.Windows.Forms.Label lblEthnicBackground;
    }
}