using Interface.Concret;
using System.Numerics;
using System.Xml.Linq;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Student class-i yaradin
        static Count
        Id
        Name
        Surname
        Capitalize()
Hər dəfə Student yarananda Count artmalı və Id constructor işə 
            düşdükdə dinamik olaraq Count-a əsasən təyin olunmalıdır

IEMail interface yaradirsiz :
 CustomEmail propertysi,
 GenerateEmail() methodu olur

Student classi IEMail   inteface-ni implement etmelidir ve GenerateEmail() methodu Name 
            ve Surname noqte ile birleshdirmelidir
 ardina Id deyerini elave edib ve boyuk herfleri kicildib @gamil.com domainli Email yaratmalidir
(Meselen: Murad Qelenderli Id:5 Email olmalidir -> "murad.qelenderli5@

gamil.com   ") ve emaili 

CustomEmail propertysine menimsetmelidir.
GenerateEmail() methodu studentin ctoru ishe dushdukde ctorun icerisinde cagrilib ishe dushmelidir.*/

          
            Student student = new Student ("Murad","Qelenderli");
            Console.WriteLine(Student.CustomEmail);


            Student student1 = new Student("Murad", "Qelenderli");
            Console.WriteLine(Student.CustomEmail);

        }
    }
}
