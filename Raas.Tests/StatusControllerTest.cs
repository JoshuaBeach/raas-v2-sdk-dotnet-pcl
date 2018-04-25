/*
 * Raas.Tests
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
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
    public class StatusControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static StatusController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Status;
            applyConfiguration();
        }

        /// <summary>
        /// Tests if we can retrieve the system status 
        /// </summary>
        [Test]
        public async Task TestTestStatusIsOK() 
        {

            // Perform API call
            Raas.Models.SystemStatusResponseModel result = null;

            try
            {
                result = await controller.GetSystemStatusAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"status\" : \"UP\"\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}