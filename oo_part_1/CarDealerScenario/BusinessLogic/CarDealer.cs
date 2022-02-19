using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
