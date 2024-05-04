namespace ASM.EmployeeManagementAPIUIClientWinForm.Presentation
{
    partial class GetUserInfoForm
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
            this._lbLoginID = new System.Windows.Forms.Label();
            this._gbAuthInfo = new System.Windows.Forms.GroupBox();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._lbPassword = new System.Windows.Forms.Label();
            this._tbLoginID = new System.Windows.Forms.TextBox();
            this._lbUserID = new System.Windows.Forms.Label();
            this._tbUserID = new System.Windows.Forms.TextBox();
            this._btnExecute = new System.Windows.Forms.Button();
            this._gbSearchInfo = new System.Windows.Forms.GroupBox();
            this._gbUserInfo = new System.Windows.Forms.GroupBox();
            this._tbJobStartDate = new System.Windows.Forms.TextBox();
            this._tbPhoneNo = new System.Windows.Forms.TextBox();
            this._tbEmail = new System.Windows.Forms.TextBox();
            this._tbAddress = new System.Windows.Forms.TextBox();
            this._tbDateOfBirth = new System.Windows.Forms.TextBox();
            this._tbGender = new System.Windows.Forms.TextBox();
            this._tbDepartment = new System.Windows.Forms.TextBox();
            this._tbUserName = new System.Windows.Forms.TextBox();
            this._lbJobStartDate = new System.Windows.Forms.Label();
            this._lbPhoneNo = new System.Windows.Forms.Label();
            this._lbEmail = new System.Windows.Forms.Label();
            this._lbAddress = new System.Windows.Forms.Label();
            this._lbBirthDate = new System.Windows.Forms.Label();
            this._lbGender = new System.Windows.Forms.Label();
            this._lbDepartmentName = new System.Windows.Forms.Label();
            this._lbUserName = new System.Windows.Forms.Label();
            this._tbResultUserID = new System.Windows.Forms.TextBox();
            this._lbResultUserID = new System.Windows.Forms.Label();
            this._btnMenu = new System.Windows.Forms.Button();
            this._gbAuthInfo.SuspendLayout();
            this._gbSearchInfo.SuspendLayout();
            this._gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lbLoginID
            // 
            this._lbLoginID.AutoSize = true;
            this._lbLoginID.Location = new System.Drawing.Point(6, 34);
            this._lbLoginID.Name = "_lbLoginID";
            this._lbLoginID.Size = new System.Drawing.Size(47, 13);
            this._lbLoginID.TabIndex = 0;
            this._lbLoginID.Text = "LoginID:";
            // 
            // _gbAuthInfo
            // 
            this._gbAuthInfo.Controls.Add(this._tbPassword);
            this._gbAuthInfo.Controls.Add(this._lbPassword);
            this._gbAuthInfo.Controls.Add(this._tbLoginID);
            this._gbAuthInfo.Controls.Add(this._lbLoginID);
            this._gbAuthInfo.Location = new System.Drawing.Point(33, 26);
            this._gbAuthInfo.Name = "_gbAuthInfo";
            this._gbAuthInfo.Size = new System.Drawing.Size(214, 100);
            this._gbAuthInfo.TabIndex = 1;
            this._gbAuthInfo.TabStop = false;
            this._gbAuthInfo.Text = "AuthenticationInfo";
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(75, 61);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.PasswordChar = '*';
            this._tbPassword.Size = new System.Drawing.Size(119, 20);
            this._tbPassword.TabIndex = 3;
            // 
            // _lbPassword
            // 
            this._lbPassword.AutoSize = true;
            this._lbPassword.Location = new System.Drawing.Point(6, 68);
            this._lbPassword.Name = "_lbPassword";
            this._lbPassword.Size = new System.Drawing.Size(56, 13);
            this._lbPassword.TabIndex = 2;
            this._lbPassword.Text = "Password:";
            // 
            // _tbLoginID
            // 
            this._tbLoginID.Location = new System.Drawing.Point(75, 27);
            this._tbLoginID.Name = "_tbLoginID";
            this._tbLoginID.Size = new System.Drawing.Size(119, 20);
            this._tbLoginID.TabIndex = 1;
            // 
            // _lbUserID
            // 
            this._lbUserID.AutoSize = true;
            this._lbUserID.Location = new System.Drawing.Point(6, 31);
            this._lbUserID.Name = "_lbUserID";
            this._lbUserID.Size = new System.Drawing.Size(43, 13);
            this._lbUserID.TabIndex = 2;
            this._lbUserID.Text = "UserID:";
            // 
            // _tbUserID
            // 
            this._tbUserID.Location = new System.Drawing.Point(75, 24);
            this._tbUserID.Name = "_tbUserID";
            this._tbUserID.Size = new System.Drawing.Size(119, 20);
            this._tbUserID.TabIndex = 3;
            // 
            // _btnExecute
            // 
            this._btnExecute.Location = new System.Drawing.Point(274, 166);
            this._btnExecute.Name = "_btnExecute";
            this._btnExecute.Size = new System.Drawing.Size(75, 23);
            this._btnExecute.TabIndex = 4;
            this._btnExecute.Text = "Execute";
            this._btnExecute.UseVisualStyleBackColor = true;
            this._btnExecute.Click += new System.EventHandler(this._btnExecute_Click);
            // 
            // _gbSearchInfo
            // 
            this._gbSearchInfo.Controls.Add(this._lbUserID);
            this._gbSearchInfo.Controls.Add(this._tbUserID);
            this._gbSearchInfo.Location = new System.Drawing.Point(33, 132);
            this._gbSearchInfo.Name = "_gbSearchInfo";
            this._gbSearchInfo.Size = new System.Drawing.Size(214, 57);
            this._gbSearchInfo.TabIndex = 5;
            this._gbSearchInfo.TabStop = false;
            this._gbSearchInfo.Text = "SearchInfo";
            // 
            // _gbUserInfo
            // 
            this._gbUserInfo.Controls.Add(this._tbJobStartDate);
            this._gbUserInfo.Controls.Add(this._tbPhoneNo);
            this._gbUserInfo.Controls.Add(this._tbEmail);
            this._gbUserInfo.Controls.Add(this._tbAddress);
            this._gbUserInfo.Controls.Add(this._tbDateOfBirth);
            this._gbUserInfo.Controls.Add(this._tbGender);
            this._gbUserInfo.Controls.Add(this._tbDepartment);
            this._gbUserInfo.Controls.Add(this._tbUserName);
            this._gbUserInfo.Controls.Add(this._lbJobStartDate);
            this._gbUserInfo.Controls.Add(this._lbPhoneNo);
            this._gbUserInfo.Controls.Add(this._lbEmail);
            this._gbUserInfo.Controls.Add(this._lbAddress);
            this._gbUserInfo.Controls.Add(this._lbBirthDate);
            this._gbUserInfo.Controls.Add(this._lbGender);
            this._gbUserInfo.Controls.Add(this._lbDepartmentName);
            this._gbUserInfo.Controls.Add(this._lbUserName);
            this._gbUserInfo.Controls.Add(this._tbResultUserID);
            this._gbUserInfo.Controls.Add(this._lbResultUserID);
            this._gbUserInfo.Location = new System.Drawing.Point(33, 208);
            this._gbUserInfo.Name = "_gbUserInfo";
            this._gbUserInfo.Size = new System.Drawing.Size(447, 247);
            this._gbUserInfo.TabIndex = 6;
            this._gbUserInfo.TabStop = false;
            this._gbUserInfo.Text = "User Info";
            // 
            // _tbJobStartDate
            // 
            this._tbJobStartDate.Location = new System.Drawing.Point(302, 147);
            this._tbJobStartDate.Name = "_tbJobStartDate";
            this._tbJobStartDate.ReadOnly = true;
            this._tbJobStartDate.Size = new System.Drawing.Size(119, 20);
            this._tbJobStartDate.TabIndex = 17;
            // 
            // _tbPhoneNo
            // 
            this._tbPhoneNo.Location = new System.Drawing.Point(302, 102);
            this._tbPhoneNo.Name = "_tbPhoneNo";
            this._tbPhoneNo.ReadOnly = true;
            this._tbPhoneNo.Size = new System.Drawing.Size(119, 20);
            this._tbPhoneNo.TabIndex = 16;
            // 
            // _tbEmail
            // 
            this._tbEmail.Location = new System.Drawing.Point(302, 64);
            this._tbEmail.Name = "_tbEmail";
            this._tbEmail.ReadOnly = true;
            this._tbEmail.Size = new System.Drawing.Size(119, 20);
            this._tbEmail.TabIndex = 15;
            // 
            // _tbAddress
            // 
            this._tbAddress.Location = new System.Drawing.Point(302, 27);
            this._tbAddress.Name = "_tbAddress";
            this._tbAddress.ReadOnly = true;
            this._tbAddress.Size = new System.Drawing.Size(119, 20);
            this._tbAddress.TabIndex = 14;
            // 
            // _tbDateOfBirth
            // 
            this._tbDateOfBirth.Location = new System.Drawing.Point(74, 189);
            this._tbDateOfBirth.Name = "_tbDateOfBirth";
            this._tbDateOfBirth.ReadOnly = true;
            this._tbDateOfBirth.Size = new System.Drawing.Size(119, 20);
            this._tbDateOfBirth.TabIndex = 13;
            // 
            // _tbGender
            // 
            this._tbGender.Location = new System.Drawing.Point(74, 143);
            this._tbGender.Name = "_tbGender";
            this._tbGender.ReadOnly = true;
            this._tbGender.Size = new System.Drawing.Size(119, 20);
            this._tbGender.TabIndex = 12;
            // 
            // _tbDepartment
            // 
            this._tbDepartment.Location = new System.Drawing.Point(74, 102);
            this._tbDepartment.Name = "_tbDepartment";
            this._tbDepartment.ReadOnly = true;
            this._tbDepartment.Size = new System.Drawing.Size(120, 20);
            this._tbDepartment.TabIndex = 11;
            // 
            // _tbUserName
            // 
            this._tbUserName.Location = new System.Drawing.Point(75, 64);
            this._tbUserName.Name = "_tbUserName";
            this._tbUserName.ReadOnly = true;
            this._tbUserName.Size = new System.Drawing.Size(118, 20);
            this._tbUserName.TabIndex = 10;
            // 
            // _lbJobStartDate
            // 
            this._lbJobStartDate.AutoSize = true;
            this._lbJobStartDate.Location = new System.Drawing.Point(218, 150);
            this._lbJobStartDate.Name = "_lbJobStartDate";
            this._lbJobStartDate.Size = new System.Drawing.Size(78, 13);
            this._lbJobStartDate.TabIndex = 9;
            this._lbJobStartDate.Text = "Job Start Date:";
            // 
            // _lbPhoneNo
            // 
            this._lbPhoneNo.AutoSize = true;
            this._lbPhoneNo.Location = new System.Drawing.Point(218, 109);
            this._lbPhoneNo.Name = "_lbPhoneNo";
            this._lbPhoneNo.Size = new System.Drawing.Size(58, 13);
            this._lbPhoneNo.TabIndex = 8;
            this._lbPhoneNo.Text = "Phone No:";
            // 
            // _lbEmail
            // 
            this._lbEmail.AutoSize = true;
            this._lbEmail.Location = new System.Drawing.Point(218, 71);
            this._lbEmail.Name = "_lbEmail";
            this._lbEmail.Size = new System.Drawing.Size(35, 13);
            this._lbEmail.TabIndex = 7;
            this._lbEmail.Text = "Email:";
            // 
            // _lbAddress
            // 
            this._lbAddress.AutoSize = true;
            this._lbAddress.Location = new System.Drawing.Point(218, 34);
            this._lbAddress.Name = "_lbAddress";
            this._lbAddress.Size = new System.Drawing.Size(48, 13);
            this._lbAddress.TabIndex = 6;
            this._lbAddress.Text = "Address:";
            // 
            // _lbBirthDate
            // 
            this._lbBirthDate.AutoSize = true;
            this._lbBirthDate.Location = new System.Drawing.Point(6, 196);
            this._lbBirthDate.Name = "_lbBirthDate";
            this._lbBirthDate.Size = new System.Drawing.Size(69, 13);
            this._lbBirthDate.TabIndex = 5;
            this._lbBirthDate.Text = "Date of Birth:";
            // 
            // _lbGender
            // 
            this._lbGender.AutoSize = true;
            this._lbGender.Location = new System.Drawing.Point(6, 150);
            this._lbGender.Name = "_lbGender";
            this._lbGender.Size = new System.Drawing.Size(45, 13);
            this._lbGender.TabIndex = 4;
            this._lbGender.Text = "Gender:";
            // 
            // _lbDepartmentName
            // 
            this._lbDepartmentName.AutoSize = true;
            this._lbDepartmentName.Location = new System.Drawing.Point(6, 109);
            this._lbDepartmentName.Name = "_lbDepartmentName";
            this._lbDepartmentName.Size = new System.Drawing.Size(65, 13);
            this._lbDepartmentName.TabIndex = 3;
            this._lbDepartmentName.Text = "Department:";
            // 
            // _lbUserName
            // 
            this._lbUserName.AutoSize = true;
            this._lbUserName.Location = new System.Drawing.Point(6, 71);
            this._lbUserName.Name = "_lbUserName";
            this._lbUserName.Size = new System.Drawing.Size(63, 13);
            this._lbUserName.TabIndex = 2;
            this._lbUserName.Text = "User Name:";
            // 
            // _tbResultUserID
            // 
            this._tbResultUserID.Location = new System.Drawing.Point(74, 27);
            this._tbResultUserID.Name = "_tbResultUserID";
            this._tbResultUserID.ReadOnly = true;
            this._tbResultUserID.Size = new System.Drawing.Size(120, 20);
            this._tbResultUserID.TabIndex = 1;
            // 
            // _lbResultUserID
            // 
            this._lbResultUserID.AutoSize = true;
            this._lbResultUserID.Location = new System.Drawing.Point(6, 34);
            this._lbResultUserID.Name = "_lbResultUserID";
            this._lbResultUserID.Size = new System.Drawing.Size(43, 13);
            this._lbResultUserID.TabIndex = 0;
            this._lbResultUserID.Text = "UserID:";
            // 
            // _btnMenu
            // 
            this._btnMenu.Location = new System.Drawing.Point(274, 36);
            this._btnMenu.Name = "_btnMenu";
            this._btnMenu.Size = new System.Drawing.Size(75, 23);
            this._btnMenu.TabIndex = 7;
            this._btnMenu.Text = "Main Menu";
            this._btnMenu.UseVisualStyleBackColor = true;
            this._btnMenu.Click += new System.EventHandler(this._btnMenu_Click);
            // 
            // GetUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 474);
            this.Controls.Add(this._btnMenu);
            this.Controls.Add(this._gbUserInfo);
            this.Controls.Add(this._gbSearchInfo);
            this.Controls.Add(this._btnExecute);
            this.Controls.Add(this._gbAuthInfo);
            this.Name = "GetUserInfoForm";
            this.Text = "GetUserInfoForm";
            this._gbAuthInfo.ResumeLayout(false);
            this._gbAuthInfo.PerformLayout();
            this._gbSearchInfo.ResumeLayout(false);
            this._gbSearchInfo.PerformLayout();
            this._gbUserInfo.ResumeLayout(false);
            this._gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lbLoginID;
        private System.Windows.Forms.GroupBox _gbAuthInfo;
        private System.Windows.Forms.TextBox _tbLoginID;
        private System.Windows.Forms.Label _lbPassword;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _lbUserID;
        private System.Windows.Forms.TextBox _tbUserID;
        private System.Windows.Forms.Button _btnExecute;
        private System.Windows.Forms.GroupBox _gbSearchInfo;
        private System.Windows.Forms.GroupBox _gbUserInfo;
        private System.Windows.Forms.Label _lbJobStartDate;
        private System.Windows.Forms.Label _lbPhoneNo;
        private System.Windows.Forms.Label _lbEmail;
        private System.Windows.Forms.Label _lbAddress;
        private System.Windows.Forms.Label _lbBirthDate;
        private System.Windows.Forms.Label _lbGender;
        private System.Windows.Forms.Label _lbDepartmentName;
        private System.Windows.Forms.Label _lbUserName;
        private System.Windows.Forms.TextBox _tbResultUserID;
        private System.Windows.Forms.Label _lbResultUserID;
        private System.Windows.Forms.TextBox _tbJobStartDate;
        private System.Windows.Forms.TextBox _tbPhoneNo;
        private System.Windows.Forms.TextBox _tbEmail;
        private System.Windows.Forms.TextBox _tbAddress;
        private System.Windows.Forms.TextBox _tbDateOfBirth;
        private System.Windows.Forms.TextBox _tbGender;
        private System.Windows.Forms.TextBox _tbDepartment;
        private System.Windows.Forms.TextBox _tbUserName;
        private System.Windows.Forms.Button _btnMenu;
    }
}