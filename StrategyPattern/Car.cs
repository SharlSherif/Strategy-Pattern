using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Car : IVehicle
    {
        public void Honk ()
        {
            Console.WriteLine("Beep");
        }

        public void MaximumSpeed()
        {
            Console.WriteLine(120);
        }
    }
}
