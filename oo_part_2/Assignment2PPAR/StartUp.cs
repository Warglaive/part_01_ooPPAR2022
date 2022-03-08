using Assignment2.Entities;
using System;

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
            while (Console.ReadLine() != null)
            {

            }
        }
    }
}