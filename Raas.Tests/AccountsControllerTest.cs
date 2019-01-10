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
    public class AccountsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static AccountsController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Accounts;
            applyConfiguration();
        }

        /// <summary>
        /// Tests retrieving all accounts under a specific customer 
        /// </summary>
        [Test]
        public async Task TestGetAllCustomerAccounts() 
        {
            // Parameters for the API call
            string customerIdentifier = "sdkautotest1";

            // Perform API call
            List<Raas.Models.AccountSummaryModel> result = null;

            try
            {
                result = await controller.GetAccountsByCustomerAsync(customerIdentifier);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsArrayOfJsonObjectsProperSubsetOf(
                    "[\n  {\n    \"accountIdentifier\": \"sdkautotest3\",\n    \"accountNumber\": \"A01335766\",\n    \"displayName\": \"SDK Auto Testing 3\",\n    \"createdAt\": \"2018-04-26T18:16:51.652Z\",\n    \"status\": \"ACTIVE\"\n  },\n  {\n    \"accountIdentifier\": \"sdkautotest2\",\n    \"accountNumber\": \"A11720237\",\n    \"displayName\": \"SDK Auto Testing 2\",\n    \"createdAt\": \"2018-04-26T18:13:45.196Z\",\n    \"status\": \"ACTIVE\"\n  }\n]", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests retrieving all accounts 
        /// </summary>
        [Test]
        public async Task TestGetAllAccounts() 
        {

            // Perform API call
            List<Raas.Models.AccountModel> result = null;

            try
            {
                result = await controller.GetAllAccountsAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsArrayOfJsonObjectsProperSubsetOf(
                    "[\n	{\n		\"accountIdentifier\": \"sdkautotest2\",\n		\"accountNumber\": \"A11720237\",\n		\"displayName\": \"SDK Auto Testing 2\",\n		\"currencyCode\": \"USD\",\n                \"currentBalance\": 0,\n		\"createdAt\": \"2018-04-26T18:13:45.196Z\",\n		\"status\": \"ACTIVE\",\n		\"contactEmail\": \"test@example.com\"\n	}\n]", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests retrieving a single account 
        /// </summary>
        [Test]
        public async Task TestGetSingleAccount() 
        {
            // Parameters for the API call
            string accountIdentifier = "sdkautotest2";

            // Perform API call
            Raas.Models.AccountModel result = null;

            try
            {
                result = await controller.GetAccountAsync(accountIdentifier);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"accountIdentifier\": \"sdkautotest2\",\n  \"accountNumber\": \"A11720237\",\n  \"displayName\": \"SDK Auto Testing 2\",\n  \"currencyCode\": \"USD\",\n  \"currentBalance\": 0,\n  \"createdAt\": \"2018-04-26T18:13:45.196Z\",\n  \"status\": \"ACTIVE\",\n  \"contactEmail\": \"test@example.com\"\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

    }
}