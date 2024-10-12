using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Person
    {
        public string _name;
        public  string _sureName;
        public  int _age;

        public Person(string name, string sureName, int age)
        {
            _name = name;
            _sureName = sureName;
            _age = age;
        }

    }
}
