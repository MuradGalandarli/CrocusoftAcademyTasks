using System.Collections.Generic;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Şagirdlərin qiymətləri üçün List<int> qiymetler yaradın.Məsələn, qiymətlər: 85, 92, 78, 90, 88.
Lambda ifadəsindən istifadə edərək şagirdlərin orta qiymətini hesablayın və 
                nəticəni ekrana çıxarın. List sinfində olan Average() metodundan istifadə edə bilərsiniz.
 Lambda ifadəsi ilə şagirdlərin yalnız 90 - dan yüksək qiymətlərini ekrana çıxarın.*/


            List<int> ints = new List<int>() { 85, 92, 78, 90, 88 };   

            var gread = ints.Average();
            var greadPrice = ints.Where(x=> x > 90).ToList();
            foreach(int i in greadPrice)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(gread);

        }
    }
}
