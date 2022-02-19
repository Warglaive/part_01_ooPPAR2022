using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealerScenario.Enums;
namespace CarDealerScenario.BusinessLogic
{
    /// <summary>
    /// Create, save, list, print Vehicle operations
    /// </summary>
    internal class CarDealer
    {
        List<Vehicle> VehiclesList = new List<Vehicle>();
        //TODO: 1. Read input, 2.Store input, 3. Perform operations

        public Vehicle CreateVehicle(long id, decimal price, string LicensePlate, VehicleType Type)
        {
            return new Vehicle(id, price, LicensePlate, Type);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            VehiclesList.Add(vehicle);
        }

        /// <summary>
        /// print a list of Vehicles and their most important characteristics
        /// </summary>
        void PrintVehiclesList()
        {
            //TODO:
        }

        /// <summary>
        /// get the number of vehicles
        /// </summary>
        void GetNumberOfVehicles()
        {
            //TODO:
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
