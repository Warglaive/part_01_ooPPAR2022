namespace CustomExceptions
{
    internal class InvalidVehicleTypeException : Exception
    {
        public InvalidVehicleTypeException(string? message) : base(message)
        {
        }
    }
}
