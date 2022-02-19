using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario.BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    internal class CarDealer
    {
        List<Vehicle> VehiclesList = new List<Vehicle>();
        //TODO: 1. Read input, 2.Store input, 3. Perform operations

        public Vehicle CreateVehicle(long id, decimal price, string LicensePlate, VehicleType Type)
        {
            //Validate
            return new Vehicle(id, price, LicensePlate, Type);
        }
        //public void AddVehicle(Vehicle vehicle)
        //{
        //    return new Vehicle(0, 0, "s", VehicleType.Car);
        //}
    }
}
