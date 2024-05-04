namespace ASM.EmployeeManagementAPIUIClientWinForm.Util
{
    /// <summary>
    /// User List Sort Key
    /// </summary>
    public enum eUserListSortKey
    {
        UserID,
        UserName,
        DepartmentName,
        Gender,
		MaritalStatus,
		DateOfBirth,
        Address,
        Email,
        PhoneNo,
        JobStartDate
    }

    /// <summary>
    /// message box type
    /// </summary>
    public enum MessageBoxType
    {
        None = 0, //invalid message
        Error = 1, //error message
        Confirm = 2, //confirm message
        Info = 3, //information message
    }
}
