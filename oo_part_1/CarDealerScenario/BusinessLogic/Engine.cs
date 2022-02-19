using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerScenario.BusinessLogic
{
    internal class Engine
    {
        public void Start()
        {
            ReadInput();

        }
        void ReadInput()
        {
            Console.WriteLine("Enter vehicle Id: ");
            var id = long.Parse(Console.ReadLine());
        }
    }
}
