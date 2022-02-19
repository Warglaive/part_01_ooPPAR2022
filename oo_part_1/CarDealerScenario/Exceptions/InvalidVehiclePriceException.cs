using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario.Exceptions
{
    internal class InvalidVehiclePriceException : Exception
    {
        public InvalidVehiclePriceException(string? message) : base(message)
        {
        }
    }
}
