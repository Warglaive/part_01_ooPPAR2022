namespace CustomExceptions
{
    public class InvalidVehiclePriceException : Exception
    {
        public InvalidVehiclePriceException(string? message) : base(message)
        {
        }
    }
}
