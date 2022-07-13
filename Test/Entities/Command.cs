namespace Assignment2.Entities
{
    public class Command
    {
        public string Description { get; set; }

        public Action action;
        private Action methodToExecute;


        public Command(string Description, Action methodToExecute)
        {
            this.Description = Description;

            action = () => PrintLineOnConsole(Description);
            this.methodToExecute = methodToExecute;
        }

        public void PrintLineOnConsole(string message)
        {
            Console.WriteLine(message);
        }
        public Command(Action action)
        {
            this.action = action;
        }

      /*  public Command()
        {
        }*/
    }
}
