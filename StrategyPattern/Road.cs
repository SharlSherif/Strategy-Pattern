using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Road: IRoad
    {
        private IVehicle _vehicle;

        public Road (IVehicle Vehicle)
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
