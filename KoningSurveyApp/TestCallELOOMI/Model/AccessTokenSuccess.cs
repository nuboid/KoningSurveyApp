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
  public class AccessTokenSuccess {
    /// <summary>
    ///  Type of access token
    /// </summary>
    /// <value> Type of access token</value>
    [DataMember(Name="token_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_type")]
    public string TokenType { get; set; }

    /// <summary>
    /// Token lifetime in seconds
    /// </summary>
    /// <value>Token lifetime in seconds</value>
    [DataMember(Name="expires_in", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    ///  Token to be used in subsequent API calls
    /// </summary>
    /// <value> Token to be used in subsequent API calls</value>
    [DataMember(Name="access_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_token")]
    public string AccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessTokenSuccess {\n");
      sb.Append("  TokenType: ").Append(TokenType).Append("\n");
      sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
      sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
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
