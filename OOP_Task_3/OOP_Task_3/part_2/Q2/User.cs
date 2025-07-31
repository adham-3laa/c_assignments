using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q2
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            this.role = role;
        }
    }
}
