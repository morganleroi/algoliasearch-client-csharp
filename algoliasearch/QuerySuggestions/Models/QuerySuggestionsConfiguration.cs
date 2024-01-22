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

namespace Algolia.Search.Models.QuerySuggestions
{
  /// <summary>
  /// Query Suggestions configuration.
  /// </summary>
  [DataContract(Name = "QuerySuggestionsConfiguration")]
  [JsonObject(MemberSerialization.OptOut)]
  public partial class QuerySuggestionsConfiguration
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="QuerySuggestionsConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public QuerySuggestionsConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QuerySuggestionsConfiguration" /> class.
    /// </summary>
    /// <param name="sourceIndices">Algolia indices from which to get the popular searches for query suggestions. (required).</param>
    public QuerySuggestionsConfiguration(List<SourceIndex> sourceIndices)
    {
      this.SourceIndices = sourceIndices ?? throw new ArgumentNullException("sourceIndices is a required property for QuerySuggestionsConfiguration and cannot be null");
    }

    /// <summary>
    /// Algolia indices from which to get the popular searches for query suggestions.
    /// </summary>
    /// <value>Algolia indices from which to get the popular searches for query suggestions.</value>
    [DataMember(Name = "sourceIndices", IsRequired = true, EmitDefaultValue = false)]
    public List<SourceIndex> SourceIndices { get; set; }

    /// <summary>
    /// Gets or Sets Languages
    /// </summary>
    [DataMember(Name = "languages", EmitDefaultValue = false)]
    public Languages Languages { get; set; }

    /// <summary>
    /// Patterns to exclude from query suggestions.
    /// </summary>
    /// <value>Patterns to exclude from query suggestions.</value>
    [DataMember(Name = "exclude", EmitDefaultValue = false)]
    public List<string> Exclude { get; set; }

    /// <summary>
    /// Turn on personalized query suggestions.
    /// </summary>
    /// <value>Turn on personalized query suggestions.</value>
    [DataMember(Name = "enablePersonalization", EmitDefaultValue = false)]
    public bool? EnablePersonalization { get; set; }

    /// <summary>
    /// Allow suggestions with special characters.
    /// </summary>
    /// <value>Allow suggestions with special characters.</value>
    [DataMember(Name = "allowSpecialCharacters", EmitDefaultValue = false)]
    public bool? AllowSpecialCharacters { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class QuerySuggestionsConfiguration {\n");
      sb.Append("  SourceIndices: ").Append(SourceIndices).Append("\n");
      sb.Append("  Languages: ").Append(Languages).Append("\n");
      sb.Append("  Exclude: ").Append(Exclude).Append("\n");
      sb.Append("  EnablePersonalization: ").Append(EnablePersonalization).Append("\n");
      sb.Append("  AllowSpecialCharacters: ").Append(AllowSpecialCharacters).Append("\n");
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
