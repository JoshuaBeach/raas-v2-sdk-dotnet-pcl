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
    public class FundControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static FundController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Fund;
            applyConfiguration();
        }

        /// <summary>
        /// Tests retrieving deposit information 
        /// </summary>
        [Test]
        public async Task TestTestGetDeposit() 
        {
            // Parameters for the API call
            string depositId = "RAD-180426-5407";

            // Perform API call
            Raas.Models.GetDepositResponseModel result = null;

            try
            {
                result = await controller.GetDepositAsync(depositId);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"referenceDepositID\": \"RAD-180426-5407\",\n  \"amount\": 1.25,\n  \"amountCharged\": 1.29,\n  \"feePercent\": 3.5,\n  \"createdDate\": \"2018-04-26T18:56:28.28Z\",\n  \"status\": \"SUCCESS\",\n  \"accountNumber\": \"A32386768\"\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests adding funds to an account 
        /// </summary>
        [Test]
        public async Task TestTestAddFunds() 
        {
            // Parameters for the API call
            Raas.Models.DepositRequestModel body = APIHelper.JsonDeserialize<Raas.Models.DepositRequestModel>("{   \"accountIdentifier\": \"sdkautotest5\",   \"amount\": 1.25,   \"creditCardToken\": \"56ac1a30-6ba2-4047-9b8c-70f97a5502c5\",   \"customerIdentifier\": \"sdkautotest4\" }");

            // Perform API call
            Raas.Models.DepositResponseModel result = null;

            try
            {
                result = await controller.AddFundsAsync(body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"referenceDepositID\": \"RAD-180426-5407\",\n  \"amount\": 1.25,\n  \"amountCharged\": 1.29,\n  \"feePercent\": 3.5,\n  \"createdDate\": \"2018-04-26T18:56:28.28Z\",\n  \"status\": \"SUCCESS\",\n  \"accountNumber\": \"A32386768\"\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests retrieving all credit cards for a platform 
        /// </summary>
        [Test]
        public async Task TestTestGetCreditCards() 
        {

            // Perform API call
            List<Raas.Models.CreditCardModel> result = null;

            try
            {
                result = await controller.GetCreditCardsAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsArrayOfJsonObjectsProperSubsetOf(
                    "[\n  {\n    \"customerIdentifier\": \"sdkautotest4\",\n    \"accountIdentifier\": \"sdkautotest5\",\n    \"token\": \"56ac1a30-6ba2-4047-9b8c-70f97a5502c5\",\n    \"label\": \"SDK Auto Testing Card 1\",\n    \"lastFourDigits\": \"4444\",\n    \"expirationDate\": \"2020-01\",\n    \"status\": \"ACTIVE\",\n    \"createdDate\": \"2018-04-26T18:52:17.575Z\",\n    \"activationDate\": \"2018-04-26T18:52:17.575Z\",\n    \"contactInformation\": [\n      {\n        \"fullName\": \"Test User\",\n        \"emailAddress\": \"test@example.com\"\n      },\n      {\n        \"fullName\": \"Test Man Two\",\n        \"emailAddress\": \"test2@example.com\"\n      }\n    ],\n    \"accountNumber\": \"A32386768\"\n  }\n]", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Tests retrieving a single credit card 
        /// </summary>
        [Test]
        public async Task TestTestGetCreditCard() 
        {
            // Parameters for the API call
            string token = "56ac1a30-6ba2-4047-9b8c-70f97a5502c5";

            // Perform API call
            Raas.Models.CreditCardModel result = null;

            try
            {
                result = await controller.GetCreditCardAsync(token);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"customerIdentifier\": \"sdkautotest4\",\n  \"accountIdentifier\": \"sdkautotest5\",\n  \"token\": \"56ac1a30-6ba2-4047-9b8c-70f97a5502c5\",\n  \"label\": \"SDK Auto Testing Card 1\",\n  \"lastFourDigits\": \"4444\",\n  \"expirationDate\": \"2020-01\",\n  \"status\": \"ACTIVE\",\n  \"createdDate\": \"2018-04-26T18:52:17.575Z\",\n  \"activationDate\": \"2018-04-26T18:52:17.575Z\",\n  \"contactInformation\": [\n    {\n      \"fullName\": \"Test User\",\n      \"emailAddress\": \"test@example.com\"\n    },\n    {\n      \"fullName\": \"Test Man Two\",\n      \"emailAddress\": \"test2@example.com\"\n    }\n  ],\n  \"accountNumber\": \"A32386768\"\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    true, true, false),
                    "Response body should have matching keys");
        }

    }
}