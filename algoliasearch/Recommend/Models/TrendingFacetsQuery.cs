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

namespace Algolia.Search.Recommend.Models
{
  /// <summary>
  /// TrendingFacetsQuery
  /// </summary>
  [DataContract(Name = "trendingFacetsQuery")]
  public partial class TrendingFacetsQuery : IEquatable<TrendingFacetsQuery>
  {

    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    [DataMember(Name = "model", EmitDefaultValue = false)]
    public TrendingFacetsModel? Model { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrendingFacetsQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TrendingFacetsQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrendingFacetsQuery" /> class.
    /// </summary>
    /// <param name="facetName">Facet name for trending models. (required).</param>
    /// <param name="model">model.</param>
    /// <param name="indexName">Algolia index name. (required).</param>
    /// <param name="threshold">Recommendations with a confidence score lower than &#x60;threshold&#x60; won&#39;t appear in results. &gt; **Note**: Each recommendation has a confidence score of 0 to 100. The closer the score is to 100, the more relevant the recommendations are. .</param>
    /// <param name="maxRecommendations">Maximum number of recommendations to retrieve. If 0, all recommendations will be returned. (default to 0).</param>
    public TrendingFacetsQuery(string facetName = default(string), TrendingFacetsModel? model = default(TrendingFacetsModel?), string indexName = default(string), int threshold = default(int), int maxRecommendations = 0)
    {
      // to ensure "facetName" is required (not null)
      if (facetName == null)
      {
        throw new ArgumentNullException("facetName is a required property for TrendingFacetsQuery and cannot be null");
      }
      this.FacetName = facetName;
      // to ensure "indexName" is required (not null)
      if (indexName == null)
      {
        throw new ArgumentNullException("indexName is a required property for TrendingFacetsQuery and cannot be null");
      }
      this.IndexName = indexName;
      this.Model = model;
      this.Threshold = threshold;
      this.MaxRecommendations = maxRecommendations;
    }

    /// <summary>
    /// Facet name for trending models.
    /// </summary>
    /// <value>Facet name for trending models.</value>
    [DataMember(Name = "facetName", IsRequired = true, EmitDefaultValue = true)]
    public string FacetName { get; set; }

    /// <summary>
    /// Algolia index name.
    /// </summary>
    /// <value>Algolia index name.</value>
    [DataMember(Name = "indexName", IsRequired = true, EmitDefaultValue = true)]
    public string IndexName { get; set; }

    /// <summary>
    /// Recommendations with a confidence score lower than &#x60;threshold&#x60; won&#39;t appear in results. &gt; **Note**: Each recommendation has a confidence score of 0 to 100. The closer the score is to 100, the more relevant the recommendations are. 
    /// </summary>
    /// <value>Recommendations with a confidence score lower than &#x60;threshold&#x60; won&#39;t appear in results. &gt; **Note**: Each recommendation has a confidence score of 0 to 100. The closer the score is to 100, the more relevant the recommendations are. </value>
    [DataMember(Name = "threshold", EmitDefaultValue = false)]
    public int Threshold { get; set; }

    /// <summary>
    /// Maximum number of recommendations to retrieve. If 0, all recommendations will be returned.
    /// </summary>
    /// <value>Maximum number of recommendations to retrieve. If 0, all recommendations will be returned.</value>
    [DataMember(Name = "maxRecommendations", EmitDefaultValue = false)]
    public int MaxRecommendations { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class TrendingFacetsQuery {\n");
      sb.Append("  FacetName: ").Append(FacetName).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  IndexName: ").Append(IndexName).Append("\n");
      sb.Append("  Threshold: ").Append(Threshold).Append("\n");
      sb.Append("  MaxRecommendations: ").Append(MaxRecommendations).Append("\n");
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
      return this.Equals(input as TrendingFacetsQuery);
    }

    /// <summary>
    /// Returns true if TrendingFacetsQuery instances are equal
    /// </summary>
    /// <param name="input">Instance of TrendingFacetsQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrendingFacetsQuery input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.FacetName == input.FacetName ||
              (this.FacetName != null &&
              this.FacetName.Equals(input.FacetName))
          ) &&
          (
              this.Model == input.Model ||
              this.Model.Equals(input.Model)
          ) &&
          (
              this.IndexName == input.IndexName ||
              (this.IndexName != null &&
              this.IndexName.Equals(input.IndexName))
          ) &&
          (
              this.Threshold == input.Threshold ||
              this.Threshold.Equals(input.Threshold)
          ) &&
          (
              this.MaxRecommendations == input.MaxRecommendations ||
              this.MaxRecommendations.Equals(input.MaxRecommendations)
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
        if (this.FacetName != null)
        {
          hashCode = (hashCode * 59) + this.FacetName.GetHashCode();
        }
        hashCode = (hashCode * 59) + this.Model.GetHashCode();
        if (this.IndexName != null)
        {
          hashCode = (hashCode * 59) + this.IndexName.GetHashCode();
        }
        hashCode = (hashCode * 59) + this.Threshold.GetHashCode();
        hashCode = (hashCode * 59) + this.MaxRecommendations.GetHashCode();
        return hashCode;
      }
    }

  }

}
