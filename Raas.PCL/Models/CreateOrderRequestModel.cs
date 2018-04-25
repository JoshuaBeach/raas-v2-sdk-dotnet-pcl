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
    public class CreateOrderRequestModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountIdentifier;
        private double amount;
        private string customerIdentifier;
        private bool sendEmail;
        private string utid;
        private string campaign;
        private string emailSubject;
        private string externalRefID;
        private string message;
        private Models.NameEmailModel recipient;
        private Models.NameEmailModel sender;
        private string notes;
        private string etid;

        /// <summary>
        /// The account identifier
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
        /// The order amount
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
        /// The customer identifier
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
        /// Indicates whether we should deliver this reward via email
        /// </summary>
        [JsonProperty("sendEmail")]
        public bool SendEmail 
        { 
            get 
            {
                return this.sendEmail; 
            } 
            set 
            {
                this.sendEmail = value;
                onPropertyChanged("SendEmail");
            }
        }

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
        /// An optional campaign identifier
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign 
        { 
            get 
            {
                return this.campaign; 
            } 
            set 
            {
                this.campaign = value;
                onPropertyChanged("Campaign");
            }
        }

        /// <summary>
        /// The subject of the gift email
        /// </summary>
        [JsonProperty("emailSubject")]
        public string EmailSubject 
        { 
            get 
            {
                return this.emailSubject; 
            } 
            set 
            {
                this.emailSubject = value;
                onPropertyChanged("EmailSubject");
            }
        }

        /// <summary>
        /// An optional external reference id
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
        /// The gift message in the email
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// The recipient's information
        /// </summary>
        [JsonProperty("recipient")]
        public Models.NameEmailModel Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// Optional sender information
        /// </summary>
        [JsonProperty("sender")]
        public Models.NameEmailModel Sender 
        { 
            get 
            {
                return this.sender; 
            } 
            set 
            {
                this.sender = value;
                onPropertyChanged("Sender");
            }
        }

        /// <summary>
        /// Optional notes (not displayed to customer)
        /// </summary>
        [JsonProperty("notes")]
        public string Notes 
        { 
            get 
            {
                return this.notes; 
            } 
            set 
            {
                this.notes = value;
                onPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// The email template identifier
        /// </summary>
        [JsonProperty("etid")]
        public string Etid 
        { 
            get 
            {
                return this.etid; 
            } 
            set 
            {
                this.etid = value;
                onPropertyChanged("Etid");
            }
        }
    }
} 