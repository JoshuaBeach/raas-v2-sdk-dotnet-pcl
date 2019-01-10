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
    public class ItemModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string utid;
        private string rewardName;
        private string currencyCode;
        private string status;
        private string valueType;
        private string rewardType;
        private double? minValue;
        private double? maxValue;
        private double? faceValue;
        private DateTime createdDate;
        private DateTime lastUpdateDate;
        private List<string> countries;

        /// <summary>
        /// The UTID
        /// </summary>
        [JsonProperty("utid")]
        public string Utid 
        { 
            get 
            {
                return this.utid; 
            } 
            set 
            {
                this.utid = value;
                onPropertyChanged("Utid");
            }
        }

        /// <summary>
        /// The reward name
        /// </summary>
        [JsonProperty("rewardName")]
        public string RewardName 
        { 
            get 
            {
                return this.rewardName; 
            } 
            set 
            {
                this.rewardName = value;
                onPropertyChanged("RewardName");
            }
        }

        /// <summary>
        /// The currency code
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
        /// The item's status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The item's value type (VARIABLE_VALUE or FIXED_VALUE)
        /// </summary>
        [JsonProperty("valueType")]
        public string ValueType 
        { 
            get 
            {
                return this.valueType; 
            } 
            set 
            {
                this.valueType = value;
                onPropertyChanged("ValueType");
            }
        }

        /// <summary>
        /// The reward type
        /// </summary>
        [JsonProperty("rewardType")]
        public string RewardType 
        { 
            get 
            {
                return this.rewardType; 
            } 
            set 
            {
                this.rewardType = value;
                onPropertyChanged("RewardType");
            }
        }

        /// <summary>
        /// The minimum orderable value (for variable value items)
        /// </summary>
        [JsonProperty("minValue")]
        public double? MinValue 
        { 
            get 
            {
                return this.minValue; 
            } 
            set 
            {
                this.minValue = value;
                onPropertyChanged("MinValue");
            }
        }

        /// <summary>
        /// The maximum orderable value (for variable value items)
        /// </summary>
        [JsonProperty("maxValue")]
        public double? MaxValue 
        { 
            get 
            {
                return this.maxValue; 
            } 
            set 
            {
                this.maxValue = value;
                onPropertyChanged("MaxValue");
            }
        }

        /// <summary>
        /// The face value of the gift card
        /// </summary>
        [JsonProperty("faceValue")]
        public double? FaceValue 
        { 
            get 
            {
                return this.faceValue; 
            } 
            set 
            {
                this.faceValue = value;
                onPropertyChanged("FaceValue");
            }
        }

        /// <summary>
        /// The date the item was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate")]
        public DateTime CreatedDate 
        { 
            get 
            {
                return this.createdDate; 
            } 
            set 
            {
                this.createdDate = value;
                onPropertyChanged("CreatedDate");
            }
        }

        /// <summary>
        /// The date the item was last updated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdateDate")]
        public DateTime LastUpdateDate 
        { 
            get 
            {
                return this.lastUpdateDate; 
            } 
            set 
            {
                this.lastUpdateDate = value;
                onPropertyChanged("LastUpdateDate");
            }
        }

        /// <summary>
        /// The countries this item is valid in
        /// </summary>
        [JsonProperty("countries")]
        public List<string> Countries 
        { 
            get 
            {
                return this.countries; 
            } 
            set 
            {
                this.countries = value;
                onPropertyChanged("Countries");
            }
        }
    }
} 