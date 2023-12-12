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
  /// SourceUpdateDocker
  /// </summary>
  [DataContract(Name = "SourceUpdateDocker")]
  public partial class SourceUpdateDocker : IEquatable<SourceUpdateDocker>
  {

    /// <summary>
    /// Gets or Sets Registry
    /// </summary>
    [DataMember(Name = "registry", EmitDefaultValue = false)]
    public DockerRegistry? Registry { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceUpdateDocker" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SourceUpdateDocker() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourceUpdateDocker" /> class.
    /// </summary>
    /// <param name="registry">registry.</param>
    /// <param name="image">The name of the image to pull..</param>
    /// <param name="varVersion">The version of the image, defaults to &#x60;latest&#x60;..</param>
    /// <param name="varConfiguration">The configuration of the spec. (required).</param>
    public SourceUpdateDocker(DockerRegistry? registry = default(DockerRegistry?), string image = default(string), string varVersion = default(string), Object varConfiguration = default(Object))
    {
      // to ensure "varConfiguration" is required (not null)
      if (varConfiguration == null)
      {
        throw new ArgumentNullException("varConfiguration is a required property for SourceUpdateDocker and cannot be null");
      }
      this.VarConfiguration = varConfiguration;
      this.Registry = registry;
      this.Image = image;
      this.VarVersion = varVersion;
    }

    /// <summary>
    /// The name of the image to pull.
    /// </summary>
    /// <value>The name of the image to pull.</value>
    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }

    /// <summary>
    /// The version of the image, defaults to &#x60;latest&#x60;.
    /// </summary>
    /// <value>The version of the image, defaults to &#x60;latest&#x60;.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string VarVersion { get; set; }

    /// <summary>
    /// The configuration of the spec.
    /// </summary>
    /// <value>The configuration of the spec.</value>
    [DataMember(Name = "configuration", IsRequired = true, EmitDefaultValue = true)]
    public Object VarConfiguration { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class SourceUpdateDocker {\n");
      sb.Append("  Registry: ").Append(Registry).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
      sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
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
      return this.Equals(input as SourceUpdateDocker);
    }

    /// <summary>
    /// Returns true if SourceUpdateDocker instances are equal
    /// </summary>
    /// <param name="input">Instance of SourceUpdateDocker to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SourceUpdateDocker input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.Registry == input.Registry ||
              this.Registry.Equals(input.Registry)
          ) &&
          (
              this.Image == input.Image ||
              (this.Image != null &&
              this.Image.Equals(input.Image))
          ) &&
          (
              this.VarVersion == input.VarVersion ||
              (this.VarVersion != null &&
              this.VarVersion.Equals(input.VarVersion))
          ) &&
          (
              this.VarConfiguration == input.VarConfiguration ||
              (this.VarConfiguration != null &&
              this.VarConfiguration.Equals(input.VarConfiguration))
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
        hashCode = (hashCode * 59) + this.Registry.GetHashCode();
        if (this.Image != null)
        {
          hashCode = (hashCode * 59) + this.Image.GetHashCode();
        }
        if (this.VarVersion != null)
        {
          hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
        }
        if (this.VarConfiguration != null)
        {
          hashCode = (hashCode * 59) + this.VarConfiguration.GetHashCode();
        }
        return hashCode;
      }
    }

  }

}
