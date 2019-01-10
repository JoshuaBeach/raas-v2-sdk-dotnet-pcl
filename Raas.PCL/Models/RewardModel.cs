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
    public class RewardModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Dictionary<string, string> credentials;
        private List<Models.RewardCredentialModel> credentialList;
        private string redemptionInstructions;

        /// <summary>
        /// A map of reward credentials
        /// </summary>
        [JsonProperty("credentials")]
        public Dictionary<string, string> Credentials 
        { 
            get 
            {
                return this.credentials; 
            } 
            set 
            {
                this.credentials = value;
                onPropertyChanged("Credentials");
            }
        }

        /// <summary>
        /// An array of reward credentials
        /// </summary>
        [JsonProperty("credentialList")]
        public List<Models.RewardCredentialModel> CredentialList 
        { 
            get 
            {
                return this.credentialList; 
            } 
            set 
            {
                this.credentialList = value;
                onPropertyChanged("CredentialList");
            }
        }

        /// <summary>
        /// Reward redemption instructions
        /// </summary>
        [JsonProperty("redemptionInstructions")]
        public string RedemptionInstructions 
        { 
            get 
            {
                return this.redemptionInstructions; 
            } 
            set 
            {
                this.redemptionInstructions = value;
                onPropertyChanged("RedemptionInstructions");
            }
        }
    }
} 