using System.Diagnostics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace StaticRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Student class-i yaradin
          static Count
          Id
          Name
          Surname
          GetInfo()


  Group classi yaradin:
         static Group[] Groups(Group arrayidir yaranan butun gruplar program.cs de bura elave olunmalidir)
         static GroupCount(Unikal Id vermek ucun)
         GroupId
         GroupName
         Student[] Students(her grupun oz telebeleri olur static deyil)

        GetGroupInfo() Groupun melumatlarini ve grupdaki telebelerin sayini ekrana cixarir.
        GetStudent() int id qebul edir o id-li studenti return edir eger gonderilen id ye aid 
              student yoxdursa geriye null qaytarir.
        AddStudent() Gonderilen Studenti Groupdaki Students Arrayina elave edir
        Search() string qebul edir adinda ve ya soyadinda gonderilen string deyerleri olan
              telebelerin melumatlarini ekrana cixarir

        ShowStudents() - Groupdaki telebeleri ekrana cixaran method*/


            Student student = new Student()
            { Name = "Cavad",
            SureName = "Cavadov"};
            student.GetInfo();
            Student student1 = new Student()
            {
                Name = "Elsen",
                SureName = "Qapagov"
            };
            student1.GetInfo();


            Group group = new Group()
            {
                GroupName = "C#"
            };
           

            Group.Groups = new Group[] {
                group
            };
            
            group.GetGroupInfo();
           
            group.AddStudent(student);

            group.AddStudent(student1);

            group.GetStudent(2);

            group.ShowStudents();
            Console.WriteLine("******************");
            group.Search("Ca");


        }
    }
}
