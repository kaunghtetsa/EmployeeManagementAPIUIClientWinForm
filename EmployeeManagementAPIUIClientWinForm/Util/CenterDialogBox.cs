using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Util
{
    /// <summary>
    /// Center the dialog box
    /// </summary>
    public class CenterDialogBox
    {
        #region delegate

        private delegate bool EnumThreadWndProc(IntPtr hWnd, IntPtr lp);

        #endregion

        #region dll for center dialog box

        [DllImport("user32.dll")]
        private static extern bool EnumThreadWindows(int tid, EnumThreadWndProc callback, IntPtr lp);

        [DllImport("kernel32.dll")]
        private static extern int GetCurrentThreadId();

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern void GetClassName(IntPtr hWnd, StringBuilder buffer, int buflen);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT rc);

        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool repaint);
        private struct RECT { public int Left; public int Top; public int Right; public int Bottom; }

        #endregion

        #region member variables

        private Form _owner;
        private int _count = 0;

        #endregion

        #region constant

        /// <summary>
        /// class name of dialog window
        /// </summary>
        public const string DialogClassName = "#32770";

        #endregion

        #region public methods

        /// <summary>
        /// to move the dialog box to owner center
        /// </summary>
        /// <param name="owner">current form that own the dialog box</param>
        public void MoveDialogToCenter(Form owner)
        {
            try
            {
                _owner = owner;
                _owner.BeginInvoke(new MethodInvoker(FindDialog));
            }
            catch (EmployeeManagementAPIToolException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex.Message, ex);
                throw new EmployeeManagementAPIToolException("Unexpected error occur");
            }
        }

        #endregion

        #region private methods

        /// <summary>
        /// to find the dialog box of owner
        /// </summary>
        private void FindDialog()
        {
            try
            {
                EnumThreadWndProc callback = new EnumThreadWndProc(CheckWindow);
                if (EnumThreadWindows(GetCurrentThreadId(), callback, IntPtr.Zero))
                {
                    if (++_count < 10)
                    {
                        _owner.BeginInvoke(new MethodInvoker(FindDialog));
                    }
                }
            }
            catch (EmployeeManagementAPIToolException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex.Message, ex);
                throw new EmployeeManagementAPIToolException("Unexcepted error occur", ex);
            }
        }

        /// <summary>
        /// move the window to the center of owner form
        /// </summary>
        /// <param name="hWnd">A handle to input dialog window</param>
        /// <param name="lp">The application-defined value given in EnumThreadWndProc</param>
        /// <returns>true if the input window is not a dialog box; otherwise: false</returns>
        private bool CheckWindow(IntPtr hWnd, IntPtr lp)
        {
            try
            {
                // Checks if <hWnd> is a dialog
                StringBuilder sb = new StringBuilder(260);

                GetClassName(hWnd, sb, sb.Capacity);
                if (!sb.ToString().Equals(DialogClassName))
                {
                    return true;
                }

                //get the rectangle of owner form 
                Rectangle frmRect = new Rectangle(_owner.Location, _owner.Size);
                RECT dlgRect;

                //get the rectangle of input dialog
                GetWindowRect(hWnd, out dlgRect);

                //change the position of specified dialog to owner center
                MoveWindow(hWnd,
                    frmRect.Left + (frmRect.Width - dlgRect.Right + dlgRect.Left) / 2,
                    frmRect.Top + (frmRect.Height - dlgRect.Bottom + dlgRect.Top) / 2,
                    dlgRect.Right - dlgRect.Left,
                    dlgRect.Bottom - dlgRect.Top, true);

                return false;
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex.Message, ex);
                throw new EmployeeManagementAPIToolException("Unexcepted error occur", ex);
            }
        }

        #endregion
    }
}
