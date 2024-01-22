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

namespace Algolia.Search.Models.Search
{
  /// <summary>
  /// Assign userID parameters.
  /// </summary>
  [DataContract(Name = "batchAssignUserIdsParams")]
  [JsonObject(MemberSerialization.OptOut)]
  public partial class BatchAssignUserIdsParams
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchAssignUserIdsParams" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    public BatchAssignUserIdsParams() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchAssignUserIdsParams" /> class.
    /// </summary>
    /// <param name="cluster">Cluster name. (required).</param>
    /// <param name="users">User IDs to assign. (required).</param>
    public BatchAssignUserIdsParams(string cluster, List<string> users)
    {
      this.Cluster = cluster ?? throw new ArgumentNullException("cluster is a required property for BatchAssignUserIdsParams and cannot be null");
      this.Users = users ?? throw new ArgumentNullException("users is a required property for BatchAssignUserIdsParams and cannot be null");
    }

    /// <summary>
    /// Cluster name.
    /// </summary>
    /// <value>Cluster name.</value>
    [DataMember(Name = "cluster", IsRequired = true, EmitDefaultValue = false)]
    public string Cluster { get; set; }

    /// <summary>
    /// User IDs to assign.
    /// </summary>
    /// <value>User IDs to assign.</value>
    [DataMember(Name = "users", IsRequired = true, EmitDefaultValue = false)]
    public List<string> Users { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class BatchAssignUserIdsParams {\n");
      sb.Append("  Cluster: ").Append(Cluster).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
