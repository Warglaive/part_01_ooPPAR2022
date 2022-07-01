namespace Assignment2.Entities
{
    public class Command
    {
        private string Description { get; set; }

        public Action action;
        //private Action methodToExecute;


        public Command(string Description)
        {
            this.Description = Description;

            action = () => PrintLineOnConsole(Description);

        }

        public void PrintLineOnConsole(string message)
        {
            Console.WriteLine(message);
        }
        public Command(Action action)
        {
            this.action = action;
        }

        public Command()
        {
        }
    }
}
