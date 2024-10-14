using AbstractClass.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Bicycle:Vehicle
    {
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("none");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath} {ProductionDate} {Type}");
        }

        public string? Type { get; set; }
    }
}
