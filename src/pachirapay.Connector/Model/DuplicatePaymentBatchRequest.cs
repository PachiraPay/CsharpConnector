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
    /// The AuthorByCopy batch Payment Request
    /// </summary>
    [DataContract]
    public partial class DuplicatePaymentBatchRequest :  IEquatable<DuplicatePaymentBatchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatePaymentBatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DuplicatePaymentBatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatePaymentBatchRequest" /> class.
        /// </summary>
        /// <param name="duplicatePaymentRequestList">Gets or Sets ContextData (required).</param>
        public DuplicatePaymentBatchRequest(List<DuplicatePaymentRequest> duplicatePaymentRequestList = default(List<DuplicatePaymentRequest>))
        {
            // to ensure "duplicatePaymentRequestList" is required (not null)
            if (duplicatePaymentRequestList == null)
            {
                throw new InvalidDataException("duplicatePaymentRequestList is a required property for DuplicatePaymentBatchRequest and cannot be null");
            }
            else
            {
                this.DuplicatePaymentRequestList = duplicatePaymentRequestList;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets ContextData
        /// </summary>
        /// <value>Gets or Sets ContextData</value>
        [DataMember(Name="duplicatePaymentRequestList", EmitDefaultValue=false)]
        public List<DuplicatePaymentRequest> DuplicatePaymentRequestList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DuplicatePaymentBatchRequest {\n");
            sb.Append("  DuplicatePaymentRequestList: ").Append(DuplicatePaymentRequestList).Append("\n");
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
            return this.Equals(input as DuplicatePaymentBatchRequest);
        }

        /// <summary>
        /// Returns true if DuplicatePaymentBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DuplicatePaymentBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DuplicatePaymentBatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DuplicatePaymentRequestList == input.DuplicatePaymentRequestList ||
                    this.DuplicatePaymentRequestList != null &&
                    input.DuplicatePaymentRequestList != null &&
                    this.DuplicatePaymentRequestList.SequenceEqual(input.DuplicatePaymentRequestList)
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
                if (this.DuplicatePaymentRequestList != null)
                    hashCode = hashCode * 59 + this.DuplicatePaymentRequestList.GetHashCode();
                return hashCode;
            }
        }
    }

}