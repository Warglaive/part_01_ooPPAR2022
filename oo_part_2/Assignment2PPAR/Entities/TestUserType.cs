using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    public class TestUserType : User
    {
        public TestUserType(string firstName, string lastName, string email, string nationality) : base(firstName, lastName, email, nationality)
        {
        }
    }
}
