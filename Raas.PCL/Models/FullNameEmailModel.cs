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
    public class FullNameEmailModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string fullName;
        private string emailAddress;

        /// <summary>
        /// The full name
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName 
        { 
            get 
            {
                return this.fullName; 
            } 
            set 
            {
                this.fullName = value;
                onPropertyChanged("FullName");
            }
        }

        /// <summary>
        /// The email address
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress 
        { 
            get 
            {
                return this.emailAddress; 
            } 
            set 
            {
                this.emailAddress = value;
                onPropertyChanged("EmailAddress");
            }
        }
    }
} 