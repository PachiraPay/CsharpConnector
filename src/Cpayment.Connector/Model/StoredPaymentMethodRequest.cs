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
    /// StoredPaymentMethodRequest
    /// </summary>
    [DataContract]
    public partial class StoredPaymentMethodRequest :  IEquatable<StoredPaymentMethodRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredPaymentMethodRequest" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="card">card.</param>
        public StoredPaymentMethodRequest(CardPaymentContextData context = default(CardPaymentContextData), CardData card = default(CardData))
        {
            this.Context = context;
            this.Card = card;
        }
        
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public CardPaymentContextData Context { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public CardData Card { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredPaymentMethodRequest {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
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
            return this.Equals(input as StoredPaymentMethodRequest);
        }

        /// <summary>
        /// Returns true if StoredPaymentMethodRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StoredPaymentMethodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredPaymentMethodRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Card != null)
                    hashCode = hashCode * 59 + this.Card.GetHashCode();
                return hashCode;
            }
        }
    }

}