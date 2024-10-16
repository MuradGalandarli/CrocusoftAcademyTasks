using Interface.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface.Concret
{
    internal class Student : IEMail
    {
        public static int count = 1;
        private readonly IEMail _email;
        public Student(string name, string sureName)
        {
            count++;
            CustomEmail = GenerateEmail(Id, name, sureName);

        }

        public int Id { get; set; } = count;
        public string Name { get; set; }
        public string SureName { get; set; }
        static public string CustomEmail { get; set; }

        static string GenerateEmail(int id, string name, string sureName)
        {
            return $"{name}.{sureName}{id}.@gmail.com".ToLower();
        }

    } 
}
