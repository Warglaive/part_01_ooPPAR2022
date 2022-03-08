using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public abstract class User : IUser
    {
        //add fields according to properties
        //public string type;
        public string firstName;
        public string lastName;
        public string email;
        public string nationality;

        /* public string Type
         {
             //may not work, test it
             get => type; set => type = value;
         }*/
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
