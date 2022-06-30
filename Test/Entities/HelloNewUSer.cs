using Assignment2.Entities;
using System.Xml.Serialization;

namespace Test.Entities
{
    public class HelloNewUSer : User
    {
        public HelloNewUSer() { }

        public HelloNewUSer(string firstName, string lastName, string email, string nationality, string phoneNumberWork, string dateStarted)
            : base(firstName, lastName, email, nationality)
        {

        }
    }
}
