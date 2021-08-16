using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationAPI.Model
{
    [ExcludeFromCodeCoverage]
    public class User
    {
        public User() { }
        public User(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
