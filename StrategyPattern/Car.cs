using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Car : Vehicle
    {
        public override void Honk ()
        {
            Console.WriteLine("Beep");
        }

        public override void MaximumSpeed()
        {
            Console.WriteLine(120);
        }
    }
}
