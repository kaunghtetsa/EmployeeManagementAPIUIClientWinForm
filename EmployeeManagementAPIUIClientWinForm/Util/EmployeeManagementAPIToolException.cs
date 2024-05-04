using System;
using System.Runtime.Serialization;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Util
{
    /// <summary>
    /// User defined Exception Class
    /// </summary>
    public class EmployeeManagementAPIToolException : Exception
    {
        #region Public Methods

        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeManagementAPIToolException()
        {

        }

        /// <summary>
        /// One argument constructor
        /// </summary>
        /// <param name="ex"></param>
        public EmployeeManagementAPIToolException(Exception ex)
            : base(string.Empty, ex)
        {

        }

        /// <summary>
        /// One argument constructor
        /// </summary>
        /// <param name="message"></param>
        public EmployeeManagementAPIToolException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Two argument constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public EmployeeManagementAPIToolException(string message, Exception ex)
            : base(message, ex)
        {

        }

        /// <summary>
        /// Two argument constructor
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public EmployeeManagementAPIToolException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        #endregion
    }
}
