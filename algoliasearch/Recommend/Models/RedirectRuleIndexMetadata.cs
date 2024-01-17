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

namespace Algolia.Search.Models.Recommend
{
  /// <summary>
  /// RedirectRuleIndexMetadata
  /// </summary>
  [DataContract(Name = "RedirectRuleIndexMetadata")]
  public partial class RedirectRuleIndexMetadata
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="RedirectRuleIndexMetadata" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public RedirectRuleIndexMetadata() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RedirectRuleIndexMetadata" /> class.
    /// </summary>
    /// <param name="varSource">Source index for the redirect rule. (required).</param>
    /// <param name="dest">Destination index for the redirect rule. (required).</param>
    /// <param name="reason">Reason for the redirect rule. (required).</param>
    /// <param name="succeed">Redirect rule status. (required).</param>
    /// <param name="data">data (required).</param>
    public RedirectRuleIndexMetadata(string varSource, string dest, string reason, bool? succeed, RedirectRuleIndexMetadataData data)
    {
      this.VarSource = varSource ?? throw new ArgumentNullException("varSource is a required property for RedirectRuleIndexMetadata and cannot be null");
      this.Dest = dest ?? throw new ArgumentNullException("dest is a required property for RedirectRuleIndexMetadata and cannot be null");
      this.Reason = reason ?? throw new ArgumentNullException("reason is a required property for RedirectRuleIndexMetadata and cannot be null");
      this.Succeed = succeed;
      this.Data = data ?? throw new ArgumentNullException("data is a required property for RedirectRuleIndexMetadata and cannot be null");
    }

    /// <summary>
    /// Source index for the redirect rule.
    /// </summary>
    /// <value>Source index for the redirect rule.</value>
    [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = false)]
    public string VarSource { get; set; }

    /// <summary>
    /// Destination index for the redirect rule.
    /// </summary>
    /// <value>Destination index for the redirect rule.</value>
    [DataMember(Name = "dest", IsRequired = true, EmitDefaultValue = false)]
    public string Dest { get; set; }

    /// <summary>
    /// Reason for the redirect rule.
    /// </summary>
    /// <value>Reason for the redirect rule.</value>
    [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = false)]
    public string Reason { get; set; }

    /// <summary>
    /// Redirect rule status.
    /// </summary>
    /// <value>Redirect rule status.</value>
    [DataMember(Name = "succeed", IsRequired = true, EmitDefaultValue = false)]
    public bool? Succeed { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
    public RedirectRuleIndexMetadataData Data { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class RedirectRuleIndexMetadata {\n");
      sb.Append("  VarSource: ").Append(VarSource).Append("\n");
      sb.Append("  Dest: ").Append(Dest).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Succeed: ").Append(Succeed).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
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
