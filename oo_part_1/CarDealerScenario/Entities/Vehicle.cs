using CarDealerScenario.Enums;
using CustomExceptions;
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
        //Auto assign when new Vehicle is created
        private PriceRange PriceRanges;
        public Vehicle(long id, decimal price, string licensePlate, VehicleType type)
        {

            //Validate input
            //
            if (price <= MinVehiclePrice || price >= MaxVehiclePrice)
            {
                throw new InvalidVehiclePriceException("Invalid vehicle price.");
            }
            //
            Id = id;
            Price = price;
            LicensePlate = licensePlate;
            Type = type;
            AssignPriceRange(price);
        }

        private void AssignPriceRange(decimal price)
        {
            if (price >= 0 && price < 10000)
            {
                this.PriceRanges = PriceRange.Cheap;
            }
            else if (price < 10000 && price < 100000)
            {
                this.PriceRanges = PriceRange.Mid;
            }
            else if (price >= 100000)
            {
                this.PriceRanges = PriceRange.Expensive;
            }
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
