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
    /// All payment option data
    /// </summary>
    [DataContract]
    public partial class PaymentOption :  IEquatable<PaymentOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentOption" /> class.
        /// </summary>
        /// <param name="paymentOptionRef">The payment option reference.</param>
        /// <param name="name">The payment option name.</param>
        /// <param name="active">Indicates if the payment option is active or not.</param>
        /// <param name="minAmount">The minimum amount allowed.</param>
        /// <param name="maxAmount">The maximum amount allowed.</param>
        /// <param name="storedCardsEnabled">Indicates if stored cards are enabled or not.</param>
        /// <param name="paymentScheduleRules">All payment schedule rules data.</param>
        /// <param name="paymentFees">All payment fees data.</param>
        /// <param name="paymentCards">All payment cards data.</param>
        /// <param name="loanOffers">All loan offers data.</param>
        /// <param name="acquiringBanks">All acquiring banks data.</param>
        public PaymentOption(string paymentOptionRef = default(string), string name = default(string), bool? active = default(bool?), long? minAmount = default(long?), long? maxAmount = default(long?), bool? storedCardsEnabled = default(bool?), List<PaymentScheduleRule> paymentScheduleRules = default(List<PaymentScheduleRule>), List<PaymentFee> paymentFees = default(List<PaymentFee>), List<PaymentCard> paymentCards = default(List<PaymentCard>), List<LoanOffer> loanOffers = default(List<LoanOffer>), List<AcquiringBank> acquiringBanks = default(List<AcquiringBank>))
        {
            this.PaymentOptionRef = paymentOptionRef;
            this.Name = name;
            this.Active = active;
            this.MinAmount = minAmount;
            this.MaxAmount = maxAmount;
            this.StoredCardsEnabled = storedCardsEnabled;
            this.PaymentScheduleRules = paymentScheduleRules;
            this.PaymentFees = paymentFees;
            this.PaymentCards = paymentCards;
            this.LoanOffers = loanOffers;
            this.AcquiringBanks = acquiringBanks;
        }
        
        /// <summary>
        /// The payment option reference
        /// </summary>
        /// <value>The payment option reference</value>
        [DataMember(Name="paymentOptionRef", EmitDefaultValue=false)]
        public string PaymentOptionRef { get; set; }

        /// <summary>
        /// The payment option name
        /// </summary>
        /// <value>The payment option name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the payment option is active or not
        /// </summary>
        /// <value>Indicates if the payment option is active or not</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The minimum amount allowed
        /// </summary>
        /// <value>The minimum amount allowed</value>
        [DataMember(Name="minAmount", EmitDefaultValue=false)]
        public long? MinAmount { get; set; }

        /// <summary>
        /// The maximum amount allowed
        /// </summary>
        /// <value>The maximum amount allowed</value>
        [DataMember(Name="maxAmount", EmitDefaultValue=false)]
        public long? MaxAmount { get; set; }

        /// <summary>
        /// Indicates if stored cards are enabled or not
        /// </summary>
        /// <value>Indicates if stored cards are enabled or not</value>
        [DataMember(Name="storedCardsEnabled", EmitDefaultValue=false)]
        public bool? StoredCardsEnabled { get; set; }

        /// <summary>
        /// All payment schedule rules data
        /// </summary>
        /// <value>All payment schedule rules data</value>
        [DataMember(Name="paymentScheduleRules", EmitDefaultValue=false)]
        public List<PaymentScheduleRule> PaymentScheduleRules { get; set; }

        /// <summary>
        /// All payment fees data
        /// </summary>
        /// <value>All payment fees data</value>
        [DataMember(Name="paymentFees", EmitDefaultValue=false)]
        public List<PaymentFee> PaymentFees { get; set; }

        /// <summary>
        /// All payment cards data
        /// </summary>
        /// <value>All payment cards data</value>
        [DataMember(Name="paymentCards", EmitDefaultValue=false)]
        public List<PaymentCard> PaymentCards { get; set; }

        /// <summary>
        /// All loan offers data
        /// </summary>
        /// <value>All loan offers data</value>
        [DataMember(Name="loanOffers", EmitDefaultValue=false)]
        public List<LoanOffer> LoanOffers { get; set; }

        /// <summary>
        /// All acquiring banks data
        /// </summary>
        /// <value>All acquiring banks data</value>
        [DataMember(Name="acquiringBanks", EmitDefaultValue=false)]
        public List<AcquiringBank> AcquiringBanks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentOption {\n");
            sb.Append("  PaymentOptionRef: ").Append(PaymentOptionRef).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  StoredCardsEnabled: ").Append(StoredCardsEnabled).Append("\n");
            sb.Append("  PaymentScheduleRules: ").Append(PaymentScheduleRules).Append("\n");
            sb.Append("  PaymentFees: ").Append(PaymentFees).Append("\n");
            sb.Append("  PaymentCards: ").Append(PaymentCards).Append("\n");
            sb.Append("  LoanOffers: ").Append(LoanOffers).Append("\n");
            sb.Append("  AcquiringBanks: ").Append(AcquiringBanks).Append("\n");
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
            return this.Equals(input as PaymentOption);
        }

        /// <summary>
        /// Returns true if PaymentOption instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentOptionRef == input.PaymentOptionRef ||
                    (this.PaymentOptionRef != null &&
                    this.PaymentOptionRef.Equals(input.PaymentOptionRef))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.MinAmount == input.MinAmount ||
                    (this.MinAmount != null &&
                    this.MinAmount.Equals(input.MinAmount))
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
                ) && 
                (
                    this.StoredCardsEnabled == input.StoredCardsEnabled ||
                    (this.StoredCardsEnabled != null &&
                    this.StoredCardsEnabled.Equals(input.StoredCardsEnabled))
                ) && 
                (
                    this.PaymentScheduleRules == input.PaymentScheduleRules ||
                    this.PaymentScheduleRules != null &&
                    input.PaymentScheduleRules != null &&
                    this.PaymentScheduleRules.SequenceEqual(input.PaymentScheduleRules)
                ) && 
                (
                    this.PaymentFees == input.PaymentFees ||
                    this.PaymentFees != null &&
                    input.PaymentFees != null &&
                    this.PaymentFees.SequenceEqual(input.PaymentFees)
                ) && 
                (
                    this.PaymentCards == input.PaymentCards ||
                    this.PaymentCards != null &&
                    input.PaymentCards != null &&
                    this.PaymentCards.SequenceEqual(input.PaymentCards)
                ) && 
                (
                    this.LoanOffers == input.LoanOffers ||
                    this.LoanOffers != null &&
                    input.LoanOffers != null &&
                    this.LoanOffers.SequenceEqual(input.LoanOffers)
                ) && 
                (
                    this.AcquiringBanks == input.AcquiringBanks ||
                    this.AcquiringBanks != null &&
                    input.AcquiringBanks != null &&
                    this.AcquiringBanks.SequenceEqual(input.AcquiringBanks)
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
                if (this.PaymentOptionRef != null)
                    hashCode = hashCode * 59 + this.PaymentOptionRef.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.MinAmount != null)
                    hashCode = hashCode * 59 + this.MinAmount.GetHashCode();
                if (this.MaxAmount != null)
                    hashCode = hashCode * 59 + this.MaxAmount.GetHashCode();
                if (this.StoredCardsEnabled != null)
                    hashCode = hashCode * 59 + this.StoredCardsEnabled.GetHashCode();
                if (this.PaymentScheduleRules != null)
                    hashCode = hashCode * 59 + this.PaymentScheduleRules.GetHashCode();
                if (this.PaymentFees != null)
                    hashCode = hashCode * 59 + this.PaymentFees.GetHashCode();
                if (this.PaymentCards != null)
                    hashCode = hashCode * 59 + this.PaymentCards.GetHashCode();
                if (this.LoanOffers != null)
                    hashCode = hashCode * 59 + this.LoanOffers.GetHashCode();
                if (this.AcquiringBanks != null)
                    hashCode = hashCode * 59 + this.AcquiringBanks.GetHashCode();
                return hashCode;
            }
        }
    }

}