namespace CarDealerScenario.BusinessLogic
{
    public class CarDealerInheritanceExample
    {
        List<Vehicle> VehiclesList = new List<Vehicle>();

        public Vehicle CreateVehicle(long id, decimal price, string LicensePlate, VehicleType Type)
        {
            throw new Exception();
        }
    }

}
