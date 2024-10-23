using System.Diagnostics;
using System;
using Reflection_Exception_Upcasting_Downcasting.Abstract;
using System.Security.Cryptography;
using System.Reflection;
using System.Resources;

namespace Reflection_Exception_Upcasting_Downcasting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Fruit abstract classi verilir:
Price
Sort  fieldleri olur
Taste() methodu olur(abstract yoxsa virtual duzgun secin) ekrana meyvenin dadini cixarir.

Apple classi:
VitaminA
VitaminB
fieldleri olur ededle vitaminin miqdarini gosterir

Pineapple classi:
VitaminE
VitaminD
fieldleri olur

Orange classi:
VitaminC
fieldi olur

Program cs-dəHər üçünü özündə cəmləyə biləcək bir Basket adli array yaradin və fərqli meyvələri o arraya daxil edin.

Foreach daxilindde Arraydaki elementleri  reflection ile type adini(Apple, Pineapple ve s.) ve ardincada butun fieldlerinin adini ve deyerlerini ekrana cixardin.
(Məsələn: Apple tipinden obyektde Price, Sort, A ve B vitamin deyerlerini ------ Orange-də Price, Sort, C vitamin deyerlerini ekrana cixartsin)

Ipucu: GetType(), GetFields(), GetValue() istifade ederek reflectionla elde ede bilersiz.

Qeyd: Reflection ile yaza bilmeyenler Foreach icerisinde Downcast ederek yazsinlar ancaq bu zaman tapshiriq 90 uzerinden qiymetlendirilecek.
			*/

			Apple apple = new Apple()
			{
				Price = 1,
				Sort = "AppleSort"
			};
			Orange orange = new Orange()
			{
				Price = 2,
				Sort = "OrangeSort"
			};
			Pineapple applePineapple = new Pineapple()
			{
				Price = 1,
				Sort = "PineappleSort"
			};

			Fruit[] Basket = { apple, orange, applePineapple };
			foreach (var item in Basket)
			{

				if (item is Apple test)
				{
					Console.Write($"Qiymet: {item.Price} Sortu: {item.Sort} "); item.Taste();
					Console.WriteLine($"Apple A vitamini: {test.VitaminA} Apple B vitamini:  {test.VitaminB} ");
				}

				if (item is Orange ogr)
				{
					Console.Write($"Qiymet: {item.Price} Sortu: {item.Sort} "); item.Taste();
					Console.WriteLine($"Orange c vitamini: {ogr.VitaminC} ");
				}

				if (item is Pineapple pin)
				{
					Console.Write($"Qiymet: {item.Price} Sortu: {item.Sort} "); item.Taste();
					Console.WriteLine($"Pineapple D vitamini: {pin.VitaminD} Pineapple E vitamini: {pin.VitaminE}");
				}

			}
			Console.WriteLine("*****************************************************");

			var assembly = Assembly.GetExecutingAssembly();
			
			foreach (var i in assembly.GetTypes())
			{
				Console.WriteLine(i);
				foreach (var a in i.GetFields())
				{
					Console.WriteLine(a);
					Console.WriteLine(a.GetValue);

				}
			}




		}
	}
}
