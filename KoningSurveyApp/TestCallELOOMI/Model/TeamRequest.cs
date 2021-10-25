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
  public class TeamRequest {
    /// <summary>
    /// The name of the team
    /// </summary>
    /// <value>The name of the team</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the team
    /// </summary>
    /// <value>The description of the team</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The eloomi ids of the team leaders
    /// </summary>
    /// <value>The eloomi ids of the team leaders</value>
    [DataMember(Name="leader_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leader_ids")]
    public List<int?> LeaderIds { get; set; }

    /// <summary>
    /// The eloomi ids of the users in the team
    /// </summary>
    /// <value>The eloomi ids of the users in the team</value>
    [DataMember(Name="user_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_ids")]
    public List<int?> UserIds { get; set; }

    /// <summary>
    /// The emails the users in the team
    /// </summary>
    /// <value>The emails the users in the team</value>
    [DataMember(Name="user_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_emails")]
    public List<string> UserEmails { get; set; }

    /// <summary>
    /// The employee ids of the users in the team
    /// </summary>
    /// <value>The employee ids of the users in the team</value>
    [DataMember(Name="employee_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "employee_ids")]
    public List<string> EmployeeIds { get; set; }

    /// <summary>
    /// IDs of the courses that should be removed from the team
    /// </summary>
    /// <value>IDs of the courses that should be removed from the team</value>
    [DataMember(Name="remove_course_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remove_course_ids")]
    public List<int?> RemoveCourseIds { get; set; }

    /// <summary>
    /// IDs of the courses that should be added to the team
    /// </summary>
    /// <value>IDs of the courses that should be added to the team</value>
    [DataMember(Name="add_course_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_course_ids")]
    public List<int?> AddCourseIds { get; set; }

    /// <summary>
    /// Gets or Sets CustomAttributes
    /// </summary>
    [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_attributes")]
    public Object CustomAttributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  LeaderIds: ").Append(LeaderIds).Append("\n");
      sb.Append("  UserIds: ").Append(UserIds).Append("\n");
      sb.Append("  UserEmails: ").Append(UserEmails).Append("\n");
      sb.Append("  EmployeeIds: ").Append(EmployeeIds).Append("\n");
      sb.Append("  RemoveCourseIds: ").Append(RemoveCourseIds).Append("\n");
      sb.Append("  AddCourseIds: ").Append(AddCourseIds).Append("\n");
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
