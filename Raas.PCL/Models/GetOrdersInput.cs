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
    public class GetOrdersInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountIdentifier;
        private string customerIdentifier;
        private string externalRefID;
        private DateTime? startDate;
        private DateTime? endDate;
        private int? elementsPerBlock;
        private int? page;

        /// <summary>
        /// Account identifier
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier 
        { 
            get 
            {
                return this.accountIdentifier; 
            } 
            set 
            {
                this.accountIdentifier = value;
                onPropertyChanged("AccountIdentifier");
            }
        }

        /// <summary>
        /// Customer identifier
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
        /// External reference id
        /// </summary>
        [JsonProperty("externalRefID")]
        public string ExternalRefID 
        { 
            get 
            {
                return this.externalRefID; 
            } 
            set 
            {
                this.externalRefID = value;
                onPropertyChanged("ExternalRefID");
            }
        }

        /// <summary>
        /// The start date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startDate")]
        public DateTime? StartDate 
        { 
            get 
            {
                return this.startDate; 
            } 
            set 
            {
                this.startDate = value;
                onPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// The end date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endDate")]
        public DateTime? EndDate 
        { 
            get 
            {
                return this.endDate; 
            } 
            set 
            {
                this.endDate = value;
                onPropertyChanged("EndDate");
            }
        }

        /// <summary>
        /// The number of elements per page
        /// </summary>
        [JsonProperty("elementsPerBlock")]
        public int? ElementsPerBlock 
        { 
            get 
            {
                return this.elementsPerBlock; 
            } 
            set 
            {
                this.elementsPerBlock = value;
                onPropertyChanged("ElementsPerBlock");
            }
        }

        /// <summary>
        /// The page number to return
        /// </summary>
        [JsonProperty("page")]
        public int? Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }
    }
} 