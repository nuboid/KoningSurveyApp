using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CourseRequest {
    /// <summary>
    /// Course name as it appears in eloomi
    /// </summary>
    /// <value>Course name as it appears in eloomi</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A description of the course
    /// </summary>
    /// <value>A description of the course</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Type of course. `Offline` is called onsite in the eloomi platform
    /// </summary>
    /// <value>Type of course. `Offline` is called onsite in the eloomi platform</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Flag to indicate if the course is active
    /// </summary>
    /// <value>Flag to indicate if the course is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public int? Active { get; set; }

    /// <summary>
    /// The amount of points a user gets upon course completion
    /// </summary>
    /// <value>The amount of points a user gets upon course completion</value>
    [DataMember(Name="points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "points")]
    public decimal? Points { get; set; }

    /// <summary>
    /// A flag that indicates whether or not points are enabled for this course
    /// </summary>
    /// <value>A flag that indicates whether or not points are enabled for this course</value>
    [DataMember(Name="reward", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward")]
    public decimal? Reward { get; set; }

    /// <summary>
    /// Expected time to finish the course in minutes
    /// </summary>
    /// <value>Expected time to finish the course in minutes</value>
    [DataMember(Name="expected_duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_duration")]
    public decimal? ExpectedDuration { get; set; }

    /// <summary>
    /// The price of the course if applicable.
    /// </summary>
    /// <value>The price of the course if applicable.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// A reference number of the course.
    /// </summary>
    /// <value>A reference number of the course.</value>
    [DataMember(Name="reference_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference_number")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomAttributes
    /// </summary>
    [DataMember(Name="customAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customAttributes")]
    public Object CustomAttributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CourseRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
      sb.Append("  Reward: ").Append(Reward).Append("\n");
      sb.Append("  ExpectedDuration: ").Append(ExpectedDuration).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
