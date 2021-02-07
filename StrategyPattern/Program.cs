using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Vehicle = new Motorcycle();
            Road Road = new Road(Vehicle);

            Road.AskVehicleToGo();
            Road.ListenToHonks();
            Road.DisplayVehicleMaxSpeed();
        }
    }
}
