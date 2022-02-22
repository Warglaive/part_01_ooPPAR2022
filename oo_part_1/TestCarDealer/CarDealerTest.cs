using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealerScenario;
using CarDealerScenario.BusinessLogic;
using System.Collections.Generic;

namespace TestCarDealer
{
    [TestClass]
    public class CarDealerTest
    {
        public CarDealer? CarDealer;
        [TestInitialize]
        public void Init()
        {
            this.CarDealer = new CarDealer();
        }


        [TestMethod]
        public void CreateVehicleTest()
        {
            long id = 1;
            decimal price = 123;
            string licensePlate = "asda";
            var type = VehicleType.Car;


            Vehicle vehicle = this.CarDealer.CreateVehicle(id, price, licensePlate, type);

            Assert.IsInstanceOfType(vehicle, typeof(Vehicle));
        }

        [TestMethod]
        public void AddVehicleTest()
        {
            long id = 1;
            decimal price = 123;
            string licensePlate = "asda";
            var type = VehicleType.Car;

            Vehicle vehicle = CarDealer.CreateVehicle(id, price, licensePlate, type);

            var listResult = CarDealer.AddVehicle(vehicle);

            Assert.AreEqual(listResult[0], vehicle);
        }
        [TestMethod]
        public void PrintVehiclesListTest()
        {
            long id = 1;
            decimal price = 123;
            string licensePlate = "asda";
            var type = VehicleType.Car;

            Vehicle vehicle = CarDealer.CreateVehicle(id, price, licensePlate, type);
            Vehicle vehicle2 = CarDealer.CreateVehicle(2, 85.5m, "TestPlates", VehicleType.Truck);

            List<Vehicle> listResult = new();
            listResult.Add(vehicle);
            listResult.Add(vehicle2);

            string expectedResult = $"Id = {vehicle.Id}; Price = {vehicle.Price};" +
                $" LicensePlate = {vehicle.LicensePlate}; Type = {vehicle.Type}; Price range = {vehicle.PriceRange}";
            string actualResult = this.CarDealer.PrintVehiclesList();
        }
        [TestMethod]
        public void GetNumberOfVehiclesTest()
        {
            long id = 1;
            decimal price = 123;
            string licensePlate = "asda";
            var type = VehicleType.Car;

            Vehicle vehicle = CarDealer.CreateVehicle(id, price, licensePlate, type);
            Vehicle vehicle2 = CarDealer.CreateVehicle(2, 85.5m, "TestPlates", VehicleType.Car);
            Vehicle vehicle3 = CarDealer.CreateVehicle(3, 85.5m, "TestPlates", VehicleType.Truck);
            Vehicle vehicle4 = CarDealer.CreateVehicle(4, 85.5m, "TestPlates", VehicleType.Truck);
            Vehicle vehicle5 = CarDealer.CreateVehicle(5, 85.5m, "TestPlates", VehicleType.Truck);
            int expectedResult = 5;
            int actualResult = CarDealer.GetNumberOfVehicles();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}