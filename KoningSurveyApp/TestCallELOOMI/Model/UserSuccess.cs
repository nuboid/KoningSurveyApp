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
  public class UserSuccess {
    /// <summary>
    /// HTTP Status text
    /// </summary>
    /// <value>HTTP Status text</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// HTTP Status code
    /// </summary>
    /// <value>HTTP Status code</value>
    [DataMember(Name="status_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_code")]
    public int? StatusCode { get; set; }

    /// <summary>
    /// Text to help with debugging
    /// </summary>
    /// <value>Text to help with debugging</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Text to help with debugging
    /// </summary>
    /// <value>Text to help with debugging</value>
    [DataMember(Name="extended_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extended_message")]
    public string ExtendedMessage { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public User Data { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSuccess {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  ExtendedMessage: ").Append(ExtendedMessage).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
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
