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

namespace Algolia.Search.Models.Ingestion
{
  /// <summary>
  /// SourceCreateResponse
  /// </summary>
  [DataContract(Name = "SourceCreateResponse")]
  public partial class SourceCreateResponse
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceCreateResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public SourceCreateResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceCreateResponse" /> class.
    /// </summary>
    /// <param name="sourceID">The source UUID. (required).</param>
    /// <param name="name">name (required).</param>
    /// <param name="createdAt">Date of creation (RFC3339 format). (required).</param>
    public SourceCreateResponse(string sourceID, string name, string createdAt)
    {
      this.SourceID = sourceID ?? throw new ArgumentNullException("sourceID is a required property for SourceCreateResponse and cannot be null");
      this.Name = name ?? throw new ArgumentNullException("name is a required property for SourceCreateResponse and cannot be null");
      this.CreatedAt = createdAt ?? throw new ArgumentNullException("createdAt is a required property for SourceCreateResponse and cannot be null");
    }

    /// <summary>
    /// The source UUID.
    /// </summary>
    /// <value>The source UUID.</value>
    [DataMember(Name = "sourceID", IsRequired = true, EmitDefaultValue = false)]
    public string SourceID { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    /// Date of creation (RFC3339 format).
    /// </summary>
    /// <value>Date of creation (RFC3339 format).</value>
    [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class SourceCreateResponse {\n");
      sb.Append("  SourceID: ").Append(SourceID).Append("\n");
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

  }

}
