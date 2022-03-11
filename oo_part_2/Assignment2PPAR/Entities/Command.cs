using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Command
    {
        //Description property
        public string Description { get; set; }


        public Command(string description)
        {
            this.Description = description;
            Action<string> printMessageAction;

            printMessageAction = PrintLineOnConsole;

            printMessageAction(this.Description);
        }

        public void PrintLineOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
