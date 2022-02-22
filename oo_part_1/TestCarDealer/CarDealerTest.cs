using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealerScenario;

namespace TestCarDealer
{
    [TestClass]
    public class CarDealerTest
    {
        [TestMethod]
        public void CreateVehicleTest()
        {
            long id = 1;
            decimal price = 123;
            string licensePlate = "asda";
            var type = CarDealerScenario.VehicleType.Car;


            Vehicle? vehicle = new Vehicle(id, price, licensePlate, type);
        }
    }
}