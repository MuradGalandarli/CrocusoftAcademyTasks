using LanguageDetection;
using System;

namespace NewTask
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Task 1: 
           //  a / b məsələn 9 / 36 kəsr ədədini ən sadə hala gətirən yəni 1 / 4 kimi ekranda çıxardacaq function yazın
            /*
                        int input1 = 0;
                        int input2 = 0;
                        bool IsSuccess1 = int.TryParse(Console.ReadLine(), out input1);
                        bool IsSuccess2 = int.TryParse(Console.ReadLine(), out input2);


                        if (IsSuccess1 && IsSuccess2)
                        {
                            int divisor = EBOB(input1, input2);
                            Console.WriteLine($"{input1 / divisor} / {input2 / divisor}");
                        }

                        Console.WriteLine();

                        int EBOB(int num1, int num2)
                        {
                            for (int i = num1; i > 0; i--)
                            {
                                if (num1 % i == 0 && num2 % i == 0)
                                {
                                    return i;
                                }
                            }
                            return -1;

                        }*/




            //    Task 2: 

            //Ədədi təxmin et oyunu Console yazmaq
            //Proqram sizə random 1,100 aralığında bir  rəqəm yaratmalı və user bu ədədi təxmin etməlidir.
            //Əgər cavab yanlış olarsa o zaman doğru cavaba yönləndirməlidir.

            int input = 0;
            bool IsSuccess = int.TryParse(Console.ReadLine(), out input);
            Random random = new Random();
            var ran = random.Next(1, 100);

            Console.WriteLine((IsSuccess && ran == input) ? "Dogrudur" : ran);
          




            //Task 3: 
            //Consoldan söz daxil edirsiz həmin sözün azərbaycan dilində olub olmadığını yoxlayan alq qurun.
            //  Hansı sözü daxil etsəz işləsin

            /*
                LanguageDetector ld = new LanguageDetector();
                ld.AddAllLanguages();
                string text = "Men su icmek isteyirem";
                string lanCode = ld.Detect(text);

                Console.WriteLine(lanCode);
                Console.ReadLine();*/




        }
    }
}
