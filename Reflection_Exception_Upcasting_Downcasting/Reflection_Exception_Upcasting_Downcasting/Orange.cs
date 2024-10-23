using Reflection_Exception_Upcasting_Downcasting.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Exception_Upcasting_Downcasting
{
	public class Orange:Fruit
	{
	   public int VitaminC = 45;

		public override void Taste()
		{
			Console.Write("Orange dad");
		}
	}
}
