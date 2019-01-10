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
    public class CurrencyBreakdownModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string currencyCode;
        private double? exchangeRate;
        private double? fee;
        private double? total;
        private double? mvalue;

        /// <summary>
        /// A 3 digit currency code
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
        /// The exchange rate
        /// </summary>
        [JsonProperty("exchangeRate")]
        public double? ExchangeRate 
        { 
            get 
            {
                return this.exchangeRate; 
            } 
            set 
            {
                this.exchangeRate = value;
                onPropertyChanged("ExchangeRate");
            }
        }

        /// <summary>
        /// The amount of the fee applied
        /// </summary>
        [JsonProperty("fee")]
        public double? Fee 
        { 
            get 
            {
                return this.fee; 
            } 
            set 
            {
                this.fee = value;
                onPropertyChanged("Fee");
            }
        }

        /// <summary>
        /// The order total
        /// </summary>
        [JsonProperty("total")]
        public double? Total 
        { 
            get 
            {
                return this.total; 
            } 
            set 
            {
                this.total = value;
                onPropertyChanged("Total");
            }
        }

        /// <summary>
        /// The value of the order
        /// </summary>
        [JsonProperty("value")]
        public double? Value 
        { 
            get 
            {
                return this.mvalue; 
            } 
            set 
            {
                this.mvalue = value;
                onPropertyChanged("Value");
            }
        }
    }
} 