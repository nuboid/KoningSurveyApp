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
  public class AccessToken400 {
    /// <summary>
    /// Error code
    /// </summary>
    /// <value>Error code</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    /// <value>Error message</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Debugging help
    /// </summary>
    /// <value>Debugging help</value>
    [DataMember(Name="hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hint")]
    public string Hint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessToken400 {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Hint: ").Append(Hint).Append("\n");
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