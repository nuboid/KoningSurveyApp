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
  public class CategoryRequest {
    /// <summary>
    /// eloomis id of the parent of this category
    /// </summary>
    /// <value>eloomis id of the parent of this category</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public decimal? ParentId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public Object Name { get; set; }

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
      sb.Append("class CategoryRequest {\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
