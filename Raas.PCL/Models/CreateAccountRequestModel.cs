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
    public class CreateAccountRequestModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountIdentifier;
        private string displayName;
        private string contactEmail;

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
        /// The display name
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
        /// The contact email
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