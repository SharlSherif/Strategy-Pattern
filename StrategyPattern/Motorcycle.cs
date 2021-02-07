using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Motorcycle: Vehicle
    {
        public override void Honk ()
        {
            Console.WriteLine("Beeeeeepooo");
        }

        public override void MaximumSpeed()
        {
            Console.WriteLine(240);
        }
    }
}
