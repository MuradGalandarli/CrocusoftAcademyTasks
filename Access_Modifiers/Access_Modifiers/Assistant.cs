using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Access_Modifiers
{
    internal class Assistant:Manager
    {
        public Employee GetFeedBack(Employee employe)
        {
            if(employe.IsSuccessfull)
            {
                GetPromotion(employe);
            }
            return employe; 
        }

    }
}
