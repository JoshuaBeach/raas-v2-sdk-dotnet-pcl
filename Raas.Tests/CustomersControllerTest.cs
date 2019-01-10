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
    public class CustomersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static CustomersController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Customers;
            applyConfiguration();
        }

        /// <summary>
        /// Tests retrieving all customers 
        /// </summary>
        [Test]
        public async Task TestGetAllCustomers() 
        {

            // Perform API call
            List<Raas.Models.CustomerModel> result = null;

            try
            {
                result = await controller.GetAllCustomersAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsArrayOfJsonObjectsProperSubsetOf(
                    "[\n  {\n    \"customerIdentifier\": \"sdkautotest1\",\n    \"displayName\": \"SDK Auto Testing 1\",\n    \"status\": \"active\",\n    \"createdAt\": \"2018-04-26T18:13:12.874Z\",\n    \"accounts\": [\n      {\n        \"accountIdentifier\": \"sdkautotest3\",\n        \"accountNumber\": \"A01335766\",\n        \"displayName\": \"SDK Auto Testing 3\",\n        \"createdAt\": \"2018-04-26T18:16:51.652Z\",\n        \"status\": \"ACTIVE\"\n      },\n      {\n        \"accountIdentifier\": \"sdkautotest2\",\n        \"accountNumber\": \"A11720237\",\n        \"displayName\": \"SDK Auto Testing 2\",\n        \"createdAt\": \"2018-04-26T18:13:45.196Z\",\n        \"status\": \"ACTIVE\"\n      }\n    ]\n  }\n]", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests retrieving a single customer 
        /// </summary>
        [Test]
        public async Task TestGetCustomer() 
        {
            // Parameters for the API call
            string customerIdentifier = "sdkautotest1";

            // Perform API call
            Raas.Models.CustomerModel result = null;

            try
            {
                result = await controller.GetCustomerAsync(customerIdentifier);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"customerIdentifier\": \"sdkautotest1\",\n  \"displayName\": \"SDK Auto Testing 1\",\n  \"status\": \"active\",\n  \"createdAt\": \"2018-04-26T18:13:12.874Z\",\n  \"accounts\": [\n    {\n      \"accountIdentifier\": \"sdkautotest3\",\n      \"accountNumber\": \"A01335766\",\n      \"displayName\": \"SDK Auto Testing 3\",\n      \"createdAt\": \"2018-04-26T18:16:51.652Z\",\n      \"status\": \"ACTIVE\"\n    },\n    {\n      \"accountIdentifier\": \"sdkautotest2\",\n      \"accountNumber\": \"A11720237\",\n      \"displayName\": \"SDK Auto Testing 2\",\n      \"createdAt\": \"2018-04-26T18:13:45.196Z\",\n      \"status\": \"ACTIVE\"\n    }\n  ]\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

    }
}