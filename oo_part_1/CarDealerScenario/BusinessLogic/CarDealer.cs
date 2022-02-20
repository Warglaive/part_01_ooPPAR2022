using CarDealerScenario.Enums;
namespace CarDealerScenario.BusinessLogic
{
    /// <summary>
    /// Create, save, list, print Vehicle operations
    /// </summary>
    internal class CarDealer : CarDealerInheritanceExample
    {
        readonly List<Vehicle> VehiclesList = new();
        //TODO: 1. Read input, 2.Store input, 3. Perform operations
        //Example of Inheritance
        /// <summary>
        /// Create vehicle and add it to the list
        /// </summary>
        /// <returns>Created vehicle for test purposes</returns>
        public new Vehicle CreateVehicle(long id, decimal price, string LicensePlate, VehicleType Type)
        {
            var vehicle = new Vehicle(id, price, LicensePlate, Type);
            AddVehicle(vehicle);
            return vehicle;
        }
        /// <summary>
        /// Add vehicle to list
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>Return VehiclesList for test purposes</returns>
        public List<Vehicle> AddVehicle(Vehicle vehicle)
        {
            VehiclesList.Add(vehicle);
            return this.VehiclesList;
        }

        /// <summary>
        /// print a list of Vehicles and their most important characteristics
        /// </summary>
        public void PrintVehiclesList()
        {
            VehiclesList.ForEach(x => Console.WriteLine($"Id = {x.Id}; Price = {x.Price}; LicensePlate = {x.LicensePlate}; Type = {x.Type}; Price range = {x.PriceRange}"));
            // Engine.Start();
        }

        /// <summary>
        /// get the number of vehicles
        /// </summary>
        public int GetNumberOfVehicles()
        {
            var vehiclesCount = this.VehiclesList.Count();
            PrintVehiclesCount(vehiclesCount);
            return vehiclesCount;
        }

        private void PrintVehiclesCount(int vehiclesCount)
        {
            Console.WriteLine($"Vehicles count: {vehiclesCount}");
        }

        /// <summary>
        ///  get the total value of all vehicles
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalValueOfVehicles()
        {
            //TODO:
            var totalPrice = VehiclesList.Select(x => x.Price).Sum();
            Console.WriteLine($"Vehicles total price: {totalPrice:f2}");
            return totalPrice;
        }

        /// <summary>
        /// get the price of a specific vehicle (based on ID)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public decimal GetVehiclePrice(long id)
        {
            var vehicle = this.VehiclesList.First(x => x.Id == id);
            PrintVehiclePrice(vehicle);
            return vehicle.Price;
        }

        private static void PrintVehiclePrice(Vehicle vehicle)
        {
            Console.WriteLine($"Vehicle with id = {vehicle.Id} is priced at: {vehicle.Price:f2}");
        }

        /// <summary>
        /// increase all prices with a certain percentage
        /// </summary>
        /// <param name="value"></param>
        public List<Vehicle> IncreaseAllPricesByPercent(decimal value)
        {
            Console.WriteLine("Current vehicles details: ");
            //print old prices
            PrintVehiclesList();
            //increate by percent
            Console.WriteLine($"Increase all prices by {value:f2}%...");
            var valueToPercent = value / 100;
            this.VehiclesList.ForEach(x => x.Price = x.Price + (x.Price * valueToPercent));
            //print new prices
            PrintVehiclesList();

            //return updated list of vehicles

            return this.VehiclesList;
        }

        /// <summary>
        /// search for a vehicle based on licence
        /// </summary>
        /// <param name="licensePlate"></param>
        public Vehicle SearchVehicleByLicensePlate(string licensePlate)
        {
            Console.WriteLine($"Searching for vehicle with license plate number {licensePlate}...");
            Vehicle vehicle = this.VehiclesList.Find(x => x.LicensePlate == licensePlate);
            Console.WriteLine("Vehicle FOUND! Printing details...");
            Console.WriteLine($"Id = { vehicle.Id}; Price = { vehicle.Price}; LicensePlate = { vehicle.LicensePlate};" +
                $" Type = { vehicle.Type}; Price range = { vehicle.PriceRange }");
            return vehicle;
        }


        /// <summary>
        /// search for a vehicle in a certain price range
        /// </summary>
        /// <param name="priceRange"></param>
        public void SearchVehicleInAPriceRange(PriceRange priceRange)
        {

        }

    }
}
