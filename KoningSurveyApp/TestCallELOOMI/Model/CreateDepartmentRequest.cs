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
  public class CreateDepartmentRequest {
    /// <summary>
    /// Department name is it should appear in eloomi
    /// </summary>
    /// <value>Department name is it should appear in eloomi</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Your companys id for the department
    /// </summary>
    /// <value>Your companys id for the department</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// eloomis internal id of the parent department
    /// </summary>
    /// <value>eloomis internal id of the parent department</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public int? ParentId { get; set; }

    /// <summary>
    /// Your companys id for the parent department
    /// </summary>
    /// <value>Your companys id for the parent department</value>
    [DataMember(Name="parent_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_code")]
    public string ParentCode { get; set; }

    /// <summary>
    /// IDs of the users that should be added to the department
    /// </summary>
    /// <value>IDs of the users that should be added to the department</value>
    [DataMember(Name="add_user_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_user_ids")]
    public List<int?> AddUserIds { get; set; }

    /// <summary>
    /// IDs of the users that should be removed from the department
    /// </summary>
    /// <value>IDs of the users that should be removed from the department</value>
    [DataMember(Name="remove_user_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remove_user_ids")]
    public List<int?> RemoveUserIds { get; set; }

    /// <summary>
    /// IDs of the courses that should be removed from the department
    /// </summary>
    /// <value>IDs of the courses that should be removed from the department</value>
    [DataMember(Name="remove_course_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remove_course_ids")]
    public List<int?> RemoveCourseIds { get; set; }

    /// <summary>
    /// IDs of the courses that should be added to the department
    /// </summary>
    /// <value>IDs of the courses that should be added to the department</value>
    [DataMember(Name="add_course_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_course_ids")]
    public List<int?> AddCourseIds { get; set; }

    /// <summary>
    /// IDs of the users in the department
    /// </summary>
    /// <value>IDs of the users in the department</value>
    [DataMember(Name="user_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_ids")]
    public List<int?> UserIds { get; set; }

    /// <summary>
    /// Emails of the users in the department
    /// </summary>
    /// <value>Emails of the users in the department</value>
    [DataMember(Name="user_emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_emails")]
    public List<string> UserEmails { get; set; }

    /// <summary>
    /// IDs of the leaders of the department
    /// </summary>
    /// <value>IDs of the leaders of the department</value>
    [DataMember(Name="leader_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leader_ids")]
    public List<int?> LeaderIds { get; set; }

    /// <summary>
    /// Employee IDs of the leaders of the department
    /// </summary>
    /// <value>Employee IDs of the leaders of the department</value>
    [DataMember(Name="leader_employee_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leader_employee_ids")]
    public List<string> LeaderEmployeeIds { get; set; }

    /// <summary>
    /// IDs of the access groups that will be inherited by department members
    /// </summary>
    /// <value>IDs of the access groups that will be inherited by department members</value>
    [DataMember(Name="access_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_groups")]
    public List<int?> AccessGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateDepartmentRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  ParentCode: ").Append(ParentCode).Append("\n");
      sb.Append("  AddUserIds: ").Append(AddUserIds).Append("\n");
      sb.Append("  RemoveUserIds: ").Append(RemoveUserIds).Append("\n");
      sb.Append("  RemoveCourseIds: ").Append(RemoveCourseIds).Append("\n");
      sb.Append("  AddCourseIds: ").Append(AddCourseIds).Append("\n");
      sb.Append("  UserIds: ").Append(UserIds).Append("\n");
      sb.Append("  UserEmails: ").Append(UserEmails).Append("\n");
      sb.Append("  LeaderIds: ").Append(LeaderIds).Append("\n");
      sb.Append("  LeaderEmployeeIds: ").Append(LeaderEmployeeIds).Append("\n");
      sb.Append("  AccessGroups: ").Append(AccessGroups).Append("\n");
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
