using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Command
    {
        //Description property
        public string Description { get; set; }


        public Command()
        {
            Action<string> printMessageAction;

            printMessageAction = PrintLineOnConsole;

            printMessageAction(this.Description);
        }

        private static void PrintLineOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
