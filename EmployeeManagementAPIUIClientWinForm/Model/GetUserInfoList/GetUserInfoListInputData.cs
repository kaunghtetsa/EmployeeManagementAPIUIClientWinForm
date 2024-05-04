namespace ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfoList
{
    /// <summary>
    /// Request Params of GetUserInfoList API
    /// </summary>
    public class GetUserInfoListInputData
    {
        #region Properties

        /// <summary>
        /// Authentication Information
        /// </summary>
        public EmployeeManagementAPIUIClient.AuthenticationInfo AuthenticationInfo { get; set; }

        /// <summary>
        /// Paging
        /// </summary>
        public EmployeeManagementAPIUIClient.Paging Paging { get; set; }

        /// <summary>
        /// Filter Info
        /// </summary>
        public EmployeeManagementAPIUIClient.UserFilterInfo UserFilterInfo { get; set; }

        #endregion
    }
}
