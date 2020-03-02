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
    /// All payment card option data
    /// </summary>
    [DataContract]
    public partial class PaymentCardOption :  IEquatable<PaymentCardOption>
    {
        /// <summary>
        /// The postponement lenght type
        /// </summary>
        /// <value>The postponement lenght type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PostponementDelayUnitEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Day for value: day
            /// </summary>
            [EnumMember(Value = "day")]
            Day = 2,

            /// <summary>
            /// Enum Week for value: week
            /// </summary>
            [EnumMember(Value = "week")]
            Week = 3,

            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 4,

            /// <summary>
            /// Enum Year for value: year
            /// </summary>
            [EnumMember(Value = "year")]
            Year = 5

        }

        /// <summary>
        /// The postponement lenght type
        /// </summary>
        /// <value>The postponement lenght type</value>
        [DataMember(Name="postponementDelayUnit", EmitDefaultValue=false)]
        public PostponementDelayUnitEnum? PostponementDelayUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardOption" /> class.
        /// </summary>
        /// <param name="paymentCardOptionRef">The payment card option reference.</param>
        /// <param name="name">The payment card option name.</param>
        /// <param name="minAmount">The minimum amount allowed.</param>
        /// <param name="maxAmount">The maximum amount allowed.</param>
        /// <param name="totalBillingCycles">The total billing cycles.</param>
        /// <param name="effectiveRate">The effective rate.</param>
        /// <param name="cardOptionGroupName">The card option group name.</param>
        /// <param name="cardOptionGroupId">The card option group identifier.</param>
        /// <param name="cardOptionGroupPosition">The card option group position.</param>
        /// <param name="postponementDelayUnit">The postponement lenght type.</param>
        /// <param name="postponementDelay">The postponement lenght.</param>
        public PaymentCardOption(string paymentCardOptionRef = default(string), string name = default(string), long? minAmount = default(long?), long? maxAmount = default(long?), int? totalBillingCycles = default(int?), int? effectiveRate = default(int?), string cardOptionGroupName = default(string), int? cardOptionGroupId = default(int?), int? cardOptionGroupPosition = default(int?), PostponementDelayUnitEnum? postponementDelayUnit = default(PostponementDelayUnitEnum?), int? postponementDelay = default(int?))
        {
            this.PaymentCardOptionRef = paymentCardOptionRef;
            this.Name = name;
            this.MinAmount = minAmount;
            this.MaxAmount = maxAmount;
            this.TotalBillingCycles = totalBillingCycles;
            this.EffectiveRate = effectiveRate;
            this.CardOptionGroupName = cardOptionGroupName;
            this.CardOptionGroupId = cardOptionGroupId;
            this.CardOptionGroupPosition = cardOptionGroupPosition;
            this.PostponementDelayUnit = postponementDelayUnit;
            this.PostponementDelay = postponementDelay;
        }
        
        /// <summary>
        /// The payment card option reference
        /// </summary>
        /// <value>The payment card option reference</value>
        [DataMember(Name="paymentCardOptionRef", EmitDefaultValue=false)]
        public string PaymentCardOptionRef { get; set; }

        /// <summary>
        /// The payment card option name
        /// </summary>
        /// <value>The payment card option name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// The total billing cycles
        /// </summary>
        /// <value>The total billing cycles</value>
        [DataMember(Name="totalBillingCycles", EmitDefaultValue=false)]
        public int? TotalBillingCycles { get; set; }

        /// <summary>
        /// The effective rate
        /// </summary>
        /// <value>The effective rate</value>
        [DataMember(Name="effectiveRate", EmitDefaultValue=false)]
        public int? EffectiveRate { get; set; }

        /// <summary>
        /// The card option group name
        /// </summary>
        /// <value>The card option group name</value>
        [DataMember(Name="cardOptionGroupName", EmitDefaultValue=false)]
        public string CardOptionGroupName { get; set; }

        /// <summary>
        /// The card option group identifier
        /// </summary>
        /// <value>The card option group identifier</value>
        [DataMember(Name="cardOptionGroupId", EmitDefaultValue=false)]
        public int? CardOptionGroupId { get; set; }

        /// <summary>
        /// The card option group position
        /// </summary>
        /// <value>The card option group position</value>
        [DataMember(Name="cardOptionGroupPosition", EmitDefaultValue=false)]
        public int? CardOptionGroupPosition { get; set; }


        /// <summary>
        /// The postponement lenght
        /// </summary>
        /// <value>The postponement lenght</value>
        [DataMember(Name="postponementDelay", EmitDefaultValue=false)]
        public int? PostponementDelay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardOption {\n");
            sb.Append("  PaymentCardOptionRef: ").Append(PaymentCardOptionRef).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  TotalBillingCycles: ").Append(TotalBillingCycles).Append("\n");
            sb.Append("  EffectiveRate: ").Append(EffectiveRate).Append("\n");
            sb.Append("  CardOptionGroupName: ").Append(CardOptionGroupName).Append("\n");
            sb.Append("  CardOptionGroupId: ").Append(CardOptionGroupId).Append("\n");
            sb.Append("  CardOptionGroupPosition: ").Append(CardOptionGroupPosition).Append("\n");
            sb.Append("  PostponementDelayUnit: ").Append(PostponementDelayUnit).Append("\n");
            sb.Append("  PostponementDelay: ").Append(PostponementDelay).Append("\n");
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
            return this.Equals(input as PaymentCardOption);
        }

        /// <summary>
        /// Returns true if PaymentCardOption instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentCardOptionRef == input.PaymentCardOptionRef ||
                    (this.PaymentCardOptionRef != null &&
                    this.PaymentCardOptionRef.Equals(input.PaymentCardOptionRef))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.TotalBillingCycles == input.TotalBillingCycles ||
                    (this.TotalBillingCycles != null &&
                    this.TotalBillingCycles.Equals(input.TotalBillingCycles))
                ) && 
                (
                    this.EffectiveRate == input.EffectiveRate ||
                    (this.EffectiveRate != null &&
                    this.EffectiveRate.Equals(input.EffectiveRate))
                ) && 
                (
                    this.CardOptionGroupName == input.CardOptionGroupName ||
                    (this.CardOptionGroupName != null &&
                    this.CardOptionGroupName.Equals(input.CardOptionGroupName))
                ) && 
                (
                    this.CardOptionGroupId == input.CardOptionGroupId ||
                    (this.CardOptionGroupId != null &&
                    this.CardOptionGroupId.Equals(input.CardOptionGroupId))
                ) && 
                (
                    this.CardOptionGroupPosition == input.CardOptionGroupPosition ||
                    (this.CardOptionGroupPosition != null &&
                    this.CardOptionGroupPosition.Equals(input.CardOptionGroupPosition))
                ) && 
                (
                    this.PostponementDelayUnit == input.PostponementDelayUnit ||
                    (this.PostponementDelayUnit != null &&
                    this.PostponementDelayUnit.Equals(input.PostponementDelayUnit))
                ) && 
                (
                    this.PostponementDelay == input.PostponementDelay ||
                    (this.PostponementDelay != null &&
                    this.PostponementDelay.Equals(input.PostponementDelay))
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
                if (this.PaymentCardOptionRef != null)
                    hashCode = hashCode * 59 + this.PaymentCardOptionRef.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MinAmount != null)
                    hashCode = hashCode * 59 + this.MinAmount.GetHashCode();
                if (this.MaxAmount != null)
                    hashCode = hashCode * 59 + this.MaxAmount.GetHashCode();
                if (this.TotalBillingCycles != null)
                    hashCode = hashCode * 59 + this.TotalBillingCycles.GetHashCode();
                if (this.EffectiveRate != null)
                    hashCode = hashCode * 59 + this.EffectiveRate.GetHashCode();
                if (this.CardOptionGroupName != null)
                    hashCode = hashCode * 59 + this.CardOptionGroupName.GetHashCode();
                if (this.CardOptionGroupId != null)
                    hashCode = hashCode * 59 + this.CardOptionGroupId.GetHashCode();
                if (this.CardOptionGroupPosition != null)
                    hashCode = hashCode * 59 + this.CardOptionGroupPosition.GetHashCode();
                if (this.PostponementDelayUnit != null)
                    hashCode = hashCode * 59 + this.PostponementDelayUnit.GetHashCode();
                if (this.PostponementDelay != null)
                    hashCode = hashCode * 59 + this.PostponementDelay.GetHashCode();
                return hashCode;
            }
        }
    }

}