using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario.Exceptions
{
    internal class InvalidVehicleTypeException : Exception
    {
        public InvalidVehicleTypeException(string? message) : base(message)
        {
        }
    }
}
