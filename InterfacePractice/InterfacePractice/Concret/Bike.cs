using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice.Concret
{
    internal class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Velosiped gedir");
        }

        public override void Stop()
        {
            Console.WriteLine("Velosiped deyandi");
        }
    }
}
