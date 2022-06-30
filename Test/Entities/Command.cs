namespace Assignment2.Entities
{
    public class Command
    {
        private string Description { get; set; }

        public Action<string> printMessageAction;
        //private Action methodToExecute;
        public Command()
        {
            printMessageAction = PrintLineOnConsole;
        }

        public void PrintLineOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
