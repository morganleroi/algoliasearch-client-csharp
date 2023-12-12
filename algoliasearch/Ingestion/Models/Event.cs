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
  /// An event describe a step of the task execution flow..
  /// </summary>
  [DataContract(Name = "Event")]
  public partial class Event : IEquatable<Event>
  {

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public EventStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
    public EventType Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Event" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Event() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Event" /> class.
    /// </summary>
    /// <param name="eventID">The event UUID. (required).</param>
    /// <param name="runID">The run UUID. (required).</param>
    /// <param name="parentID">The parent event, the cause of this event..</param>
    /// <param name="status">status (required).</param>
    /// <param name="type">type (required).</param>
    /// <param name="batchSize">The extracted record batch size. (required).</param>
    /// <param name="data">data.</param>
    /// <param name="publishedAt">Date of publish (RFC3339 format). (required).</param>
    public Event(string eventID = default(string), string runID = default(string), string parentID = default(string), EventStatus status = default(EventStatus), EventType type = default(EventType), int batchSize = default(int), Dictionary<string, Object> data = default(Dictionary<string, Object>), string publishedAt = default(string))
    {
      // to ensure "eventID" is required (not null)
      if (eventID == null)
      {
        throw new ArgumentNullException("eventID is a required property for Event and cannot be null");
      }
      this.EventID = eventID;
      // to ensure "runID" is required (not null)
      if (runID == null)
      {
        throw new ArgumentNullException("runID is a required property for Event and cannot be null");
      }
      this.RunID = runID;
      this.Status = status;
      this.Type = type;
      this.BatchSize = batchSize;
      // to ensure "publishedAt" is required (not null)
      if (publishedAt == null)
      {
        throw new ArgumentNullException("publishedAt is a required property for Event and cannot be null");
      }
      this.PublishedAt = publishedAt;
      this.ParentID = parentID;
      this.Data = data;
    }

    /// <summary>
    /// The event UUID.
    /// </summary>
    /// <value>The event UUID.</value>
    [DataMember(Name = "eventID", IsRequired = true, EmitDefaultValue = true)]
    public string EventID { get; set; }

    /// <summary>
    /// The run UUID.
    /// </summary>
    /// <value>The run UUID.</value>
    [DataMember(Name = "runID", IsRequired = true, EmitDefaultValue = true)]
    public string RunID { get; set; }

    /// <summary>
    /// The parent event, the cause of this event.
    /// </summary>
    /// <value>The parent event, the cause of this event.</value>
    [DataMember(Name = "parentID", EmitDefaultValue = false)]
    public string ParentID { get; set; }

    /// <summary>
    /// The extracted record batch size.
    /// </summary>
    /// <value>The extracted record batch size.</value>
    [DataMember(Name = "batchSize", IsRequired = true, EmitDefaultValue = true)]
    public int BatchSize { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public Dictionary<string, Object> Data { get; set; }

    /// <summary>
    /// Date of publish (RFC3339 format).
    /// </summary>
    /// <value>Date of publish (RFC3339 format).</value>
    [DataMember(Name = "publishedAt", IsRequired = true, EmitDefaultValue = true)]
    public string PublishedAt { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("class Event {\n");
      sb.Append("  EventID: ").Append(EventID).Append("\n");
      sb.Append("  RunID: ").Append(RunID).Append("\n");
      sb.Append("  ParentID: ").Append(ParentID).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
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
      return this.Equals(input as Event);
    }

    /// <summary>
    /// Returns true if Event instances are equal
    /// </summary>
    /// <param name="input">Instance of Event to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Event input)
    {
      if (input == null)
      {
        return false;
      }
      return
          (
              this.EventID == input.EventID ||
              (this.EventID != null &&
              this.EventID.Equals(input.EventID))
          ) &&
          (
              this.RunID == input.RunID ||
              (this.RunID != null &&
              this.RunID.Equals(input.RunID))
          ) &&
          (
              this.ParentID == input.ParentID ||
              (this.ParentID != null &&
              this.ParentID.Equals(input.ParentID))
          ) &&
          (
              this.Status == input.Status ||
              this.Status.Equals(input.Status)
          ) &&
          (
              this.Type == input.Type ||
              this.Type.Equals(input.Type)
          ) &&
          (
              this.BatchSize == input.BatchSize ||
              this.BatchSize.Equals(input.BatchSize)
          ) &&
          (
              this.Data == input.Data ||
              this.Data != null &&
              input.Data != null &&
              this.Data.SequenceEqual(input.Data)
          ) &&
          (
              this.PublishedAt == input.PublishedAt ||
              (this.PublishedAt != null &&
              this.PublishedAt.Equals(input.PublishedAt))
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
        if (this.EventID != null)
        {
          hashCode = (hashCode * 59) + this.EventID.GetHashCode();
        }
        if (this.RunID != null)
        {
          hashCode = (hashCode * 59) + this.RunID.GetHashCode();
        }
        if (this.ParentID != null)
        {
          hashCode = (hashCode * 59) + this.ParentID.GetHashCode();
        }
        hashCode = (hashCode * 59) + this.Status.GetHashCode();
        hashCode = (hashCode * 59) + this.Type.GetHashCode();
        hashCode = (hashCode * 59) + this.BatchSize.GetHashCode();
        if (this.Data != null)
        {
          hashCode = (hashCode * 59) + this.Data.GetHashCode();
        }
        if (this.PublishedAt != null)
        {
          hashCode = (hashCode * 59) + this.PublishedAt.GetHashCode();
        }
        return hashCode;
      }
    }

  }

}
