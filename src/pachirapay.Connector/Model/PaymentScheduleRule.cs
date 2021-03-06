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
    /// All payment schedule data
    /// </summary>
    [DataContract]
    public partial class PaymentScheduleRule :  IEquatable<PaymentScheduleRule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentScheduleRule" /> class.
        /// </summary>
        /// <param name="rank">The rank.</param>
        /// <param name="name">The amount distribution weight.</param>
        /// <param name="dateDelay">The date delay.</param>
        /// <param name="isBondRank">Indicates if the rank is bonded or not.</param>
        /// <param name="thresholdDay">The threshold day.</param>
        /// <param name="firstDueDay">The first due day.</param>
        /// <param name="firstDueMonthDelay">The first due month delay.</param>
        /// <param name="secondDueDay">The second due day.</param>
        /// <param name="secondDueMonthDelay">The second due month delay.</param>
        /// <param name="hasFees">Indicates if the schedule rule has fees or not.</param>
        public PaymentScheduleRule(int? rank = default(int?), int? name = default(int?), int? dateDelay = default(int?), bool? isBondRank = default(bool?), int? thresholdDay = default(int?), int? firstDueDay = default(int?), int? firstDueMonthDelay = default(int?), int? secondDueDay = default(int?), int? secondDueMonthDelay = default(int?), bool? hasFees = default(bool?))
        {
            this.Rank = rank;
            this.Name = name;
            this.DateDelay = dateDelay;
            this.IsBondRank = isBondRank;
            this.ThresholdDay = thresholdDay;
            this.FirstDueDay = firstDueDay;
            this.FirstDueMonthDelay = firstDueMonthDelay;
            this.SecondDueDay = secondDueDay;
            this.SecondDueMonthDelay = secondDueMonthDelay;
            this.HasFees = hasFees;
        }
        
        /// <summary>
        /// The rank
        /// </summary>
        /// <value>The rank</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// The amount distribution weight
        /// </summary>
        /// <value>The amount distribution weight</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public int? Name { get; set; }

        /// <summary>
        /// The date delay
        /// </summary>
        /// <value>The date delay</value>
        [DataMember(Name="dateDelay", EmitDefaultValue=false)]
        public int? DateDelay { get; set; }

        /// <summary>
        /// Indicates if the rank is bonded or not
        /// </summary>
        /// <value>Indicates if the rank is bonded or not</value>
        [DataMember(Name="isBondRank", EmitDefaultValue=false)]
        public bool? IsBondRank { get; set; }

        /// <summary>
        /// The threshold day
        /// </summary>
        /// <value>The threshold day</value>
        [DataMember(Name="thresholdDay", EmitDefaultValue=false)]
        public int? ThresholdDay { get; set; }

        /// <summary>
        /// The first due day
        /// </summary>
        /// <value>The first due day</value>
        [DataMember(Name="firstDueDay", EmitDefaultValue=false)]
        public int? FirstDueDay { get; set; }

        /// <summary>
        /// The first due month delay
        /// </summary>
        /// <value>The first due month delay</value>
        [DataMember(Name="firstDueMonthDelay", EmitDefaultValue=false)]
        public int? FirstDueMonthDelay { get; set; }

        /// <summary>
        /// The second due day
        /// </summary>
        /// <value>The second due day</value>
        [DataMember(Name="secondDueDay", EmitDefaultValue=false)]
        public int? SecondDueDay { get; set; }

        /// <summary>
        /// The second due month delay
        /// </summary>
        /// <value>The second due month delay</value>
        [DataMember(Name="secondDueMonthDelay", EmitDefaultValue=false)]
        public int? SecondDueMonthDelay { get; set; }

        /// <summary>
        /// Indicates if the schedule rule has fees or not
        /// </summary>
        /// <value>Indicates if the schedule rule has fees or not</value>
        [DataMember(Name="hasFees", EmitDefaultValue=false)]
        public bool? HasFees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentScheduleRule {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateDelay: ").Append(DateDelay).Append("\n");
            sb.Append("  IsBondRank: ").Append(IsBondRank).Append("\n");
            sb.Append("  ThresholdDay: ").Append(ThresholdDay).Append("\n");
            sb.Append("  FirstDueDay: ").Append(FirstDueDay).Append("\n");
            sb.Append("  FirstDueMonthDelay: ").Append(FirstDueMonthDelay).Append("\n");
            sb.Append("  SecondDueDay: ").Append(SecondDueDay).Append("\n");
            sb.Append("  SecondDueMonthDelay: ").Append(SecondDueMonthDelay).Append("\n");
            sb.Append("  HasFees: ").Append(HasFees).Append("\n");
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
            return this.Equals(input as PaymentScheduleRule);
        }

        /// <summary>
        /// Returns true if PaymentScheduleRule instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentScheduleRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentScheduleRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DateDelay == input.DateDelay ||
                    (this.DateDelay != null &&
                    this.DateDelay.Equals(input.DateDelay))
                ) && 
                (
                    this.IsBondRank == input.IsBondRank ||
                    (this.IsBondRank != null &&
                    this.IsBondRank.Equals(input.IsBondRank))
                ) && 
                (
                    this.ThresholdDay == input.ThresholdDay ||
                    (this.ThresholdDay != null &&
                    this.ThresholdDay.Equals(input.ThresholdDay))
                ) && 
                (
                    this.FirstDueDay == input.FirstDueDay ||
                    (this.FirstDueDay != null &&
                    this.FirstDueDay.Equals(input.FirstDueDay))
                ) && 
                (
                    this.FirstDueMonthDelay == input.FirstDueMonthDelay ||
                    (this.FirstDueMonthDelay != null &&
                    this.FirstDueMonthDelay.Equals(input.FirstDueMonthDelay))
                ) && 
                (
                    this.SecondDueDay == input.SecondDueDay ||
                    (this.SecondDueDay != null &&
                    this.SecondDueDay.Equals(input.SecondDueDay))
                ) && 
                (
                    this.SecondDueMonthDelay == input.SecondDueMonthDelay ||
                    (this.SecondDueMonthDelay != null &&
                    this.SecondDueMonthDelay.Equals(input.SecondDueMonthDelay))
                ) && 
                (
                    this.HasFees == input.HasFees ||
                    (this.HasFees != null &&
                    this.HasFees.Equals(input.HasFees))
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
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DateDelay != null)
                    hashCode = hashCode * 59 + this.DateDelay.GetHashCode();
                if (this.IsBondRank != null)
                    hashCode = hashCode * 59 + this.IsBondRank.GetHashCode();
                if (this.ThresholdDay != null)
                    hashCode = hashCode * 59 + this.ThresholdDay.GetHashCode();
                if (this.FirstDueDay != null)
                    hashCode = hashCode * 59 + this.FirstDueDay.GetHashCode();
                if (this.FirstDueMonthDelay != null)
                    hashCode = hashCode * 59 + this.FirstDueMonthDelay.GetHashCode();
                if (this.SecondDueDay != null)
                    hashCode = hashCode * 59 + this.SecondDueDay.GetHashCode();
                if (this.SecondDueMonthDelay != null)
                    hashCode = hashCode * 59 + this.SecondDueMonthDelay.GetHashCode();
                if (this.HasFees != null)
                    hashCode = hashCode * 59 + this.HasFees.GetHashCode();
                return hashCode;
            }
        }
    }

}
