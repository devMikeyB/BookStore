using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael_Baldwin_Lab_6
{
    internal class User
    {
        public User() {
            this.Name = "Unknown";
            this.Phone = "";
            this.Password = "Password";
        }

        public User(string name, string password, string phone = "")
        {
            this.Name = name;
            this.Phone = phone;
            this.Password = password;
        }

        public string Name { get;}
        public string Phone { get;}
        public string Password { get;}



        public override string ToString()
        {
            return Name;
        }
    }
}
