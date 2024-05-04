using System;
using System.Windows.Forms;

using ASM.EmployeeManagementAPIUIClientWinForm.Mid;
using ASM.EmployeeManagementAPIUIClientWinForm.Util;
using ASM.EmployeeManagementAPIUIClientWinForm.Properties;
using ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfo;
using static ASM.EmployeeManagementAPIUIClientWinForm.Util.Constants;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Presentation
{
    /// <summary>
    /// GetUserInfo Form
    /// </summary>
    public partial class GetUserInfoForm : Form
    {

        #region Private Members

        /// <summary>
        /// GetUserInfoCaller
        /// </summary>
        private GetUserInfoCaller _apiCaller = new GetUserInfoCaller();

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GetUserInfoForm()
        {
            InitializeComponent();

            GetUserInfoCaller.MessageDel messageDel = new GetUserInfoCaller.MessageDel(ShowCustomMessageBox);
            GetUserInfoCaller.ShowResultDel showResultDel = new GetUserInfoCaller.ShowResultDel(DisplayResult);
            GetUserInfoCaller.EnabledControlDel enabledControlDel = new GetUserInfoCaller.EnabledControlDel(EnableDisableFormControls);

            _apiCaller.SetDelegate(messageDel, showResultDel, enabledControlDel);
        }

        #endregion

        #region Form event methods

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnExecute_Click(object sender, EventArgs e)
        
{
            // Clear Result
            ClearResult();

            if (!CheckValidationOfInputData())
            {
                return;
            }

            // Enable/Disable form control
            EnableDisableFormControls(false);

            // Get Input data
            GetAPIInputData(out GetUserInfoInputData inputData);

            // Call API
            _apiCaller.Execute(inputData);
        }

        /// <summary>
        /// Main Menu button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.ShowDialog();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// CheckValidationOfInputData
        /// </summary>
        /// <returns></returns>
        private bool CheckValidationOfInputData()
        {
            try
            {
                // Check LoginID
                if (string.IsNullOrEmpty(_tbLoginID.Text) || string.IsNullOrWhiteSpace(_tbLoginID.Text))
                {
                    _tbLoginID.Focus();
                    return false;
                }

                // Check Password
                if (string.IsNullOrEmpty(_tbPassword.Text) || string.IsNullOrWhiteSpace(_tbPassword.Text))
                {
                    _tbPassword.Focus();
                    return false;
                }

                // Check Input Start Index
                if (string.IsNullOrEmpty(_tbUserID.Text) && string.IsNullOrWhiteSpace(_tbUserID.Text))
                {
                    _tbUserID.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex.Message);
                throw new EmployeeManagementAPIToolException(Resources.MSG_UNEXPECTED_ERROR);
            }
        }

        /// <summary>
        /// EnableDisableFormControls
        /// </summary>
        /// <param name="isEnable"></param>
        private void EnableDisableFormControls(bool isEnable)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => EnableDisableFormControls(isEnable)));
                return;
            }

            // Disable AuthenticationInfo input
            _tbLoginID.Enabled = isEnable;
            _lbPassword.Enabled = isEnable;

            // Disable UserID input
            _tbUserID.Enabled = isEnable;

            // Disable button
            _btnExecute.Enabled = isEnable;
        }

        /// <summary>
        /// show center message box
        /// </summary>
        /// <param name="message">message string</param>
        /// <param name="msgType">message type</param>
        /// <returns></returns>
        private DialogResult ShowCustomMessageBox(string message, MessageBoxType msgType)
        {
            if (InvokeRequired)
            {
                return (DialogResult)this.Invoke(new Func<DialogResult>(() => ShowCustomMessageBox(message, msgType)));
            }

            try
            {
                CenterDialogBox centerDlg = new CenterDialogBox();
                centerDlg.MoveDialogToCenter(this);
                DialogResult dlgResult = CustomMessageBox.ShowMessageBox(message, msgType);

                return dlgResult;
            }
            catch (EmployeeManagementAPIToolException ex)
            {
                ShowCustomMessageBox(ex.Message, MessageBoxType.Error);
                return DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex.Message, ex);
                ShowCustomMessageBox("Unexpected error occur", MessageBoxType.Error);
                return DialogResult.Cancel;
            }
        }

        /// <summary>
        /// GetAPIInputData
        /// </summary>
        /// <param name="inputData"></param>
        private void GetAPIInputData(out GetUserInfoInputData inputData)
        {
            inputData = new GetUserInfoInputData();

            // Get Auth Info
            inputData.AuthenticationInfo = new EmployeeManagementAPIUIClient.AuthenticationInfo()
            {
                LoginID = _tbLoginID.Text,
                Password = _tbPassword.Text
            };

            inputData.UserID = _tbUserID.Text;
        }

        /// <summary>
        /// DisplayResult
        /// </summary>
        /// <param name="userDetailInfo"></param>
        private void DisplayResult(EmployeeManagementAPIUIClient.UserDetailInfo userDetailInfo)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => DisplayResult(userDetailInfo)));
                return;
            }

            try
            {
                if (userDetailInfo == null)
                {
                    return;
                }

                _tbResultUserID.Text = userDetailInfo.UserID;
                _tbUserName.Text = userDetailInfo.UserName;
                _tbDepartment.Text = userDetailInfo.DepartmentName;
                _tbGender.Text = Enum.GetName(typeof(enumGender), userDetailInfo.Gender);
                _tbDateOfBirth.Text = userDetailInfo.DateOfBirth;
                _tbAddress.Text = userDetailInfo.Address;
                _tbEmail.Text = userDetailInfo.Email;
                _tbPhoneNo.Text = userDetailInfo.PhoneNo;
                _tbJobStartDate.Text = userDetailInfo.JobStartDate;
            }
            catch(Exception ex)
            {
                Logger.Error(this, ex.Message);
                ShowCustomMessageBox(Resources.MSG_UNEXPECTED_ERROR, MessageBoxType.Error);
            }
        }

        /// <summary>
        /// Clear result
        /// </summary>
        private void ClearResult()
        {
            _tbResultUserID.Clear();
            _tbUserName.Clear();
            _tbDepartment.Clear();
            _tbGender.Clear();
            _tbDateOfBirth.Clear();
            _tbAddress.Clear();
            _tbEmail.Clear();
            _tbPhoneNo.Clear();
            _tbJobStartDate.Clear();
        }

        #endregion
    }
}
