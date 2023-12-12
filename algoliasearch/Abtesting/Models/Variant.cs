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

namespace Algolia.Search.Abtesting.Models
{
  /// <summary>
  /// Variant
  /// </summary>
  [DataContract(Name = "variant")]
  public partial class Variant : IEquatable<Variant>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Variant" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Variant() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Variant" /> class.
    /// </summary>
    /// <param name="addToCartCount">Number of add-to-cart events for this variant. (required).</param>
    /// <param name="addToCartRate">Variant&#39;s [add-to-cart rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#add-to-cart-rate). (required).</param>
    /// <param name="averageClickPosition">Variant&#39;s [average click position](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-position). (required).</param>
    /// <param name="clickCount">Number of click events for this variant. (required).</param>
    /// <param name="clickThroughRate">Variant&#39;s [click-through rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-through-rate). (required).</param>
    /// <param name="conversionCount">Number of click events for this variant. (required).</param>
    /// <param name="conversionRate">Variant&#39;s [conversion rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#conversion-rate). (required).</param>
    /// <param name="currencies">A/B test currencies. (required).</param>
    /// <param name="description">A/B test description. (required).</param>
    /// <param name="filterEffects">filterEffects.</param>
    /// <param name="index">A/B test index. (required).</param>
    /// <param name="noResultCount">Number of [searches without results](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#searches-without-results) for that variant. (required).</param>
    /// <param name="purchaseCount">Number of purchase events for this variant. (required).</param>
    /// <param name="purchaseRate">Variant&#39;s [purchase rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#purchase-rate). (required).</param>
    /// <param name="searchCount">Number of searches carried out during the A/B test. (required).</param>
    /// <param name="trackedSearchCount">Number of tracked searches. This is the number of search requests where the &#x60;clickAnalytics&#x60; parameter is &#x60;true&#x60;. (required).</param>
    /// <param name="trafficPercentage">A/B test traffic percentage. (required).</param>
    /// <param name="userCount">Number of users during the A/B test. (required).</param>
    public Variant(int addToCartCount = default(int), double addToCartRate = default(double), int averageClickPosition = default(int), int clickCount = default(int), double clickThroughRate = default(double), int conversionCount = default(int), double conversionRate = default(double), Dictionary<string, CurrenciesValue> currencies = default(Dictionary<string, CurrenciesValue>), string description = default(string), FilterEffects filterEffects = default(FilterEffects), string index = default(string), int noResultCount = default(int), int purchaseCount = default(int), double purchaseRate = default(double), int searchCount = default(int), int trackedSearchCount = default(int), int trafficPercentage = default(int), int userCount = default(int))
    {
      this.AddToCartCount = addToCartCount;
      this.AddToCartRate = addToCartRate;
      this.AverageClickPosition = averageClickPosition;
      this.ClickCount = clickCount;
      this.ClickThroughRate = clickThroughRate;
      this.ConversionCount = conversionCount;
      this.ConversionRate = conversionRate;
      // to ensure "currencies" is required (not null)
      if (currencies == null)
      {
        throw new ArgumentNullException("currencies is a required property for Variant and cannot be null");
      }
      this.Currencies = currencies;
      // to ensure "description" is required (not null)
      if (description == null)
      {
        throw new ArgumentNullException("description is a required property for Variant and cannot be null");
      }
      this.Description = description;
      // to ensure "index" is required (not null)
      if (index == null)
      {
        throw new ArgumentNullException("index is a required property for Variant and cannot be null");
      }
      this.Index = index;
      this.NoResultCount = noResultCount;
      this.PurchaseCount = purchaseCount;
      this.PurchaseRate = purchaseRate;
      this.SearchCount = searchCount;
      this.TrackedSearchCount = trackedSearchCount;
      this.TrafficPercentage = trafficPercentage;
      this.UserCount = userCount;
      this.FilterEffects = filterEffects;
    }

    /// <summary>
    /// Number of add-to-cart events for this variant.
    /// </summary>
    /// <value>Number of add-to-cart events for this variant.</value>
    [DataMember(Name = "addToCartCount", IsRequired = true, EmitDefaultValue = true)]
    public int AddToCartCount { get; set; }

    /// <summary>
    /// Variant&#39;s [add-to-cart rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#add-to-cart-rate).
    /// </summary>
    /// <value>Variant&#39;s [add-to-cart rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#add-to-cart-rate).</value>
    [DataMember(Name = "addToCartRate", IsRequired = true, EmitDefaultValue = true)]
    public double AddToCartRate { get; set; }

    /// <summary>
    /// Variant&#39;s [average click position](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-position).
    /// </summary>
    /// <value>Variant&#39;s [average click position](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-position).</value>
    [DataMember(Name = "averageClickPosition", IsRequired = true, EmitDefaultValue = true)]
    public int AverageClickPosition { get; set; }

