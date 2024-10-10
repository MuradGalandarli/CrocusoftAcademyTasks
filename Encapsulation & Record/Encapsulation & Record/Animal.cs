using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation___Record
{
    public class Animal
    {
        public Animal(string Gender)
        {
            this.Gender = Gender; 
            BirthYear = DateTime.Now.Year;
        }
        public string Gender { get; set; }
        public int BirthYear { get; init; }
        public void AnimalInfo()
        {
            Console.WriteLine($"Gender: {Gender} \n BirthYear: {BirthYear}");
        }

    }
}
