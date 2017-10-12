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
    public partial class FundController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static FundController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static FundController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new FundController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// List all credit cards registered on this platform
        /// </summary>
        /// <return>Returns the List<Models.CreditCardModel> response from the API call</return>
        public List<Models.CreditCardModel> GetCreditCards()
        {
            Task<List<Models.CreditCardModel>> t = GetCreditCardsAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// List all credit cards registered on this platform
        /// </summary>
        /// <return>Returns the List<Models.CreditCardModel> response from the API call</return>
        public async Task<List<Models.CreditCardModel>> GetCreditCardsAsync()
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/creditCards");


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
                return APIHelper.JsonDeserialize<List<Models.CreditCardModel>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Register a new credit card
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.CreditCardModel response from the API call</return>
        public Models.CreditCardModel CreateCreditCard(Models.CreateCreditCardRequestModel body)
        {
            Task<Models.CreditCardModel> t = CreateCreditCardAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Register a new credit card
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.CreditCardModel response from the API call</return>
        public async Task<Models.CreditCardModel> CreateCreditCardAsync(Models.CreateCreditCardRequestModel body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/creditCards");


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
                return APIHelper.JsonDeserialize<Models.CreditCardModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Unregister a credit card
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.UnregisterCreditCardResponseModel response from the API call</return>
        public Models.UnregisterCreditCardResponseModel CreateUnregisterCreditCard(Models.UnregisterCreditCardRequestModel body)
        {
            Task<Models.UnregisterCreditCardResponseModel> t = CreateUnregisterCreditCardAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Unregister a credit card
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.UnregisterCreditCardResponseModel response from the API call</return>
        public async Task<Models.UnregisterCreditCardResponseModel> CreateUnregisterCreditCardAsync(Models.UnregisterCreditCardRequestModel body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/creditCardUnregisters");


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
                return APIHelper.JsonDeserialize<Models.UnregisterCreditCardResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Fund an account
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.DepositResponseModel response from the API call</return>
        public Models.DepositResponseModel CreateDeposit(Models.DepositRequestModel body)
        {
            Task<Models.DepositResponseModel> t = CreateDepositAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Fund an account
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.DepositResponseModel response from the API call</return>
        public async Task<Models.DepositResponseModel> CreateDepositAsync(Models.DepositRequestModel body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/creditCardDeposits");


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
                return APIHelper.JsonDeserialize<Models.DepositResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get details for a specific credit card deposit
        /// </summary>
        /// <param name="depositId">Required parameter: Deposit ID</param>
        /// <return>Returns the Models.GetDepositResponseModel response from the API call</return>
        public Models.GetDepositResponseModel GetDeposit(string depositId)
        {
            Task<Models.GetDepositResponseModel> t = GetDepositAsync(depositId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get details for a specific credit card deposit
        /// </summary>
        /// <param name="depositId">Required parameter: Deposit ID</param>
        /// <return>Returns the Models.GetDepositResponseModel response from the API call</return>
        public async Task<Models.GetDepositResponseModel> GetDepositAsync(string depositId)
        {
            //validating required parameters
            if (null == depositId)
                throw new ArgumentNullException("depositId", "The parameter \"depositId\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/creditCardDeposits/{depositId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "depositId", depositId }
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
                return APIHelper.JsonDeserialize<Models.GetDepositResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get details for a specific credit card
        /// </summary>
        /// <param name="token">Required parameter: Card Token</param>
        /// <return>Returns the Models.CreditCardModel response from the API call</return>
        public Models.CreditCardModel GetCreditCard(string token)
        {
            Task<Models.CreditCardModel> t = GetCreditCardAsync(token);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get details for a specific credit card
        /// </summary>
        /// <param name="token">Required parameter: Card Token</param>
        /// <return>Returns the Models.CreditCardModel response from the API call</return>
        public async Task<Models.CreditCardModel> GetCreditCardAsync(string token)
        {
            //validating required parameters
            if (null == token)
                throw new ArgumentNullException("token", "The parameter \"token\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/creditCards/{token}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "token", token }
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
                return APIHelper.JsonDeserialize<Models.CreditCardModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 