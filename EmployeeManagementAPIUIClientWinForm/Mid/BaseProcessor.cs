using System;
using System.IO;
using System.ServiceModel;
using System.Threading;

using ASM.EmployeeManagementAPIUIClientWinForm.Util;
using ASM.EmployeeManagementAPIUIClientWinForm.Model.Common;

namespace ASM.EmployeeManagementAPIUIClientWinForm.Mid
{
    /// <summary>
    /// Base Processor
    /// </summary>
    public abstract class BaseProcessor
    {
        #region Constant

        /// <summary>
        /// Url config file path
        /// </summary>
        private const string ConfigFilePath = "Config/EndpointUrlConfig.xml";

        #endregion

        #region member variables

        private Thread _thread;
        private AutoResetEvent _wait = new AutoResetEvent(false);

        #endregion

        #region abstract method

        /// <summary>
        /// thread start method
        /// </summary>
        /// <param name="param">method parameter data required to process</param>
        protected abstract void Process(object param);

        /// <summary>
        /// get the processing thread name
        /// </summary>
        /// <returns>thread name</returns>
        protected abstract string GetThreadName();

        #endregion

        #region protected methods

        /// <summary>
        /// to start a thread
        /// </summary>
        /// <param name="data">data for thread start function</param>
        protected void Start(object data)
        {
            try
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Process);
                _thread = new Thread(threadStart);
                _thread.IsBackground = true;
                _thread.Name = GetThreadName();
                _thread.Priority = ThreadPriority.Normal;
                _thread.Start(data);
            }
            catch (Exception ex)
            {
                Logger.Error(this, ex);
                throw new EmployeeManagementAPIToolException(ex);
            }
        }

        /// <summary>
        /// Paused
        /// </summary>
        /// <param name="timeout"></param>
        protected void Paused(int timeout)
        {
            _wait.WaitOne(timeout);
        }

        #endregion

        #region public methods

        /// <summary>
        /// Return reference of APIUI
        /// </summary>
        /// <returns></returns>
        public static EmployeeManagementAPIUIClient.EmployeeManagementWebAPIUIServiceClient GetAPIUIServiceObject()
        {
            EmployeeManagementAPIUIClient.EmployeeManagementWebAPIUIServiceClient objService = null;
            try
            {
                // BasicHttpsBinding objBinding = new BasicHttpsBinding(); -- For https
                BasicHttpBinding objBinding = new BasicHttpBinding();

                objBinding.CloseTimeout = new TimeSpan(Constants.OpenCloseTimeoutHr,
                                              Constants.OpenCloseTimeoutMin, Constants.OpenCloseTimeoutSec);
                objBinding.OpenTimeout = new TimeSpan(Constants.OpenCloseTimeoutHr,
                                              Constants.OpenCloseTimeoutMin, Constants.OpenCloseTimeoutSec);

                objBinding.SendTimeout = new TimeSpan(Constants.SendReceiveTimeoutHr,
                                             Constants.SendReceiveTimeoutMin, Constants.SendReceiveTimeoutSec);
                objBinding.ReceiveTimeout = new TimeSpan(Constants.SendReceiveTimeoutHr,
                                             Constants.SendReceiveTimeoutMin, Constants.SendReceiveTimeoutSec);

                objBinding.MaxBufferSize = Constants.MaxBuffSize;
                objBinding.MaxReceivedMessageSize = Constants.MaxReceiveMsgSize;

                string endPointUrl = GetAPIEndPointUrl();
                EndpointAddress objEndpoint = new EndpointAddress(endPointUrl);
                objService = new EmployeeManagementAPIUIClient.EmployeeManagementWebAPIUIServiceClient(objBinding, objEndpoint);

                return objService;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// GetAPIEndPointUrl
        /// </summary>
        /// <returns></returns>
        private static string GetAPIEndPointUrl()
        {
            try
            {
                ConfigData configData = new ConfigData();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigFilePath);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ConfigData));
                using (StreamReader sr = new StreamReader(path, new System.Text.UTF8Encoding(false)))
                {
                    configData = (ConfigData)serializer.Deserialize(sr);
                    sr.Close();
                }

                return configData.APIUrl;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
