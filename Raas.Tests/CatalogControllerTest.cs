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
    public class CatalogControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static CatalogController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Catalog;
            applyConfiguration();
        }

        /// <summary>
        /// Tests if we can successfully retrieve a platform's catalog 
        /// </summary>
        [Test]
        public async Task TestRetrieveCatalog() 
        {

            // Perform API call
            Raas.Models.CatalogModel result = null;

            try
            {
                result = await controller.GetCatalogAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\"catalogName\":\"TestCatalog\",\"brands\":[{\"brandKey\":\"B916708\",\"brandName\":\"Amazon.com\",\"disclaimer\":\"disclaimer\",\"description\":\"desc\",\"shortDescription\":\"short desc\",\"terms\":\"terms\",\"createdDate\":\"2016-06-17T16:52:24Z\",\"lastUpdateDate\":\"2017-10-23T22:18:51Z\",\"imageUrls\":{\"80w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b916708-80w-326ppi.png\",\"130w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b916708-130w-326ppi.png\",\"200w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b916708-200w-326ppi.png\",\"278w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b916708-278w-326ppi.png\",\"300w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b916708-300w-326ppi.png\",\"1200w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b916708-1200w-326ppi.png\"},\"status\":\"active\",\"items\":[{\"utid\":\"U666425\",\"rewardName\":\"Amazon.com Gift Card\",\"currencyCode\":\"USD\",\"status\":\"active\",\"valueType\":\"VARIABLE_VALUE\",\"rewardType\":\"gift card\",\"minValue\":0.01,\"maxValue\":2000,\"createdDate\":\"2016-06-17T17:38:45.294Z\",\"lastUpdateDate\":\"2017-12-15T01:27:49.607Z\",\"countries\":[\"US\"]}]},{\"brandKey\":\"B725361\",\"brandName\":\"AMC Theatres®\",\"disclaimer\":\"discl\",\"description\":\"desc\",\"shortDescription\":\"short desc\",\"terms\":\"terms\",\"createdDate\":\"2016-06-23T21:53:45Z\",\"lastUpdateDate\":\"2016-07-25T22:41:11Z\",\"imageUrls\":{\"80w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b725361-80w-326ppi.png\",\"130w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b725361-130w-326ppi.png\",\"200w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b725361-200w-326ppi.png\",\"278w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b725361-278w-326ppi.png\",\"300w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b725361-300w-326ppi.png\",\"1200w-326ppi\":\"https://d30s7yzk2az89n.cloudfront.net/images/brands/b725361-1200w-326ppi.png\"},\"status\":\"active\",\"items\":[{\"utid\":\"U154092\",\"rewardName\":\"AMC® Gift Card $10.00\",\"currencyCode\":\"USD\",\"status\":\"active\",\"valueType\":\"FIXED_VALUE\",\"rewardType\":\"gift card\",\"faceValue\":10,\"createdDate\":\"2016-07-27T02:54:30.142Z\",\"lastUpdateDate\":\"2016-09-21T20:59:01.874Z\",\"countries\":[\"US\"]},{\"utid\":\"U913336\",\"rewardName\":\"AMC® Gift Card $25.00\",\"currencyCode\":\"USD\",\"status\":\"active\",\"valueType\":\"FIXED_VALUE\",\"rewardType\":\"gift card\",\"faceValue\":25,\"createdDate\":\"2016-07-27T02:55:37.899Z\",\"lastUpdateDate\":\"2016-10-17T20:55:00.386Z\",\"countries\":[\"US\"]},{\"utid\":\"U652361\",\"rewardName\":\"AMC® Gift Card $50.00\",\"currencyCode\":\"USD\",\"status\":\"active\",\"valueType\":\"FIXED_VALUE\",\"rewardType\":\"gift card\",\"faceValue\":50,\"createdDate\":\"2016-07-27T02:56:53.391Z\",\"lastUpdateDate\":\"2016-09-21T20:59:16.283Z\",\"countries\":[\"US\"]}]}]}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}