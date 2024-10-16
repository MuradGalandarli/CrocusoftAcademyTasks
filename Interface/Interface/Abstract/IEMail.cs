using Interface.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract
{
    internal interface IEMail
    {
      // string GenerateEmail(int id, string name, string sureName);
       public static string CustomEmail { get; set; }
    }
}
