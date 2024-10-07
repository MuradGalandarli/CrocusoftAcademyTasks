using Constructor_Inheritance.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Constructor_Inheritance.Students
{
    public class Student
    {
        string Name;
        string SureName;
        string Group;
        public int Point;
        bool isGraduated;

        public Student(string Name, string SureName, string Group, int point)
        {
            this.Name = Name;
            this.SureName = SureName;
            this.Group = Group;
            this.Point = point;
        }
        public void isGraduatedChech(int point)
        {
            if (point < 65)
            {
                isGraduated = false;
            }
            else
            {
                isGraduated = true;
            }
        }
        public void Getİnfo(Student student)
        {
            Console.WriteLine("Telebe haqqda melumat");
            Console.WriteLine($"Adi: {student.Name},Soyadi: {student.SureName},Qrupu: {student.Group},Ortalamasi: {student.Point}");
        }
        public void CheckGraduation(int point)
        {
            isGraduatedChech(point);
            if (isGraduated)
            {
                Console.WriteLine("Mezun olub");
            }
            else
            {
                Console.WriteLine("Mezun olmayib");
            }
        }
        public void GetDiplomDegree(int point)
        {
            if (Point < 65)
            {
                Console.WriteLine($"Ortalamaniz 65 - az oldugu ucun mezun olmadniz.Ortalamainiz {point}");
            }
            else if (point > 65 && point < 80)
            {
                Console.WriteLine($"Ortalamaniz {point}, Telebenin adi: {Name}");
            }
            else if (point > 80 && Point < 90)
            {
                Console.WriteLine($"Ortalamaniz {point}: Seref");
            }
            else
            {
                Console.WriteLine($"Ortalamaniz {point}: Yuksek seref");
            }


        }

    }
}

/*
Student classi yaradirsiz. Name, Surname, Group, Point, isGraduated
    (mezun olub olmadigi ile bagli boolean bir type olacaq) 
    field-leri olacaq.Student classindan instance alindigi zaman isGraduated-den bashqa bütün dəyərləri ötürülməlidir.
    isGraduated constructor işə düşdükdə gelen Point field-nə əsasən təyin olunmalıdır(65-den aşagidirsa kesilib).
Student classinda aşağıdakı methodlari yazırsız:
    a)Getİnfo() - Studentin butun deyerlerini consola cixardan bir method.

    b)CheckGraduation() - Student-in mezun olub olmadigini(isGraduated-fieldine esasen) 
    ekrana cixaran method. Eger mezun olubsa bu telebe mezun olub deye yazilsin,
    eger mezun olmayibsa mezun olmadigi ile bagli bir melumat yazilsin.


    c)GetDiplomDegree() - Studentin Point-nə əsasən diplom növünü ekrana çıxaran method.
    Eger 65-den kicikdirse yoxdur, 65-80 araligindadirsa adi, 80-90 araligindadirsa şərəf, 
    90-dan yuxaridirsa yüksək şərəf.
*/