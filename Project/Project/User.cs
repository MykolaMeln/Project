using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Index { get; set; }

        public User(string login, string password, bool index)
        {
            Login = login;
            Password = password;
            Index = index;
        }
        
        
    }
}
