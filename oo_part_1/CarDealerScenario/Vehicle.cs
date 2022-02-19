using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario
{
    internal class Vehicle
    {
        private long Id;
        private decimal Price;
        private string LicensePlate;

        public Vehicle(long id, decimal price, string licensePlate)
        {
            Id = id;
            Price = price;
            LicensePlate = licensePlate;
        }
        public void SetPrice(decimal price)
        {
            this.Price = price;
        }
        public decimal GetPrice()
        {
            return this.Price;
        }
    }
}
