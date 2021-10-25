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
  public class UserRequest {
    /// <summary>
    /// The users first name
    /// </summary>
    /// <value>The users first name</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The users last name
    /// </summary>
    /// <value>The users last name</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// The users employee id
    /// </summary>
    /// <value>The users employee id</value>
    [DataMember(Name="employee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "employee_id")]
    public string EmployeeId { get; set; }

    /// <summary>
    /// The users password
    /// </summary>
    /// <value>The users password</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// The users role
    /// </summary>
    /// <value>The users role</value>
    [DataMember(Name="generic_role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generic_role")]
    public string GenericRole { get; set; }

    /// <summary>
    ///  When the employee starts employment
    /// </summary>
    /// <value> When the employee starts employment</value>
    [DataMember(Name="start_of_employment_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_of_employment_at")]
    public string StartOfEmploymentAt { get; set; }

    /// <summary>
    ///  When the employee ends employment
    /// </summary>
    /// <value> When the employee ends employment</value>
    [DataMember(Name="end_of_employment_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_of_employment_at")]
    public string EndOfEmploymentAt { get; set; }

    /// <summary>
    ///  The users email
    /// </summary>
    /// <value> The users email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    ///  The users personal email
    /// </summary>
    /// <value> The users personal email</value>
    [DataMember(Name="personal_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personal_email")]
    public string PersonalEmail { get; set; }

    /// <summary>
    /// How user should be activated<ul><li>`deactivate` - Do not activate the user</li><li>`standard` - Send user an email with activation link</li><li>`company_default` - What is specified at the company level</li><li>`pre_generated_password` - Activate user and send a pregenerated password</li><li>`instant` Activate user</li></ul>
    /// </summary>
    /// <value>How user should be activated<ul><li>`deactivate` - Do not activate the user</li><li>`standard` - Send user an email with activation link</li><li>`company_default` - What is specified at the company level</li><li>`pre_generated_password` - Activate user and send a pregenerated password</li><li>`instant` Activate user</li></ul></value>
    [DataMember(Name="activate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activate")]
    public string Activate { get; set; }

    /// <summary>
    /// The language to be used in eloomi (Defaults to the langauge specified on a company level)
    /// </summary>
    /// <value>The language to be used in eloomi (Defaults to the langauge specified on a company level)</value>
    [DataMember(Name="language_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language_code")]
    public string LanguageCode { get; set; }

    /// <summary>
    /// The users title
    /// </summary>
    /// <value>The users title</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The users phone number
    /// </summary>
    /// <value>The users phone number</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The users mobile phone number
    /// </summary>
    /// <value>The users mobile phone number</value>
    [DataMember(Name="mobile_phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile_phone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Gets or Sets DepartmentCode
    /// </summary>
    [DataMember(Name="department_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "department_code")]
    public List<string> DepartmentCode { get; set; }

    /// <summary>
    /// Gets or Sets DepartmentId
    /// </summary>
    [DataMember(Name="department_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "department_id")]
    public List<string> DepartmentId { get; set; }

    /// <summary>
    /// Gets or Sets TeamIds
    /// </summary>
    [DataMember(Name="team_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_ids")]
    public List<string> TeamIds { get; set; }

    /// <summary>
    /// The users default access (Defaults to user)
    /// </summary>
    /// <value>The users default access (Defaults to user)</value>
    [DataMember(Name="user_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_permission")]
    public string UserPermission { get; set; }

    /// <summary>
    /// The id(s) of the users profile(s)
    /// </summary>
    /// <value>The id(s) of the users profile(s)</value>
    [DataMember(Name="profile_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile_ids")]
    public List<int?> ProfileIds { get; set; }

    /// <summary>
    /// The IDs of the access groups the user belongs to
    /// </summary>
    /// <value>The IDs of the access groups the user belongs to</value>
    [DataMember(Name="access_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_groups")]
    public List<int?> AccessGroups { get; set; }

    /// <summary>
    ///  The eloomi id of the direct managers of the user
    /// </summary>
    /// <value> The eloomi id of the direct managers of the user</value>
    [DataMember(Name="direct_manager_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direct_manager_ids")]
    public List<int?> DirectManagerIds { get; set; }

    /// <summary>
    ///  The employee ids of the direct managers of the user
    /// </summary>
    /// <value> The employee ids of the direct managers of the user</value>
    [DataMember(Name="direct_manager_employee_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direct_manager_employee_ids")]
    public List<string> DirectManagerEmployeeIds { get; set; }

    /// <summary>
    /// User will be prompted to fill out these properties when they login the next time, if a property isn't defined, he is not propmted to fill it out at all, if it's true it's required to be filled out, if it's false then it's optional.
    /// </summary>
    /// <value>User will be prompted to fill out these properties when they login the next time, if a property isn't defined, he is not propmted to fill it out at all, if it's true it's required to be filled out, if it's false then it's optional.</value>
    [DataMember(Name="prompts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prompts")]
    public Object Prompts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRequest {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  GenericRole: ").Append(GenericRole).Append("\n");
      sb.Append("  StartOfEmploymentAt: ").Append(StartOfEmploymentAt).Append("\n");
      sb.Append("  EndOfEmploymentAt: ").Append(EndOfEmploymentAt).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
      sb.Append("  Activate: ").Append(Activate).Append("\n");
      sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  DepartmentCode: ").Append(DepartmentCode).Append("\n");
      sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
      sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
      sb.Append("  UserPermission: ").Append(UserPermission).Append("\n");
      sb.Append("  ProfileIds: ").Append(ProfileIds).Append("\n");
      sb.Append("  AccessGroups: ").Append(AccessGroups).Append("\n");
      sb.Append("  DirectManagerIds: ").Append(DirectManagerIds).Append("\n");
      sb.Append("  DirectManagerEmployeeIds: ").Append(DirectManagerEmployeeIds).Append("\n");
      sb.Append("  Prompts: ").Append(Prompts).Append("\n");
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
