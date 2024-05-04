using System;
using System.Windows.Forms;

using ASM.EmployeeManagementAPIUIClientWinForm.Presentation;

namespace ASM.EmployeeManagementAPIUIClientWinForm
{
    public partial class MainForm : Form
    {
        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form event method

        /// <summary>
        /// Execute when GetUserInfoList button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnGetUserInfoList_Click(object sender, EventArgs e)
        {
			this.Hide();

			GetUserInfoListForm getUserInfoListForm = new GetUserInfoListForm();
			getUserInfoListForm.Closed += (s, args) => Close();
			getUserInfoListForm.ShowDialog();
		}

        /// <summary>
        /// Execute when GetUserInfo button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnGetUserInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetUserInfoForm getUserInfoForm = new GetUserInfoForm();
            getUserInfoForm.Closed += (s, args) => Close();
            getUserInfoForm.ShowDialog();
        }

        #endregion
    }
}
