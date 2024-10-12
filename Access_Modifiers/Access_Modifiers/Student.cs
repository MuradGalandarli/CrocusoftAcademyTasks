using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Access_Modifiers
{
    internal class Student:Person
    {
        public bool _isOnline = false;
        public Student(string name, string sureName, int age, bool isOnline = false) :base(name,sureName,age)
        {
            _isOnline = isOnline;
        }
    }
}