    /// <summary>
    /// Number of click events for this variant.
    /// </summary>
    /// <value>Number of click events for this variant.</value>
    [DataMember(Name = "clickCount", IsRequired = true, EmitDefaultValue = true)]
    public int ClickCount { get; set; }

    /// <summary>
    /// Variant&#39;s [click-through rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-through-rate).
    /// </summary>
    /// <value>Variant&#39;s [click-through rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#click-through-rate).</value>
    [DataMember(Name = "clickThroughRate", IsRequired = true, EmitDefaultValue = true)]
    public double ClickThroughRate { get; set; }

    /// <summary>
    /// Number of click events for this variant.
    /// </summary>
    /// <value>Number of click events for this variant.</value>
    [DataMember(Name = "conversionCount", IsRequired = true, EmitDefaultValue = true)]
    public int ConversionCount { get; set; }

    /// <summary>
    /// Variant&#39;s [conversion rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#conversion-rate).
    /// </summary>
    /// <value>Variant&#39;s [conversion rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#conversion-rate).</value>
    [DataMember(Name = "conversionRate", IsRequired = true, EmitDefaultValue = true)]
    public double ConversionRate { get; set; }

    /// <summary>
    /// A/B test currencies.
    /// </summary>
    /// <value>A/B test currencies.</value>
    [DataMember(Name = "currencies", IsRequired = true, EmitDefaultValue = true)]
    public Dictionary<string, CurrenciesValue> Currencies { get; set; }

