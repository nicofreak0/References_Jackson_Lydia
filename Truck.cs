using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Jackson_Lydia
{
    internal class Truck : IAutomobile
    {
        //property to get the speed for truck
        public double Speed { get; private set; }

        //property to get the number of wheels for truck
        public int Wheels { get; private set; }

        //property to get the license plate number for truck
        public string LicensePlate { get; private set; }

        // gets the weight for truck
        public double Weight { get; }

        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            // sets the speed for speed param
            Speed = speedParam;
            // sets the weight for weight
            Weight = weightParam;
            // sets the license plate number for licenseNum
            LicensePlate = licenseNum;

            // if the weight is less than 400 it has 8 wheels
            if(Weight < 400) 
            {
                Wheels = 8;
            }
            // if the weight is more than 400 it has 12 wheels
            else 
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
            Console.WriteLine($"The Truck is Travleing at a Speed of {Speed} on {Wheels} Wheels, with a License Plate Number of {LicensePlate}.");
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
