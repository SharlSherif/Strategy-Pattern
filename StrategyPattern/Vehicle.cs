using System;

namespace StrategyPattern
{
    abstract class Vehicle
    {
        public void Go()
        {
            Console.WriteLine("Vroom Vroom!");
        }

        public virtual void Honk() { }
        public virtual void MaximumSpeed() { }
    }
}
