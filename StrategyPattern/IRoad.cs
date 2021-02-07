using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    interface IRoad
    {
        public void AskVehicleToGo();
        public void DisplayVehicleMaxSpeed();
        public void ListenToHonks();
    }
}
