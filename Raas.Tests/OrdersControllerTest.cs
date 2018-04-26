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
    public class OrdersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static OrdersController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Orders;
            applyConfiguration();
        }

        /// <summary>
        /// Tests retrieving a single order 
        /// </summary>
        [Test]
        public async Task TestTestGetOrder() 
        {
            // Parameters for the API call
            string referenceOrderID = "RA180426-1401-64";

            // Perform API call
            Raas.Models.OrderModel result = null;

            try
            {
                result = await controller.GetOrderAsync(referenceOrderID);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"referenceOrderID\": \"RA180426-1401-64\",\n  \"customerIdentifier\": \"sdkautotest4\",\n  \"accountIdentifier\": \"sdkautotest5\",\n  \"accountNumber\": \"A32386768\",\n  \"amountCharged\": {\n    \"value\": 1,\n    \"currencyCode\": \"USD\",\n    \"total\": 1\n  },\n  \"marginShare\": {\n    \"value\": 0,\n    \"currencyCode\": \"USD\"\n  },\n  \"denomination\": {\n    \"value\": 1,\n    \"currencyCode\": \"USD\"\n  },\n  \"utid\": \"U561593\",\n  \"rewardName\": \"Reward Link\",\n  \"sender\": {\n    \"firstName\": \"\",\n    \"lastName\": \"\",\n    \"email\": \"\"\n  },\n  \"recipient\": {\n    \"email\": \"\",\n    \"firstName\": \"\",\n    \"lastName\": \"\"\n  },\n  \"sendEmail\": false,\n  \"status\": \"COMPLETE\",\n  \"createdAt\": \"2018-04-26T20:08:59.624Z\",\n  \"reward\": {\n    \"credentials\": {\n      \"Redemption URL\": \"https://sandbox.rewardlink.io/r/1/ed0HtzSblNV6oFddNnnlf68eXzGQoREvcxwxu_Vi5Wk\"\n    },\n    \"credentialList\": [\n      {\n        \"label\": \"Redemption URL\",\n        \"value\": \"https://sandbox.rewardlink.io/r/1/ed0HtzSblNV6oFddNnnlf68eXzGQoREvcxwxu_Vi5Wk\",\n        \"type\": \"url\"\n      }\n    ],\n    \"redemptionInstructions\": \"<p>&bull; Click on the redemption link above to activate your Reward Link.<br />\\r\\n&bull; Next, you will be able to spend your balance on retail gift cards.</p>\\r\\n\\r\\n<p>If you don&#39;t want to spend your entire Reward Link value right away, save the email or URL and return via the redemption link - your value will be waiting to be spent. This allows you to store the balance to redeem at another time.</p>\\r\\n\"\n  }\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests placing an order with the minimum parameters required 
        /// </summary>
        [Test]
        public async Task TestTestPlaceOrderWithMinimumCriteria() 
        {
            // Parameters for the API call
            Raas.Models.CreateOrderRequestModel body = APIHelper.JsonDeserialize<Raas.Models.CreateOrderRequestModel>("{   \"accountIdentifier\": \"sdkautotest5\",   \"amount\": 1.00,   \"customerIdentifier\": \"sdkautotest4\",   \"sendEmail\": false,   \"utid\": \"U561593\" }");

            // Perform API call
            Raas.Models.OrderModel result = null;

            try
            {
                result = await controller.CreateOrderAsync(body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(201, httpCallBackHandler.Response.StatusCode,
                    "Status should be 201");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"referenceOrderID\": \"RA180426-1401-64\",\n  \"customerIdentifier\": \"sdkautotest4\",\n  \"accountIdentifier\": \"sdkautotest5\",\n  \"accountNumber\": \"A32386768\",\n  \"amountCharged\": {\n    \"value\": 1,\n    \"currencyCode\": \"USD\",\n    \"total\": 1\n  },\n  \"marginShare\": {\n    \"value\": 0,\n    \"currencyCode\": \"USD\"\n  },\n  \"denomination\": {\n    \"value\": 1,\n    \"currencyCode\": \"USD\"\n  },\n  \"utid\": \"U561593\",\n  \"rewardName\": \"Reward Link\",\n  \"sender\": {\n    \"firstName\": \"\",\n    \"lastName\": \"\",\n    \"email\": \"\"\n  },\n  \"recipient\": {\n    \"email\": \"\",\n    \"firstName\": \"\",\n    \"lastName\": \"\"\n  },\n  \"sendEmail\": false,\n  \"status\": \"COMPLETE\",\n  \"createdAt\": \"2018-04-26T20:08:59.624Z\",\n  \"reward\": {\n    \"credentials\": {\n      \"Redemption URL\": \"https://sandbox.rewardlink.io/r/1/ed0HtzSblNV6oFddNnnlf68eXzGQoREvcxwxu_Vi5Wk\"\n    },\n    \"credentialList\": [\n      {\n        \"label\": \"Redemption URL\",\n        \"value\": \"https://sandbox.rewardlink.io/r/1/ed0HtzSblNV6oFddNnnlf68eXzGQoREvcxwxu_Vi5Wk\",\n        \"type\": \"url\"\n      }\n    ],\n    \"redemptionInstructions\": \"<p>&bull; Click on the redemption link above to activate your Reward Link.<br />\\r\\n&bull; Next, you will be able to spend your balance on retail gift cards.</p>\\r\\n\\r\\n<p>If you don&#39;t want to spend your entire Reward Link value right away, save the email or URL and return via the redemption link - your value will be waiting to be spent. This allows you to store the balance to redeem at another time.</p>\\r\\n\"\n  }\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}