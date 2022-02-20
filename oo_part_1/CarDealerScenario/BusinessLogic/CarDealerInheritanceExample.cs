using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario.BusinessLogic
{
    internal class CarDealerInheritanceExample
    {
        List<Vehicle> VehiclesList = new List<Vehicle>();

        private Vehicle CreateVehicle(long id, decimal price, string LicensePlate, VehicleType Type)
        {
            return new Vehicle(id, price, LicensePlate, Type);
        }
    }

}
