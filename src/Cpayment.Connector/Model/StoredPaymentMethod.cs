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
    /// StoredPaymentMethod
    /// </summary>
    [DataContract]
    public partial class StoredPaymentMethod :  IEquatable<StoredPaymentMethod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethod" /> class.
        /// </summary>
        /// <param name="lastTransactionDate">The last transaction date associated.</param>
        /// <param name="paymentMethodExpirationDate">The expiration date.</param>
        /// <param name="holderBirthDate">The holder birth date.</param>
        /// <param name="methodSubtype">The payment method subtype.</param>
        /// <param name="methodType">The payment method type.</param>
        /// <param name="customerRef">The customer ref.</param>
        /// <param name="paymentMethodRef">The payment method ref.</param>
        /// <param name="storedPaymentMethodId">The stored payment method identifier.</param>
        /// <param name="truncatedPaymentMethodNumber">The truncated payment method number.</param>
        /// <param name="label">The Label.</param>
        public StoredPaymentMethod(DateTime? lastTransactionDate = default(DateTime?), DateTime? paymentMethodExpirationDate = default(DateTime?), DateTime? holderBirthDate = default(DateTime?), string methodSubtype = default(string), string methodType = default(string), string customerRef = default(string), string paymentMethodRef = default(string), string storedPaymentMethodId = default(string), string truncatedPaymentMethodNumber = default(string), string label = default(string))
        {
            this.LastTransactionDate = lastTransactionDate;
            this.PaymentMethodExpirationDate = paymentMethodExpirationDate;
            this.HolderBirthDate = holderBirthDate;
            this.MethodSubtype = methodSubtype;
            this.MethodType = methodType;
            this.CustomerRef = customerRef;
            this.PaymentMethodRef = paymentMethodRef;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.TruncatedPaymentMethodNumber = truncatedPaymentMethodNumber;
            this.Label = label;
        }
        
        /// <summary>
        /// The last transaction date associated
        /// </summary>
        /// <value>The last transaction date associated</value>
        [DataMember(Name="lastTransactionDate", EmitDefaultValue=false)]
        public DateTime? LastTransactionDate { get; set; }

        /// <summary>
        /// The expiration date
        /// </summary>
        /// <value>The expiration date</value>
        [DataMember(Name="paymentMethodExpirationDate", EmitDefaultValue=false)]
        public DateTime? PaymentMethodExpirationDate { get; set; }

        /// <summary>
        /// The holder birth date
        /// </summary>
        /// <value>The holder birth date</value>
        [DataMember(Name="holderBirthDate", EmitDefaultValue=false)]
        public DateTime? HolderBirthDate { get; set; }

        /// <summary>
        /// The payment method subtype
        /// </summary>
        /// <value>The payment method subtype</value>
        [DataMember(Name="methodSubtype", EmitDefaultValue=false)]
        public string MethodSubtype { get; set; }

        /// <summary>
        /// The payment method type
        /// </summary>
        /// <value>The payment method type</value>
        [DataMember(Name="methodType", EmitDefaultValue=false)]
        public string MethodType { get; set; }

        /// <summary>
        /// The customer ref
        /// </summary>
        /// <value>The customer ref</value>
        [DataMember(Name="customerRef", EmitDefaultValue=false)]
        public string CustomerRef { get; set; }

        /// <summary>
        /// The payment method ref
        /// </summary>
        /// <value>The payment method ref</value>
        [DataMember(Name="paymentMethodRef", EmitDefaultValue=false)]
        public string PaymentMethodRef { get; set; }

        /// <summary>
        /// The stored payment method identifier
        /// </summary>
        /// <value>The stored payment method identifier</value>
        [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// The truncated payment method number
        /// </summary>
        /// <value>The truncated payment method number</value>
        [DataMember(Name="truncatedPaymentMethodNumber", EmitDefaultValue=false)]
        public string TruncatedPaymentMethodNumber { get; set; }

        /// <summary>
        /// The Label
        /// </summary>
        /// <value>The Label</value>
        [DataMember(Name="Label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredPaymentMethod {\n");
            sb.Append("  LastTransactionDate: ").Append(LastTransactionDate).Append("\n");
            sb.Append("  PaymentMethodExpirationDate: ").Append(PaymentMethodExpirationDate).Append("\n");
            sb.Append("  HolderBirthDate: ").Append(HolderBirthDate).Append("\n");
            sb.Append("  MethodSubtype: ").Append(MethodSubtype).Append("\n");
            sb.Append("  MethodType: ").Append(MethodType).Append("\n");
            sb.Append("  CustomerRef: ").Append(CustomerRef).Append("\n");
            sb.Append("  PaymentMethodRef: ").Append(PaymentMethodRef).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  TruncatedPaymentMethodNumber: ").Append(TruncatedPaymentMethodNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as StoredPaymentMethod);
        }

        /// <summary>
        /// Returns true if StoredPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredPaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastTransactionDate == input.LastTransactionDate ||
                    (this.LastTransactionDate != null &&
                    this.LastTransactionDate.Equals(input.LastTransactionDate))
                ) && 
                (
                    this.PaymentMethodExpirationDate == input.PaymentMethodExpirationDate ||
                    (this.PaymentMethodExpirationDate != null &&
                    this.PaymentMethodExpirationDate.Equals(input.PaymentMethodExpirationDate))
                ) && 
                (
                    this.HolderBirthDate == input.HolderBirthDate ||
                    (this.HolderBirthDate != null &&
                    this.HolderBirthDate.Equals(input.HolderBirthDate))
                ) && 
                (
                    this.MethodSubtype == input.MethodSubtype ||
                    (this.MethodSubtype != null &&
                    this.MethodSubtype.Equals(input.MethodSubtype))
                ) && 
                (
                    this.MethodType == input.MethodType ||
                    (this.MethodType != null &&
                    this.MethodType.Equals(input.MethodType))
                ) && 
                (
                    this.CustomerRef == input.CustomerRef ||
                    (this.CustomerRef != null &&
                    this.CustomerRef.Equals(input.CustomerRef))
                ) && 
                (
                    this.PaymentMethodRef == input.PaymentMethodRef ||
                    (this.PaymentMethodRef != null &&
                    this.PaymentMethodRef.Equals(input.PaymentMethodRef))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) && 
                (
                    this.TruncatedPaymentMethodNumber == input.TruncatedPaymentMethodNumber ||
                    (this.TruncatedPaymentMethodNumber != null &&
                    this.TruncatedPaymentMethodNumber.Equals(input.TruncatedPaymentMethodNumber))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.LastTransactionDate != null)
                    hashCode = hashCode * 59 + this.LastTransactionDate.GetHashCode();
                if (this.PaymentMethodExpirationDate != null)
                    hashCode = hashCode * 59 + this.PaymentMethodExpirationDate.GetHashCode();
                if (this.HolderBirthDate != null)
                    hashCode = hashCode * 59 + this.HolderBirthDate.GetHashCode();
                if (this.MethodSubtype != null)
                    hashCode = hashCode * 59 + this.MethodSubtype.GetHashCode();
                if (this.MethodType != null)
                    hashCode = hashCode * 59 + this.MethodType.GetHashCode();
                if (this.CustomerRef != null)
                    hashCode = hashCode * 59 + this.CustomerRef.GetHashCode();
                if (this.PaymentMethodRef != null)
                    hashCode = hashCode * 59 + this.PaymentMethodRef.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                if (this.TruncatedPaymentMethodNumber != null)
                    hashCode = hashCode * 59 + this.TruncatedPaymentMethodNumber.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }

}
