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
    public class ExchangeRateModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime lastModifiedDate;
        private string rewardCurrency;
        private string baseCurrency;
        private double baseFx;

        /// <summary>
        /// When the exchange rate was last updated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate")]
        public DateTime LastModifiedDate 
        { 
            get 
            {
                return this.lastModifiedDate; 
            } 
            set 
            {
                this.lastModifiedDate = value;
                onPropertyChanged("LastModifiedDate");
            }
        }

        /// <summary>
        /// The reward currency
        /// </summary>
        [JsonProperty("rewardCurrency")]
        public string RewardCurrency 
        { 
            get 
            {
                return this.rewardCurrency; 
            } 
            set 
            {
                this.rewardCurrency = value;
                onPropertyChanged("RewardCurrency");
            }
        }

        /// <summary>
        /// The base currency
        /// </summary>
        [JsonProperty("baseCurrency")]
        public string BaseCurrency 
        { 
            get 
            {
                return this.baseCurrency; 
            } 
            set 
            {
                this.baseCurrency = value;
                onPropertyChanged("BaseCurrency");
            }
        }

        /// <summary>
        /// The exchange rate
        /// </summary>
        [JsonProperty("baseFx")]
        public double BaseFx 
        { 
            get 
            {
                return this.baseFx; 
            } 
            set 
            {
                this.baseFx = value;
                onPropertyChanged("BaseFx");
            }
        }
    }
} 