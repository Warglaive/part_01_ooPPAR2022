using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario.BusinessLogic
{
    /// <summary>
    ///  Class used to mainly execute methods from CarDealer and secondly pass arguments from the console.
    /// </summary>
    internal class Engine
    {
        protected CarDealer CarDealer = new();

        /// <summary>
        /// Get arguments and create a Vehicle
        /// </summary>
        public void CreateNewVehicle()
        {
            var inputArguments = ReadInput();
            //
            //
            long id = (long)inputArguments[0];
            decimal price = (decimal)inputArguments[1];
            string licensePlate = (string)inputArguments[2];
            VehicleType type = (VehicleType)inputArguments[3];
            //Execute Create, save, list, print Vehicle operations
            CarDealer.CreateVehicle(id, price, licensePlate, type);



            Console.WriteLine("1) - Show Car Dealer menu");
            Console.WriteLine("2) - Exit simulation (won't save any previous input).");

            switch (Console.ReadLine())
            {
                case "1":
                    CarDealerMainMenu();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }


        }
        /// <summary>
        /// Read input from console
        /// </summary>
        /// <returns>List containing the input</returns>
        List<Object> ReadInput()
        {
            List<object> list = new();

            Console.WriteLine("Enter vehicle Id: ");
            var id = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter vehicle price: ");
            var price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter vehicle license plate");
            var licensePlate = Console.ReadLine();
            //make user select type
            VehicleType type = VehicleType.Unassigned;

            Console.WriteLine("Select vehicle type: ");
            Console.WriteLine("1) - Car");
            Console.WriteLine("2) - Truck");
            switch (Console.ReadLine())
            {
                case "1":
                    type = VehicleType.Car;
                    break;
                case "2":
                    type = VehicleType.Truck;
                    break;
                default:
                    type = VehicleType.Unassigned;
                    break;

            }
            list.Add(id);
            list.Add(price);
            list.Add(licensePlate);
            list.Add(type);
            Console.Clear();
            return list;
        }

        private void CarDealerMainMenu()
        {
            Console.WriteLine("1) - Add new vehicle");
            Console.WriteLine("2) - Print all vehicles");

            //TODO:
            switch (Console.ReadLine())
            {
                case "1":
                    CreateNewVehicle();
                    break;
                case "2":
                    this.CarDealer.PrintVehiclesList();
                    break;
                default:
                    break;
            }

        }
    }
}
