using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public abstract class User : IUser
    {
        private int id;
        //add fields according to properties
        private string firstName;
        private string lastName;
        private string email;
        private string nationality;


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
