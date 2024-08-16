using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Jackson_Lydia
{
    internal interface IAutomobile
    {
        //property to get the speed for automobiles
        public double Speed { get; }

        //property to get the number of wheels for automobiles
        public int Wheels { get; }

        //property to get the license plate of automobiles
        public string LicensePlate { get; }

        public void Stringify();


    }
}
