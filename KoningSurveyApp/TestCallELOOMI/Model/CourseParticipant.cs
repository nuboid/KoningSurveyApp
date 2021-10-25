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
  public class CourseParticipant {
    /// <summary>
    /// eloomis internal id for the course
    /// </summary>
    /// <value>eloomis internal id for the course</value>
    [DataMember(Name="course_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "course_id")]
    public int? CourseId { get; set; }

    /// <summary>
    /// eloomis internal id for the user
    /// </summary>
    /// <value>eloomis internal id for the user</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// When the user was assigned the course
    /// </summary>
    /// <value>When the user was assigned the course</value>
    [DataMember(Name="assigned_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigned_at")]
    public string AssignedAt { get; set; }

    /// <summary>
    /// When the user needs to have completed the course
    /// </summary>
    /// <value>When the user needs to have completed the course</value>
    [DataMember(Name="deadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deadline")]
    public string Deadline { get; set; }

    /// <summary>
    /// When the user started taking the course
    /// </summary>
    /// <value>When the user started taking the course</value>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public string StartedAt { get; set; }

    /// <summary>
    /// When the user completed the course
    /// </summary>
    /// <value>When the user completed the course</value>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public string CompletedAt { get; set; }

    /// <summary>
    /// Seconds spent completing the course
    /// </summary>
    /// <value>Seconds spent completing the course</value>
    [DataMember(Name="time_spent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time_spent")]
    public decimal? TimeSpent { get; set; }

    /// <summary>
    /// How many attempts it has taken the user to finish so far
    /// </summary>
    /// <value>How many attempts it has taken the user to finish so far</value>
    [DataMember(Name="attempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attempts")]
    public decimal? Attempts { get; set; }

    /// <summary>
    /// A stringified number that tells the users score
    /// </summary>
    /// <value>A stringified number that tells the users score</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public string Score { get; set; }

    /// <summary>
    /// How far the user has progressed in the course in percent
    /// </summary>
    /// <value>How far the user has progressed in the course in percent</value>
    [DataMember(Name="progress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progress")]
    public decimal? Progress { get; set; }

    /// <summary>
    /// A flag to indicate if the course is required for the user or not
    /// </summary>
    /// <value>A flag to indicate if the course is required for the user or not</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public decimal? Required { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CourseParticipant {\n");
      sb.Append("  CourseId: ").Append(CourseId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  AssignedAt: ").Append(AssignedAt).Append("\n");
      sb.Append("  Deadline: ").Append(Deadline).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
      sb.Append("  TimeSpent: ").Append(TimeSpent).Append("\n");
      sb.Append("  Attempts: ").Append(Attempts).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  Progress: ").Append(Progress).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
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
