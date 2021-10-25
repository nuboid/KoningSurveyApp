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
  public class ParticipantCreateUpdateRequest {
    /// <summary>
    /// Flag to indicate if the course is mandatory or not
    /// </summary>
    /// <value>Flag to indicate if the course is mandatory or not</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public decimal? Required { get; set; }

    /// <summary>
    /// Date for when the course should be completed
    /// </summary>
    /// <value>Date for when the course should be completed</value>
    [DataMember(Name="deadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deadline")]
    public string Deadline { get; set; }

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
      sb.Append("class ParticipantCreateUpdateRequest {\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Deadline: ").Append(Deadline).Append("\n");
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
