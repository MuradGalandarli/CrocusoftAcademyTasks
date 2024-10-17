using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaticRepeat
{
    internal class Student
    {
        public static int count = 0;
        public Student()
        {
            count++;
        }

        public int Id { get; set; } = count+1;
        public string Name { get; set; }
        public string SureName { get; set; }

       public void GetInfo()
        {
            Console.WriteLine($"{Id}. {Name} {SureName}");
        }




    }
}
