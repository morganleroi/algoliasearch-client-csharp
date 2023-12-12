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

namespace Algolia.Search.Monitoring.Models
{
  /// <summary>
  /// Defines Period
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))]
  public enum Period
  {
    /// <summary>
    /// Enum Minute for value: minute
    /// </summary>
    [EnumMember(Value = "minute")]
    Minute = 1,

    /// <summary>
    /// Enum Hour for value: hour
    /// </summary>
    [EnumMember(Value = "hour")]
    Hour = 2,

    /// <summary>
    /// Enum Day for value: day
    /// </summary>
    [EnumMember(Value = "day")]
    Day = 3,

    /// <summary>
    /// Enum Week for value: week
    /// </summary>
    [EnumMember(Value = "week")]
    Week = 4,

    /// <summary>
    /// Enum Month for value: month
    /// </summary>
    [EnumMember(Value = "month")]
    Month = 5
  }

}
