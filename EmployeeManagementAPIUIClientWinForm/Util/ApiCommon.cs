using System;
using System.Net;
using System.ServiceModel;
using System.Xml.Linq;

using ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Util
{
	public class ApiCommon
	{
		#region Constants
		public static string Name { get { return "EmployeeAPIAccess"; } }

		// openTimeout and closeTimeout
		private const int OC_TIME_OUT_HR = 0;
		private const int OC_TIME_OUT_MIN = 0;
		private const int OC_TIME_OUT_SEC = 10;

		// receiceTimeout and sendTimeout
		private const int SR_TIME_OUT_HR = 0;
		private const int SR_TIME_OUT_MIN = 0;
		private const int SR_TIME_OUT_SEC = 30;

		// maxBufferSize
		private const int MAX_BUFF_SIZE = int.MaxValue;

		// maxReceiveMessageSize
		private const int MAX_RECEIVE_MSG_SIZE = int.MaxValue;

		// サービス参照を呼ぶ再に失敗した場合。
		protected const int SERVICE_RETRYCNT = 3;
		protected const int SERVICE_RETRY_INTERVAL = 1000; // millisec (1 sec)

		private const string TAG_API_URL = "APIUrl";

		/// <summary>
		/// API認証ACK・NACK
		/// </summary>
		public const string RESULT_INFO_ACK = "1";
		public const string RESULT_INFO_NACK = "2";

		/// <summary>
		/// URI format
		/// </summary>
		private const string FORMAT_URI = "{0}:{1}";
		#endregion

		#region Static Members
		/// <summary>
		/// Basic Https binding
		/// </summary>
		protected static BasicHttpsBinding _objhttpsBinding = null;

		/// <summary>
		/// Basic Http binding
		/// </summary>
		protected static BasicHttpBinding _objhttpBinding = null;

		protected static EndpointAddress _objEndpoint = null;

		#endregion

		#region Properties
		/// <summary>
		/// Token
		/// </summary>
		public static string Token { get; private set; }

		#endregion

		#region Public
		/// <summary>
		/// Initialize
		/// </summary>
		/// <param name="sFilePath"></param>
		public void Initialize(string sFilePath)
		{
			InitializeService(sFilePath);
		}

		/// <summary>
		/// Initialize service
		/// </summary>
		/// <param name="sFilePath">Setting file path</param>
		public static void InitializeService(string sFilePath)
		{
			Logger.Info(null, string.Format("filepath={0}", sFilePath));
			try
			{
				if (string.IsNullOrEmpty(sFilePath))
				{
					throw new System.Exception("config do not have.");
				}

				// read root tag 
				XElement objRoot = XElement.Load(sFilePath);

				string apiUrl = GetManageURL(objRoot);

				CreateService(apiUrl);

				Logger.Debug(null, string.Format("URL={0}", apiUrl));
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Initialization method for service
		/// </summary>
		/// <param name="url">API Url</param>
		/// <param name="token">token</param>
		public static void InitializeApiService(string url)
		{
			if (string.IsNullOrEmpty(url))
			{
				Logger.Warn(null, "URL can not be empty.");
				throw new ArgumentNullException(nameof(url));
			}

			CreateService(url);
		}

		/// <summary>
		/// CreateService
		/// </summary>
		/// <returns></returns>
		public static EmployeeManagementWebAPIUIServiceClient CreateService()
		{
			EmployeeManagementWebAPIUIServiceClient client = null;

			if (_objhttpBinding != null)
			{
				client = new EmployeeManagementWebAPIUIServiceClient(_objhttpBinding, _objEndpoint);
			}
			else
			{
				client = new EmployeeManagementWebAPIUIServiceClient(_objhttpsBinding, _objEndpoint);
			}

			return client;
		}

		#endregion

		#region Private

		/// <summary>
		/// CreateService
		/// </summary>
		/// <param name="url"></param>
		private static void CreateService(string url)
		{
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
				ServicePointManager.Expect100Continue = false;

				Uri uri = new Uri(url);

				if (uri.Scheme.Equals("https"))
				{
					CreateHttpsBindingObject();
				}
				else
				{
					CreateHttpBindingObject();
				}

				_objEndpoint = new EndpointAddress(url);
			}
			catch (System.Exception ex)
			{
				Logger.Error(null, string.Format("can not get api service ({0})", url), ex);
				throw;
			}
		}

		/// <summary>
		/// GetManageURL
		/// </summary>
		/// <param name="objRoot"></param>
		/// <returns></returns>
		private static string GetManageURL(XElement objRoot)
		{
			string sManageURL = string.Empty;
			try
			{
				sManageURL = objRoot.Element(TAG_API_URL).Value;
				if (string.IsNullOrEmpty(sManageURL))
				{
					throw new System.Exception("API Url tag is empty.");
				}
			}
			catch (System.Exception ex)
			{
				Logger.Error(null, ex.Message);
			}

			return sManageURL;
		}

		/// <summary>
		/// Create Https binding object
		/// </summary>
		private static void CreateHttpsBindingObject()
		{
			_objhttpsBinding = new BasicHttpsBinding();
			_objhttpsBinding.Security.Mode = BasicHttpsSecurityMode.Transport;
			_objhttpsBinding.CloseTimeout = new TimeSpan(OC_TIME_OUT_HR, OC_TIME_OUT_MIN, OC_TIME_OUT_SEC);
			_objhttpsBinding.OpenTimeout = new TimeSpan(OC_TIME_OUT_HR, OC_TIME_OUT_MIN, OC_TIME_OUT_SEC);

			_objhttpsBinding.SendTimeout = new TimeSpan(SR_TIME_OUT_HR, SR_TIME_OUT_MIN, SR_TIME_OUT_SEC);
			_objhttpsBinding.ReceiveTimeout = new TimeSpan(SR_TIME_OUT_HR, SR_TIME_OUT_MIN, SR_TIME_OUT_SEC);

			_objhttpsBinding.MaxBufferSize = MAX_BUFF_SIZE;
			_objhttpsBinding.MaxReceivedMessageSize = MAX_RECEIVE_MSG_SIZE;

			_objhttpsBinding.UseDefaultWebProxy = false;
		}

		/// <summary>
		/// Create Http binding object
		/// </summary>
		private static void CreateHttpBindingObject()
		{
			_objhttpBinding = new BasicHttpBinding();
			_objhttpBinding.CloseTimeout = new TimeSpan(OC_TIME_OUT_HR, OC_TIME_OUT_MIN, OC_TIME_OUT_SEC);
			_objhttpBinding.OpenTimeout = new TimeSpan(OC_TIME_OUT_HR, OC_TIME_OUT_MIN, OC_TIME_OUT_SEC);

			_objhttpBinding.SendTimeout = new TimeSpan(SR_TIME_OUT_HR, SR_TIME_OUT_MIN, SR_TIME_OUT_SEC);
			_objhttpBinding.ReceiveTimeout = new TimeSpan(SR_TIME_OUT_HR, SR_TIME_OUT_MIN, SR_TIME_OUT_SEC);

			_objhttpBinding.MaxBufferSize = MAX_BUFF_SIZE;
			_objhttpBinding.MaxReceivedMessageSize = MAX_RECEIVE_MSG_SIZE;
			_objhttpBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;

			_objhttpBinding.UseDefaultWebProxy = false;
		}

		#endregion
	}
}
