﻿using CarDealerScenario.Enums;
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
        /// <summary>
        /// Add vehicle to list
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>Return added Vehicle for test purposes</returns>
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            VehiclesList.Add(vehicle);
            return vehicle;
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

        private static void PrintVehiclesCount(int vehiclesCount)
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
        public long GetVehiclePrice(long id)
        {
            var vehicle = this.VehiclesList.First(x => x.Id == id);
            PrintVehiclePrice(vehicle);
            return 0;
        }

        private static void PrintVehiclePrice(Vehicle vehicle)
        {
            Console.WriteLine($"Vehicle with id = {vehicle.Id} is priced at: {vehicle.Price:f2}");
        }

        /// <summary>
        /// increase all prices with a certain percentage
        /// </summary>
        /// <param name="percent"></param>
        public void IncreaseAllPricesByPercent(decimal percent)
        {

        }

        /// <summary>
        /// search for a vehicle based on licence
        /// </summary>
        /// <param name="licensePlate"></param>
        public void SearchVehicleByLicensePlate(string licensePlate)
        {

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
