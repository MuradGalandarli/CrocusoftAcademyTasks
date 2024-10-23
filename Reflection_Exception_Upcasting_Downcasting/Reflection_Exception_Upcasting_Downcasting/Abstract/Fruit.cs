using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Exception_Upcasting_Downcasting.Abstract
{
	public abstract class Fruit
	{
		public int Price = 0; 
        public string Sort;
		public abstract void Taste();
		
	}
}
