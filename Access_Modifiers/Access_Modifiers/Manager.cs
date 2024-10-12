using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Manager
    {
        public Employee GetPromotion(Employee employe)
        {
            employe.Salary += 100;
            return employe;
        }
    }
}
