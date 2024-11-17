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

        }
    }
}
