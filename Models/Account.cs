using System;
using System.Collections.Generic;

namespace dotnet1.Models
{
    public partial class Account
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
