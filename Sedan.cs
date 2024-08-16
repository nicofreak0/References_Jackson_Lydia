﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Jackson_Lydia
{
    internal class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-66";
        }

        public void Stringify()
        {
            Console.WriteLine($"The Sedan is Traveling at a Speed of {Speed} on {Wheels} Wheels, with a License Plate Number of {LicensePlate}.");
        }

        public void IncreaseSpeed()
        {
            Speed += 5;
        }
        
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
