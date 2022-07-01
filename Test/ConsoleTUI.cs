using Assignment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.BusinessLogic;

namespace Test
{
    /// <summary>
    /// Print each command using Action
    /// </summary>
    public class ConsoleTUI
    {
        private Command command;
        Action action;
        Logic logic = new Logic();

        public ConsoleTUI()
        {
            this.command = new Command();
        }
        public Command Command()
        {
            return new Command("Choose an option from the menu: ");
        }

        public Command CreateUserPrint()
        {
            return new Command("1. Create User.");
        }

        public Command CreateUserAction()
        {
            action = () => { logic.CreateUser(); };
            return new Command(action);
        }

        public Command UsersOverviewPrint()
        {
            return new Command("2. Show overview of users in database.");
        }

        public Command UsersOverviewAction()
        {
            action = () =>
            {
                logic.DisplayUsers();
            };
            return new Command(action);
        }

        public Command UserByIdPrint()
        {
            return new Command("3. Show specific user details.");
        }

        public Command UserByIdAction()
        {
            command.PrintLineOnConsole("Enter Id: ");
            var id = int.Parse(Console.ReadLine());
            action = () => { logic.ShowUserById(id); };
            return new Command(action);
        }

        public Command ExitAppPrint()
        {
            return new Command("4. Exit application.");
        }

        public Command ExitAppAction()
        {
            action = () => { logic.ExitApplication(); };
            return new Command(action);
        }
    }
}
