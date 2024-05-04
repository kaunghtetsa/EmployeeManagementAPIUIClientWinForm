using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using ASM.EmployeeManagementAPIUIClientWinForm.Util;

namespace ASM.EmployeeManagementAPIUIClientWinForm.App
{
    static class Program
    {
        #region dll

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                #region check duplicate running app

                Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);

                if (processes.Length > 1)
                {
                    SetForegroundWindow(processes[0].MainWindowHandle);
                    return;
                }

                #endregion

                // log4net configure
                SetLogConfig();
                Logger.Info(null, "Application is started.");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Presentation.GetUserInfoListForm());
            }
            catch (Exception ex)
            {
                Logger.Error(null, ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Log file set up
        /// </summary>
        private static void SetLogConfig()
        {
            try
            {
                string sExePath = System.Reflection.Assembly.GetEntryAssembly().Location;
                string sDirPath = Path.Combine(Path.GetDirectoryName(sExePath), Constants.LogConfigFilePath);

                Logger.Configure(sDirPath, false);
            }
            catch (Exception ex)
            {
                Logger.Error(null, ex);
            }
        }
    }
}
