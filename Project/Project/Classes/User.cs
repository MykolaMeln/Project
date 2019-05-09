using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        public string Login { get; set; }//логін користувача
        public string Password { get; set; }//пароль користувача 
        public int Index { get; set; }//адміністратор чи ні
        public User() { }
        public User(string login, string password, int index)
        {
            Login = login;
            Password = password;
            Index = index;
        }

        
    }
}
