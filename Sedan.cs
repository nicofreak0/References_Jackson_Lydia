using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Jackson_Lydia
{
    internal class Sedan : IAutomobile
    {
        // property to get the speed for Sedan
        public double Speed { get; private set; }

        // property to get the number of wheels for Sedan
        public int Wheels { get; private set; }

        // property to get the license plate number for for Sedan
        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            // sets the number of wheels for sedan
            Wheels = 4;
            //sets the speed for sedan
            Speed = speed;
            //sets the license plate number for sedan
            LicensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            // writes to console what wpeed the sadan is going at, the wheel number and license plates
            Console.WriteLine($"The Sedan is Traveling at a Speed of {Speed} on {Wheels} Wheels, with a License Plate Number of {LicensePlate}.");
        }

        // increases the speed by 5
        public void IncreaseSpeed()
        {
            Speed += 5;
        }
        
        //decreases the speed by 5
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
