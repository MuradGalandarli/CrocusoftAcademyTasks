using System.Runtime.ConstrainedExecution;

namespace Delegate
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*  1.Person class-ınız olur.Name, Surname, Age propertyləri olur.
  Program.cs de:
  People List-i yaradırsınız. FindAll methodu ilə aşağıdakı sorğuları yazın :
  a.Adı Kamil(her hansisa bir ad) olan person-u çıxarsın.
  b.Soyadı ov ve ova ilə bitən tələbələri çıxarsın.
  c.Yaşı 20+ olanları çıxarsın*/

            Person person1 = new Person()
            {
                Name = "Ehmed",
                SureName = "Ehmedov",
                Age = 19
            };
            Person person2 = new Person()
            {
                Name = "Ehmed",
                SureName = "Ehmedov",
                Age = 22
            };
            Person person3 = new Person()
            {
                Name = "Rufet",
                SureName = "Esedov",
                Age = 25
            };
            Person person4 = new Person()
            {
                Name = "Pervane",
                SureName = "Rehimova",
                Age = 28
            };

            List<Person> list = new List<Person>() { person1, person2, person3, person4 };
            while (true)
            {

                Console.WriteLine("Axtarmaq istediginiz adi girin");
                var inputName = Console.ReadLine();
                var findAllName = list.FirstOrDefault(x => x.Name.ToUpper() == inputName.ToUpper());
                if (findAllName != null)
                {
                    Console.WriteLine($"Adi: {findAllName.Name} Soadi: {findAllName.SureName} {findAllName.Age}");
                }
                else
                {
                    Console.WriteLine("Bazada yoxdur");
                }
            }

        }
    }
}
