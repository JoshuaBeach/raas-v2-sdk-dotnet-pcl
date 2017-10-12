/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using TangoCard.Raas.Controllers;
using TangoCard.Raas.Http.Client;
using TangoCard.Raas.Utilities;

namespace TangoCard.Raas
{
    public partial class RaasClient
    {

        /// <summary>
        /// Singleton access to Orders controller
        /// </summary>
        public OrdersController Orders
        {
            get
            {
                return OrdersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Accounts controller
        /// </summary>
        public AccountsController Accounts
        {
            get
            {
                return AccountsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Catalog controller
        /// </summary>
        public CatalogController Catalog
        {
            get
            {
                return CatalogController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ExchangeRates controller
        /// </summary>
        public ExchangeRatesController ExchangeRates
        {
            get
            {
                return ExchangeRatesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Status controller
        /// </summary>
        public StatusController Status
        {
            get
            {
                return StatusController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Customers controller
        /// </summary>
        public CustomersController Customers
        {
            get
            {
                return CustomersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Fund controller
        /// </summary>
        public FundController Fund
        {
            get
            {
                return FundController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public RaasClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public RaasClient(string platformName = "QAPlatform2", string platformKey = "apYPfT6HNONpDRUj3CLGWYt7gvIHONpDRUYPfT6Hj")
        {
            Configuration.PlatformName = platformName;
            Configuration.PlatformKey = platformKey;
        }
        #endregion
    }
}