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
  public class AssignmentRequest {
    /// <summary>
    /// The eloomi ids of the users that should have this assigned
    /// </summary>
    /// <value>The eloomi ids of the users that should have this assigned</value>
    [DataMember(Name="user_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_ids")]
    public List<int?> UserIds { get; set; }

    /// <summary>
    /// The employee ids of the users that should have this assigned
    /// </summary>
    /// <value>The employee ids of the users that should have this assigned</value>
    [DataMember(Name="user_codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_codes")]
    public List<int?> UserCodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssignmentRequest {\n");
      sb.Append("  UserIds: ").Append(UserIds).Append("\n");
      sb.Append("  UserCodes: ").Append(UserCodes).Append("\n");
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
