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
  /// SourceJSON
  /// </summary>
  [DataContract(Name = "SourceJSON")]
  public partial class SourceJSON
  {

    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name = "method", EmitDefaultValue = false)]
    public MethodType Method { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceJSON" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public SourceJSON() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceJSON" /> class.
    /// </summary>
    /// <param name="url">The URL of the file. (required).</param>
    public SourceJSON(string url)
    {
      this.Url = url ?? throw new ArgumentNullException("url is a required property for SourceJSON and cannot be null");
    }

    /// <summary>
    /// The URL of the file.
    /// </summary>
    /// <value>The URL of the file.</value>
    [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
    public string Url { get; set; }

    /// <summary>
    /// The name of the column that contains the unique ID, used as &#x60;objectID&#x60; in Algolia.
    /// </summary>
    /// <value>The name of the column that contains the unique ID, used as &#x60;objectID&#x60; in Algolia.</value>
    [DataMember(Name = "uniqueIDColumn", EmitDefaultValue = false)]
    public string UniqueIDColumn { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class SourceJSON {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  UniqueIDColumn: ").Append(UniqueIDColumn).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
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
