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
        [TestMethod]
        public void PrintVehiclesCountTest()
        {
            Vehicle vehicle2 = CarDealer.CreateVehicle(2, 85.5m, "TestPlates", VehicleType.Car);
            Vehicle vehicle3 = CarDealer.CreateVehicle(3, 85.5m, "TestPlates", VehicleType.Truck);
            Vehicle vehicle4 = CarDealer.CreateVehicle(4, 85.5m, "TestPlates", VehicleType.Truck);
            Vehicle vehicle5 = CarDealer.CreateVehicle(5, 85.5m, "TestPlates", VehicleType.Truck);
            string expectedResult = "Vehicles count: 4";
            Assert.AreEqual($"Vehicles count: {CarDealer.GetNumberOfVehicles()}", expectedResult);
        }
        [TestMethod]
        public void GetTotalValueOfVehiclesTest()
        {
            Vehicle vehicle = CarDealer.CreateVehicle(2, 85.5m, "TestPlates", VehicleType.Car);
            Vehicle vehicle1 = CarDealer.CreateVehicle(3, 85.5m, "TestPlates", VehicleType.Truck);
            decimal expected = vehicle.Price + vehicle1.Price;
            decimal actual = CarDealer.GetTotalValueOfVehicles();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVehiclePriceTest()
        {
            Vehicle vehicle = CarDealer.CreateVehicle(2, 85.5m, "TestPlates", VehicleType.Car);
            Assert.AreEqual(CarDealer.GetVehiclePrice(vehicle.Id), 85.5m);
        }
        [TestMethod]
        public void IncreaseAllPricesByPercentTest()
        {
            CarDealer.CreateVehicle(1, 100, "TestPlates", VehicleType.Car);
            var actual = CarDealer.IncreaseAllPricesByPercent(20)[0].Price;
            var expected = 120m;
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void SearchVehicleByLicensePlateTest()
        {
            CarDealer.CreateVehicle(1, 100, "TestPlates", VehicleType.Car);
            var expectedOutput = new Vehicle(1, 100, "TestPlates", VehicleType.Car).LicensePlate;
            var actualOutput = CarDealer.SearchVehicleByLicensePlate("TestPlates").LicensePlate;
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}