using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Access_Modifiers
{
    internal class Group
    {
        private string _groupName;
        public Student[] Students { get; set; }
        public int arraySize = 3;
        int a = 0;
        public Group(string groupName)
        {
            Students = new Student[arraySize];
            _groupName = groupName;
        }
        
        public void Add(Student student)
        {
            Students[a] = student;
            a++;
        }

        public void GetAll()
        {
            Console.WriteLine("Qrupun butun telebeleri");
            foreach (var student in Students)
            { 
                Console.WriteLine($"Adi: {student._name}\n Soyadi: {student._sureName}\n Yasi: {student._age}\n");
            }
        }

        public void GetOnlineStudents()
        {
            int counterOnline = 0;
            Console.WriteLine($"Onlayin {_groupName} grupunun telebeleri");

                foreach (var student in Students)
                {
                    if (student._isOnline == true)
                    {
                        counterOnline++;
                        Console.WriteLine($"Adi: {student._name}\n Soyadi: {student._sureName}\n ");
                    }
                   
                }
            if(counterOnline == 0)
            {
                Console.WriteLine("Onlayin grupnuz yoxdur");
            }
        }

        
        public void GetOfflineStudents()
        { int counterIsOffline = 0;
            Console.WriteLine($"Offline {_groupName} grupunun telebeleri ");
            if (Students.Length <= arraySize)
            {
                foreach (var student in Students)
                {
                    if (!student._isOnline)
                    {
                        counterIsOffline++;
                        Console.WriteLine($"Adi: {student._name}\n Soyadi: {student._sureName}\n ");
                    }

                }
            }
            if(counterIsOffline == 0)
            {
                Console.WriteLine("Offline grupnuz yoxdur");
            }
        }
    }
}          /* Group classı yaradırsız GroupName və özündə Student-ləri saxlayan Students(Array olacaq)
                             field-ləri olsun.GroupName constructordan gəlməlidir və Students arrayı
                             constructor işə düşdükdə initialize olunmalıdır.Group classında aşağıdakı
                             methodları yaradırsız:
         a.Add methodu Student qəbul edir və Students array-na daxil edir.
         b.GetAll methodu parameterless-olmalıdır Group-da ki butun telebelerin(Students arrayindaki)
                             ad və soyadını ekrana çıxartmalıdır.
         c.GetOnlineStudents methodu methodu parameterless(parametirsiz)-olmalıdır Group-da ki online
                             oxuyan telebelerin(IsOnline fieldinə əsasən) ad və soyadını ekrana çıxartmalıdır.
         d.GetOfflineStudents methodu parameterless-olmalıdır Group-da ki offline oxuyan
                     telebelerin(IsOnline fieldinə əsasən) ad və soyadını ekrana çıxartmalıdır.*/


            
         
