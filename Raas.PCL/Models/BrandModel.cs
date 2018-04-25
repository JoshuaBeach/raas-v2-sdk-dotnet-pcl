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
    public class BrandModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string brandKey;
        private string brandName;
        private string disclaimer;
        private string description;
        private string shortDescription;
        private string terms;
        private DateTime createdDate;
        private DateTime lastUpdateDate;
        private Dictionary<string, string> imageUrls;
        private string status;
        private List<Models.ItemModel> items;

        /// <summary>
        /// The brand key
        /// </summary>
        [JsonProperty("brandKey")]
        public string BrandKey 
        { 
            get 
            {
                return this.brandKey; 
            } 
            set 
            {
                this.brandKey = value;
                onPropertyChanged("BrandKey");
            }
        }

        /// <summary>
        /// The brand name
        /// </summary>
        [JsonProperty("brandName")]
        public string BrandName 
        { 
            get 
            {
                return this.brandName; 
            } 
            set 
            {
                this.brandName = value;
                onPropertyChanged("BrandName");
            }
        }

        /// <summary>
        /// The brand's disclaimer
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
        /// The brand's description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The brand's short description
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription 
        { 
            get 
            {
                return this.shortDescription; 
            } 
            set 
            {
                this.shortDescription = value;
                onPropertyChanged("ShortDescription");
            }
        }

        /// <summary>
        /// The brand's terms
        /// </summary>
        [JsonProperty("terms")]
        public string Terms 
        { 
            get 
            {
                return this.terms; 
            } 
            set 
            {
                this.terms = value;
                onPropertyChanged("Terms");
            }
        }

        /// <summary>
        /// The date the brand was created
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
        /// The date the brand was last updated
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
        /// A map of Image URLs
        /// </summary>
        [JsonProperty("imageUrls")]
        public Dictionary<string, string> ImageUrls 
        { 
            get 
            {
                return this.imageUrls; 
            } 
            set 
            {
                this.imageUrls = value;
                onPropertyChanged("ImageUrls");
            }
        }

        /// <summary>
        /// The brand's status
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
        /// An array of Item objects
        /// </summary>
        [JsonProperty("items")]
        public List<Models.ItemModel> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }
    }
} 