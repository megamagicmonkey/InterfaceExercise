using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int GearSpeeds { get; set; }
        public bool IsElectric { get; set; }

    }
}
