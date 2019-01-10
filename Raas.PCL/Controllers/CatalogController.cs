/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io ).
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
    public partial class CatalogController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CatalogController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CatalogController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CatalogController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieves a platform's catalog
        /// </summary>
        /// <return>Returns the Models.CatalogModel response from the API call</return>
        public Models.CatalogModel GetCatalog()
        {
            Task<Models.CatalogModel> t = GetCatalogAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a platform's catalog
        /// </summary>
        /// <return>Returns the Models.CatalogModel response from the API call</return>
        public async Task<Models.CatalogModel> GetCatalogAsync()
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/catalogs");


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
                return APIHelper.JsonDeserialize<Models.CatalogModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 