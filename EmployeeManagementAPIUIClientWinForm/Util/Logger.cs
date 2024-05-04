using log4net;
using log4net.Config;

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Util
{
    /// <summary>
    /// Log Management Class
    /// </summary>
    public class Logger
    {
        #region 定数

        /// <summary>
        /// LOGGER名
        /// </summary>
        private static string LOGGER_NAME = "EmployeeManagmentAPIAccessToolLog";

        #endregion

        #region private変数

        /// <summary>
        /// ログオブジェクト
        /// </summary>
        //private static ILog LOGGER = null;
        private static ILog LOGGER = LogManager.GetLogger(LOGGER_NAME);

        /// <summary>
        /// ASSERT表示するフラグ
        /// </summary>
        private static bool SHOW_ASSERT = false;

        /// <summary>
        /// 設定フラグ
        /// </summary>
        private static bool _isConfigure = false;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected Logger()
        {
        }

        #endregion

        #region Logger取得

        /// <summary>
        /// 初期したロガーを使う。
        /// </summary>
        public static ILog GetLogger()
        {
            return LOGGER;
        }

        #endregion

        #region 初期化
        /// <summary>
        /// 初期したロガーを使う。
        /// </summary>
        public static void Configure(ILog logger, bool ShowAssert)
        {
            if (_isConfigure == false)
            {
                LOGGER = logger;

                SHOW_ASSERT = ShowAssert;
                _isConfigure = true;
            }
        }

        /// <summary>
        /// ログXmlファイル設定をする。
        /// </summary>
        public static void Configure(string configFilePath, bool ShowAssert)
        {
            if (_isConfigure == false)
            {
                LOGGER = log4net.LogManager.GetLogger(LOGGER_NAME);
                XmlConfigurator.Configure(new FileInfo(configFilePath));

                SHOW_ASSERT = ShowAssert;
                _isConfigure = true;
            }
        }

        #endregion

        #region ログ出力
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objCaller"></param>
        /// <param name="sMessage"></param>
        /// <param name="sMethodName"></param>
        public static void Info(object objCaller, string sMessage, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, sMessage));
                return;
            }

            LOGGER.Info(GetMessage(objCaller, sMessage, sMethodName));
        }

        /// <summary>
        /// Warnレベルのメッソド
        /// </summary>
        /// <param name="sMessage">警告メッセージ</param>
        public static void Warn(object objCaller, string sMessage, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, sMessage, sMethodName));
                return;
            }

            LOGGER.Warn(GetMessage(objCaller, sMessage, sMethodName));
        }

        /// <summary>
        /// ログのディパグレベルメッソド
        /// </summary>
        /// <param name="message">ディパグメッセージ</param>
        public static void Debug(object objCaller, string message, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, message, sMethodName));
                return;
            }

            LOGGER.Debug(GetMessage(objCaller, message));
        }

        /// <summary>
        /// エラーレベルのメッソド
        /// </summary>
        /// <param name="objCaller"></param>
        /// <param name="message"></param>
        public static void Error(object objCaller, string message, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, message, sMethodName));
                return;
            }

            if (SHOW_ASSERT)
            {
                System.Diagnostics.Debug.Assert(false, GetMessage(objCaller, message, sMethodName));
            }

            LOGGER.Error(GetMessage(objCaller, message, sMethodName));
        }

        /// <summary>
        /// エラーレベルのメッソド
        /// </summary>
        /// <param name="objCaller"></param>
        /// <param name="e">例外</param>
        public static void Error(object objCaller, Exception e, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, null, sMethodName));
                return;
            }

            if (SHOW_ASSERT)
            {
                System.Diagnostics.Debug.Assert(false, GetMessage(objCaller, null, sMethodName));
            }

            LOGGER.Error(GetMessage(objCaller, null), e);
        }

        /// <summary>
        /// エラーレベルのメッソド
        /// </summary>
        /// <param name="objCaller"></param>
        /// <param name="message">メッセージ</param>
        /// <param name="e">例外</param>
        public static void Error(object objCaller, string message, Exception e, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, message, sMethodName));
                return;
            }

            if (SHOW_ASSERT)
            {
                System.Diagnostics.Debug.Assert(false, GetMessage(objCaller, message, sMethodName));
            }

            LOGGER.Error(GetMessage(objCaller, message), e);
        }

        /// <summary>
        /// Fatalレベルのメッソド
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="e">例外</param>
        public static void Fatal(object objCaller, Exception e, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, null, sMethodName));
                return;
            }

            System.Diagnostics.Debug.Assert(false, GetMessage(objCaller, null, sMethodName));

            LOGGER.Fatal(GetMessage(objCaller, null), e);
        }

        /// <summary>
        /// Fatalレベルのメッソド
        /// </summary>
        /// <param name="objCaller"></param>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public static void Fatal(object objCaller, string message, Exception e, [CallerMemberName] string sMethodName = "")
        {
            if (LOGGER == null)
            {
                System.Diagnostics.Debug.Assert(false);
                System.Diagnostics.Trace.WriteLine(GetMessage(objCaller, message, sMethodName));
                return;
            }

            System.Diagnostics.Debug.Assert(false, GetMessage(objCaller, message, sMethodName));

            LOGGER.Fatal(GetMessage(objCaller, message), e);
        }

        #endregion

        #region privateメッソド

        /// <summary>
        /// メッセージ作成
        /// </summary>
        /// <param name="objCaller"></param>
        /// <param name="message"></param>
        /// <param name="sMethodName"></param>
        /// <returns></returns>
        private static string GetMessage(object objCaller, string message, string sMethodName = "")
        {
            StringBuilder builder = new StringBuilder();

            if (objCaller != null)
            {
                builder.Append("[");
                builder.Append(objCaller.GetType().FullName);
                if (!string.IsNullOrEmpty(sMethodName))
                {
                    builder.Append(string.Format("::{0}", sMethodName));
                }
                builder.Append("] - ");
            }

            if (message != null)
            {
                builder.Append(message);
            }

            return builder.ToString();
        }

        #endregion
    }
}
