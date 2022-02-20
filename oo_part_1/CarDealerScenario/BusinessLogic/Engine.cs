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
        /// <summary>
        /// Get arguments and create a Vehicle
        /// </summary>
        public void Start()
        {
            var inputArguments = ReadInput();
            //
            var carDealer = new CarDealer();
            //
            long id = (long)inputArguments[0];
            decimal price = (decimal)inputArguments[1];
            string licensePlate = (string)inputArguments[2];
            VehicleType type = (VehicleType)inputArguments[3];
            //Execute Create, save, list, print Vehicle operations
            var vehicle = carDealer.CreateVehicle(id, price, licensePlate, type);
            carDealer.AddVehicle(vehicle);
            carDealer.PrintVehiclesList();
        }
        /// <summary>
        /// Read input from console
        /// </summary>
        /// <returns>List containing the input</returns>
        List<Object> ReadInput()
        {
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
            Console.WriteLine("3) - Exit simulation (won't save any previous input.");
            switch (Console.ReadLine())
            {
                case "1":
                    type = VehicleType.Car;
                    break;
                case "2":
                    type = VehicleType.Truck;
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    type = VehicleType.Unassigned;
                    break;

            }
            List<object> list = new();
            list.Add(id);
            list.Add(price);
            list.Add(licensePlate);
            list.Add(type);
            return list;
        }
    }
}
