using Assignment2.Entities;
using System;

namespace Assignment2 // Note: actual namespace depends on the project name.
{
    public class StartUp
    {
        public static void Main()
        {
            //use reflection to get Entities data
            // User user = new();
            System.Type type = typeof(User);
            Console.WriteLine(type.Name);
            var a = type.Attributes;
        }
    }
}