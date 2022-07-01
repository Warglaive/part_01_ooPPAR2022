using Assignment2;
using Assignment2.Entities;
using Assignment2.Factories;
using Test.Persistence;

namespace Test.BusinessLogic
{
    /// <summary>
    /// Call the DBManager to work with XMLDB
    /// Use command for printing 
    /// </summary>
    public class Logic
    {
        private List<User> Users = new List<User>();
        static Command Command;
        // static List<User> Users;
        static DBManager DbManager;

        public Logic()
        {
            Command = new Command();
            DbManager = AbstractDBFactory.CreateDbManager();

        }
        public void PrintFirstMenu()
        {
            //Make user chose start option
            StartUp.ChoseStartOption();
        }
        public void ExitApplication()
        {
            DbManager.ExitApplication();
        }
        public void ShowUserById(int id)
        {
            DbManager.ShowUserDetailsById(id);
        }

        public void DisplayUsers()
        {
            DbManager.ShowUsersOverview();
            PrintFirstMenu();
        }

        public void SaveCreatedUsers()
        {
            //add to array and save users as array in XML file

            DbManager.SaveUsers(Users);
        }

        public void CreateUser()
        {
            //get all User types and make the user select which to create
            var userTypes = typeof(User).Assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(User)))
                .ToList();
            Command.PrintLineOnConsole("Which type of User would you like to create? ");
            for (int i = 0; i < userTypes.Count; i++)
            {
                Command.PrintLineOnConsole($"{userTypes[i].Name}");
            }
            string inputSelectedType = Console.ReadLine();

            var currentType = userTypes.Where(x => x.Name.Equals(inputSelectedType)).FirstOrDefault();

            // var typeProperties = currentType.GetProperties();
            var consoleInputArguments = new List<object>();
            var constructrs = currentType.GetConstructors().Where(x => x.GetParameters().Length > 0).First();
            var firstCtor = constructrs;
            foreach (var parameter in firstCtor.GetParameters())
            {
                Command.PrintLineOnConsole($"Add {parameter.Name}: ");
                //add to list
                consoleInputArguments.Add(Console.ReadLine());
            }
            //pass list to type's constructor
            var arr = consoleInputArguments.ToArray();
            var userInstance = (User)Activator.CreateInstance(currentType, arr);
            //Save instance to XML
            //XmlSerializer xmlSerializer = new(currentType);
            Users.Add(userInstance);
            SaveCreatedUsers();
            PrintFirstMenu();
        }
    }
}
