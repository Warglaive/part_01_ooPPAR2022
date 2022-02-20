using CarDealerScenario.Entities;
using CarDealerScenario.Enums;
using CustomExceptions;

namespace CarDealerScenario
{
    internal class Vehicle : VehicleInterface
    {
        private const int MaxVehiclePrice = 100000000;
        private const int MinVehiclePrice = 0;
        private long id;
        private decimal price;
        private string licensePlate;
        private VehicleType type;
        //Auto assign when new Vehicle is created
        private PriceRange priceRange;

        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public decimal Price { get; set; }
        public string LicensePlate { get; set; }
        public VehicleType Type { get; set; }
        public PriceRange PriceRange { get; set; }


        public Vehicle(long id, decimal price, string licensePlate, VehicleType type)
        {
            //Validate input
            //
            try
            {
                if (price <= MinVehiclePrice || price >= MaxVehiclePrice)
                {
                    throw new InvalidVehiclePriceException("Invalid vehicle price.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Press Enter to terminate program");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //
            this.id = id;
            this.price = price;
            this.licensePlate = licensePlate;
            this.type = type;
            AssignPriceRange(price);
        }
        /// <summary>
        /// No ID Constructor for overloading example
        /// </summary>
        public Vehicle(decimal price, string licensePlate, VehicleType type)
        {
            this.price = price;
            this.licensePlate = licensePlate;
            this.type = type;
        }
        private void AssignPriceRange(decimal price)
        {
            if (price >= 0 && price < 10000)
            {
                this.priceRange = PriceRange.Cheap;
            }
            else if (price < 10000 && price < 100000)
            {
                this.priceRange = PriceRange.Mid;
            }
            else if (price >= 100000)
            {
                this.priceRange = PriceRange.Expensive;
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
