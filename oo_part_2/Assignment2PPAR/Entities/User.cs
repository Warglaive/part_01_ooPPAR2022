using Assignment2.Factories;
using Assignment2.Interfaces;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public abstract class User : IUser
    {
        AbstractDBFactory factory;
        //Read last id from XML

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
            this.id = 0;
/*
            factory = new XMLDBFactory();
            try
            {
               // this.id = factory.ReadLastIdFromXML();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                this.id = 0;
            }*/
            this.firstName = firstName;
            this.lastName = lastName;
            //TODO: Validate Email using own regex
            //string emailValidationRegexPattern = @"^[A-Za-z0-9+_.-]+@(.+)$";
            //Regex regex = new(emailValidationRegexPattern);
            ////check if it is NOT a match -> Invalid email exception
            //if (!regex.IsMatch(email))
            //{
            //    
            //
            //}
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
