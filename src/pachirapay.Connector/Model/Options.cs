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
    /// Options
    /// </summary>
    [DataContract]
    public partial class Options :  IEquatable<Options>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options" /> class.
        /// </summary>
        /// <param name="reportDelayInDays">The report delay in days.</param>
        /// <param name="allowCardStorage">Allow card storage for the payment.</param>
        public Options(int? reportDelayInDays = default(int?), bool? allowCardStorage = default(bool?))
        {
            this.ReportDelayInDays = reportDelayInDays;
            this.AllowCardStorage = allowCardStorage;
        }
        
        /// <summary>
        /// The report delay in days
        /// </summary>
        /// <value>The report delay in days</value>
        [DataMember(Name="reportDelayInDays", EmitDefaultValue=false)]
        public int? ReportDelayInDays { get; set; }

        /// <summary>
        /// Allow card storage for the payment
        /// </summary>
        /// <value>Allow card storage for the payment</value>
        [DataMember(Name="allowCardStorage", EmitDefaultValue=false)]
        public bool? AllowCardStorage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options {\n");
            sb.Append("  ReportDelayInDays: ").Append(ReportDelayInDays).Append("\n");
            sb.Append("  AllowCardStorage: ").Append(AllowCardStorage).Append("\n");
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
            return this.Equals(input as Options);
        }

        /// <summary>
        /// Returns true if Options instances are equal
        /// </summary>
        /// <param name="input">Instance of Options to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportDelayInDays == input.ReportDelayInDays ||
                    (this.ReportDelayInDays != null &&
                    this.ReportDelayInDays.Equals(input.ReportDelayInDays))
                ) && 
                (
                    this.AllowCardStorage == input.AllowCardStorage ||
                    (this.AllowCardStorage != null &&
                    this.AllowCardStorage.Equals(input.AllowCardStorage))
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
                if (this.ReportDelayInDays != null)
                    hashCode = hashCode * 59 + this.ReportDelayInDays.GetHashCode();
                if (this.AllowCardStorage != null)
                    hashCode = hashCode * 59 + this.AllowCardStorage.GetHashCode();
                return hashCode;
            }
        }
    }

}