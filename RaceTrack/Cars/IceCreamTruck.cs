﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class IceCreamTruck : RaceCar
    {
        public IceCreamTruck()
        {
            Name = "Ice Cream Truck";
            TopSpeed = 40;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }
    }
}
