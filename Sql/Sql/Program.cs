using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace Sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --1.Get empid, firstname, lastname, country, region, city of all employees from USA. * /

  --use Employees
  --SELECT Employees.FirstName,Employees.LastName,Employees.CountryRegionName,Employees.City FROM Employees WHERE(Employees.CountryRegionName = 'United States')

 --Get the number of employees for each specialty.

   --select Employees.JobTitle, COUNT(*) as EmployeCount from Employees group by (Employees.JobTitle)

  -- Count the number of people for each name
  --select Employees.FirstName, Count(*) as NameCount from Employees group by (Employees.FirstName)

  --4.Get the most common name

  --select top 1 FirstName, count(*) as FirstNameCount from Employees Group by(FirstName) order by FirstNameCount desc

  --5 Get the least common name.

  --select top 1 FirstName, Count(FirstName) as NameCount from Employees group by (FirstName)order by(NameCount)


 --6.Get the top 5 cities where the most workers are.

 --select top 5 City, Count(*) as employe from Employees group by (City)order by(employe) desc

 -- 7.Get the top 5 cities, which have the most unique specialties.

 --select top 5 JobTitle, count(City) as cityCount from Employees group by (JobTitle)order by(cityCount)

 -- Issue mailing addresses for emailing to all employees who started working on 1 / 01 / 2012

 --select EmailAddress from Employees where (StartDate > '1/01/2012')

 -- 9.Issue statistics in what year how many employees were employed. * /

 --select * from Employees where (StartDate Between '1/01/2011' and '1/01/2012')

                         --Issue statistics in which year how many workers in which countries were employed.

 --select City, count(City) from Employees where (StartDate between '1/01/2011' and '1/01/2012') group by(City)

 --*11.Refresh the Employees table by adding data from the History table to the EndDate column. * /

 --update Employees set EndDate = '1/01/2011' where(BusinessEntityID between 1 and 10)
  --update Employees set EndDate = '1/01/2011' where(BusinessEntityID = 12)

  -- / *12.Issue statistics on how many employees in which year they left. * /

  --Select Count(BusinessEntityID) from Employees where (EndDate between '1/01/2011' and '1/01/2012')

  --13.Issue the number of employees who have worked less than a year.

 --select* from Employees where(DATEADD(YEAR, -1, EndDate) < StartDate)
 */


            ///////////////////////////////////////////////////////////
            ///

            // Task 1: 
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
