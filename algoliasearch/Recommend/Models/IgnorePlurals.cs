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
using System.Reflection;
using Algolia.Search.Models;

namespace Algolia.Search.Recommend.Models
{
  /// <summary>
  /// Treats singular, plurals, and other forms of declensions as matching terms. &#x60;ignorePlurals&#x60; is used in conjunction with the &#x60;queryLanguages&#x60; setting. _list_: language ISO codes for which ignoring plurals should be enabled. This list will override any values that you may have set in &#x60;queryLanguages&#x60;. _true_: enables the ignore plurals feature, where singulars and plurals are considered equivalent (\&quot;foot\&quot; &#x3D; \&quot;feet\&quot;). The languages supported here are either [every language](https://www.algolia.com/doc/guides/managing-results/optimize-search-results/handling-natural-languages-nlp/in-depth/supported-languages/) (this is the default) or those set by &#x60;queryLanguages&#x60;. _false_: turns off the ignore plurals feature, so that singulars and plurals aren&#39;t considered to be the same (\&quot;foot\&quot; will not find \&quot;feet\&quot;). 
  /// </summary>
  [JsonConverter(typeof(IgnorePluralsJsonConverter))]
  [DataContract(Name = "ignorePlurals")]
  public partial class IgnorePlurals : AbstractSchema, IEquatable<IgnorePlurals>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="IgnorePlurals" /> class
    /// with the <see cref="List{String}" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of List&lt;string&gt;.</param>
    public IgnorePlurals(List<string> actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IgnorePlurals" /> class
    /// with the <see cref="bool" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of bool.</param>
    public IgnorePlurals(bool actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance;
    }


    private Object _actualInstance;

    /// <summary>
    /// Gets or Sets ActualInstance
    /// </summary>
    public override Object ActualInstance
    {
      get
      {
        return _actualInstance;
      }
      set
      {
        if (value.GetType() == typeof(List<string>))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(bool))
        {
          this._actualInstance = value;
        }
        else
        {
          throw new ArgumentException("Invalid instance found. Must be the following types: List<string>, bool");
        }
      }
    }

    /// <summary>
    /// Get the actual instance of `List&lt;string&gt;`. If the actual instance is not `List&lt;string&gt;`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of List&lt;string&gt;</returns>
    public List<string> GetterListString()
    {
      return (List<string>)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `bool`. If the actual instance is not `bool`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of bool</returns>
    public bool GetterBool()
    {
      return (bool)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class IgnorePlurals {\n");
      sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public override string ToJson()
    {
      return JsonConvert.SerializeObject(this.ActualInstance, IgnorePlurals.SerializerSettings);
    }

    /// <summary>
    /// Converts the JSON string into an instance of IgnorePlurals
    /// </summary>
    /// <param name="jsonString">JSON string</param>
    /// <returns>An instance of IgnorePlurals</returns>
    public static IgnorePlurals FromJson(string jsonString)
    {
      IgnorePlurals newIgnorePlurals = null;

      if (string.IsNullOrEmpty(jsonString))
      {
        return newIgnorePlurals;
      }
      int match = 0;
      List<string> matchedTypes = new List<string>();

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(List<string>).GetProperty("AdditionalProperties") == null)
        {
          newIgnorePlurals = new IgnorePlurals(JsonConvert.DeserializeObject<List<string>>(jsonString, IgnorePlurals.SerializerSettings));
        }
        else
        {
          newIgnorePlurals = new IgnorePlurals(JsonConvert.DeserializeObject<List<string>>(jsonString, IgnorePlurals.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("List<string>");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<string>: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(bool).GetProperty("AdditionalProperties") == null)
        {
          newIgnorePlurals = new IgnorePlurals(JsonConvert.DeserializeObject<bool>(jsonString, IgnorePlurals.SerializerSettings));
        }
        else
        {
          newIgnorePlurals = new IgnorePlurals(JsonConvert.DeserializeObject<bool>(jsonString, IgnorePlurals.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("bool");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into bool: {1}", jsonString, exception.ToString()));
      }

      if (match == 0)
      {
        throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
      }
      else if (match > 1)
      {
        throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
      }

      // deserialization is considered successful at this point if no exception has been thrown.
      return newIgnorePlurals;
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
      return this.Equals(input as IgnorePlurals);
    }

    /// <summary>
    /// Returns true if IgnorePlurals instances are equal
    /// </summary>
    /// <param name="input">Instance of IgnorePlurals to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IgnorePlurals input)
    {
      if (input == null)
        return false;

      return this.ActualInstance.Equals(input.ActualInstance);
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
        if (this.ActualInstance != null)
          hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
        return hashCode;
      }
    }
  }

  /// <summary>
  /// Custom JSON converter for IgnorePlurals
  /// </summary>
  public class IgnorePluralsJsonConverter : JsonConverter
  {
    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="serializer">JSON Serializer</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      writer.WriteRawValue((string)(typeof(IgnorePlurals).GetMethod("ToJson").Invoke(value, null)));
    }

    /// <summary>
    /// To convert a JSON string into an object
    /// </summary>
    /// <param name="reader">JSON reader</param>
    /// <param name="objectType">Object type</param>
    /// <param name="existingValue">Existing value</param>
    /// <param name="serializer">JSON Serializer</param>
    /// <returns>The object converted from the JSON string</returns>
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      if (reader.TokenType != JsonToken.Null)
      {
        return IgnorePlurals.FromJson(JObject.Load(reader).ToString(Formatting.None));
      }
      return null;
    }

    /// <summary>
    /// Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
      return false;
    }
  }

}
