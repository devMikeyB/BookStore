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
            this.Phone = "5555555555";
        }

        public User(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;

        }

        public string Name { get;}
        public string Phone { get;}



        public override string ToString()
        {
            return Name;
        }
    }
}
