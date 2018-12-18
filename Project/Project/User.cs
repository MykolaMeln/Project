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
        public int Index { get; set; }
        public User() { }
        public User(string login, string password, int index)
        {
            Login = login;
            Password = password;
            Index = index;
        }
        
        
    }
}
