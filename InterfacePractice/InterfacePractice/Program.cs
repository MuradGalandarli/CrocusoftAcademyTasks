using InterfacePractice.Concret;
using System.Drawing;

namespace InterfacePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Nəqliyyat Vasitələri" Simulyasiyası

Bu tapşırıqda bir "nəqliyyat vasitələri" simulyasiyası yaradacaqsınız. Bu simulyasiyada >
abstract sinifdən və interface-dən istifadə edərək avtomobillər, velosipedlər və motosikletlər kimi
            müxtəlif nəqliyyat vasitələrini təmsil edəcəksiniz.

Vehicle- sinif yaradın. Bu sinif aşağıdakı xüsusiyyətlərə və metodlara sahib olmalıdır:
Property: Speed (Sürət)
Abstract Method: Drive() (Hərəkət etmək)
Abstract Method: Stop() (Dayanmaq)

IEngine adlı interface yaradın. Bu interface aşağıdakı metodlara sahib olmalıdır:
StartEngine() (Mühərriki işə salmaq)
StopEngine() (Mühərriki söndürmək)

Avtomobil, Velosiped və Motosiklet sinifləri yaradın:

Car(Avtomobil) sinfi yaradın.Bu sinif Vehicle abstract sinifindən miras almalı və
            IEngine interface-ni implement etməlidir.
Bike(Velosiped) sinfi yaradın.Bu sinif yalnız Vehicle sinifindən miras almalı,
            amma mühərriki olmadığı üçün IEngine interface-ni implement etməməlidir.
Motorcycle(Motosiklet) sinfi yaradın.Bu sinif də Vehicle abstract sinifindən miras almalı və
            IEngine interface-ni implement etməlidir.

Main metodunda hər bir nəqliyyat vasitəsi yaradın və müvafiq metodları çağırın*/

            Car car = new Car();
            car.StartEngine();
            car.Drive();
            car.Stop();
            car.StopEngine();
            Console.WriteLine("********************************************");
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.StartEngine();
            motorcycle.Drive();
            motorcycle.Stop();
            motorcycle.StopEngine();
            Console.WriteLine("********************************************");
            Bike bike = new Bike();
            bike.Drive();
            bike.Stop();




        }
    }
}
