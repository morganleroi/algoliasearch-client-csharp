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

namespace Algolia.Search.Insights.Models
{
  /// <summary>
  /// ObjectDataAfterSearch
  /// </summary>
  [DataContract(Name = "objectDataAfterSearch")]
  public partial class ObjectDataAfterSearch : IEquatable<ObjectDataAfterSearch>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectDataAfterSearch" /> class.
    /// </summary>
    /// <param name="queryID">ID of the query that this specific record is attributable to. Used to track purchase events with multiple items originating from different searches..</param>
    /// <param name="price">price.</param>
    /// <param name="quantity">The quantity of the purchased or added-to-cart item. The total value of a purchase is the sum of &#x60;quantity&#x60; multiplied with the &#x60;price&#x60; for each purchased item..</param>
    /// <param name="discount">discount.</param>
    public ObjectDataAfterSearch(string queryID = default(string), Price price = default(Price), int quantity = default(int), Discount discount = default(Discount))
    {
      this.QueryID = queryID;
      this.Price = price;
      this.Quantity = quantity;
      this.Discount = discount;
    }

    /// <summary>
    /// ID of the query that this specific record is attributable to. Used to track purchase events with multiple items originating from different searches.
    /// </summary>
    /// <value>ID of the query that this specific record is attributable to. Used to track purchase events with multiple items originating from different searches.</value>
    [DataMember(Name = "queryID", EmitDefaultValue = false)]
    public string QueryID { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name = "price", EmitDefaultValue = false)]
    public Price Price { get; set; }

    /// <summary>
    /// The quantity of the purchased or added-to-cart item. The total value of a purchase is the sum of &#x60;quantity&#x60; multiplied with the &#x60;price&#x60; for each purchased item.
    /// </summary>
    /// <value>The quantity of the purchased or added-to-cart item. The total value of a purchase is the sum of &#x60;quantity&#x60; multiplied with the &#x60;price&#x60; for each purchased item.</value>
    [DataMember(Name = "quantity", EmitDefaultValue = false)]
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or Sets Discount
    /// </summary>
    [DataMember(Name = "discount", EmitDefaultValue = false)]
    public Discount Discount { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class ObjectDataAfterSearch {\n");
      sb.Append("  QueryID: ").Append(QueryID).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
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
      return this.Equals(input as ObjectDataAfterSearch);
    }

    /// <summary>
    /// Returns true if ObjectDataAfterSearch instances are equal
    /// </summary>
    /// <param name="input">Instance of ObjectDataAfterSearch to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ObjectDataAfterSearch input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.QueryID == input.QueryID ||
              (this.QueryID != null &&
              this.QueryID.Equals(input.QueryID))
          ) &&
          (
              this.Price == input.Price ||
              (this.Price != null &&
              this.Price.Equals(input.Price))
          ) &&
          (
              this.Quantity == input.Quantity ||
              this.Quantity.Equals(input.Quantity)
          ) &&
          (
              this.Discount == input.Discount ||
              (this.Discount != null &&
              this.Discount.Equals(input.Discount))
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
        if (this.QueryID != null)
        {
          hashCode = (hashCode * 59) + this.QueryID.GetHashCode();
        }
        if (this.Price != null)
        {
          hashCode = (hashCode * 59) + this.Price.GetHashCode();
        }
        hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
        if (this.Discount != null)
        {
          hashCode = (hashCode * 59) + this.Discount.GetHashCode();
        }
        return hashCode;
      }
    }

  }

}
