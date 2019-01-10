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
    public class GetOrdersResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.PageModel page;
        private List<Models.OrderSummaryModel> orders;

        /// <summary>
        /// Pagination information
        /// </summary>
        [JsonProperty("page")]
        public Models.PageModel Page 
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

        /// <summary>
        /// An array of orders
        /// </summary>
        [JsonProperty("orders")]
        public List<Models.OrderSummaryModel> Orders 
        { 
            get 
            {
                return this.orders; 
            } 
            set 
            {
                this.orders = value;
                onPropertyChanged("Orders");
            }
        }
    }
} 