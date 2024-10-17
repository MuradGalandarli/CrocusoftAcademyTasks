using InterfacePractice.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice.Concret
{
    internal class Car : Vehicle, IEngine
    {
        public override void Drive()
        {
            Console.WriteLine("Avtomobil getmeye basladi");
        }

        public void StartEngine()
        {
            Console.WriteLine("Avtomobilin mator ise dusdu");
        }

        public override void Stop()
        {
            Console.WriteLine("Avtomobil deyandi");
        }

        public void StopEngine()
        {
            Console.WriteLine("Avtomobilin matoru deyandi");
        }
    }
}
