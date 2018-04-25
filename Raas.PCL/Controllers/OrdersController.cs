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
    public partial class OrdersController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static OrdersController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static OrdersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new OrdersController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieves a single order
        /// </summary>
        /// <param name="referenceOrderID">Required parameter: Reference Order ID</param>
        /// <return>Returns the Models.OrderModel response from the API call</return>
        public Models.OrderModel GetOrder(string referenceOrderID)
        {
            Task<Models.OrderModel> t = GetOrderAsync(referenceOrderID);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a single order
        /// </summary>
        /// <param name="referenceOrderID">Required parameter: Reference Order ID</param>
        /// <return>Returns the Models.OrderModel response from the API call</return>
        public async Task<Models.OrderModel> GetOrderAsync(string referenceOrderID)
        {
            //validating required parameters
            if (null == referenceOrderID)
                throw new ArgumentNullException("referenceOrderID", "The parameter \"referenceOrderID\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{referenceOrderID}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "referenceOrderID", referenceOrderID }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "V2NGSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new RaasGenericException(@"API Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.OrderModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Resends an order
        /// </summary>
        /// <param name="referenceOrderID">Required parameter: The order's reference order id</param>
        /// <return>Returns the Models.ResendOrderResponseModel response from the API call</return>
        public Models.ResendOrderResponseModel CreateResendOrder(string referenceOrderID)
        {
            Task<Models.ResendOrderResponseModel> t = CreateResendOrderAsync(referenceOrderID);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Resends an order
        /// </summary>
        /// <param name="referenceOrderID">Required parameter: The order's reference order id</param>
        /// <return>Returns the Models.ResendOrderResponseModel response from the API call</return>
        public async Task<Models.ResendOrderResponseModel> CreateResendOrderAsync(string referenceOrderID)
        {
            //validating required parameters
            if (null == referenceOrderID)
                throw new ArgumentNullException("referenceOrderID", "The parameter \"referenceOrderID\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders/{referenceOrderID}/resends");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "referenceOrderID", referenceOrderID }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "V2NGSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new RaasGenericException(@"API Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ResendOrderResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieves a list of orders under a platform
        /// </summary>
        /// <param name="Models.GetOrdersInput">Object containing request parameters</param>
        /// <return>Returns the Models.GetOrdersResponseModel response from the API call</return>
        public Models.GetOrdersResponseModel GetOrders(Models.GetOrdersInput input)
        {
            Task<Models.GetOrdersResponseModel> t = GetOrdersAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a list of orders under a platform
        /// </summary>
        /// <param name="Models.GetOrdersInput">Object containing request parameters</param>
        /// <return>Returns the Models.GetOrdersResponseModel response from the API call</return>
        public async Task<Models.GetOrdersResponseModel> GetOrdersAsync(Models.GetOrdersInput input)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "accountIdentifier", input.AccountIdentifier },
                { "customerIdentifier", input.CustomerIdentifier },
                { "externalRefID", input.ExternalRefID },
                { "startDate", (input.StartDate.HasValue) ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "endDate", (input.EndDate.HasValue) ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null },
                { "elementsPerBlock", input.ElementsPerBlock },
                { "page", input.Page }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "V2NGSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.PlatformName, Configuration.PlatformKey);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new RaasGenericException(@"API Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetOrdersResponseModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Places an order
        /// </summary>
        /// <param name="body">Required parameter: A CreateOrderRequest object</param>
        /// <return>Returns the Models.OrderModel response from the API call</return>
        public Models.OrderModel CreateOrder(Models.CreateOrderRequestModel body)
        {
            Task<Models.OrderModel> t = CreateOrderAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Places an order
        /// </summary>
        /// <param name="body">Required parameter: A CreateOrderRequest object</param>
        /// <return>Returns the Models.OrderModel response from the API call</return>
        public async Task<Models.OrderModel> CreateOrderAsync(Models.CreateOrderRequestModel body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/orders");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "V2NGSDK" },
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

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new RaasGenericException(@"API Error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.OrderModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 