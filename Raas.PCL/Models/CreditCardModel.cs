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
        private List<Models.FullNameEmailModel> contactInformation;

        /// <summary>
        /// The customer identifier
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
        /// The account identifier
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
        /// The credit card token
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
        /// The label/nickname for the credit card
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
        /// The last four digits of the credit card number
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
        /// The credit card's expiration date
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
        /// The status of the credit card
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
        /// The date the card was added
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
        /// The date the card will be available for use
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

        /// <summary>
        /// An optional array of FullNameEmail objects
        /// </summary>
        [JsonProperty("contactInformation")]
        public List<Models.FullNameEmailModel> ContactInformation 
        { 
            get 
            {
                return this.contactInformation; 
            } 
            set 
            {
                this.contactInformation = value;
                onPropertyChanged("ContactInformation");
            }
        }
    }
} 