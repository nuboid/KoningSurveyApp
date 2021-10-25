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
  public class User {
    /// <summary>
    /// eloomis internal id for the department
    /// </summary>
    /// <value>eloomis internal id for the department</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Users first name
    /// </summary>
    /// <value>Users first name</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Users last name
    /// </summary>
    /// <value>Users last name</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Employees ID. Used to identify with other systems.
    /// </summary>
    /// <value>Employees ID. Used to identify with other systems.</value>
    [DataMember(Name="employee_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "employee_id")]
    public string EmployeeId { get; set; }

    /// <summary>
    /// The users email
    /// </summary>
    /// <value>The users email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The users username
    /// </summary>
    /// <value>The users username</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    /// <summary>
    /// The time at which the user activated the eloomi account
    /// </summary>
    /// <value>The time at which the user activated the eloomi account</value>
    [DataMember(Name="activated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activated_at")]
    public string ActivatedAt { get; set; }

    /// <summary>
    /// The user gender
    /// </summary>
    /// <value>The user gender</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// The users birthday
    /// </summary>
    /// <value>The users birthday</value>
    [DataMember(Name="birthday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthday")]
    public string Birthday { get; set; }

    /// <summary>
    /// The time at which the user activated the eloomi account
    /// </summary>
    /// <value>The time at which the user activated the eloomi account</value>
    [DataMember(Name="department_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "department_id")]
    public List<int?> DepartmentId { get; set; }

    /// <summary>
    /// The users permission level
    /// </summary>
    /// <value>The users permission level</value>
    [DataMember(Name="user_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_permission")]
    public string UserPermission { get; set; }

    /// <summary>
    /// When did the user start employment
    /// </summary>
    /// <value>When did the user start employment</value>
    [DataMember(Name="start_of_employment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_of_employment")]
    public string StartOfEmployment { get; set; }

    /// <summary>
    /// When did the user end employment
    /// </summary>
    /// <value>When did the user end employment</value>
    [DataMember(Name="end_of_employment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_of_employment")]
    public string EndOfEmployment { get; set; }

    /// <summary>
    /// The users personal email
    /// </summary>
    /// <value>The users personal email</value>
    [DataMember(Name="personal_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personal_email")]
    public string PersonalEmail { get; set; }

    /// <summary>
    /// Title of the user
    /// </summary>
    /// <value>Title of the user</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Phone number of the user
    /// </summary>
    /// <value>Phone number of the user</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Mobile phone number of the user
    /// </summary>
    /// <value>Mobile phone number of the user</value>
    [DataMember(Name="mobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile")]
    public string Mobile { get; set; }

    /// <summary>
    /// Language of the user. Format given in example.
    /// </summary>
    /// <value>Language of the user. Format given in example.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// IDs of the access groups that will be inherited by department members
    /// </summary>
    /// <value>IDs of the access groups that will be inherited by department members</value>
    [DataMember(Name="access_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_groups")]
    public List<Object> AccessGroups { get; set; }

    /// <summary>
    /// Country of the user
    /// </summary>
    /// <value>Country of the user</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Location of the user
    /// </summary>
    /// <value>Location of the user</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// A users generic role
    /// </summary>
    /// <value>A users generic role</value>
    [DataMember(Name="generic_role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generic_role")]
    public string GenericRole { get; set; }

    /// <summary>
    /// The users timezone. Adheres to the tz database format (also knowns as the Olsen database)
    /// </summary>
    /// <value>The users timezone. Adheres to the tz database format (also knowns as the Olsen database)</value>
    [DataMember(Name="timezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Legal company
    /// </summary>
    /// <value>Legal company</value>
    [DataMember(Name="legal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legal")]
    public string Legal { get; set; }

    /// <summary>
    /// Language of the user. Format given in example.
    /// </summary>
    /// <value>Language of the user. Format given in example.</value>
    [DataMember(Name="level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level")]
    public int? Level { get; set; }

    /// <summary>
    /// The users initials
    /// </summary>
    /// <value>The users initials</value>
    [DataMember(Name="initials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initials")]
    public string Initials { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <value>Deprecated</value>
    [DataMember(Name="sub_company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sub_company")]
    public string SubCompany { get; set; }

    /// <summary>
    /// Deprecated.
    /// </summary>
    /// <value>Deprecated.</value>
    [DataMember(Name="skill_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skill_level")]
    public string SkillLevel { get; set; }

    /// <summary>
    /// Language of the user. Format given in example.
    /// </summary>
    /// <value>Language of the user. Format given in example.</value>
    [DataMember(Name="salary_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salary_id")]
    public int? SalaryId { get; set; }

    /// <summary>
    /// The IDs of the teams the user is a part of
    /// </summary>
    /// <value>The IDs of the teams the user is a part of</value>
    [DataMember(Name="team_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_id")]
    public List<int?> TeamId { get; set; }

    /// <summary>
    /// The IDs of the managers assigned directly to the user
    /// </summary>
    /// <value>The IDs of the managers assigned directly to the user</value>
    [DataMember(Name="direct_manager_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direct_manager_ids")]
    public List<int?> DirectManagerIds { get; set; }

    /// <summary>
    /// Object containing extra data defined by the company
    /// </summary>
    /// <value>Object containing extra data defined by the company</value>
    [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_attributes")]
    public Object CustomAttributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  ActivatedAt: ").Append(ActivatedAt).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Birthday: ").Append(Birthday).Append("\n");
      sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
      sb.Append("  UserPermission: ").Append(UserPermission).Append("\n");
      sb.Append("  StartOfEmployment: ").Append(StartOfEmployment).Append("\n");
      sb.Append("  EndOfEmployment: ").Append(EndOfEmployment).Append("\n");
      sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Mobile: ").Append(Mobile).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  AccessGroups: ").Append(AccessGroups).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  GenericRole: ").Append(GenericRole).Append("\n");
      sb.Append("  Timezone: ").Append(Timezone).Append("\n");
      sb.Append("  Legal: ").Append(Legal).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  Initials: ").Append(Initials).Append("\n");
      sb.Append("  SubCompany: ").Append(SubCompany).Append("\n");
      sb.Append("  SkillLevel: ").Append(SkillLevel).Append("\n");
      sb.Append("  SalaryId: ").Append(SalaryId).Append("\n");
      sb.Append("  TeamId: ").Append(TeamId).Append("\n");
      sb.Append("  DirectManagerIds: ").Append(DirectManagerIds).Append("\n");
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
