using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation___Record
{
    public class Dog:Animal
    {
        public Dog(string Gender, string Name, string Brend) :base(Gender)
        {
            this.Name = Name;
            this.Brend = Brend;
        }
        public string Name { get; init; }
        public string Brend { get; set; }

      public void DogInfo()
        {
            Console.WriteLine($"Name: {Name} \n Brend: {Brend}");
        }

    }
}
