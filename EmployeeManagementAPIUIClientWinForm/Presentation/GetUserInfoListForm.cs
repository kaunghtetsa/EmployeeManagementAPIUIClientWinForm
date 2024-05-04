using System;
using System.Windows.Forms;
using System.Collections.Generic;

using ASM.EmployeeManagementAPIUIClientWinForm.Mid;
using ASM.EmployeeManagementAPIUIClientWinForm.Util;
using ASM.EmployeeManagementAPIUIClientWinForm.Properties;
using ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfoList;
using static ASM.EmployeeManagementAPIUIClientWinForm.Util.Constants;
using ASM.EmployeeManagementAPIUIClientWinForm.Model.Common;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Presentation
{
    /// <summary>
    /// GetUserInfoList Form
    /// </summary>
    public partial class GetUserInfoListForm : Form
    {
        #region Private Members

        /// <summary>
        /// GetUserInfoListCaller
        /// </summary>
        private GetUserInfoListCaller _apiCaller = new GetUserInfoListCaller();

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GetUserInfoListForm()
        {
            InitializeComponent();

            GetUserInfoListCaller.MessageDel messageDel = new GetUserInfoListCaller.MessageDel(ShowCustomMessageBox);
            GetUserInfoListCaller.ShowResultDel showResultDel = new GetUserInfoListCaller.ShowResultDel(DisplayResult);
            GetUserInfoListCaller.EnabledControlDel enabledControlDel = new GetUserInfoListCaller.EnabledControlDel(EnableDisableFormControls);

            _apiCaller.SetDelegate(messageDel,showResultDel, enabledControlDel);
        }

        #endregion

        #region Form event methods

        /// <summary>
        /// Initialize on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetUserInfoListForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Fill Page Size combo box
                FillPageSizeComboBoxData();

                // Fill Page Sort Key combo box
                FillPagingSortKey();
				_cbSortKey.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnExecute_Click(object sender, EventArgs e)
        {
			_lvUserList.Items.Clear();
			_lvUserList.Refresh();

            if (!CheckValidationOfInputData())
            {
                return;
            }

            // Enable/Disable form control
            EnableDisableFormControls(false);

            // Get Input Data
            GetAPIInputData(out GetUserInfoListInputData inputData);

            // Call API
            _apiCaller.Execute(inputData);
        }

		/// <summary>
		/// Main Menu button clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _btnMain_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.FormClosed += (s, args) => this.Close();
			mainForm.ShowDialog();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// FillPageSizeComboBoxData
		/// </summary>
		private void FillPageSizeComboBoxData()
        {
            try
            {
                List<int> lstPageSize = new List<int>() { 10, 20, 50, 100, 200,500,1000};
                _cbPageSize.DataSource = lstPageSize;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// FillPagingSortKey
        /// </summary>
        private void FillPagingSortKey()
        {
            try
            {
                List<UserSortKey> lstSortKey = GetUserSortKeys();
                lstSortKey.Insert(0, new UserSortKey() { SortKey = -1, SortKeyName = string.Empty });
                _cbSortKey.DataSource = lstSortKey;
                _cbSortKey.DisplayMember = nameof(UserSortKey.SortKeyName);
                _cbSortKey.ValueMember = nameof(UserSortKey.SortKey);
                _cbSortKey.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetUserSortKeys
        /// </summary>
        /// <returns></returns>
        private List<UserSortKey> GetUserSortKeys()
        {
            List<UserSortKey> lstSortKey = new List<UserSortKey>();
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.UserID, SortKeyName = nameof(eUserListSortKey.UserID) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.UserName, SortKeyName = nameof(eUserListSortKey.UserName) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.DepartmentName, SortKeyName = nameof(eUserListSortKey.DepartmentName) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.Gender, SortKeyName = nameof(eUserListSortKey.Gender) });
			lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.MaritalStatus, SortKeyName = nameof(eUserListSortKey.MaritalStatus) });
			lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.DateOfBirth, SortKeyName = nameof(eUserListSortKey.DateOfBirth) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.Address, SortKeyName = nameof(eUserListSortKey.Address) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.Email, SortKeyName = nameof(eUserListSortKey.Email) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.PhoneNo, SortKeyName = nameof(eUserListSortKey.PhoneNo) });
            lstSortKey.Add(new UserSortKey() { SortKey = (int)eUserListSortKey.JobStartDate, SortKeyName = nameof(eUserListSortKey.JobStartDate) });

            return lstSortKey;
        }

        /// <summary>
        ///  CheckValidationOfInputData
        /// </summary>
        /// <returns></returns>
        private bool CheckValidationOfInputData()
        {
            try
            {
                // Check LoginID
                if (string.IsNullOrEmpty(_tbxLoginID.Text) || string.IsNullOrWhiteSpace(_tbxLoginID.Text))
                {
                    _tbxLoginID.Focus();
                    return false;
                }

                // Check Password
                if (string.IsNullOrEmpty(_tbxPassword.Text) || string.IsNullOrWhiteSpace(_tbxPassword.Text))
                {
                    _tbxPassword.Focus();
                    return false;
                }

                // Check Input Start Index
                if(!string.IsNullOrEmpty(_tbxStartIndex.Text) && !string.IsNullOrWhiteSpace(_tbxStartIndex.Text))
                {
                    if(!int.TryParse(_tbxStartIndex.Text, out int result))
                    {
                        ShowCustomMessageBox(Resources.MSG_Invalid_Start_Index, MessageBoxType.Error);
                        return false;
                    }
                }
                else
                {
                    _tbxStartIndex.Focus();
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                Logger.Error(this, ex.Message);
                throw new EmployeeManagementAPIToolException(Resources.MSG_UNEXPECTED_ERROR);
            }
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
                ShowCustomMessageBox("Unexpected error occure", MessageBoxType.Error);
                return DialogResult.Cancel;
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
            _tbxLoginID.Enabled = isEnable;
            _lblPassword.Enabled = isEnable;

            // Disable Paging input
            _cbPageSize.Enabled = isEnable;
            _tbxStartIndex.Enabled = isEnable;
            _rdoASC.Enabled = isEnable;
            _rdoDesc.Enabled = isEnable;
            _cbSortKey.Enabled = isEnable;

            // Disable Filter input
            _tbxUserID.Enabled = isEnable;
            _tbxEmail.Enabled = isEnable;

            // Disable button
            _btnExecute.Enabled = isEnable;
        }

        /// <summary>
        /// GetAPIInputData
        /// </summary>
        /// <param name="inputData"></param>
        private void GetAPIInputData(out GetUserInfoListInputData inputData)
        {
            inputData = new GetUserInfoListInputData();

            // Get Auth Info
            inputData.AuthenticationInfo = new EmployeeManagementAPIUIClient.AuthenticationInfo()
            {
                LoginID = _tbxLoginID.Text,
                Password = _tbxPassword.Text
            };

            // Get paging Info
            inputData.Paging = new EmployeeManagementAPIUIClient.Paging()
            {
				Num = (int)_cbPageSize.SelectedValue,
				StartIndex = int.Parse(_tbxStartIndex.Text),
                SortKey = GetSortKey(),
                SortOrder = GetSortOrder()
            };

            // Get Filter Info
            inputData.UserFilterInfo = new EmployeeManagementAPIUIClient.UserFilterInfo()
            {
				IsExactMatchSearch = (_cbExactMatch.Checked) ? true : false,
			    UserID = _tbxUserID.Text,
                Email = _tbxEmail.Text
            };
        }

        /// <summary>
        /// GetSortKey
        /// </summary>
        /// <returns></returns>
        private int? GetSortKey()
        {
            int? sortkey = null;

            if((int)_cbSortKey.SelectedValue != -1)
            {
                sortkey = (int)_cbSortKey.SelectedValue;
            }

            return sortkey;
        }

        /// <summary>
        /// GetSortOrder
        /// </summary>
        /// <returns></returns>
        private int? GetSortOrder()
        {
            int? sortOrder = null;

            if (_rdoASC.Checked)
            {
                sortOrder = (int)enumSortOrder.ASC;
            }

            if (_rdoDesc.Checked)
            {
                sortOrder = (int)enumSortOrder.DESC;
            }

            return sortOrder;
        }

        /// <summary>
        /// DisplayResultInListView
        /// </summary>
        /// <param name="userInfo"></param>
        private void DisplayResult(UserInfoDisplayResult displayResult)
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => DisplayResult(displayResult)));
                return;
            }

            try
            {
				if (displayResult == null)
				{
					return;
				}

				_lblRecordCount.Text = displayResult.UserCount.ToString();

				foreach (UserInfoDetail userDetail in displayResult.UserInfoList)
				{
					string gender = Enum.GetName(typeof(enumGender), userDetail.Gender);
					string maritalStatus = userDetail.MaritalStatus == null ? string.Empty : Enum.GetName(typeof(enumMaritalStatus), userDetail.MaritalStatus);

					_lvUserList.Items.Add(new ListViewItem(new string[] { userDetail.UserID, userDetail.UserName, userDetail.DepartmentName, gender
						, maritalStatus, userDetail.DateOfBirth, userDetail.Address, userDetail.Email, userDetail.PhoneNo, userDetail.JobStartDate}));
				}
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex.Message);
                ShowCustomMessageBox("Unexpected error occur.", MessageBoxType.Error);
            }
        }

		#endregion

		
	}
}
