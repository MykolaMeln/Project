using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Account : User//Singleton
    {
        private static Account account;
        private Account(User user)  : base(user) { }

        public static Account getInstance(User user)
        {
            if (account == null)
                account= new Account(user);
            return account;
        }
    }
}
