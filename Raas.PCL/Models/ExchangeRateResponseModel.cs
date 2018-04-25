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
    public class ExchangeRateResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string disclaimer;
        private List<Models.ExchangeRateModel> exchangeRates;

        /// <summary>
        /// A disclaimer about the exchange rates returned
        /// </summary>
        [JsonProperty("disclaimer")]
        public string Disclaimer 
        { 
            get 
            {
                return this.disclaimer; 
            } 
            set 
            {
                this.disclaimer = value;
                onPropertyChanged("Disclaimer");
            }
        }

        /// <summary>
        /// An array of ExchangeRate objects
        /// </summary>
        [JsonProperty("exchangeRates")]
        public List<Models.ExchangeRateModel> ExchangeRates 
        { 
            get 
            {
                return this.exchangeRates; 
            } 
            set 
            {
                this.exchangeRates = value;
                onPropertyChanged("ExchangeRates");
            }
        }
    }
} 