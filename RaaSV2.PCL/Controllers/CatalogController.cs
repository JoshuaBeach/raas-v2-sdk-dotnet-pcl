/*
 * RaaSV2.PCL
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
using TangoCard.RaaSv2;
using TangoCard.RaaSv2.Utilities;
using TangoCard.RaaSv2.Http.Request;
using TangoCard.RaaSv2.Http.Response;
using TangoCard.RaaSv2.Http.Client;
using TangoCard.RaaSv2.Exceptions;
using TangoCard.RaaSv2.Models;

namespace TangoCard.RaaSv2.Controllers
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
        /// Get Catalog
        /// </summary>
        /// <return>Returns the Models.CatalogModel response from the API call</return>
        public Models.CatalogModel GetCatalog()
        {
            Task<Models.CatalogModel> t = GetCatalogAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get Catalog
        /// </summary>
        /// <return>Returns the Models.CatalogModel response from the API call</return>
        public async Task<Models.CatalogModel> GetCatalogAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/catalogs");


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
                return APIHelper.JsonDeserialize<Models.CatalogModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 