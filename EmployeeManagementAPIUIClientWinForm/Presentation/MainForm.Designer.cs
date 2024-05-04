namespace ASM.EmployeeManagementAPIUIClientWinForm
{
    partial class MainForm
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
            this._btnGetUserInfoList = new System.Windows.Forms.Button();
            this._btnGetUserInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnGetUserInfoList
            // 
            this._btnGetUserInfoList.Location = new System.Drawing.Point(35, 60);
            this._btnGetUserInfoList.Name = "_btnGetUserInfoList";
            this._btnGetUserInfoList.Size = new System.Drawing.Size(237, 37);
            this._btnGetUserInfoList.TabIndex = 0;
            this._btnGetUserInfoList.Text = "GetUserInfoList";
            this._btnGetUserInfoList.UseVisualStyleBackColor = true;
            this._btnGetUserInfoList.Click += new System.EventHandler(this._btnGetUserInfoList_Click);
            // 
            // _btnGetUserInfo
            // 
            this._btnGetUserInfo.Location = new System.Drawing.Point(35, 136);
            this._btnGetUserInfo.Name = "_btnGetUserInfo";
            this._btnGetUserInfo.Size = new System.Drawing.Size(237, 37);
            this._btnGetUserInfo.TabIndex = 1;
            this._btnGetUserInfo.Text = "GetUserInfo";
            this._btnGetUserInfo.UseVisualStyleBackColor = true;
            this._btnGetUserInfo.Click += new System.EventHandler(this._btnGetUserInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 240);
            this.Controls.Add(this._btnGetUserInfo);
            this.Controls.Add(this._btnGetUserInfoList);
            this.Name = "MainForm";
            this.Text = "EmployeeManagementAccessTool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnGetUserInfoList;
        private System.Windows.Forms.Button _btnGetUserInfo;
    }
}

