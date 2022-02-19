using CarDealerScenario.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario
{
    internal class Vehicle
    {
        private const int MaxVehiclePrice = 100000000;
        private const int MinVehiclePrice = 0;
        private long Id;
        private decimal Price { get; set; }
        private string LicensePlate { get; set; }
        private VehicleType Type;
        public Vehicle(long id, decimal price, string licensePlate, VehicleType type)
        {
            Id = id;
            if (price <= MinVehiclePrice || price >= MaxVehiclePrice)
            {
                throw new InvalidVehiclePriceException("Invalid vehicle price.");
            }
            Price = price;
            LicensePlate = licensePlate;
            Type = type;
        }
        //public void SetPrice(decimal price)
        //{
        //    this.Price = price;
        //}
        //public decimal GetPrice()
        //{
        //    return this.Price;
        //}
    }
}
