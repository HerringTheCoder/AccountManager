using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Administrator : User
    {
        public Administrator(string login, string password) : base(login, password)
        {
            ElevatedPrivileges = true;
        }
    }
}
