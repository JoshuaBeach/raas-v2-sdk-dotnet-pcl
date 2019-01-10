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
    public class CreateCreditCardRequestModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string customerIdentifier;
        private string accountIdentifier;
        private string label;
        private string ipAddress;
        private Models.NewCreditCardModel creditCard;
        private Models.BillingAddressModel billingAddress;
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
        /// The credit card's label/nickname
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
        /// The IP address of the user registering the card
        /// </summary>
        [JsonProperty("ipAddress")]
        public string IpAddress 
        { 
            get 
            {
                return this.ipAddress; 
            } 
            set 
            {
                this.ipAddress = value;
                onPropertyChanged("IpAddress");
            }
        }

        /// <summary>
        /// A NewCreditCard object
        /// </summary>
        [JsonProperty("creditCard")]
        public Models.NewCreditCardModel CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// A BillingAddress object
        /// </summary>
        [JsonProperty("billingAddress")]
        public Models.BillingAddressModel BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
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