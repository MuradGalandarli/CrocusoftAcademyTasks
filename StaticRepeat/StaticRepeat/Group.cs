using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StaticRepeat
{
    internal class Group
    {
        static int count = 0;
        
            public Group()
        {
            Students = new Student[2];
            count++;
        }
        public static Group[] Groups { get; set; }
        int GroupId { get; set; } = count + 1;
        public string GroupName { get; set; }

        public static Student[] Students;

        public void GetGroupInfo()
        {
            Console.WriteLine($"{GroupId}.Grupun adi: {GroupName} Grupdaki telebe sayi: {Student.count}");
        }
        public void GetStudent(int id)
        {
            var data = Students.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                Console.WriteLine($"{data.Id}. {data.Name} {data.SureName}");
            }
            else
            {
                Console.WriteLine(data);
            }
        }
        int studentCount = 0;
        public void AddStudent(Student student)
        {
            
          //  Array.Resize(ref Students, Students.Length + 1);
            Students[studentCount] = student;
            studentCount++;
        }
        public void Search(string search)
        {
            foreach (Student item in Students)
            {
                if (item.Name.ToString().Contains(search) || item.SureName.ToString().Contains(search))
                {
                    Console.WriteLine($"{item.Id}. {item.Name} {item.SureName}");
                };
            }

        }
        public void ShowStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Id}.{student.Name} {student.SureName}");
            }
        }



        /* Group classi yaradin:
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
    }
}
