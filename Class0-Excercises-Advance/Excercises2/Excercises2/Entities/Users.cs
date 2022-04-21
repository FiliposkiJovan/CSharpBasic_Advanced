using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises2.Entities
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public Users(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
