using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Road: IRoad
    {
        private Vehicle _vehicle;

        public Road (Vehicle Vehicle)
        {
            _vehicle = Vehicle;
        }

        public void AskVehicleToGo()
        {
            _vehicle.Go();
        }

        public void DisplayVehicleMaxSpeed()
        {
            _vehicle.MaximumSpeed();
        }

        public void ListenToHonks ()
        {
            _vehicle.Honk();
        }
    }
}
