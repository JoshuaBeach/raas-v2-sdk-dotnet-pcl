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
    public class CreditCardModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string customerIdentifier;
        private string accountIdentifier;
        private string token;
        private string label;
        private string lastFourDigits;
        private string expirationDate;
        private string status;
        private DateTime createdDate;
        private DateTime activationDate;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customerIdentifier")]
        public string CustomerIdentifier 
        { 
            get 
            {
                return this.customerIdentifier; 
            } 
            set 
            {
                this.customerIdentifier = value;
                onPropertyChanged("CustomerIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier 
        { 
            get 
            {
                return this.accountIdentifier; 
            } 
            set 
            {
                this.accountIdentifier = value;
                onPropertyChanged("AccountIdentifier");
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("label")]
        public string Label 
        { 
            get 
            {
                return this.label; 
            } 
            set 
            {
                this.label = value;
                onPropertyChanged("Label");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lastFourDigits")]
        public string LastFourDigits 
        { 
            get 
            {
                return this.lastFourDigits; 
            } 
            set 
            {
                this.lastFourDigits = value;
                onPropertyChanged("LastFourDigits");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("expirationDate")]
        public string ExpirationDate 
        { 
            get 
            {
                return this.expirationDate; 
            } 
            set 
            {
                this.expirationDate = value;
                onPropertyChanged("ExpirationDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("activationDate")]
        public DateTime ActivationDate 
        { 
            get 
            {
                return this.activationDate; 
            } 
            set 
            {
                this.activationDate = value;
                onPropertyChanged("ActivationDate");
            }
        }
    }
} 