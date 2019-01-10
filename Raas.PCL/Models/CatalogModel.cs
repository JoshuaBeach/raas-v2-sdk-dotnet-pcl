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
    public class CatalogModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string catalogName;
        private List<Models.BrandModel> brands;

        /// <summary>
        /// The name of your catalog
        /// </summary>
        [JsonProperty("catalogName")]
        public string CatalogName 
        { 
            get 
            {
                return this.catalogName; 
            } 
            set 
            {
                this.catalogName = value;
                onPropertyChanged("CatalogName");
            }
        }

        /// <summary>
        /// The brands in your catalog
        /// </summary>
        [JsonProperty("brands")]
        public List<Models.BrandModel> Brands 
        { 
            get 
            {
                return this.brands; 
            } 
            set 
            {
                this.brands = value;
                onPropertyChanged("Brands");
            }
        }
    }
} 