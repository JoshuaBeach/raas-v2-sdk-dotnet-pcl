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
    public class CreateAccountInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string customerIdentifier;
        private Models.CreateAccountRequestModel body;

        /// <summary>
        /// Customer Identifier
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
        /// Request Body
        /// </summary>
        [JsonProperty("body")]
        public Models.CreateAccountRequestModel Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }
    }
} 