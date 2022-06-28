namespace Assignment2.Entities
{
    public class Command
    {
        private string Description { get; set; }

        private Action<string> printMessageAction;
        private Action methodToExecute;
        public Command(string description)
        {
            this.Description = description;
            printMessageAction = PrintLineOnConsole;
            printMessageAction(this.Description);
        }

        public void PrintLineOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
