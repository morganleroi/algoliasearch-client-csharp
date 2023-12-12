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
  /// Response from the API when the Authentication is successfully created.
  /// </summary>
  [DataContract(Name = "AuthenticationCreateResponse")]
  public partial class AuthenticationCreateResponse : IEquatable<AuthenticationCreateResponse>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationCreateResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuthenticationCreateResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticationCreateResponse" /> class.
    /// </summary>
    /// <param name="authenticationID">The authentication UUID. (required).</param>
    /// <param name="name">An human readable name describing the object. (required).</param>
    /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
    public AuthenticationCreateResponse(string authenticationID = default(string), string name = default(string), string createdAt = default(string))
    {
      // to ensure "authenticationID" is required (not null)
      if (authenticationID == null)
      {
        throw new ArgumentNullException("authenticationID is a required property for AuthenticationCreateResponse and cannot be null");
      }
      this.AuthenticationID = authenticationID;
      // to ensure "name" is required (not null)
      if (name == null)
      {
        throw new ArgumentNullException("name is a required property for AuthenticationCreateResponse and cannot be null");
      }
      this.Name = name;
      // to ensure "createdAt" is required (not null)
      if (createdAt == null)
      {
        throw new ArgumentNullException("createdAt is a required property for AuthenticationCreateResponse and cannot be null");
      }
      this.CreatedAt = createdAt;
    }

    /// <summary>
    /// The authentication UUID.
    /// </summary>
    /// <value>The authentication UUID.</value>
    [DataMember(Name = "authenticationID", IsRequired = true, EmitDefaultValue = true)]
    public string AuthenticationID { get; set; }

    /// <summary>
    /// An human readable name describing the object.
    /// </summary>
    /// <value>An human readable name describing the object.</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    /// Date of creation (RFC3339 format).
    /// </summary>
    /// <value>Date of creation (RFC3339 format).</value>
    [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class AuthenticationCreateResponse {\n");
      sb.Append("  AuthenticationID: ").Append(AuthenticationID).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
      return this.Equals(input as AuthenticationCreateResponse);
    }

    /// <summary>
    /// Returns true if AuthenticationCreateResponse instances are equal
    /// </summary>
    /// <param name="input">Instance of AuthenticationCreateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuthenticationCreateResponse input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.AuthenticationID == input.AuthenticationID ||
              (this.AuthenticationID != null &&
              this.AuthenticationID.Equals(input.AuthenticationID))
          ) &&
          (
              this.Name == input.Name ||
              (this.Name != null &&
              this.Name.Equals(input.Name))
          ) &&
          (
              this.CreatedAt == input.CreatedAt ||
              (this.CreatedAt != null &&
              this.CreatedAt.Equals(input.CreatedAt))
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
        if (this.AuthenticationID != null)
        {
          hashCode = (hashCode * 59) + this.AuthenticationID.GetHashCode();
        }
        if (this.Name != null)
        {
          hashCode = (hashCode * 59) + this.Name.GetHashCode();
        }
        if (this.CreatedAt != null)
        {
          hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
        }
        return hashCode;
      }
    }

  }

}
