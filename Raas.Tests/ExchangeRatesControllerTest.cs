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

    }
}