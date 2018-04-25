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
    public class PageModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int number;
        private int elementsPerBlock;
        private int resultCount;
        private int totalCount;

        /// <summary>
        /// The page number
        /// </summary>
        [JsonProperty("number")]
        public int Number 
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
        /// The number of elements per page
        /// </summary>
        [JsonProperty("elementsPerBlock")]
        public int ElementsPerBlock 
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
        /// The number of results returned
        /// </summary>
        [JsonProperty("resultCount")]
        public int ResultCount 
        { 
            get 
            {
                return this.resultCount; 
            } 
            set 
            {
                this.resultCount = value;
                onPropertyChanged("ResultCount");
            }
        }

        /// <summary>
        /// The total number of results
        /// </summary>
        [JsonProperty("totalCount")]
        public int TotalCount 
        { 
            get 
            {
                return this.totalCount; 
            } 
            set 
            {
                this.totalCount = value;
                onPropertyChanged("TotalCount");
            }
        }
    }
} 