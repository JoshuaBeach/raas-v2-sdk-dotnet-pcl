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
    public class RaasClientErrorModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string path;
        private string message;
        private string constraint;
        private string invalidValue;

        /// <summary>
        /// The path to the invalid value
        /// </summary>
        [JsonProperty("path")]
        public string Path 
        { 
            get 
            {
                return this.path; 
            } 
            set 
            {
                this.path = value;
                onPropertyChanged("Path");
            }
        }

        /// <summary>
        /// The error message
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
        /// The constraint validated
        /// </summary>
        [JsonProperty("constraint")]
        public string Constraint 
        { 
            get 
            {
                return this.constraint; 
            } 
            set 
            {
                this.constraint = value;
                onPropertyChanged("Constraint");
            }
        }

        /// <summary>
        /// The value that was invalid
        /// </summary>
        [JsonProperty("invalidValue")]
        public string InvalidValue 
        { 
            get 
            {
                return this.invalidValue; 
            } 
            set 
            {
                this.invalidValue = value;
                onPropertyChanged("InvalidValue");
            }
        }
    }
} 