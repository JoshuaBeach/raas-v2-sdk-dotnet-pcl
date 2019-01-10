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
    public class OrderResendCriteriaModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string newEmail;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("newEmail")]
        public string NewEmail 
        { 
            get 
            {
                return this.newEmail; 
            } 
            set 
            {
                this.newEmail = value;
                onPropertyChanged("NewEmail");
            }
        }
    }
} 