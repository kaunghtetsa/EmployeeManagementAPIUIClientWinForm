﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Model.Common
{
	public class UserInfoDetail
	{
		/// <summary>
		/// User ID
		/// </summary>
		public string UserID { get; set; }

		/// <summary>
		/// User Name
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// Department Name
		/// </summary>
		public string DepartmentName { get; set; }

		/// <summary>
		/// Gender
		/// </summary>
		public short Gender { get; set; }

		/// <summary>
		/// Gender
		/// </summary>
		public short? MaritalStatus { get; set; }

		/// <summary>
		/// Date of Birth
		/// </summary>
		public string DateOfBirth { get; set; }

		/// <summary>
		/// Address
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Email
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Phone No
		/// </summary>
		public string PhoneNo { get; set; }

		/// <summary>
		/// Job Start Date
		/// </summary>
		public string JobStartDate { get; set; }

		/// <summary>
		/// Job Start Date
		/// </summary>
		public string JobResignDate { get; set; }
	}
}
