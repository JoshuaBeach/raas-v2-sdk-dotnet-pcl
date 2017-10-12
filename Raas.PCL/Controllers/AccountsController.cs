/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using TangoCard.Raas;
using TangoCard.Raas.Utilities;
using TangoCard.Raas.Http.Request;
using TangoCard.Raas.Http.Response;
using TangoCard.Raas.Http.Client;
using TangoCard.Raas.Exceptions;

namespace TangoCard.Raas.Controllers
{
    public partial class AccountsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AccountsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AccountsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AccountsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="accountIdentifier">Required parameter: Account Identifier</param>
        /// <return>Returns the Models.AccountModel response from the API call</return>
        public Models.AccountModel GetAccount(string accountIdentifier)
        {
            Task<Models.AccountModel> t = GetAccountAsync(accountIdentifier);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name="accountIdentifier">Required parameter: Account Identifier</param>
        /// <return>Returns the Models.AccountModel response from the API call</return>
        public async Task<Models.AccountModel> GetAccountAsync(string accountIdentifier)
        {
            //validating required parameters
            if (null == accountIdentifier)
                throw new ArgumentNullException("accountIdentifier", "The parameter \"accountIdentifier\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/{accountIdentifier}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountIdentifier", accountIdentifier }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "TangoCardv2NGSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.AccountModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets a list of accounts for a given customer
        /// </summary>
        /// <param name="customerIdentifier">Required parameter: Customer Identifier</param>
        /// <return>Returns the List<Models.AccountSummaryModel> response from the API call</return>
        public List<Models.AccountSummaryModel> GetAccountsByCustomer(string customerIdentifier)
        {
            Task<List<Models.AccountSummaryModel>> t = GetAccountsByCustomerAsync(customerIdentifier);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a list of accounts for a given customer
        /// </summary>
        /// <param name="customerIdentifier">Required parameter: Customer Identifier</param>
        /// <return>Returns the List<Models.AccountSummaryModel> response from the API call</return>
        public async Task<List<Models.AccountSummaryModel>> GetAccountsByCustomerAsync(string customerIdentifier)
        {
            //validating required parameters
            if (null == customerIdentifier)
                throw new ArgumentNullException("customerIdentifier", "The parameter \"customerIdentifier\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/customers/{customerIdentifier}/accounts");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "customerIdentifier", customerIdentifier }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "TangoCardv2NGSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<List<Models.AccountSummaryModel>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Create an account under a given customer
        /// </summary>
        /// <param name="customerIdentifier">Required parameter: Customer Identifier</param>
        /// <param name="body">Required parameter: Request Body</param>
        /// <return>Returns the Models.AccountModel response from the API call</return>
        public Models.AccountModel CreateAccount(string customerIdentifier, Models.CreateAccountRequestModel body)
        {
            Task<Models.AccountModel> t = CreateAccountAsync(customerIdentifier, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create an account under a given customer
        /// </summary>
        /// <param name="customerIdentifier">Required parameter: Customer Identifier</param>
        /// <param name="body">Required parameter: Request Body</param>
        /// <return>Returns the Models.AccountModel response from the API call</return>
        public async Task<Models.AccountModel> CreateAccountAsync(string customerIdentifier, Models.CreateAccountRequestModel body)
        {
            //validating required parameters
            if (null == customerIdentifier)
                throw new ArgumentNullException("customerIdentifier", "The parameter \"customerIdentifier\" is a required parameter and cannot be null.");

            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/customers/{customerIdentifier}/accounts");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "customerIdentifier", customerIdentifier }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "TangoCardv2NGSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.AccountModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets all accounts under the platform
        /// </summary>
        /// <return>Returns the List<Models.AccountModel> response from the API call</return>
        public List<Models.AccountModel> GetAllAccounts()
        {
            Task<List<Models.AccountModel>> t = GetAllAccountsAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all accounts under the platform
        /// </summary>
        /// <return>Returns the List<Models.AccountModel> response from the API call</return>
        public async Task<List<Models.AccountModel>> GetAllAccountsAsync()
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "TangoCardv2NGSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<List<Models.AccountModel>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 