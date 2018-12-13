using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class User
    {
        public int UserCode { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