    /// <summary>
    /// A/B test description.
    /// </summary>
    /// <value>A/B test description.</value>
    [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets FilterEffects
    /// </summary>
    [DataMember(Name = "filterEffects", EmitDefaultValue = false)]
    public FilterEffects FilterEffects { get; set; }

    /// <summary>
    /// A/B test index.
    /// </summary>
    /// <value>A/B test index.</value>
    [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
    public string Index { get; set; }

    /// <summary>
    /// Number of [searches without results](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#searches-without-results) for that variant.
    /// </summary>
    /// <value>Number of [searches without results](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#searches-without-results) for that variant.</value>
    [DataMember(Name = "noResultCount", IsRequired = true, EmitDefaultValue = true)]
    public int NoResultCount { get; set; }

    /// <summary>
    /// Number of purchase events for this variant.
    /// </summary>
    /// <value>Number of purchase events for this variant.</value>
    [DataMember(Name = "purchaseCount", IsRequired = true, EmitDefaultValue = true)]
    public int PurchaseCount { get; set; }

    /// <summary>
    /// Variant&#39;s [purchase rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#purchase-rate).
    /// </summary>
    /// <value>Variant&#39;s [purchase rate](https://www.algolia.com/doc/guides/search-analytics/concepts/metrics/#purchase-rate).</value>
    [DataMember(Name = "purchaseRate", IsRequired = true, EmitDefaultValue = true)]
    public double PurchaseRate { get; set; }

    /// <summary>
    /// Number of searches carried out during the A/B test.
    /// </summary>
    /// <value>Number of searches carried out during the A/B test.</value>
    [DataMember(Name = "searchCount", IsRequired = true, EmitDefaultValue = true)]
    public int SearchCount { get; set; }

    /// <summary>
    /// Number of tracked searches. This is the number of search requests where the &#x60;clickAnalytics&#x60; parameter is &#x60;true&#x60;.
    /// </summary>
    /// <value>Number of tracked searches. This is the number of search requests where the &#x60;clickAnalytics&#x60; parameter is &#x60;true&#x60;.</value>
    [DataMember(Name = "trackedSearchCount", IsRequired = true, EmitDefaultValue = true)]
    public int TrackedSearchCount { get; set; }

    /// <summary>
    /// A/B test traffic percentage.
    /// </summary>
    /// <value>A/B test traffic percentage.</value>
    [DataMember(Name = "trafficPercentage", IsRequired = true, EmitDefaultValue = true)]
    public int TrafficPercentage { get; set; }

    /// <summary>
    /// Number of users during the A/B test.
    /// </summary>
    /// <value>Number of users during the A/B test.</value>
    [DataMember(Name = "userCount", IsRequired = true, EmitDefaultValue = true)]
    public int UserCount { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class Variant {\n");
      sb.Append("  AddToCartCount: ").Append(AddToCartCount).Append("\n");
      sb.Append("  AddToCartRate: ").Append(AddToCartRate).Append("\n");
      sb.Append("  AverageClickPosition: ").Append(AverageClickPosition).Append("\n");
      sb.Append("  ClickCount: ").Append(ClickCount).Append("\n");
      sb.Append("  ClickThroughRate: ").Append(ClickThroughRate).Append("\n");
      sb.Append("  ConversionCount: ").Append(ConversionCount).Append("\n");
      sb.Append("  ConversionRate: ").Append(ConversionRate).Append("\n");
      sb.Append("  Currencies: ").Append(Currencies).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FilterEffects: ").Append(FilterEffects).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  NoResultCount: ").Append(NoResultCount).Append("\n");
      sb.Append("  PurchaseCount: ").Append(PurchaseCount).Append("\n");
      sb.Append("  PurchaseRate: ").Append(PurchaseRate).Append("\n");
      sb.Append("  SearchCount: ").Append(SearchCount).Append("\n");
      sb.Append("  TrackedSearchCount: ").Append(TrackedSearchCount).Append("\n");
      sb.Append("  TrafficPercentage: ").Append(TrafficPercentage).Append("\n");
      sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
      return this.Equals(input as Variant);
    }

    /// <summary>
    /// Returns true if Variant instances are equal
    /// </summary>
    /// <param name="input">Instance of Variant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Variant input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.AddToCartCount == input.AddToCartCount ||
              this.AddToCartCount.Equals(input.AddToCartCount)
          ) &&
          (
              this.AddToCartRate == input.AddToCartRate ||
              this.AddToCartRate.Equals(input.AddToCartRate)
          ) &&
          (
              this.AverageClickPosition == input.AverageClickPosition ||
              this.AverageClickPosition.Equals(input.AverageClickPosition)
          ) &&
          (
              this.ClickCount == input.ClickCount ||
              this.ClickCount.Equals(input.ClickCount)
          ) &&
          (
              this.ClickThroughRate == input.ClickThroughRate ||
              this.ClickThroughRate.Equals(input.ClickThroughRate)
          ) &&
          (
              this.ConversionCount == input.ConversionCount ||
              this.ConversionCount.Equals(input.ConversionCount)
          ) &&
          (
              this.ConversionRate == input.ConversionRate ||
              this.ConversionRate.Equals(input.ConversionRate)
          ) &&
          (
              this.Currencies == input.Currencies ||
              this.Currencies != null &&
              input.Currencies != null &&
              this.Currencies.SequenceEqual(input.Currencies)
          ) &&
          (
              this.Description == input.Description ||
              (this.Description != null &&
              this.Description.Equals(input.Description))
          ) &&
          (
              this.FilterEffects == input.FilterEffects ||
              (this.FilterEffects != null &&
              this.FilterEffects.Equals(input.FilterEffects))
          ) &&
          (
              this.Index == input.Index ||
              (this.Index != null &&
              this.Index.Equals(input.Index))
          ) &&
          (
              this.NoResultCount == input.NoResultCount ||
              this.NoResultCount.Equals(input.NoResultCount)
          ) &&
          (
              this.PurchaseCount == input.PurchaseCount ||
              this.PurchaseCount.Equals(input.PurchaseCount)
          ) &&
          (
              this.PurchaseRate == input.PurchaseRate ||
              this.PurchaseRate.Equals(input.PurchaseRate)
          ) &&
          (
              this.SearchCount == input.SearchCount ||
              this.SearchCount.Equals(input.SearchCount)
          ) &&
          (
              this.TrackedSearchCount == input.TrackedSearchCount ||
              this.TrackedSearchCount.Equals(input.TrackedSearchCount)
          ) &&
          (
              this.TrafficPercentage == input.TrafficPercentage ||
              this.TrafficPercentage.Equals(input.TrafficPercentage)
          ) &&
          (
              this.UserCount == input.UserCount ||
              this.UserCount.Equals(input.UserCount)
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
        hashCode = (hashCode * 59) + this.AddToCartCount.GetHashCode();
        hashCode = (hashCode * 59) + this.AddToCartRate.GetHashCode();
        hashCode = (hashCode * 59) + this.AverageClickPosition.GetHashCode();
        hashCode = (hashCode * 59) + this.ClickCount.GetHashCode();
        hashCode = (hashCode * 59) + this.ClickThroughRate.GetHashCode();
        hashCode = (hashCode * 59) + this.ConversionCount.GetHashCode();
        hashCode = (hashCode * 59) + this.ConversionRate.GetHashCode();
        if (this.Currencies != null)
        {
          hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
        }
        if (this.Description != null)
        {
          hashCode = (hashCode * 59) + this.Description.GetHashCode();
        }
        if (this.FilterEffects != null)
        {
          hashCode = (hashCode * 59) + this.FilterEffects.GetHashCode();
        }
        if (this.Index != null)
        {
          hashCode = (hashCode * 59) + this.Index.GetHashCode();
        }
        hashCode = (hashCode * 59) + this.NoResultCount.GetHashCode();
        hashCode = (hashCode * 59) + this.PurchaseCount.GetHashCode();
        hashCode = (hashCode * 59) + this.PurchaseRate.GetHashCode();
        hashCode = (hashCode * 59) + this.SearchCount.GetHashCode();
        hashCode = (hashCode * 59) + this.TrackedSearchCount.GetHashCode();
        hashCode = (hashCode * 59) + this.TrafficPercentage.GetHashCode();
        hashCode = (hashCode * 59) + this.UserCount.GetHashCode();
        return hashCode;
      }
    }

  }

}
