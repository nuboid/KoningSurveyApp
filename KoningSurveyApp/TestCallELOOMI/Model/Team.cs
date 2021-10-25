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
  public class Team {
    /// <summary>
    /// eloomis internal id for the department
    /// </summary>
    /// <value>eloomis internal id for the department</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the team
    /// </summary>
    /// <value>The name of the team</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A description of the team
    /// </summary>
    /// <value>A description of the team</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// IDs of the users in the department
    /// </summary>
    /// <value>IDs of the users in the department</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<int?> Users { get; set; }

    /// <summary>
    /// IDs of the leaders of the department
    /// </summary>
    /// <value>IDs of the leaders of the department</value>
    [DataMember(Name="leaders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leaders")]
    public List<int?> Leaders { get; set; }

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
      sb.Append("class Team {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Leaders: ").Append(Leaders).Append("\n");
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
