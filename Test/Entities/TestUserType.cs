using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public class TestUserType : User
    {
        public TestUserType(string firstName, string lastName, string email, string nationality)
            : base(firstName, lastName, email, nationality)
        {

        }
        public TestUserType() { }
    }
}