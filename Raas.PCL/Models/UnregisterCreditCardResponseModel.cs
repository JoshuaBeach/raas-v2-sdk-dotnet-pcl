/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
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
using TangoCard.Raas;
using TangoCard.Raas.Utilities;


namespace TangoCard.Raas.Models
{
    public class UnregisterCreditCardResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime createdDate;
        private string message;
        private string token;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate")]
        public DateTime CreatedDate 
        { 
            get 
            {
                return this.createdDate; 
            } 
            set 
            {
                this.createdDate = value;
                onPropertyChanged("CreatedDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("token")]
        public string Token 
        { 
            get 
            {
                return this.token; 
            } 
            set 
            {
                this.token = value;
                onPropertyChanged("Token");
            }
        }
    }
} 