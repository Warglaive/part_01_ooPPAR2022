using Test;

namespace Assignment2 // Note: actual namespace depends on the project name.
{
    /// <summary>
    /// I do not see a reason to create new GUI class and to transfer all of the current methods there.
    /// Since the app is just GUI/BackEnd/Persistance
    /// </summary>
    public class StartUp
    {
        public static void Main()
        {
            //Use Action to call each menu item
            ChoseStartOption();

        }

        public static void ChoseStartOption()
        {
            ConsoleTUI ui = new ConsoleTUI();

            while (true)
            {
                ui.Command().action.Invoke();
                ui.CreateUserPrint().action.Invoke();
                ui.UsersOverviewPrint().action.Invoke();
                ui.UserByIdPrint().action.Invoke();
                ui.ExitAppPrint().action.Invoke();

                var selectedOption = int.Parse(Console.ReadLine());
                if (selectedOption == 1)
                {
                    ui.CreateUserAction().action.Invoke();
                }
                else if (selectedOption == 2)
                {
                    ui.UsersOverviewAction().action.Invoke();
                }
                else if (selectedOption == 3)
                {
                    ui.UserByIdAction().action.Invoke();
                }
                else if (selectedOption == 4)
                {
                    ui.ExitAppAction().action.Invoke();
                }
            }
        }
    }
}