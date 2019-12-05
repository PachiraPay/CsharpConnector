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
    /// PaymentSessionRequest
    /// </summary>
    [DataContract]
    public partial class PaymentSessionRequest :  IEquatable<PaymentSessionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSessionRequest" /> class.
        /// </summary>
        /// <param name="merchantId">MerchantId.</param>
        /// <param name="merchantSiteId">MerchantSiteId.</param>
        /// <param name="customer">customer.</param>
        /// <param name="orderData">orderData.</param>
        /// <param name="storedCardData">StoredCardData.</param>
        /// <param name="allowCardStorage">Gets or sets a value indicating whether [allow card storage]..</param>
        /// <param name="forcedCardOptionRef">Gets or sets a value indicating whether [forced card option reference]..</param>
        /// <param name="forceCardStorage">Gets or sets a value indicating whether [forced card storage]..</param>
        /// <param name="forceImmediateStoredCardPayment">Gets or sets a value indicating whether [forced immediate stored card]..</param>
        /// <param name="configuration">configuration.</param>
        public PaymentSessionRequest(int? merchantId = default(int?), string merchantSiteId = default(string), Customer customer = default(Customer), OrderData orderData = default(OrderData), List<StoredCard> storedCardData = default(List<StoredCard>), bool? allowCardStorage = default(bool?), string forcedCardOptionRef = default(string), bool? forceCardStorage = default(bool?), bool? forceImmediateStoredCardPayment = default(bool?), Configuration configuration = default(Configuration))
        {
            this.MerchantId = merchantId;
            this.MerchantSiteId = merchantSiteId;
            this.Customer = customer;
            this.OrderData = orderData;
            this.StoredCardData = storedCardData;
            this.AllowCardStorage = allowCardStorage;
            this.ForcedCardOptionRef = forcedCardOptionRef;
            this.ForceCardStorage = forceCardStorage;
            this.ForceImmediateStoredCardPayment = forceImmediateStoredCardPayment;
            this.Configuration = configuration;
        }
        
        /// <summary>
        /// MerchantId
        /// </summary>
        /// <value>MerchantId</value>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// MerchantSiteId
        /// </summary>
        /// <value>MerchantSiteId</value>
        [DataMember(Name="merchantSiteId", EmitDefaultValue=false)]
        public string MerchantSiteId { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or Sets OrderData
        /// </summary>
        [DataMember(Name="orderData", EmitDefaultValue=false)]
        public OrderData OrderData { get; set; }

        /// <summary>
        /// StoredCardData
        /// </summary>
        /// <value>StoredCardData</value>
        [DataMember(Name="storedCardData", EmitDefaultValue=false)]
        public List<StoredCard> StoredCardData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow card storage].
        /// </summary>
        /// <value>Gets or sets a value indicating whether [allow card storage].</value>
        [DataMember(Name="allowCardStorage", EmitDefaultValue=false)]
        public bool? AllowCardStorage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [forced card option reference].
        /// </summary>
        /// <value>Gets or sets a value indicating whether [forced card option reference].</value>
        [DataMember(Name="forcedCardOptionRef", EmitDefaultValue=false)]
        public string ForcedCardOptionRef { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [forced card storage].
        /// </summary>
        /// <value>Gets or sets a value indicating whether [forced card storage].</value>
        [DataMember(Name="forceCardStorage", EmitDefaultValue=false)]
        public bool? ForceCardStorage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [forced immediate stored card].
        /// </summary>
        /// <value>Gets or sets a value indicating whether [forced immediate stored card].</value>
        [DataMember(Name="forceImmediateStoredCardPayment", EmitDefaultValue=false)]
        public bool? ForceImmediateStoredCardPayment { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSessionRequest {\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantSiteId: ").Append(MerchantSiteId).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  OrderData: ").Append(OrderData).Append("\n");
            sb.Append("  StoredCardData: ").Append(StoredCardData).Append("\n");
            sb.Append("  AllowCardStorage: ").Append(AllowCardStorage).Append("\n");
            sb.Append("  ForcedCardOptionRef: ").Append(ForcedCardOptionRef).Append("\n");
            sb.Append("  ForceCardStorage: ").Append(ForceCardStorage).Append("\n");
            sb.Append("  ForceImmediateStoredCardPayment: ").Append(ForceImmediateStoredCardPayment).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
            return this.Equals(input as PaymentSessionRequest);
        }

        /// <summary>
        /// Returns true if PaymentSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSessionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantSiteId == input.MerchantSiteId ||
                    (this.MerchantSiteId != null &&
                    this.MerchantSiteId.Equals(input.MerchantSiteId))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.OrderData == input.OrderData ||
                    (this.OrderData != null &&
                    this.OrderData.Equals(input.OrderData))
                ) && 
                (
                    this.StoredCardData == input.StoredCardData ||
                    this.StoredCardData != null &&
                    input.StoredCardData != null &&
                    this.StoredCardData.SequenceEqual(input.StoredCardData)
                ) && 
                (
                    this.AllowCardStorage == input.AllowCardStorage ||
                    (this.AllowCardStorage != null &&
                    this.AllowCardStorage.Equals(input.AllowCardStorage))
                ) && 
                (
                    this.ForcedCardOptionRef == input.ForcedCardOptionRef ||
                    (this.ForcedCardOptionRef != null &&
                    this.ForcedCardOptionRef.Equals(input.ForcedCardOptionRef))
                ) && 
                (
                    this.ForceCardStorage == input.ForceCardStorage ||
                    (this.ForceCardStorage != null &&
                    this.ForceCardStorage.Equals(input.ForceCardStorage))
                ) && 
                (
                    this.ForceImmediateStoredCardPayment == input.ForceImmediateStoredCardPayment ||
                    (this.ForceImmediateStoredCardPayment != null &&
                    this.ForceImmediateStoredCardPayment.Equals(input.ForceImmediateStoredCardPayment))
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
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
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.MerchantSiteId != null)
                    hashCode = hashCode * 59 + this.MerchantSiteId.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.OrderData != null)
                    hashCode = hashCode * 59 + this.OrderData.GetHashCode();
                if (this.StoredCardData != null)
                    hashCode = hashCode * 59 + this.StoredCardData.GetHashCode();
                if (this.AllowCardStorage != null)
                    hashCode = hashCode * 59 + this.AllowCardStorage.GetHashCode();
                if (this.ForcedCardOptionRef != null)
                    hashCode = hashCode * 59 + this.ForcedCardOptionRef.GetHashCode();
                if (this.ForceCardStorage != null)
                    hashCode = hashCode * 59 + this.ForceCardStorage.GetHashCode();
                if (this.ForceImmediateStoredCardPayment != null)
                    hashCode = hashCode * 59 + this.ForceImmediateStoredCardPayment.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                return hashCode;
            }
        }
    }

}
