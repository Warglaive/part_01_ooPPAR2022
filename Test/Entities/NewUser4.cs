using Assignment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class NewUser4 : User
    {
        public string hobby;
        public string Hobby { get => hobby; set => hobby = value; }

        public NewUser4(string firstName, string lastName, string email, string nationality, string hobby)
            : base(firstName, lastName, email, nationality)
        {
            this.hobby = hobby;
        }
        public NewUser4()
        {
            //  this.hobby = "Test";
        }
    }
}
