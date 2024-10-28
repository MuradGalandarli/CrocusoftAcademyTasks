using ExamConsole;
using System;
using System.Data;

namespace ExamConsole
{
    internal class Program
    {
       /* Exam class
 - Subject
 -ExamDuration(nece saat devam edir onu gosterir)
 - StartDate(DateTime ile dinamik teyin olunur)
 - EndDate(DateTime ile dinamik teyin olunur Startin ustune durationu gelirsiz)

Program.cs:
exams Listi yaradirsiz.
Bir nece exam yaradib daxil etdikden sonra console-da asagidaki siyahilari gosterirsiniz
- son 1 hefte erzinde olan examlarin siyahisini gosterirsiniz
- 2 saatdan uzun ceken imtahanlarin siyahisi
- bashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi

Siyahilari gosterende asagidaki datalari gosterirsiniz her bir siyahi ucun
 - Subject, Duration
       */
        static void Main(string[] args)
        {
            Exam exam1 = new Exam()
            {
                Subject = "Test1",
                StartDate = DateTime.Parse("10/24/2024 12:26:53"),
                EndDate = DateTime.Parse("10/24/2024 01:26:53")

            }; 
            Exam exam2 = new Exam()
            {
                Subject = "Test2",
                  StartDate = DateTime.Parse("10/24/2024 10:26:53"),
                EndDate = DateTime.Parse("10/24/2024 12:26:53")
            };
            Exam exam3 = new Exam()
            {
                Subject = "Test3",
                StartDate = DateTime.Parse("10/28/2024 02:26:53"),
                EndDate = new DateTime(default)
                
            };
            Exam exam4 = new Exam()
            {
                Subject = "Test4",
                StartDate = DateTime.Parse("10/15/2024 04:26:53"),
                EndDate = DateTime.Parse("10/15/2024 06:26:53")

            };

            List<Exam> exams = new List<Exam>() {exam1,exam2,exam3,exam4 };

          
            {
                var twoHour = exams.Where(x => x.EndDate.Value.Hour - x.StartDate.Value.Hour >= 2 && x.EndDate != new DateTime(default)).ToList();
                Console.WriteLine("Imtahan vaxti iki saatdan cox olan telebeler");
                foreach (var exam in twoHour)
                {
                    Console.WriteLine(exam.Subject);
                }
                Console.WriteLine("Son hefte erzinde olunan imtahanlar");
                var lastWeek = exams.
                    Where(x => DateTime.Now.Day - 7 <= x.EndDate.Value.Day && x.EndDate.Value.Day <= DateTime.Now.Day && x.EndDate != new DateTime(default)).ToList();
                foreach (var exam in lastWeek)
                {
                    Console.WriteLine(exam.Subject);
                }
            }
            Console.WriteLine("Hal-hazirda davam eden imtahanlar");
            var Continio = exams.Where(x => x.EndDate == new DateTime(default)).ToList();
            foreach (var exam in Continio)
            {
                Console.WriteLine(exam.Subject);
            }


        }
    }
}
