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

namespace Algolia.Search.Insights.Models
{
  /// <summary>
  /// EventsItems
  /// </summary>
  [JsonConverter(typeof(EventsItemsJsonConverter))]
  [DataContract(Name = "EventsItems")]
  public partial class EventsItems : AbstractSchema, IEquatable<EventsItems>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ClickedObjectIDsAfterSearch" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ClickedObjectIDsAfterSearch.</param>
    public EventsItems(ClickedObjectIDsAfterSearch actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ConvertedObjectIDsAfterSearch" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ConvertedObjectIDsAfterSearch.</param>
    public EventsItems(ConvertedObjectIDsAfterSearch actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ClickedObjectIDs" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ClickedObjectIDs.</param>
    public EventsItems(ClickedObjectIDs actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ConvertedObjectIDs" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ConvertedObjectIDs.</param>
    public EventsItems(ConvertedObjectIDs actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ClickedFilters" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ClickedFilters.</param>
    public EventsItems(ClickedFilters actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ConvertedFilters" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ConvertedFilters.</param>
    public EventsItems(ConvertedFilters actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ViewedObjectIDs" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ViewedObjectIDs.</param>
    public EventsItems(ViewedObjectIDs actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="ViewedFilters" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of ViewedFilters.</param>
    public EventsItems(ViewedFilters actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="AddedToCartObjectIDsAfterSearch" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of AddedToCartObjectIDsAfterSearch.</param>
    public EventsItems(AddedToCartObjectIDsAfterSearch actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="AddedToCartObjectIDs" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of AddedToCartObjectIDs.</param>
    public EventsItems(AddedToCartObjectIDs actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="PurchasedObjectIDs" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of PurchasedObjectIDs.</param>
    public EventsItems(PurchasedObjectIDs actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventsItems" /> class
    /// with the <see cref="PurchasedObjectIDsAfterSearch" /> class
    /// </summary>
    /// <param name="actualInstance">An instance of PurchasedObjectIDsAfterSearch.</param>
    public EventsItems(PurchasedObjectIDsAfterSearch actualInstance)
    {
      this.IsNullable = false;
      this.SchemaType = "oneOf";
      this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
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
        if (value.GetType() == typeof(AddedToCartObjectIDs))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(AddedToCartObjectIDsAfterSearch))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ClickedFilters))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ClickedObjectIDs))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ClickedObjectIDsAfterSearch))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ConvertedFilters))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ConvertedObjectIDs))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ConvertedObjectIDsAfterSearch))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(PurchasedObjectIDs))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(PurchasedObjectIDsAfterSearch))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ViewedFilters))
        {
          this._actualInstance = value;
        }
        else if (value.GetType() == typeof(ViewedObjectIDs))
        {
          this._actualInstance = value;
        }
        else
        {
          throw new ArgumentException("Invalid instance found. Must be the following types: AddedToCartObjectIDs, AddedToCartObjectIDsAfterSearch, ClickedFilters, ClickedObjectIDs, ClickedObjectIDsAfterSearch, ConvertedFilters, ConvertedObjectIDs, ConvertedObjectIDsAfterSearch, PurchasedObjectIDs, PurchasedObjectIDsAfterSearch, ViewedFilters, ViewedObjectIDs");
        }
      }
    }

    /// <summary>
    /// Get the actual instance of `ClickedObjectIDsAfterSearch`. If the actual instance is not `ClickedObjectIDsAfterSearch`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ClickedObjectIDsAfterSearch</returns>
    public ClickedObjectIDsAfterSearch GetterClickedObjectIDsAfterSearch()
    {
      return (ClickedObjectIDsAfterSearch)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ConvertedObjectIDsAfterSearch`. If the actual instance is not `ConvertedObjectIDsAfterSearch`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ConvertedObjectIDsAfterSearch</returns>
    public ConvertedObjectIDsAfterSearch GetterConvertedObjectIDsAfterSearch()
    {
      return (ConvertedObjectIDsAfterSearch)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ClickedObjectIDs`. If the actual instance is not `ClickedObjectIDs`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ClickedObjectIDs</returns>
    public ClickedObjectIDs GetterClickedObjectIDs()
    {
      return (ClickedObjectIDs)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ConvertedObjectIDs`. If the actual instance is not `ConvertedObjectIDs`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ConvertedObjectIDs</returns>
    public ConvertedObjectIDs GetterConvertedObjectIDs()
    {
      return (ConvertedObjectIDs)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ClickedFilters`. If the actual instance is not `ClickedFilters`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ClickedFilters</returns>
    public ClickedFilters GetterClickedFilters()
    {
      return (ClickedFilters)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ConvertedFilters`. If the actual instance is not `ConvertedFilters`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ConvertedFilters</returns>
    public ConvertedFilters GetterConvertedFilters()
    {
      return (ConvertedFilters)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ViewedObjectIDs`. If the actual instance is not `ViewedObjectIDs`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ViewedObjectIDs</returns>
    public ViewedObjectIDs GetterViewedObjectIDs()
    {
      return (ViewedObjectIDs)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `ViewedFilters`. If the actual instance is not `ViewedFilters`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of ViewedFilters</returns>
    public ViewedFilters GetterViewedFilters()
    {
      return (ViewedFilters)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `AddedToCartObjectIDsAfterSearch`. If the actual instance is not `AddedToCartObjectIDsAfterSearch`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of AddedToCartObjectIDsAfterSearch</returns>
    public AddedToCartObjectIDsAfterSearch GetterAddedToCartObjectIDsAfterSearch()
    {
      return (AddedToCartObjectIDsAfterSearch)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `AddedToCartObjectIDs`. If the actual instance is not `AddedToCartObjectIDs`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of AddedToCartObjectIDs</returns>
    public AddedToCartObjectIDs GetterAddedToCartObjectIDs()
    {
      return (AddedToCartObjectIDs)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `PurchasedObjectIDs`. If the actual instance is not `PurchasedObjectIDs`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of PurchasedObjectIDs</returns>
    public PurchasedObjectIDs GetterPurchasedObjectIDs()
    {
      return (PurchasedObjectIDs)this.ActualInstance;
    }

    /// <summary>
    /// Get the actual instance of `PurchasedObjectIDsAfterSearch`. If the actual instance is not `PurchasedObjectIDsAfterSearch`,
    /// the InvalidClassException will be thrown
    /// </summary>
    /// <returns>An instance of PurchasedObjectIDsAfterSearch</returns>
    public PurchasedObjectIDsAfterSearch GetterPurchasedObjectIDsAfterSearch()
    {
      return (PurchasedObjectIDsAfterSearch)this.ActualInstance;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class EventsItems {\n");
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
      return JsonConvert.SerializeObject(this.ActualInstance, EventsItems.SerializerSettings);
    }

    /// <summary>
    /// Converts the JSON string into an instance of EventsItems
    /// </summary>
    /// <param name="jsonString">JSON string</param>
    /// <returns>An instance of EventsItems</returns>
    public static EventsItems FromJson(string jsonString)
    {
      EventsItems newEventsItems = null;

      if (string.IsNullOrEmpty(jsonString))
      {
        return newEventsItems;
      }
      int match = 0;
      List<string> matchedTypes = new List<string>();

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(AddedToCartObjectIDs).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<AddedToCartObjectIDs>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<AddedToCartObjectIDs>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("AddedToCartObjectIDs");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddedToCartObjectIDs: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(AddedToCartObjectIDsAfterSearch).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<AddedToCartObjectIDsAfterSearch>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<AddedToCartObjectIDsAfterSearch>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("AddedToCartObjectIDsAfterSearch");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddedToCartObjectIDsAfterSearch: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ClickedFilters).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ClickedFilters>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ClickedFilters>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ClickedFilters");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClickedFilters: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ClickedObjectIDs).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ClickedObjectIDs>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ClickedObjectIDs>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ClickedObjectIDs");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClickedObjectIDs: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ClickedObjectIDsAfterSearch).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ClickedObjectIDsAfterSearch>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ClickedObjectIDsAfterSearch>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ClickedObjectIDsAfterSearch");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClickedObjectIDsAfterSearch: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ConvertedFilters).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ConvertedFilters>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ConvertedFilters>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ConvertedFilters");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ConvertedFilters: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ConvertedObjectIDs).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ConvertedObjectIDs>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ConvertedObjectIDs>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ConvertedObjectIDs");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ConvertedObjectIDs: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ConvertedObjectIDsAfterSearch).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ConvertedObjectIDsAfterSearch>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ConvertedObjectIDsAfterSearch>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ConvertedObjectIDsAfterSearch");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ConvertedObjectIDsAfterSearch: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(PurchasedObjectIDs).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<PurchasedObjectIDs>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<PurchasedObjectIDs>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("PurchasedObjectIDs");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PurchasedObjectIDs: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(PurchasedObjectIDsAfterSearch).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<PurchasedObjectIDsAfterSearch>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<PurchasedObjectIDsAfterSearch>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("PurchasedObjectIDsAfterSearch");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PurchasedObjectIDsAfterSearch: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ViewedFilters).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ViewedFilters>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ViewedFilters>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ViewedFilters");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ViewedFilters: {1}", jsonString, exception.ToString()));
      }

      try
      {
        // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
        if (typeof(ViewedObjectIDs).GetProperty("AdditionalProperties") == null)
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ViewedObjectIDs>(jsonString, EventsItems.SerializerSettings));
        }
        else
        {
          newEventsItems = new EventsItems(JsonConvert.DeserializeObject<ViewedObjectIDs>(jsonString, EventsItems.AdditionalPropertiesSerializerSettings));
        }
        matchedTypes.Add("ViewedObjectIDs");
        match++;
      }
      catch (Exception exception)
      {
        // deserialization failed, try the next one
        System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ViewedObjectIDs: {1}", jsonString, exception.ToString()));
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
      return newEventsItems;
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
      return this.Equals(input as EventsItems);
    }

    /// <summary>
    /// Returns true if EventsItems instances are equal
    /// </summary>
    /// <param name="input">Instance of EventsItems to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventsItems input)
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
  /// Custom JSON converter for EventsItems
  /// </summary>
  public class EventsItemsJsonConverter : JsonConverter
  {
    /// <summary>
    /// To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="serializer">JSON Serializer</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      writer.WriteRawValue((string)(typeof(EventsItems).GetMethod("ToJson").Invoke(value, null)));
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
        return EventsItems.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
