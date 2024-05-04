using ASM.EmployeeManagementAPIUIClientWinForm.Model.Common;
using ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfoList;
using ASM.EmployeeManagementAPIUIClientWinForm.Properties;
using ASM.EmployeeManagementAPIUIClientWinForm.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Mid
{
	/// <summary>
	/// Call GetUserInfoList API
	/// </summary>
	public class GetUserInfoListCaller : BaseProcessor
    {
        #region delegate

        /// <summary>
        /// delegate to call messagebox show function 
        /// </summary>
        /// <param name="text">text to display on messagebox</param>
        /// <param name="type">type of message box</param>
        public delegate DialogResult MessageDel(string text, MessageBoxType type);

        /// <summary>
        /// delegate to show result on gridview
        /// </summary>
        /// <param name="result"></param>
        public delegate void ShowResultDel(UserInfoDisplayResult result);

		/// <summary>
		/// delegate to call enable control function
		/// </summary>
		/// <param name="flag"></param>
		public delegate void EnabledControlDel(bool flag);

		private MessageDel _objMsgDel = null;

		private ShowResultDel _objResultDel = null;

		private EnabledControlDel _objEnableControl = null;

		#endregion

		#region Public Methods

		/// <summary>
		/// Call GetUserInfoList API
		/// </summary>
		/// <param name="data"></param>
		public void Execute(GetUserInfoListInputData data)
        {
            try
            {
                Start(data);
            }
            catch(EmployeeManagementAPIToolException ex)
            {
                _objMsgDel(ex.Message, MessageBoxType.Error);
            }
        }

		/// <summary>
		/// To set the delegate object
		/// </summary>
		/// <param name="msgDel"></param>
		/// <param name="resultDel"></param>
		/// <param name="enableControlDel"></param>
		public void SetDelegate(MessageDel msgDel, ShowResultDel resultDel, EnabledControlDel enableControlDel)
		{
			_objMsgDel += msgDel;
			_objResultDel += resultDel;
			_objEnableControl += enableControlDel;
		}

		#endregion

		#region Override Methods

		/// <summary>
		/// Call GetUserInfoList API
		/// </summary>
		/// <param name="param"></param>
		protected override void Process(object param)
        {
            GetUserInfoListInputData objInput = null;
            try
            {
                objInput = (GetUserInfoListInputData)param;
				CallGetUserInfoListAPI(objInput.AuthenticationInfo, objInput.Paging, objInput.UserFilterInfo);
            }
            catch(EmployeeManagementAPIToolException ex)
            {
                _objMsgDel(ex.Message, MessageBoxType.Error);
            }
            catch(Exception ex)
            {
                Logger.Error(this, ex);
                _objMsgDel(Resources.MSG_UNEXPECTED_ERROR, MessageBoxType.Error);
            }
            finally
            {
                _objEnableControl(true);
            }
        }

        /// <summary>
        /// to get the thread name
        /// </summary>
        /// <returns></returns>
        protected override string GetThreadName()
        {
            return this.GetType().Name;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// CallGetUserInfoListAPI
        /// </summary>
        /// <param name="objAuthInfo"></param>
        /// <param name="objPaging"></param>
        /// <param name="objFilterInfo"></param>
        private void CallGetUserInfoListAPI(EmployeeManagementAPIUIClient.AuthenticationInfo objAuthInfo, EmployeeManagementAPIUIClient.Paging objPaging, 
            EmployeeManagementAPIUIClient.UserFilterInfo objFilterInfo)
        {
            Logger.Info(this, string.Format("Call GetUserInfoList API. LoginID = {0}", objAuthInfo.LoginID));

            EmployeeManagementAPIUIClient.EmployeeManagementWebAPIUIServiceClient objService = GetAPIUIServiceObject();
            EmployeeManagementAPIUIClient.ResGetUserInfoList objResponse = objService.GetUserInfoList(objAuthInfo, objPaging, objFilterInfo);
            objService.Close();

            Logger.Info(this, string.Format("Successfully called GetUserInfoListAPI. ResultCode = {0}", objResponse.Result.ResultCode));

            if (objResponse.Result.ResultCode != Constants.ResultCodeAck)
            {
                _objMsgDel(objResponse.Result.ErrorDetail, MessageBoxType.Error);
                return;
            }

			if (objResponse.UserDetailInfoList != null)
			{
				_objResultDel(ConvertData(objResponse));
			}
		}

		/// <summary>
		/// Convert data
		/// </summary>
		/// <param name="apiResObj"></param>
		/// <returns></returns>
		private UserInfoDisplayResult ConvertData(EmployeeManagementAPIUIClient.ResGetUserInfoList apiResObj)
		{
			UserInfoDisplayResult displayResult = new UserInfoDisplayResult();

			if (apiResObj.UserDetailInfoList != null)
			{
				displayResult.UserCount = apiResObj.UserDetailInfoList.Length;
			}

			if (apiResObj.UserDetailInfoList != null)
			{
				displayResult.UserInfoList = apiResObj.UserDetailInfoList.ToList().Select(U => new UserInfoDetail
				{
					UserID = U.UserID.ToString(),
					UserName = U.UserName,
					DepartmentName = U.DepartmentName,
					Gender = U.Gender,
					MaritalStatus = U.MaritalStatus,
					DateOfBirth = U.DateOfBirth.ToString(),
					Address = U.Address,
					Email = U.Email,
					PhoneNo = U.PhoneNo,
					JobStartDate = U.JobStartDate.ToString()
				}).ToList();
			}

			return displayResult;
		}
        #endregion
    }
}
