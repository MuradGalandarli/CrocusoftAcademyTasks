using System.Diagnostics.Metrics;
using System;
using System.Collections.Concurrent;

namespace Delegate3_4
{
     delegate void Hesabla(int a, int b);
    public class Program
    {
      /*  İki tam ədədi toplamaq üçün Topla adlı bir metod yaradın və Hesabla adlı delegate vasitəsilə çağırın.
            Topla metodundan gələn nəticəni ekrana çıxarın və nəticənin düzgün olduğunu yoxlayın.

4.
Hesabla delegate-indən istifadə edərək iki ədədin hasilini tapmaq üçün anonim bir metod yaradın.  

Hasil edən anonim metoddan istifadə edin və nəticəni ekranda göstərin.*/ 
        static void Main(string[] args)
        {
            Hesabla hesabla = new Hesabla(Topla);
            
            Hesabla hasil = delegate(int c,int d) { Console.WriteLine(c * d); };
            hesabla += hasil;
            hesabla(4, 8);
        }
       static void Topla (int a ,int b)
        {
            Console.WriteLine(a + b);
        }
       
    }
}
