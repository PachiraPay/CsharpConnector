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
    /// SubOrder
    /// </summary>
    [DataContract]
    public partial class SubOrder :  IEquatable<SubOrder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubOrder" /> class.
        /// </summary>
        /// <param name="amount">The order&#39;s amount to pay. (required).</param>
        /// <param name="invoiceId">The invoice identifier..</param>
        /// <param name="orderAmountWithoutTax">The order amount without VAT..</param>
        /// <param name="orderRef">The order reference. (required).</param>
        /// <param name="taxAmount">The tax amount.  Optional, useful in case payment without VAT (PRO...).</param>
        public SubOrder(long? amount = default(long?), string invoiceId = default(string), long? orderAmountWithoutTax = default(long?), string orderRef = default(string), long? taxAmount = default(long?))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SubOrder and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            
            // to ensure "orderRef" is required (not null)
            if (orderRef == null)
            {
                throw new InvalidDataException("orderRef is a required property for SubOrder and cannot be null");
            }
            else
            {
                this.OrderRef = orderRef;
            }
            
            this.InvoiceId = invoiceId;
            this.OrderAmountWithoutTax = orderAmountWithoutTax;
            this.TaxAmount = taxAmount;
        }
        
        /// <summary>
        /// The order&#39;s amount to pay.
        /// </summary>
        /// <value>The order&#39;s amount to pay.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// The invoice identifier.
        /// </summary>
        /// <value>The invoice identifier.</value>
        [DataMember(Name="invoiceId", EmitDefaultValue=false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The order amount without VAT.
        /// </summary>
        /// <value>The order amount without VAT.</value>
        [DataMember(Name="orderAmountWithoutTax", EmitDefaultValue=false)]
        public long? OrderAmountWithoutTax { get; set; }

        /// <summary>
        /// The order reference.
        /// </summary>
        /// <value>The order reference.</value>
        [DataMember(Name="orderRef", EmitDefaultValue=false)]
        public string OrderRef { get; set; }

        /// <summary>
        /// The tax amount.  Optional, useful in case payment without VAT (PRO...)
        /// </summary>
        /// <value>The tax amount.  Optional, useful in case payment without VAT (PRO...)</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubOrder {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  OrderAmountWithoutTax: ").Append(OrderAmountWithoutTax).Append("\n");
            sb.Append("  OrderRef: ").Append(OrderRef).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(input as SubOrder);
        }

        /// <summary>
        /// Returns true if SubOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of SubOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.OrderAmountWithoutTax == input.OrderAmountWithoutTax ||
                    (this.OrderAmountWithoutTax != null &&
                    this.OrderAmountWithoutTax.Equals(input.OrderAmountWithoutTax))
                ) && 
                (
                    this.OrderRef == input.OrderRef ||
                    (this.OrderRef != null &&
                    this.OrderRef.Equals(input.OrderRef))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.InvoiceId != null)
                    hashCode = hashCode * 59 + this.InvoiceId.GetHashCode();
                if (this.OrderAmountWithoutTax != null)
                    hashCode = hashCode * 59 + this.OrderAmountWithoutTax.GetHashCode();
                if (this.OrderRef != null)
                    hashCode = hashCode * 59 + this.OrderRef.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                return hashCode;
            }
        }
    }

}
