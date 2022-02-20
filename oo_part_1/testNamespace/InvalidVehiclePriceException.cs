using System;

namespace ExceptionsProject // Note: actual namespace depends on the project name.
{
    public class InvalidVehiclePriceException : Exception
    {
        public InvalidVehiclePriceException(string? message) : base(message)
        {
        }
    }
}