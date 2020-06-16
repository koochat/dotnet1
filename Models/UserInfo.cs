using System;
using System.Collections.Generic;

namespace dotnet1.Models
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public string UserEmail { get; set; }
        public string UserTelephone { get; set; }
        public string IS_DELETE{ get; set; }

    }
}
