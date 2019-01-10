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
    public class DepositResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double amount;
        private double amountCharged;
        private DateTime createdDate;
        private double feePercent;
        private string referenceDepositID;
        private string status;

        /// <summary>
        /// The funding amount
        /// </summary>
        [JsonProperty("amount")]
        public double Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// The amount charged, after fees
        /// </summary>
        [JsonProperty("amountCharged")]
        public double AmountCharged 
        { 
            get 
            {
                return this.amountCharged; 
            } 
            set 
            {
                this.amountCharged = value;
                onPropertyChanged("AmountCharged");
            }
        }

        /// <summary>
        /// The date the transaction was created
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
        /// The processing fee percentage
        /// </summary>
        [JsonProperty("feePercent")]
        public double FeePercent 
        { 
            get 
            {
                return this.feePercent; 
            } 
            set 
            {
                this.feePercent = value;
                onPropertyChanged("FeePercent");
            }
        }

        /// <summary>
        /// The deposit reference id
        /// </summary>
        [JsonProperty("referenceDepositID")]
        public string ReferenceDepositID 
        { 
            get 
            {
                return this.referenceDepositID; 
            } 
            set 
            {
                this.referenceDepositID = value;
                onPropertyChanged("ReferenceDepositID");
            }
        }

        /// <summary>
        /// The status of the transaction
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
    }
} 