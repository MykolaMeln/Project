using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Users
    {
        public List<User> users = new List<User>();//список користувачів
        public Users() { }
        public void AddUser(User user)//додавання користувача в список
        {
            users.Add(user);
        }

    }
}
