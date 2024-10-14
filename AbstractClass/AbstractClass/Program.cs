using AbstractClass.Abstraction;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
             electrikle ishleyenlerde low, motorsuz ishleyen araclarda none cixarsin.

 Car classı :
  - DoorCount
  - IsElctricCar
 Bicycle classı :

  - Type


 Program.cs de Car ve Bicycle classlarindan bir nece object yaradib hamisini bir arraya yigin ve 
                 foreach ile butun arraydaki objectleri   ekrana cixardin.*/


            Car car = new Car()
            {
                FactoryName = "Toyota",
                Model = "xs",
                Color = "White",
                DriveTime = 50,
                DrivePath = 100,
                DoorCount = 2,
                IsElctricCar = true
            };
            car.GetInfo();
            car.DefineNatureHarmness();
            Console.WriteLine(car.AverageSpeed(car.DrivePath, car.DriveTime));
            Console.WriteLine("**************************************************************");

            Car car1 = new Car()
            {
                FactoryName = "Tesla",
                Model = "LWX100",
                Color = "Black",
                DriveTime = 30,
                DrivePath = 70,
                DoorCount = 4,
                IsElctricCar = false
            };
            car1.GetInfo();
            car1.DefineNatureHarmness();
            Console.WriteLine(car1.AverageSpeed(car1.DrivePath, car1.DriveTime));

            Console.WriteLine("**************************************************************");

            Bicycle bicycle = new Bicycle()
            {
                FactoryName = "bicycleTesla",
                Model = "Desna",
                Color = "Yellow",
                DriveTime = 40,
                DrivePath = 20,
                Type = "Desna10"

            };
            bicycle.GetInfo();
            bicycle.DefineNatureHarmness();
            Console.WriteLine(bicycle.AverageSpeed(bicycle.DrivePath, bicycle.DriveTime));

            Console.WriteLine("**************************************************************");

            Vehicle[] vehicles = { car, car1, bicycle };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }


        }
    }
}
