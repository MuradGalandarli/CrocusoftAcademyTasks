using AbstractClass.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Car : Vehicle
    {
        
        /*   Car classı :
    - DoorCount
    - IsElctricCar*/
        public override void DefineNatureHarmness()
        {
            if (!IsElctricCar)
            {
                Console.WriteLine("high");
            }
            else
            {
                Console.WriteLine("low");
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath} {ProductionDate} {DoorCount}");
        }
        public int DoorCount { get; set; }
        public bool IsElctricCar { get; set; }
    }
}
