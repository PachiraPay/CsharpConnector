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
    /// All acquiring bank data
    /// </summary>
    [DataContract]
    public partial class AcquiringBank :  IEquatable<AcquiringBank>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcquiringBank" /> class.
        /// </summary>
        /// <param name="acquiringBankRef">The acquiring bank reference.</param>
        /// <param name="name">The acquiring bank name.</param>
        /// <param name="active">Indicates if the acquiring bank is active or not.</param>
        public AcquiringBank(string acquiringBankRef = default(string), string name = default(string), bool? active = default(bool?))
        {
            this.AcquiringBankRef = acquiringBankRef;
            this.Name = name;
            this.Active = active;
        }
        
        /// <summary>
        /// The acquiring bank reference
        /// </summary>
        /// <value>The acquiring bank reference</value>
        [DataMember(Name="acquiringBankRef", EmitDefaultValue=false)]
        public string AcquiringBankRef { get; set; }

        /// <summary>
        /// The acquiring bank name
        /// </summary>
        /// <value>The acquiring bank name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the acquiring bank is active or not
        /// </summary>
        /// <value>Indicates if the acquiring bank is active or not</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcquiringBank {\n");
            sb.Append("  AcquiringBankRef: ").Append(AcquiringBankRef).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as AcquiringBank);
        }

        /// <summary>
        /// Returns true if AcquiringBank instances are equal
        /// </summary>
        /// <param name="input">Instance of AcquiringBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcquiringBank input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcquiringBankRef == input.AcquiringBankRef ||
                    (this.AcquiringBankRef != null &&
                    this.AcquiringBankRef.Equals(input.AcquiringBankRef))
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
                if (this.AcquiringBankRef != null)
                    hashCode = hashCode * 59 + this.AcquiringBankRef.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                return hashCode;
            }
        }
    }

}
