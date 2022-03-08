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
            var types = typeof(User).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(User)));
            foreach (var type in types)
            {
                var properties = type.GetProperties();
            }
            // Console.WriteLine(type.Name);
            //  var a = type.Attributes;
        }
    }
}