using Reflection_Exception_Upcasting_Downcasting.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Exception_Upcasting_Downcasting
{
	internal class Pineapple : Fruit
	{
		public int VitaminE = 25;
		public int VitaminD = 20;

		public override void Taste()
		{
            Console.WriteLine("Pineapple");
		}
	}
}
