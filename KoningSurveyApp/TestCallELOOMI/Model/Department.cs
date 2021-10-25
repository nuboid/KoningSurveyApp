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
  public class Department {
    /// <summary>
    /// eloomis internal id for the department
    /// </summary>
    /// <value>eloomis internal id for the department</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// IDs of the users in the department
    /// </summary>
    /// <value>IDs of the users in the department</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<long?> Users { get; set; }

    /// <summary>
    /// IDs of the leaders of the department
    /// </summary>
    /// <value>IDs of the leaders of the department</value>
    [DataMember(Name="leaders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leaders")]
    public List<long?> Leaders { get; set; }

    /// <summary>
    /// IDs of the access groups that will be inherited by department members
    /// </summary>
    /// <value>IDs of the access groups that will be inherited by department members</value>
    [DataMember(Name="access_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_groups")]
    public List<Object> AccessGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Department {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Leaders: ").Append(Leaders).Append("\n");
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
