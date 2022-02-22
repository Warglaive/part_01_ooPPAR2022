using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealerScenario;
using CarDealerScenario.BusinessLogic;

namespace TestCarDealer
{
    [TestClass]
    public class CarDealerTest
    {
        public CarDealer CarDealer;
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
            var type = CarDealerScenario.VehicleType.Car;


            Vehicle vehicle = this.CarDealer.CreateVehicle(id, price, licensePlate, type);

            Assert.IsInstanceOfType(vehicle, typeof(Vehicle));
        }

        [TestMethod]
        public void AddVehicleTest()
        {
            long id = 1;
            decimal price = 123;
            string licensePlate = "asda";
            var type = CarDealerScenario.VehicleType.Car;

            Vehicle vehicle = this.CarDealer.CreateVehicle(id, price, licensePlate, type);

            var listResult = this.CarDealer.AddVehicle(vehicle);

            Assert.AreEqual(listResult[0], vehicle);
        }
    }
}