using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle Vehicle = new Car();
            Road Road = new Road(Vehicle);

            Road.AskVehicleToGo();
            Road.ListenToHonks();
            Road.DisplayVehicleMaxSpeed();
        }
    }
}
