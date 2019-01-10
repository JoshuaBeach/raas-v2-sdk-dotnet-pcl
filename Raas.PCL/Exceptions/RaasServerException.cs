/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TangoCard.Raas.Http.Client;

using TangoCard.Raas.Models;
using TangoCard.Raas;
using TangoCard.Raas.Utilities;


namespace TangoCard.Raas.Exceptions
{
    public class RaasServerException : APIException 
    {
        // These fields hold the values for the public properties.
        private DateTime timestamp;
        private string requestId;
        private string path;
        private int httpCode;
        private string httpPhrase;
        private List<Models.RaasServerErrorModel> errors;

        /// <summary>
        /// Request timestamp
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp")]
        public DateTime Timestamp 
        { 
            get 
            {
                return this.timestamp; 
            } 
            private set 
            {
                this.timestamp = value;
            }
        }

        /// <summary>
        /// Request ID
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId 
        { 
            get 
            {
                return this.requestId; 
            } 
            private set 
            {
                this.requestId = value;
            }
        }

        /// <summary>
        /// Request Path
        /// </summary>
        [JsonProperty("path")]
        public string Path 
        { 
            get 
            {
                return this.path; 
            } 
            private set 
            {
                this.path = value;
            }
        }

        /// <summary>
        /// HTTP Code
        /// </summary>
        [JsonProperty("httpCode")]
        public int HttpCode 
        { 
            get 
            {
                return this.httpCode; 
            } 
            private set 
            {
                this.httpCode = value;
            }
        }

        /// <summary>
        /// HTTP Phrase
        /// </summary>
        [JsonProperty("httpPhrase")]
        public string HttpPhrase 
        { 
            get 
            {
                return this.httpPhrase; 
            } 
            private set 
            {
                this.httpPhrase = value;
            }
        }

        /// <summary>
        /// An array of errors
        /// </summary>
        [JsonProperty("errors")]
        public List<Models.RaasServerErrorModel> Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public RaasServerException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 