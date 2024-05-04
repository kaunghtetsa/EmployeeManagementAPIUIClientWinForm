using System;
using System.Windows.Forms;

using ASM.EmployeeManagementAPIUIClientWinForm.Util;
using ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfo;
using ASM.EmployeeManagementAPIUIClientWinForm.Properties;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Mid
{
    /// <summary>
    /// Call GetUserInfo API
    /// </summary>
    public class GetUserInfoCaller : BaseProcessor
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
        public delegate void ShowResultDel(EmployeeManagementAPIUIClient.UserDetailInfo result);

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
        public void Execute(GetUserInfoInputData data)
        {
            try
            {
                Start(data);
            }
            catch (EmployeeManagementAPIToolException ex)
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
        /// Call GetUserInfo API
        /// </summary>
        /// <param name="param"></param>
        protected override void Process(object param)
        {
            GetUserInfoInputData objInput = null;
            try
            {
                objInput = (GetUserInfoInputData)param;

                CallGetUserInfoAPI(objInput.AuthenticationInfo, objInput.UserID);
            }
            catch (EmployeeManagementAPIToolException ex)
            {
                _objMsgDel(ex.Message, MessageBoxType.Error);
            }
            catch (Exception ex)
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
        /// CallGetUserInfoAPI
        /// </summary>
        /// <param name="objAuthInfo"></param>
        /// <param name="userID"></param>
        private void CallGetUserInfoAPI(EmployeeManagementAPIUIClient.AuthenticationInfo objAuthInfo, string userID)
        {
            Logger.Info(this, string.Format("Call GetUserInfo API. LoginID = {0}", objAuthInfo.LoginID));

            EmployeeManagementAPIUIClient.EmployeeManagementWebAPIUIServiceClient objService = GetAPIUIServiceObject();
            EmployeeManagementAPIUIClient.ResGetUserInfo objResponse = objService.GetUserInfo(objAuthInfo, userID);
            objService.Close();

            Logger.Info(this, string.Format("Successfully called GetUserInfoAPI. ResultCode = {0}", objResponse.Result.ResultCode));

            if (objResponse.Result.ResultCode != Constants.ResultCodeAck)
            {
                _objMsgDel(objResponse.Result.ErrorDetail, MessageBoxType.Error);
                return;
            }

            _objResultDel(objResponse.UserDetailInfo);
        }

        #endregion
    }
}
