using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Test
{
    internal class User
    {
        internal string name;
        internal string login;
        internal string password;

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;            
        }
    }
}
