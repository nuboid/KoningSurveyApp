using System;
using System.Collections.Generic;
using System.Text;

namespace TestCallELOOMI
{


    public class Rootobject
    {
        public string status { get; set; }
        public int status_code { get; set; }
        public string message { get; set; }
        public string extended_message { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string employee_id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string activated_at { get; set; }
        public string gender { get; set; }
        public string birthday { get; set; }
        public int[] department_id { get; set; }
        public string user_permission { get; set; }
        public string start_of_employment { get; set; }
        public string end_of_employment { get; set; }
        public string personal_email { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string language { get; set; }
        public Access_Groups[] access_groups { get; set; }
        public string country { get; set; }
        public string location { get; set; }
        public string generic_role { get; set; }
        public string timezone { get; set; }
        public string legal { get; set; }
        public int level { get; set; }
        public string initials { get; set; }
        public string sub_company { get; set; }
        public string skill_level { get; set; }
        public string salary_id { get; set; }
        public int[] team_id { get; set; }
        public int[] direct_manager_ids { get; set; }
        public Custom_Attributes custom_attributes { get; set; }
    }

    public class Custom_Attributes
    {
        public string hair_color { get; set; }
    }

    public class Access_Groups
    {
        public int id { get; set; }
        public string name { get; set; }
    }


}
