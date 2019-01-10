/*
 * Raas.Tests
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using TangoCard.Raas;
using TangoCard.Raas.Utilities; 
using TangoCard.Raas.Http.Client;
using TangoCard.Raas.Http.Response;
using TangoCard.Raas.Helpers;
using NUnit.Framework;
using TangoCard.Raas;
using TangoCard.Raas.Controllers;
using TangoCard.Raas.Exceptions;

namespace TangoCard.Raas
{
    [TestFixture]
    public class ExchangeRatesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ExchangeRatesController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().ExchangeRates;
            applyConfiguration();
        }

        /// <summary>
        /// Tests if we can successfully retrieve exchange rates 
        /// </summary>
        [Test]
        public async Task TestRetrieveExchangeRates() 
        {

            // Perform API call
            Raas.Models.ExchangeRateResponseModel result = null;

            try
            {
                result = await controller.GetExchangeRatesAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n	\"disclaimer\": \"Exchange rates are provided here for reference. They are updated at least once a day and may have changed by time of order.\",\n	\"exchangeRates\": [{\n		\"lastModifiedDate\": \"2018-04-19T13:00:14.291\",\n		\"rewardCurrency\": \"EUR\",\n		\"baseCurrency\": \"NZD\",\n		\"baseFx\": 0.59120\n	}, {\n		\"lastModifiedDate\": \"2018-04-19T13:00:14.291\",\n		\"rewardCurrency\": \"USD\",\n		\"baseCurrency\": \"NZD\",\n		\"baseFx\": 0.73130\n	}, {\n		\"lastModifiedDate\": \"2018-04-19T13:00:14.230\",\n		\"rewardCurrency\": \"INR\",\n		\"baseCurrency\": \"AUD\",\n		\"baseFx\": 51.29066\n	}]\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}