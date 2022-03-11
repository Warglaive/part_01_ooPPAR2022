using Assignment2.Entities;
using System;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

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
            Command command = new Command();
            
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
            var userTypes = typeof(User).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(User)))
                .ToList();
            Console.WriteLine("Which type of User would you like to create? ");
            for (int i = 0; i < userTypes.Count; i++)
            {
                Console.WriteLine($"{userTypes[i].Name}");
            }
            string inputSelectedType = Console.ReadLine();

            var currentType = userTypes.Where(x => x.Name.Equals(inputSelectedType)).FirstOrDefault();

            // var typeProperties = currentType.GetProperties();
            var consoleInputArguments = new List<object>();
            var constructrs = currentType.GetConstructors();
            var firstCtor = constructrs[0];
            foreach (var parameter in firstCtor.GetParameters())
            {
                Console.WriteLine($"Add {parameter.Name}: ");
                //add to list
                consoleInputArguments.Add(Console.ReadLine());
            }
            //pass list to type's constructor
            var arr = consoleInputArguments.ToArray();
            var userInstance = Activator.CreateInstance(currentType, arr);
            //Save instance to XML
            //XmlSerializer xmlSerializer = new(currentType);

            XmlSerializer serializer = new XmlSerializer(userInstance.GetType());
            TextWriter streamWriter = new StreamWriter(@"D:\part_01_oo-Warglaive\oo_part_2\Assignment2PPAR\Storage\Users.xml");
            serializer.Serialize(streamWriter, userInstance);
            streamWriter.Close();
        }
    }
}