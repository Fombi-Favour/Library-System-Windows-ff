using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class User
    {
        public string School { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string school, string name, string password)
        {
            School = school;
            Name = name;
            Password = password;
        }
    }
}
