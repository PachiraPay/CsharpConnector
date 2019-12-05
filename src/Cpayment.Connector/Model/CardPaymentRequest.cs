/* 
 * Payment Gateway
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Cpayment.Connector.Client.OpenAPIDateConverter;

namespace Cpayment.Connector.Model
{
    /// <summary>
    /// CardPaymentRequest
    /// </summary>
    [DataContract]
    public partial class CardPaymentRequest :  IEquatable<CardPaymentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardPaymentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardPaymentRequest" /> class.
        /// </summary>
        /// <param name="context">context (required).</param>
        /// <param name="options">options.</param>
        /// <param name="order">order (required).</param>
        /// <param name="card">card.</param>
        /// <param name="storedCard">storedCard.</param>
        /// <param name="validationMode">validationMode.</param>
        /// <param name="notificationUrl">Url for the notification of the payment.</param>
        public CardPaymentRequest(CardPaymentContextData context = default(CardPaymentContextData), Options options = default(Options), Order order = default(Order), CardData card = default(CardData), StoredCard storedCard = default(StoredCard), ValidationModeOverride validationMode = default(ValidationModeOverride), string notificationUrl = default(string))
        {
            // to ensure "context" is required (not null)
            if (context == null)
            {
                throw new InvalidDataException("context is a required property for CardPaymentRequest and cannot be null");
            }
            else
            {
                this.Context = context;
            }
            
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for CardPaymentRequest and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            
            this.Options = options;
            this.Card = card;
            this.StoredCard = storedCard;
            this.ValidationMode = validationMode;
            this.NotificationUrl = notificationUrl;
        }
        
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public CardPaymentContextData Context { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Options Options { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public Order Order { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public CardData Card { get; set; }

        /// <summary>
        /// Gets or Sets StoredCard
        /// </summary>
        [DataMember(Name="storedCard", EmitDefaultValue=false)]
        public StoredCard StoredCard { get; set; }

        /// <summary>
        /// Gets or Sets ValidationMode
        /// </summary>
        [DataMember(Name="validationMode", EmitDefaultValue=false)]
        public ValidationModeOverride ValidationMode { get; set; }

        /// <summary>
        /// Url for the notification of the payment
        /// </summary>
        /// <value>Url for the notification of the payment</value>
        [DataMember(Name="notificationUrl", EmitDefaultValue=false)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardPaymentRequest {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  StoredCard: ").Append(StoredCard).Append("\n");
            sb.Append("  ValidationMode: ").Append(ValidationMode).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CardPaymentRequest);
        }

        /// <summary>
        /// Returns true if CardPaymentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CardPaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardPaymentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.StoredCard == input.StoredCard ||
                    (this.StoredCard != null &&
                    this.StoredCard.Equals(input.StoredCard))
                ) && 
                (
                    this.ValidationMode == input.ValidationMode ||
                    (this.ValidationMode != null &&
                    this.ValidationMode.Equals(input.ValidationMode))
                ) && 
                (
                    this.NotificationUrl == input.NotificationUrl ||
                    (this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(input.NotificationUrl))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                if (this.StoredCard != null)
                    hashCode = hashCode * 59 + this.StoredCard.GetHashCode();
                if (this.ValidationMode != null)
                    hashCode = hashCode * 59 + this.ValidationMode.GetHashCode();
                if (this.NotificationUrl != null)
                    hashCode = hashCode * 59 + this.NotificationUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
