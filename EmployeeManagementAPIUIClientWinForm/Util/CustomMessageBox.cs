using System;
using System.Windows.Forms;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Util
{
    public class CustomMessageBox
    {
        #region Constant

        // caption of confirm message box
        /// </summary>
        public const string Confirm = "Confirm";

        /// <summary>
        /// caption of error message box
        /// </summary>
        public const string Error = "Error";

        /// <summary>
        /// caption of info message box
        /// </summary>
        public const string Info = "Info";

        #endregion

        #region public method

        /// <summary>
        /// to show message box to user
        /// </summary>
        /// <param name="text">text to display</param>
        /// <param name="type">message box type</param>
        public static DialogResult ShowMessageBox(string text, MessageBoxType type)
        {
            try
            {
                MessageBoxButtons btnMsg = new MessageBoxButtons();
                MessageBoxIcon icMsg = new MessageBoxIcon();
                string caption = string.Empty;

                switch (type)
                {
                    case MessageBoxType.Error:
                        btnMsg = MessageBoxButtons.OK;
                        icMsg = MessageBoxIcon.Error;
                        caption = Error;
                        break;

                    case MessageBoxType.Confirm:
                        btnMsg = MessageBoxButtons.OKCancel;
                        icMsg = MessageBoxIcon.Information;
                        caption = Confirm;
                        break;

                    case MessageBoxType.Info:
                        btnMsg = MessageBoxButtons.OK;
                        icMsg = MessageBoxIcon.Information;
                        caption = Info;
                        break;

                    default:
                        throw new EmployeeManagementAPIToolException("Unexpected Error Occurred");
                }

                DialogResult result = MessageBox.Show(text, caption, btnMsg, icMsg);

                return result;
            }
            catch (Exception ex)
            {
                throw new EmployeeManagementAPIToolException("Unexpected error occurred", ex);
            }
        }

        #endregion
    }
}
