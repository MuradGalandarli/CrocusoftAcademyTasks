using InterfacePractice.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice.Concret
{
    internal class Motorcycle : Vehicle, IEngine
    {
        public override void Drive()
        {
            Console.WriteLine("Motosiklet getmeye basladi");
        }

        public void StartEngine()
        {
            Console.WriteLine("Motosikletin matoru ise dusdu");
        }

        public override void Stop()
        {
            Console.WriteLine("Motosiklet deyandi");
        }

        public void StopEngine()
        {
            Console.WriteLine("Motosikletin matoru deyandi");
        }
    }
}
