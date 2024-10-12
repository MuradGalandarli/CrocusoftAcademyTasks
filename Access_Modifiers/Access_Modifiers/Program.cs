using System.Globalization;
using System.Xml.Linq;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            1.Manager classi yaradirsiz:
GetPromotion() - ancaq oz classinda ve derived classda gorsenmelidir.
Employee qebul edir employee maashin 100 vahid artirir ve geriye Employee oturur

Assistant classi yaradirsiz:
            GetFeedBack() bu method Employee qebul edir eger Sucessfull - dursa GetPromotion methodu
ishe dushmelidir

Employee classi yaradirsiz:
            Name
            IsSuccessfull
Salary propertyleri olur

------------------------------------------------------------------------------------------ -
2.Person classi yaradırsız Name, Surname, Age field-ləri olsun.Person class-dan instance 
            alındıqda bütün dəyərləri constructora göndərilməlidir.
Student classı yaradırsız Person class-dan inheritance(miras) almalıdır və əlavə IsOnline
            fieldi olacaq(boolean bir type olacaq tehsili online yoxsa offline oldugunu 
                mueyyenleshdirmek ucun ) butun deyerleri constructordan gəlməlidir.
Group classı yaradırsız GroupName və özündə Student-ləri saxlayan Students(Array olacaq)
                    field-ləri olsun. GroupName constructordan gəlməlidir və Students arrayı 
                    constructor işə düşdükdə initialize olunmalıdır.Group classında aşağıdakı
                    methodları yaradırsız:
a.Add methodu Student qəbul edir və Students array-na daxil edir.
b.GetAll methodu parameterless-olmalıdır Group-da ki butun telebelerin(Students arrayindaki) 
                    ad və soyadını ekrana çıxartmalıdır.
c.GetOnlineStudents methodu methodu parameterless(parametirsiz)-olmalıdır Group-da ki online 
                    oxuyan telebelerin(IsOnline fieldinə əsasən) ad və soyadını ekrana çıxartmalıdır.
d.GetOfflineStudents methodu parameterless-olmalıdır Group-da ki offline oxuyan
            telebelerin(IsOnline fieldinə əsasən) ad və soyadını ekrana çıxartmalıdır.
*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            Employee employee = new Employee()
            {
                IsSuccessfull = true,
                Name = "Test",
                Salary = 150
            };

            Console.WriteLine($"Adi:{employee.Name} Statusu: {employee.IsSuccessfull} Maasi: {employee.Salary}");

            Assistant assistant = new Assistant();
            assistant.GetFeedBack(employee);

            Console.WriteLine($"Adi:{employee.Name} Statusu: {employee.IsSuccessfull} Maasi: {employee.Salary}");


            ///////////////////////////////////////////////////////////////////////////////////
            ///

            Student student = new Student("Murad", "Qelenderli", 26, true);
            Student student1 = new Student("Rufet", "Ehmedov", 26, false);
            Student student2 = new Student("Kerim", "Recebov", 26, false);
            Group group = new Group("Test");

            group.Add(student);
            group.Add(student1);
            group.Add(student2);

            group.GetAll();
            group.GetOfflineStudents();
            group.GetOnlineStudents();


        }
    }
}
