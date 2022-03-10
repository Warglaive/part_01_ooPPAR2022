using Assignment2.Entities;
using System;
using System.Globalization;

namespace Assignment2 // Note: actual namespace depends on the project name.
{
    public class StartUp
    {
        public static void Main()
        {
            //use reflection to get Entities data
            /* User Lecturer = new Lecturer("asd", "asd", "email", "xasd", "213231", DateTime.Now);
             var types = typeof(User).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(User)));
             foreach (var type in types)
             {
                 var properties = type.GetProperties();
             }*/
            //print first menu
            PrintFirstMenu();
        }

        private static void PrintFirstMenu()
        {
            //TODO: Print menu and start Create user
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("1. Create user");
            Console.WriteLine("2. Show overview users in database");
            Console.WriteLine("3. Show user details");
            Console.WriteLine("4. Exit application");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateUser();
                    break;
                default:
                    break;
            }
        }

        private static void CreateUser()
        {
            //get all User types and make the user select which to create
            var userTypes = typeof(User).Assembly.GetTypes().Where(x=>x.IsSubclassOf(typeof(User)));
            //get all fields for the selected type and make the user fill them
            //create selected user type
        }
    }
}


/*var a = DateTime.ParseExact("03-10-22", "MM-dd-yy", CultureInfo.InvariantCulture);
*/