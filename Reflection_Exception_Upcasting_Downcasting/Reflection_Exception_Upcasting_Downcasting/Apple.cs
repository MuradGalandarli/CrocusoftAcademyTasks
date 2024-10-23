using Reflection_Exception_Upcasting_Downcasting.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Exception_Upcasting_Downcasting
{
	public class Apple:Fruit
	{
	 public	int VitaminA = 15;
	 public int VitaminB = 10;

		public override void Taste()
		{
			Console.Write("Apple dad");
		}
	}
}
