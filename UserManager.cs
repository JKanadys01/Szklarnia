using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    internal class UserManager
    {
        private Dictionary<string, string> users;
        public UserManager() 
        {
            users = new Dictionary<string, string>();
            users.Add("admin", "admin123");
            users.Add("user", "user123");
        }

        public bool Authenticate (string username, string password)
        {
            if (users.ContainsKey(username)) 
            {
                return users[username] == password;
            }
            return false;
        }
    }
}
