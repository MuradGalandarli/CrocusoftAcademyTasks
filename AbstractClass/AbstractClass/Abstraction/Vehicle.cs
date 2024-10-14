using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Abstraction
{
    internal abstract class Vehicle
    {
        public  string FactoryName { get; set; }
        public  string Model { get; set; }
        public string Color { get; set; }
        public decimal DriveTime { get; init; }
        public  int DrivePath { get; set; }
        public  DateTime ProductionDate { get; init; }

        protected Vehicle()
        {
            ProductionDate = DateTime.Now;
        }

       public decimal AverageSpeed(int drivePath, decimal driveTime)
        {
          var km = drivePath / (driveTime/60);
            return km;
        }
        public virtual void  GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath} {ProductionDate}");
        }
        public override string ToString()
        {
            return $"({ FactoryName} {Model})";
        }

       public abstract void DefineNatureHarmness();

        /* Vehicle asbtract classı:
             -FactoryName
             - Model
             - Color
             - DriveTime
             - DrivePath
             - ProductionDate - yalniz ctor ishe dushdukde halhazirdaki tarixi goturur(readonly) ve deyishmek olmur.

             - AverageSpeed() - Ortalama sürəti hesablayır(km/ saat mentiqi ile yani path ve time dan istifade edirsiz)
  -GetInfo() virtual method yaradirsiz miras oturduyu classda override etdikde butun deyerleri ekrana cixarmalidir.
  - ToString() methodunu override edirsiz ekrana cixartdiqda FactoryName ile Model deyerlerini gostersin
  - DefineNatureHarmness() - abstract method-dur override etdikde benzinle ishleyenlerde high,
             electrikle ishleyenlerde low, motorsuz ishleyen araclarda none cixarsin.*/
    }
}
