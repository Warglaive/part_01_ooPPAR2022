namespace CustomExceptions
{
    public class NoSuchVehicleException : Exception
    {
        public NoSuchVehicleException(string? message) : base(message)
        {
        }
    }
}
