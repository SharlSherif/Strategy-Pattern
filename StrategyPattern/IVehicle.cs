using System;

namespace StrategyPattern
{
    interface IVehicle
    {
        public void Go()
        {
            Console.WriteLine("Vroom Vroom!");
        }

        public void Honk();
        public void MaximumSpeed();
    }
}
