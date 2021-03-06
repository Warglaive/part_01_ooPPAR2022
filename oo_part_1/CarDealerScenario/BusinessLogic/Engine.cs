using CarDealerScenario.Enums;
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
        public Engine()
        {
            this.CarDealer = new CarDealer();
        }
        public CarDealer CarDealer;

        /// <summary>
        /// Get arguments and create a Vehicle
        /// </summary>
        public void Start()
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

            ShowCarDealerMenu();

        }

        private void ShowCarDealerMenu()
        {
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
            Console.WriteLine("3) - Get the number of all vehicles");
            Console.WriteLine("4) - Get the total value of all vehicles");
            Console.WriteLine("5) - Get vehicle price by Id");
            Console.WriteLine("6) - Increase ALL vehicles prices by certain percent");
            Console.WriteLine("7) - Search a vehicle by license plate");
            Console.WriteLine("8) - Search for a vehicle in a specific price range");
            //TODO:
            switch (Console.ReadLine())
            {
                case "1":
                    Start();
                    break;
                case "2":
                    this.CarDealer.PrintVehiclesList();
                    ShowCarDealerMenu();
                    break;
                case "3":
                    this.CarDealer.GetNumberOfVehicles();
                    ShowCarDealerMenu();
                    break;
                case "4":
                    this.CarDealer.GetTotalValueOfVehicles();
                    ShowCarDealerMenu();
                    break;
                case "5":
                    Console.WriteLine("Enter vehicle id");
                    long id = long.Parse(Console.ReadLine());
                    this.CarDealer.GetVehiclePrice(id);
                    ShowCarDealerMenu();
                    break;
                case "6":
                    Console.WriteLine("Enter a percentage: ");
                    var percent = decimal.Parse(Console.ReadLine());
                    this.CarDealer.IncreaseAllPricesByPercent(percent);
                    ShowCarDealerMenu();
                    break;
                case "7":
                    Console.WriteLine("Enter license plate");
                    var licensePlate = Console.ReadLine();
                    this.CarDealer.SearchVehicleByLicensePlate(licensePlate);
                    ShowCarDealerMenu();
                    break;
                case "8":
                    Console.WriteLine("Enter price range(Cheap, Mid, Expensive)");
                    PriceRange priceRange;
                    Enum.TryParse(Console.ReadLine(), out priceRange);
                    this.CarDealer.SearchVehicleInAPriceRange(priceRange);
                    ShowCarDealerMenu();
                    break;
                default:
                    break;
            }

        }
    }
}
