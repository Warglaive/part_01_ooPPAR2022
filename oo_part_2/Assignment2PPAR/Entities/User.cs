using Assignment2.Interfaces;
using System.Text.RegularExpressions;

namespace Assignment2.Entities
{
    public abstract class User : IUser
    {
        public const int initId = 0;
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
            this.firstName = firstName;
            this.lastName = lastName;
            //TODO: Validate Email using own regex
            string emailValidationRegexPattern = @"^[A-Za-z0-9+_.-]+@(.+)$";
            Regex regex = new(emailValidationRegexPattern);
            //check if it is NOT a match -> Invalid email exception
            if (!regex.IsMatch(email))
            {
                

            }
            this.email = email;
            this.nationality = nationality;
        }


        public int Id { get => id; }

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
