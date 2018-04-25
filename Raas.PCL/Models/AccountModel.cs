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
    public class AccountModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountIdentifier;
        private string accountNumber;
        private string displayName;
        private string currencyCode = "USD";
        private double currentBalance;
        private DateTime createdAt;
        private string status;
        private string contactEmail;

        /// <summary>
        /// An account identifier
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
        /// An account number
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber 
        { 
            get 
            {
                return this.accountNumber; 
            } 
            set 
            {
                this.accountNumber = value;
                onPropertyChanged("AccountNumber");
            }
        }

        /// <summary>
        /// A display name
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName 
        { 
            get 
            {
                return this.displayName; 
            } 
            set 
            {
                this.displayName = value;
                onPropertyChanged("DisplayName");
            }
        }

        /// <summary>
        /// The currency code for the account
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        [JsonProperty("currentBalance")]
        public double CurrentBalance 
        { 
            get 
            {
                return this.currentBalance; 
            } 
            set 
            {
                this.currentBalance = value;
                onPropertyChanged("CurrentBalance");
            }
        }

        /// <summary>
        /// The date the account was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// The status of the account
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
        /// The contact email on file for the account
        /// </summary>
        [JsonProperty("contactEmail")]
        public string ContactEmail 
        { 
            get 
            {
                return this.contactEmail; 
            } 
            set 
            {
                this.contactEmail = value;
                onPropertyChanged("ContactEmail");
            }
        }
    }
} 