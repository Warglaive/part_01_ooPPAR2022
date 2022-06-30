using Assignment2.Entities;

namespace Test.Entities
{
    /// <summary>
    ///  Used to demonstrate reflection
    /// </summary>
    public class NewUser3Test : User
    {
        public NewUser3Test(string firstName, string lastName, string email, string nationality)
            : base(firstName, lastName, email, nationality)
        {

        }
        public NewUser3Test()
        {

        }
    }
}
