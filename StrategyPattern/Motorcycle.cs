using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Motorcycle: IVehicle
    {
        public void Honk ()
        {
            Console.WriteLine("Beeeeeepooo");
        }

        public void MaximumSpeed()
        {
            Console.WriteLine(240);
        }
    }
}
