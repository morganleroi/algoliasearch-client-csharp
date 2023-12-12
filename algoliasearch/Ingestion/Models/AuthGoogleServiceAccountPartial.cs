//
// Code generated by OpenAPI Generator (https://openapi-generator.tech), manual changes will be lost - read more on https://github.com/algolia/api-clients-automation. DO NOT EDIT.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Algolia.Search.Models;

namespace Algolia.Search.Ingestion.Models
{
  /// <summary>
  /// Authentication input to connect to a Google service (e.g. BigQuery).
  /// </summary>
  [DataContract(Name = "AuthGoogleServiceAccountPartial")]
  public partial class AuthGoogleServiceAccountPartial : IEquatable<AuthGoogleServiceAccountPartial>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthGoogleServiceAccountPartial" /> class.
    /// </summary>
    /// <param name="clientEmail">Email address of the Service Account..</param>
    /// <param name="privateKey">Private key of the Service Account..</param>
    public AuthGoogleServiceAccountPartial(string clientEmail = default(string), string privateKey = default(string))
    {
      this.ClientEmail = clientEmail;
      this.PrivateKey = privateKey;
    }

    /// <summary>
    /// Email address of the Service Account.
    /// </summary>
    /// <value>Email address of the Service Account.</value>
    [DataMember(Name = "clientEmail", EmitDefaultValue = false)]
    public string ClientEmail { get; set; }

    /// <summary>
    /// Private key of the Service Account.
    /// </summary>
    /// <value>Private key of the Service Account.</value>
    [DataMember(Name = "privateKey", EmitDefaultValue = false)]
    public string PrivateKey { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class AuthGoogleServiceAccountPartial {\n");
      sb.Append("  ClientEmail: ").Append(ClientEmail).Append("\n");
      sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
      return this.Equals(input as AuthGoogleServiceAccountPartial);
    }

    /// <summary>
    /// Returns true if AuthGoogleServiceAccountPartial instances are equal
    /// </summary>
    /// <param name="input">Instance of AuthGoogleServiceAccountPartial to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthGoogleServiceAccountPartial input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.ClientEmail == input.ClientEmail ||
              (this.ClientEmail != null &&
              this.ClientEmail.Equals(input.ClientEmail))
          ) &&
          (
              this.PrivateKey == input.PrivateKey ||
              (this.PrivateKey != null &&
              this.PrivateKey.Equals(input.PrivateKey))
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
        if (this.ClientEmail != null)
        {
          hashCode = (hashCode * 59) + this.ClientEmail.GetHashCode();
        }
        if (this.PrivateKey != null)
        {
          hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
        }
        return hashCode;
      }
    }

  }

}
