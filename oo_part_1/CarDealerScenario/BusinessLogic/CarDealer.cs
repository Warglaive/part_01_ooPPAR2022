using CarDealerScenario.Enums;
namespace CarDealerScenario.BusinessLogic
{
    /// <summary>
    /// Create, save, list, print Vehicle operations
    /// </summary>
    internal class CarDealer : CarDealerInheritanceExample
    {
        List<Vehicle> VehiclesList = new List<Vehicle>();
        //TODO: 1. Read input, 2.Store input, 3. Perform operations
        //Example of Inheritance
        /// <summary>
        /// Create vehicle and add it to the list
        /// </summary>
        /// <returns></returns>
        public new Vehicle CreateVehicle(long id, decimal price, string LicensePlate, VehicleType Type)
        {
            var vehicle = new Vehicle(id, price, LicensePlate, Type);
            AddVehicle(vehicle);
            return vehicle;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            VehiclesList.Add(vehicle);
        }

        /// <summary>
        /// print a list of Vehicles and their most important characteristics
        /// </summary>
        public void PrintVehiclesList()
        {
            VehiclesList.ForEach(x => Console.WriteLine($"Id = {x.Id}; Price = {x.Price}; LicensePlate = {x.LicensePlate}; Type = {x.Type}; Price range = {x.PriceRange}"));
        }

        /// <summary>
        /// get the number of vehicles
        /// </summary>
        int GetNumberOfVehicles()
        {
            var vehiclesCount = this.VehiclesList.Count();
            return vehiclesCount;
        }

        /// <summary>
        ///  get the total value of all vehicles
        /// </summary>
        /// <returns></returns>
        long TotalNumberOfVehicles()
        {
            //TODO:
            return 0;
        }

        /// <summary>
        /// get the price of a specific vehicle (based on ID)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        long GetVehiclePrice(long id)
        {
            long total = 0;
            return 0;
        }

        /// <summary>
        /// increase all prices with a certain percentage
        /// </summary>
        /// <param name="percent"></param>
        void IncreaseAllPricesByPercent(decimal percent)
        {

        }

        /// <summary>
        /// search for a vehicle based on licence
        /// </summary>
        /// <param name="licensePlate"></param>
        void SearchVehicleByLicensePlate(string licensePlate)
        {

        }


        /// <summary>
        /// search for a vehicle in a certain price range
        /// </summary>
        /// <param name="priceRange"></param>
        void SearchVehicleInAPriceRange(PriceRange priceRange)
        {

        }
    }
}
