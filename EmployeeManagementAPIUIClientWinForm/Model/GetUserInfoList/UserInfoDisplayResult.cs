using System;
using System.Collections.Generic;

using ASM.EmployeeManagementAPIUIClientWinForm.Model.Common;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Model.GetUserInfoList
{

	public class UserInfoDisplayResult
	{
		/// <summary>
		/// User total count
		/// </summary>
		public int UserCount { get; set; }

		/// <summary>
		/// User info list
		/// </summary>
		public List<UserInfoDetail> UserInfoList { get; set; }
	}

}