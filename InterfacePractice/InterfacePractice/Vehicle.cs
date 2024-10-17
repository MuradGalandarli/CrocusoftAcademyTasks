using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    internal abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void Drive();
     
        public abstract void Stop();
       
        /* Vehicle- sinif yaradın.Bu sinif aşağıdakı xüsusiyyətlərə və metodlara sahib olmalıdır:
 Property: Speed (Sürət)
         Abstract Method: Drive() (Hərəkət etmək)
 Abstract Method: Stop() (Dayanmaq)*/
    }
}
