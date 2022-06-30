using Assignment2.Entities;
using Assignment2.Factories;

namespace Assignment2 // Note: actual namespace depends on the project name.
{
    public class GUIStartUp
    {
        static Command Command;
        static List<User> Users;
        static DBManager DbManager;
        public static void Main()
        {
            Command = new Command();
            DbManager = AbstractDBFactory.CreateDbManager();

            Users = new List<User>();
            PrintFirstMenu();
            //TEST PURPOSES
            Console.WriteLine("Waiting...");
            Console.ReadLine();

        }

        private static void PrintFirstMenu()
        {
            var functions = new List<Action>();

            Action action;
           
            
            //TODO: Print menu and start Create user
            Command.printMessageAction("Please choose an option: ");
            Command.printMessageAction("1. Create user");
            Command.printMessageAction("2. Show overview users in database");
            Command.printMessageAction("3. Show user details by Id");
            Command.printMessageAction("4. Exit application");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateUser();
                    break;
                case "2":
                    SaveCreatedUsers();
                    DisplayUsers();
                    break;
                case "3":
                    SaveCreatedUsers();
                    Command.printMessageAction("Please enter user id: ");
                    int id = int.Parse(Console.ReadLine());
                    ShowUserById(id);
                    break;
                case "4":
                    ExitApplication();
                    break;
                default:
                    break;
            }
        }
        private static void ExitApplication()
        {
            DbManager.ExitApplication();
        }
        private static void ShowUserById(int id)
        {
            DbManager.ShowUserDetailsById(id);
        }

        private static void DisplayUsers()
        {
            DbManager.ShowUsersOverview();
            PrintFirstMenu();
        }

        private static void SaveCreatedUsers()
        {
            //add to array and save users as array in XML file

            DbManager.SaveUsers(Users);
        }

        private static void CreateUser()
        {
            //get all User types and make the user select which to create
            var userTypes = typeof(User).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(User)))
                .ToList();
            Command.printMessageAction("Which type of User would you like to create? ");
            for (int i = 0; i < userTypes.Count; i++)
            {
                Command.printMessageAction($"{userTypes[i].Name}");
            }
            string inputSelectedType = Console.ReadLine();

            var currentType = userTypes.Where(x => x.Name.Equals(inputSelectedType)).FirstOrDefault();

            // var typeProperties = currentType.GetProperties();
            var consoleInputArguments = new List<object>();
            var constructrs = currentType.GetConstructors().Where(x => x.GetParameters().Length > 0).First();
            var firstCtor = constructrs;
            foreach (var parameter in firstCtor.GetParameters())
            {
                Command.printMessageAction($"Add {parameter.Name}: ");
                //add to list
                consoleInputArguments.Add(Console.ReadLine());
            }
            //pass list to type's constructor
            var arr = consoleInputArguments.ToArray();
            var userInstance = (User)Activator.CreateInstance(currentType, arr);
            //Save instance to XML
            //XmlSerializer xmlSerializer = new(currentType);
            Users.Add(userInstance);
            PrintFirstMenu();

        }
    }
}