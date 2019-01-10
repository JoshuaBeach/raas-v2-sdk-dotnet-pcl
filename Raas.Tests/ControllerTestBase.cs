using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TangoCard.Raas;
using TangoCard.Raas.Helpers;
 
using TangoCard.Raas.Models;

namespace TangoCard.Raas
{
    [TestFixture]
    public class ControllerTestBase
    {
        //Test setup
        public const int REQUEST_TIMEOUT = 60;
        protected const double ASSERT_PRECISION = 0.1;
        public TimeSpan globalTimeout = TimeSpan.FromSeconds(REQUEST_TIMEOUT);

        protected HttpCallBackEventsHandler httpCallBackHandler = new HttpCallBackEventsHandler();

        [SetUp]
        public void SetUp()
        {
            //hooking events for catching http requests and responses
            GetClient().SharedHttpClient.OnBeforeHttpRequestEvent += httpCallBackHandler.OnBeforeHttpRequestEventHandler;
            GetClient().SharedHttpClient.OnAfterHttpResponseEvent += httpCallBackHandler.OnAfterHttpResponseEventHandler;
        }

        // Singleton instance of client for all test classes
        private static RaasClient client;
        private static object clientSync = new object();

        /// <summary>
        /// Get client instance
        /// </summary>
        /// <returns></returns>
        public static RaasClient GetClient()
        {
            lock (clientSync)
            {
                if (client == null)
                {
                    client = new RaasClient();
                }
                return client;
            }
        }

        /// <summary>
        /// Apply test configuration
        /// </summary>
        protected static void applyConfiguration()
        {
            // Set Configuration parameters for test execution
            Configuration.Environment = Configuration.Environments.SANDBOX;
        }
    }
}