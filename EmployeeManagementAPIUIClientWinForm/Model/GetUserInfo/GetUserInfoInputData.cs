namespace ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfo
{
    /// <summary>
    /// Request Params of GetUserInfo API
    /// </summary>
    public class GetUserInfoInputData
    {
        #region Properties

        /// <summary>
        /// Authentication Information
        /// </summary>
        public EmployeeManagementAPIUIClient.AuthenticationInfo AuthenticationInfo { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }

        #endregion
    }
}
