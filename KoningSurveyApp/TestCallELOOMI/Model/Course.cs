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
  public class Course {
    /// <summary>
    /// eloomis internal id for the course
    /// </summary>
    /// <value>eloomis internal id for the course</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// The file id of the cover used for the course
    /// </summary>
    /// <value>The file id of the cover used for the course</value>
    [DataMember(Name="cover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover")]
    public int? Cover { get; set; }

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
    /// Flag to indicate if the course is mandatory or not
    /// </summary>
    /// <value>Flag to indicate if the course is mandatory or not</value>
    [DataMember(Name="voluntary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voluntary")]
    public decimal? Voluntary { get; set; }

    /// <summary>
    /// Flag to if it is possible to take the course after deadline
    /// </summary>
    /// <value>Flag to if it is possible to take the course after deadline</value>
    [DataMember(Name="lock_after_deadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_after_deadline")]
    public decimal? LockAfterDeadline { get; set; }

    /// <summary>
    /// Flag to indicate if the users leader should be informed about missed deadline
    /// </summary>
    /// <value>Flag to indicate if the users leader should be informed about missed deadline</value>
    [DataMember(Name="inform_leader_deadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inform_leader_deadline")]
    public decimal? InformLeaderDeadline { get; set; }

    /// <summary>
    /// When was the course created
    /// </summary>
    /// <value>When was the course created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// When was the course last updated
    /// </summary>
    /// <value>When was the course last updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Course {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Cover: ").Append(Cover).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
      sb.Append("  Reward: ").Append(Reward).Append("\n");
      sb.Append("  ExpectedDuration: ").Append(ExpectedDuration).Append("\n");
      sb.Append("  Voluntary: ").Append(Voluntary).Append("\n");
      sb.Append("  LockAfterDeadline: ").Append(LockAfterDeadline).Append("\n");
      sb.Append("  InformLeaderDeadline: ").Append(InformLeaderDeadline).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
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
