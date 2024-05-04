namespace ASM.EmployeeManagementAPIUIClientWinForm.Presentation
{
    partial class GetUserInfoListForm
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
			this._lvUserList = new System.Windows.Forms.ListView();
			this.UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DepartmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MaritalStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PhoneNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.JobStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._lblLoginID = new System.Windows.Forms.Label();
			this._tbxLoginID = new System.Windows.Forms.TextBox();
			this._lblPassword = new System.Windows.Forms.Label();
			this._tbxPassword = new System.Windows.Forms.TextBox();
			this._lblPageSzie = new System.Windows.Forms.Label();
			this._cbPageSize = new System.Windows.Forms.ComboBox();
			this._gpbAuthInfo = new System.Windows.Forms.GroupBox();
			this._gpbPaging = new System.Windows.Forms.GroupBox();
			this._cbSortKey = new System.Windows.Forms.ComboBox();
			this._lblSortKey = new System.Windows.Forms.Label();
			this._rdoDesc = new System.Windows.Forms.RadioButton();
			this._rdoASC = new System.Windows.Forms.RadioButton();
			this._lblSortOrder = new System.Windows.Forms.Label();
			this._tbxStartIndex = new System.Windows.Forms.TextBox();
			this._lblPageStartIndex = new System.Windows.Forms.Label();
			this._gpbFilter = new System.Windows.Forms.GroupBox();
			this._cbExactMatch = new System.Windows.Forms.CheckBox();
			this._tbxEmail = new System.Windows.Forms.TextBox();
			this._lblEmail = new System.Windows.Forms.Label();
			this._tbxUserID = new System.Windows.Forms.TextBox();
			this._lblUserID = new System.Windows.Forms.Label();
			this._btnMain = new System.Windows.Forms.Button();
			this._lblRecord = new System.Windows.Forms.Label();
			this._lblRecordCount = new System.Windows.Forms.Label();
			this._btnExecute = new System.Windows.Forms.Button();
			this._gpbAuthInfo.SuspendLayout();
			this._gpbPaging.SuspendLayout();
			this._gpbFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// _lvUserList
			// 
			this._lvUserList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this._lvUserList.BackgroundImageTiled = true;
			this._lvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserID,
            this.UserName,
            this.DepartmentName,
            this.Gender,
            this.MaritalStatus,
            this.DateOfBirth,
            this.Address,
            this.Email,
            this.PhoneNo,
            this.JobStartDate});
			this._lvUserList.GridLines = true;
			this._lvUserList.HideSelection = false;
			this._lvUserList.Location = new System.Drawing.Point(12, 341);
			this._lvUserList.MultiSelect = false;
			this._lvUserList.Name = "_lvUserList";
			this._lvUserList.Size = new System.Drawing.Size(865, 346);
			this._lvUserList.TabIndex = 5;
			this._lvUserList.UseCompatibleStateImageBehavior = false;
			this._lvUserList.View = System.Windows.Forms.View.Details;
			// 
			// UserID
			// 
			this.UserID.Text = "User ID";
			this.UserID.Width = 85;
			// 
			// UserName
			// 
			this.UserName.Text = "User Name";
			this.UserName.Width = 100;
			// 
			// DepartmentName
			// 
			this.DepartmentName.Text = "Department";
			this.DepartmentName.Width = 70;
			// 
			// Gender
			// 
			this.Gender.Text = "Gender";
			this.Gender.Width = 50;
			// 
			// MaritalStatus
			// 
			this.MaritalStatus.Text = "Marital Sts";
			this.MaritalStatus.Width = 65;
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.Text = "Date Of Birth";
			this.DateOfBirth.Width = 95;
			// 
			// Address
			// 
			this.Address.Text = "Address";
			this.Address.Width = 70;
			// 
			// Email
			// 
			this.Email.Text = "Email";
			this.Email.Width = 155;
			// 
			// PhoneNo
			// 
			this.PhoneNo.Text = "Phone No.";
			this.PhoneNo.Width = 85;
			// 
			// JobStartDate
			// 
			this.JobStartDate.Text = "Job Start Date";
			this.JobStartDate.Width = 85;
			// 
			// _lblLoginID
			// 
			this._lblLoginID.AutoSize = true;
			this._lblLoginID.Location = new System.Drawing.Point(6, 43);
			this._lblLoginID.Name = "_lblLoginID";
			this._lblLoginID.Size = new System.Drawing.Size(53, 15);
			this._lblLoginID.TabIndex = 0;
			this._lblLoginID.Text = "LoginID:";
			// 
			// _tbxLoginID
			// 
			this._tbxLoginID.Location = new System.Drawing.Point(74, 40);
			this._tbxLoginID.Name = "_tbxLoginID";
			this._tbxLoginID.Size = new System.Drawing.Size(131, 20);
			this._tbxLoginID.TabIndex = 0;
			this._tbxLoginID.Text = "acty.hr";
			// 
			// _lblPassword
			// 
			this._lblPassword.AutoSize = true;
			this._lblPassword.Location = new System.Drawing.Point(6, 90);
			this._lblPassword.Name = "_lblPassword";
			this._lblPassword.Size = new System.Drawing.Size(64, 15);
			this._lblPassword.TabIndex = 2;
			this._lblPassword.Text = "Password:";
			// 
			// _tbxPassword
			// 
			this._tbxPassword.Location = new System.Drawing.Point(74, 87);
			this._tbxPassword.Name = "_tbxPassword";
			this._tbxPassword.PasswordChar = '*';
			this._tbxPassword.Size = new System.Drawing.Size(131, 20);
			this._tbxPassword.TabIndex = 1;
			this._tbxPassword.Text = "khs";
			// 
			// _lblPageSzie
			// 
			this._lblPageSzie.AutoSize = true;
			this._lblPageSzie.Location = new System.Drawing.Point(6, 36);
			this._lblPageSzie.Name = "_lblPageSzie";
			this._lblPageSzie.Size = new System.Drawing.Size(66, 15);
			this._lblPageSzie.TabIndex = 4;
			this._lblPageSzie.Text = "Page Size:";
			// 
			// _cbPageSize
			// 
			this._cbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbPageSize.FormattingEnabled = true;
			this._cbPageSize.Location = new System.Drawing.Point(74, 33);
			this._cbPageSize.Name = "_cbPageSize";
			this._cbPageSize.Size = new System.Drawing.Size(98, 21);
			this._cbPageSize.TabIndex = 0;
			// 
			// _gpbAuthInfo
			// 
			this._gpbAuthInfo.Controls.Add(this._lblLoginID);
			this._gpbAuthInfo.Controls.Add(this._tbxLoginID);
			this._gpbAuthInfo.Controls.Add(this._lblPassword);
			this._gpbAuthInfo.Controls.Add(this._tbxPassword);
			this._gpbAuthInfo.Location = new System.Drawing.Point(46, 28);
			this._gpbAuthInfo.Name = "_gpbAuthInfo";
			this._gpbAuthInfo.Size = new System.Drawing.Size(238, 125);
			this._gpbAuthInfo.TabIndex = 0;
			this._gpbAuthInfo.TabStop = false;
			this._gpbAuthInfo.Text = "AuthenticationInfo";
			// 
			// _gpbPaging
			// 
			this._gpbPaging.Controls.Add(this._cbSortKey);
			this._gpbPaging.Controls.Add(this._lblSortKey);
			this._gpbPaging.Controls.Add(this._rdoDesc);
			this._gpbPaging.Controls.Add(this._rdoASC);
			this._gpbPaging.Controls.Add(this._lblSortOrder);
			this._gpbPaging.Controls.Add(this._tbxStartIndex);
			this._gpbPaging.Controls.Add(this._lblPageStartIndex);
			this._gpbPaging.Controls.Add(this._lblPageSzie);
			this._gpbPaging.Controls.Add(this._cbPageSize);
			this._gpbPaging.Location = new System.Drawing.Point(46, 170);
			this._gpbPaging.Name = "_gpbPaging";
			this._gpbPaging.Size = new System.Drawing.Size(459, 114);
			this._gpbPaging.TabIndex = 2;
			this._gpbPaging.TabStop = false;
			this._gpbPaging.Text = "Paging";
			// 
			// _cbSortKey
			// 
			this._cbSortKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbSortKey.FormattingEnabled = true;
			this._cbSortKey.Location = new System.Drawing.Point(297, 66);
			this._cbSortKey.Name = "_cbSortKey";
			this._cbSortKey.Size = new System.Drawing.Size(121, 21);
			this._cbSortKey.TabIndex = 4;
			// 
			// _lblSortKey
			// 
			this._lblSortKey.AutoSize = true;
			this._lblSortKey.Location = new System.Drawing.Point(203, 70);
			this._lblSortKey.Name = "_lblSortKey";
			this._lblSortKey.Size = new System.Drawing.Size(55, 15);
			this._lblSortKey.TabIndex = 12;
			this._lblSortKey.Text = "Sort Key:";
			// 
			// _rdoDesc
			// 
			this._rdoDesc.AutoSize = true;
			this._rdoDesc.Location = new System.Drawing.Point(364, 34);
			this._rdoDesc.Name = "_rdoDesc";
			this._rdoDesc.Size = new System.Drawing.Size(58, 19);
			this._rdoDesc.TabIndex = 3;
			this._rdoDesc.Text = "DESC";
			this._rdoDesc.UseVisualStyleBackColor = true;
			// 
			// _rdoASC
			// 
			this._rdoASC.AutoSize = true;
			this._rdoASC.Checked = true;
			this._rdoASC.Location = new System.Drawing.Point(297, 34);
			this._rdoASC.Name = "_rdoASC";
			this._rdoASC.Size = new System.Drawing.Size(48, 19);
			this._rdoASC.TabIndex = 2;
			this._rdoASC.TabStop = true;
			this._rdoASC.Text = "ASC";
			this._rdoASC.UseVisualStyleBackColor = true;
			// 
			// _lblSortOrder
			// 
			this._lblSortOrder.AutoSize = true;
			this._lblSortOrder.Location = new System.Drawing.Point(203, 36);
			this._lblSortOrder.Name = "_lblSortOrder";
			this._lblSortOrder.Size = new System.Drawing.Size(66, 15);
			this._lblSortOrder.TabIndex = 9;
			this._lblSortOrder.Text = "Sort Order:";
			// 
			// _tbxStartIndex
			// 
			this._tbxStartIndex.Location = new System.Drawing.Point(74, 67);
			this._tbxStartIndex.Name = "_tbxStartIndex";
			this._tbxStartIndex.Size = new System.Drawing.Size(98, 20);
			this._tbxStartIndex.TabIndex = 1;
			this._tbxStartIndex.Text = "0";
			// 
			// _lblPageStartIndex
			// 
			this._lblPageStartIndex.AutoSize = true;
			this._lblPageStartIndex.Location = new System.Drawing.Point(6, 70);
			this._lblPageStartIndex.Name = "_lblPageStartIndex";
			this._lblPageStartIndex.Size = new System.Drawing.Size(68, 15);
			this._lblPageStartIndex.TabIndex = 6;
			this._lblPageStartIndex.Text = "Start Index:";
			// 
			// _gpbFilter
			// 
			this._gpbFilter.Controls.Add(this._cbExactMatch);
			this._gpbFilter.Controls.Add(this._tbxEmail);
			this._gpbFilter.Controls.Add(this._lblEmail);
			this._gpbFilter.Controls.Add(this._tbxUserID);
			this._gpbFilter.Controls.Add(this._lblUserID);
			this._gpbFilter.Location = new System.Drawing.Point(290, 28);
			this._gpbFilter.Name = "_gpbFilter";
			this._gpbFilter.Size = new System.Drawing.Size(215, 125);
			this._gpbFilter.TabIndex = 1;
			this._gpbFilter.TabStop = false;
			this._gpbFilter.Text = "Filter";
			// 
			// _cbExactMatch
			// 
			this._cbExactMatch.AutoSize = true;
			this._cbExactMatch.Location = new System.Drawing.Point(9, 24);
			this._cbExactMatch.Name = "_cbExactMatch";
			this._cbExactMatch.Size = new System.Drawing.Size(135, 19);
			this._cbExactMatch.TabIndex = 4;
			this._cbExactMatch.Text = "Exact Match Search";
			this._cbExactMatch.UseVisualStyleBackColor = true;
			// 
			// _tbxEmail
			// 
			this._tbxEmail.Location = new System.Drawing.Point(70, 83);
			this._tbxEmail.Name = "_tbxEmail";
			this._tbxEmail.Size = new System.Drawing.Size(139, 20);
			this._tbxEmail.TabIndex = 2;
			this._tbxEmail.Text = "acty.hr@gmail.com";
			// 
			// _lblEmail
			// 
			this._lblEmail.AutoSize = true;
			this._lblEmail.Location = new System.Drawing.Point(6, 90);
			this._lblEmail.Name = "_lblEmail";
			this._lblEmail.Size = new System.Drawing.Size(42, 15);
			this._lblEmail.TabIndex = 2;
			this._lblEmail.Text = "Email:";
			// 
			// _tbxUserID
			// 
			this._tbxUserID.Location = new System.Drawing.Point(70, 47);
			this._tbxUserID.Name = "_tbxUserID";
			this._tbxUserID.Size = new System.Drawing.Size(139, 20);
			this._tbxUserID.TabIndex = 1;
			this._tbxUserID.Text = "acty.hr";
			// 
			// _lblUserID
			// 
			this._lblUserID.AutoSize = true;
			this._lblUserID.Location = new System.Drawing.Point(6, 54);
			this._lblUserID.Name = "_lblUserID";
			this._lblUserID.Size = new System.Drawing.Size(48, 15);
			this._lblUserID.TabIndex = 0;
			this._lblUserID.Text = "UserID:";
			// 
			// _btnMain
			// 
			this._btnMain.Location = new System.Drawing.Point(534, 52);
			this._btnMain.Name = "_btnMain";
			this._btnMain.Size = new System.Drawing.Size(75, 23);
			this._btnMain.TabIndex = 4;
			this._btnMain.Text = "Main Menu";
			this._btnMain.UseVisualStyleBackColor = true;
			this._btnMain.Click += new System.EventHandler(this._btnMain_Click);
			// 
			// _lblRecord
			// 
			this._lblRecord.AutoSize = true;
			this._lblRecord.Location = new System.Drawing.Point(12, 314);
			this._lblRecord.Name = "_lblRecord";
			this._lblRecord.Size = new System.Drawing.Size(136, 15);
			this._lblRecord.TabIndex = 12;
			this._lblRecord.Text = "Total Record Hit Count: ";
			// 
			// _lblRecordCount
			// 
			this._lblRecordCount.AutoSize = true;
			this._lblRecordCount.Location = new System.Drawing.Point(154, 314);
			this._lblRecordCount.Name = "_lblRecordCount";
			this._lblRecordCount.Size = new System.Drawing.Size(14, 15);
			this._lblRecordCount.TabIndex = 13;
			this._lblRecordCount.Text = "0";
			// 
			// _btnExecute
			// 
			this._btnExecute.Location = new System.Drawing.Point(534, 261);
			this._btnExecute.Name = "_btnExecute";
			this._btnExecute.Size = new System.Drawing.Size(75, 23);
			this._btnExecute.TabIndex = 3;
			this._btnExecute.Text = "Execute";
			this._btnExecute.UseVisualStyleBackColor = true;
			this._btnExecute.Click += new System.EventHandler(this._btnExecute_Click);
			// 
			// GetUserInfoListForm
			// 
			this.AcceptButton = this._btnExecute;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 699);
			this.Controls.Add(this._lblRecordCount);
			this.Controls.Add(this._lblRecord);
			this.Controls.Add(this._btnMain);
			this.Controls.Add(this._btnExecute);
			this.Controls.Add(this._lvUserList);
			this.Controls.Add(this._gpbFilter);
			this.Controls.Add(this._gpbPaging);
			this.Controls.Add(this._gpbAuthInfo);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GetUserInfoListForm";
			this.Text = "GetUserInfoListForm";
			this.Load += new System.EventHandler(this.GetUserInfoListForm_Load);
			this._gpbAuthInfo.ResumeLayout(false);
			this._gpbAuthInfo.PerformLayout();
			this._gpbPaging.ResumeLayout(false);
			this._gpbPaging.PerformLayout();
			this._gpbFilter.ResumeLayout(false);
			this._gpbFilter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblLoginID;
        private System.Windows.Forms.TextBox _tbxLoginID;
        private System.Windows.Forms.Label _lblPassword;
        private System.Windows.Forms.TextBox _tbxPassword;
        private System.Windows.Forms.Label _lblPageSzie;
        private System.Windows.Forms.ComboBox _cbPageSize;
        private System.Windows.Forms.GroupBox _gpbAuthInfo;
        private System.Windows.Forms.GroupBox _gpbPaging;
        private System.Windows.Forms.TextBox _tbxStartIndex;
        private System.Windows.Forms.Label _lblPageStartIndex;
        private System.Windows.Forms.ComboBox _cbSortKey;
        private System.Windows.Forms.Label _lblSortKey;
        private System.Windows.Forms.RadioButton _rdoDesc;
        private System.Windows.Forms.RadioButton _rdoASC;
        private System.Windows.Forms.Label _lblSortOrder;
        private System.Windows.Forms.GroupBox _gpbFilter;
        private System.Windows.Forms.TextBox _tbxEmail;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.TextBox _tbxUserID;
        private System.Windows.Forms.Label _lblUserID;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader DepartmentName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader PhoneNo;
        private System.Windows.Forms.ColumnHeader JobStartDate;
        private System.Windows.Forms.CheckBox _cbExactMatch;
        private System.Windows.Forms.Button _btnMain;
		private System.Windows.Forms.Label _lblRecord;
		private System.Windows.Forms.Label _lblRecordCount;
		private System.Windows.Forms.ColumnHeader MaritalStatus;
		private System.Windows.Forms.Button _btnExecute;
		private System.Windows.Forms.ListView _lvUserList;
	}
}