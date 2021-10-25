using System;
using System.Collections.Generic;
using System.Text;

namespace TestCallELOOMI
{
    public class AuthResponse
    {
        public string token_type { get; set; }
        public Int64 expires_in { get; set; }
        public string access_token { get; set; }
       
    }
}
