using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q2
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private User[] users = new User[]
        {
            new User("admin", "admin", "Admin"),
            new User("user1", "123", "User"),
            new User("user2", "321", "User")
        };
      public  bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username == username && users[i].role == role)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

