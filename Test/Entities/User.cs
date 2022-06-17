using Assignment2.Interfaces;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using Assignment2.Exceptions;

namespace Assignment2.Entities
{
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Lecturer))]
    [XmlInclude(typeof(TestUserType))]
    public abstract class User : IUser
    {
        AbstractDBFactory factory;
        //Read last id from XML
        private static int initialId = 0;
        private int id;
        //add fields according to properties
        private string? firstName;
        private string? lastName;
        private string? email;
        private string? nationality;

        public User()
        {

        }
        public User(string firstName, string lastName, string email, string nationality)
        {
            this.id = initialId++;

            this.firstName = firstName;
            this.lastName = lastName;
            //  TODO: Validate Email using own regex
            string emailValidationRegexPattern = @"^[A-Za-z0-9+_.-]+@(.+)$";
            Regex regex = new(emailValidationRegexPattern);
            //check if it is NOT a match -> Invalid email exception
            if (!regex.IsMatch(email))
            {
                throw new InvalidEmailException("Invalid Email format");

            }
            this.email = email;
            this.nationality = nationality;
        }

        [XmlElement(ElementName = "Id")]

        public int Id { get => id; set => id = value; }

        public string FirstName
        {
            get => firstName; set => firstName = value;
        }
        public string LastName
        {

            get => lastName; set => lastName = value;
        }
        public string Email
        {
            get => email; set => email = value;
        }

        public string Nationality
        {
            get => nationality; set => nationality = value;
        }
    }
}
