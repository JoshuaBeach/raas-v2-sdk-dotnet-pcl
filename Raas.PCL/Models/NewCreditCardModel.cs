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
    public class NewCreditCardModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string number;
        private string expiration;
        private string verificationNumber;

        /// <summary>
        /// card number
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// card expiration date in YYYY-MM format
        /// </summary>
        [JsonProperty("expiration")]
        public string Expiration 
        { 
            get 
            {
                return this.expiration; 
            } 
            set 
            {
                this.expiration = value;
                onPropertyChanged("Expiration");
            }
        }

        /// <summary>
        /// 3 or 4 digit card security code on the back of card
        /// </summary>
        [JsonProperty("verificationNumber")]
        public string VerificationNumber 
        { 
            get 
            {
                return this.verificationNumber; 
            } 
            set 
            {
                this.verificationNumber = value;
                onPropertyChanged("VerificationNumber");
            }
        }
    }
} 