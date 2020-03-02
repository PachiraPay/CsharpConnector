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
using OpenAPIDateConverter = pachirapay.Connector.Client.OpenAPIDateConverter;

namespace pachirapay.Connector.Model
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
        [JsonConstructorAttribute]
        protected PaymentSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSessionRequest" /> class.
        /// </summary>
        /// <param name="merchantId">Your merchant identifier. (required).</param>
        /// <param name="merchantSiteId">Your merchant site identifier. It can very if you have separate website for phone and desktop for example. (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="orderData">orderData (required).</param>
        /// <param name="storedCardData">The stored payment methods that you want to display to the customer..</param>
        /// <param name="allowCardStorage">Specify if you allow the customer to save his payment method.   By default, the customer will have the choice (save my card : yes/no).   If you want to force the storage (without asking the customer), you can specify the field *forceCardStorage* to *TRUE*.</param>
        /// <param name="forcedCardOptionRef">This field should only be used in case of an immediate stored payment card payment (available only for non-3DS flow).   And it is only needed for specifics payment methods (credit cards like Cofinoga, or Cetelem), which allows a card option (debit, credit, 3x, 4x, 5x, ...).  For most of card types (VISA, MasterCard, CB), you don&#39;t have to specify anything..</param>
        /// <param name="forceCardStorage">In a card storage scenario (*allowCardStorage* set to *TRUE*), setting this field to *TRUE* will disable the customer choice (card will always be stored).</param>
        /// <param name="forceImmediateStoredCardPayment">If set to *TRUE*, the payment form will be skipped and the payment will start immediately using the first stored payment method from *storedCardData* field.   This is available only for non-3DS flow, and need at least one valid stored payment method..</param>
        /// <param name="configuration">configuration (required).</param>
        public PaymentSessionRequest(int? merchantId = default(int?), string merchantSiteId = default(string), Customer customer = default(Customer), OrderData orderData = default(OrderData), List<StoredCard> storedCardData = default(List<StoredCard>), bool? allowCardStorage = default(bool?), string forcedCardOptionRef = default(string), bool? forceCardStorage = default(bool?), bool? forceImmediateStoredCardPayment = default(bool?), Configuration configuration = default(Configuration))
        {
            // to ensure "merchantId" is required (not null)
            if (merchantId == null)
            {
                throw new InvalidDataException("merchantId is a required property for PaymentSessionRequest and cannot be null");
            }
            else
            {
                this.MerchantId = merchantId;
            }
            
            // to ensure "merchantSiteId" is required (not null)
            if (merchantSiteId == null)
            {
                throw new InvalidDataException("merchantSiteId is a required property for PaymentSessionRequest and cannot be null");
            }
            else
            {
                this.MerchantSiteId = merchantSiteId;
            }
            
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for PaymentSessionRequest and cannot be null");
            }
            else
            {
                this.Customer = customer;
            }
            
            // to ensure "orderData" is required (not null)
            if (orderData == null)
            {
                throw new InvalidDataException("orderData is a required property for PaymentSessionRequest and cannot be null");
            }
            else
            {
                this.OrderData = orderData;
            }
            
            // to ensure "configuration" is required (not null)
            if (configuration == null)
            {
                throw new InvalidDataException("configuration is a required property for PaymentSessionRequest and cannot be null");
            }
            else
            {
                this.Configuration = configuration;
            }
            
            this.StoredCardData = storedCardData;
            this.AllowCardStorage = allowCardStorage;
            this.ForcedCardOptionRef = forcedCardOptionRef;
            this.ForceCardStorage = forceCardStorage;
            this.ForceImmediateStoredCardPayment = forceImmediateStoredCardPayment;
        }
        
        /// <summary>
        /// Your merchant identifier.
        /// </summary>
        /// <value>Your merchant identifier.</value>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// Your merchant site identifier. It can very if you have separate website for phone and desktop for example.
        /// </summary>
        /// <value>Your merchant site identifier. It can very if you have separate website for phone and desktop for example.</value>
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
        /// The stored payment methods that you want to display to the customer.
        /// </summary>
        /// <value>The stored payment methods that you want to display to the customer.</value>
        [DataMember(Name="storedCardData", EmitDefaultValue=false)]
        public List<StoredCard> StoredCardData { get; set; }

        /// <summary>
        /// Specify if you allow the customer to save his payment method.   By default, the customer will have the choice (save my card : yes/no).   If you want to force the storage (without asking the customer), you can specify the field *forceCardStorage* to *TRUE*
        /// </summary>
        /// <value>Specify if you allow the customer to save his payment method.   By default, the customer will have the choice (save my card : yes/no).   If you want to force the storage (without asking the customer), you can specify the field *forceCardStorage* to *TRUE*</value>
        [DataMember(Name="allowCardStorage", EmitDefaultValue=false)]
        public bool? AllowCardStorage { get; set; }

        /// <summary>
        /// This field should only be used in case of an immediate stored payment card payment (available only for non-3DS flow).   And it is only needed for specifics payment methods (credit cards like Cofinoga, or Cetelem), which allows a card option (debit, credit, 3x, 4x, 5x, ...).  For most of card types (VISA, MasterCard, CB), you don&#39;t have to specify anything.
        /// </summary>
        /// <value>This field should only be used in case of an immediate stored payment card payment (available only for non-3DS flow).   And it is only needed for specifics payment methods (credit cards like Cofinoga, or Cetelem), which allows a card option (debit, credit, 3x, 4x, 5x, ...).  For most of card types (VISA, MasterCard, CB), you don&#39;t have to specify anything.</value>
        [DataMember(Name="forcedCardOptionRef", EmitDefaultValue=false)]
        public string ForcedCardOptionRef { get; set; }

        /// <summary>
        /// In a card storage scenario (*allowCardStorage* set to *TRUE*), setting this field to *TRUE* will disable the customer choice (card will always be stored)
        /// </summary>
        /// <value>In a card storage scenario (*allowCardStorage* set to *TRUE*), setting this field to *TRUE* will disable the customer choice (card will always be stored)</value>
        [DataMember(Name="forceCardStorage", EmitDefaultValue=false)]
        public bool? ForceCardStorage { get; set; }

        /// <summary>
        /// If set to *TRUE*, the payment form will be skipped and the payment will start immediately using the first stored payment method from *storedCardData* field.   This is available only for non-3DS flow, and need at least one valid stored payment method.
        /// </summary>
        /// <value>If set to *TRUE*, the payment form will be skipped and the payment will start immediately using the first stored payment method from *storedCardData* field.   This is available only for non-3DS flow, and need at least one valid stored payment method.</value>
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