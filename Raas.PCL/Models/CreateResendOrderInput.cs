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
    public class CreateResendOrderInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string referenceOrderID;
        private Models.OrderResendCriteriaModel orderResendCriteria;

        /// <summary>
        /// The order's reference order id
        /// </summary>
        [JsonProperty("referenceOrderID")]
        public string ReferenceOrderID 
        { 
            get 
            {
                return this.referenceOrderID; 
            } 
            set 
            {
                this.referenceOrderID = value;
                onPropertyChanged("ReferenceOrderID");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("orderResendCriteria")]
        public Models.OrderResendCriteriaModel OrderResendCriteria 
        { 
            get 
            {
                return this.orderResendCriteria; 
            } 
            set 
            {
                this.orderResendCriteria = value;
                onPropertyChanged("OrderResendCriteria");
            }
        }
    }
} 