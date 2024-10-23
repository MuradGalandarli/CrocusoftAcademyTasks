namespace Enum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*byte result = 0;
			Console.WriteLine("1 - 7 araliginda eded girin");
			while (true)
			{
				bool IsSuccess = byte.TryParse(Console.ReadLine(), out result);
				if (IsSuccess)
				{
					if (result > 0 && result < 8)
					{
						Console.WriteLine(Day(result));
					}

					else
					{
						Console.WriteLine("Xetali giris etdiniz");
					}

				}
				else
				{
					Console.WriteLine("Yalniz eded daxil edin");
				}
			}

			DaysOfWeek.Days Day(byte input)
			{
				switch (result)
				{
					case 1:
						return DaysOfWeek.Days.Monday;
					case 2:
						return DaysOfWeek.Days.Tuesday;
					case 3:
						return DaysOfWeek.Days.Wednesday;
					case 4:
						return DaysOfWeek.Days.Thursday;
					case 5:
						return DaysOfWeek.Days.Friday;
					case 6:
						return DaysOfWeek.Days.Saturday;
					case 7:
						return DaysOfWeek.Days.Sunday;

				}
				return 0;
			}
			
			 */

			////////////////////////////////////////////////////////////////////////////////////////////////////////////
			///

			byte result = 0;
			Console.WriteLine("1 - 12 araliginda eded girin");
			while (true)
			{
				bool IsSuccess = byte.TryParse(Console.ReadLine(), out result);
				if (IsSuccess)
				{
					if (result > 0 && result < 13)
					{
						Console.WriteLine(Year(result));
					}

					else
					{
						Console.WriteLine("Xetali giris etdiniz");
					}

				}
				else
				{
					Console.WriteLine("Yalniz eded daxil edin");
				}
			}



			MonthOfYear.Months Year(byte input)
			{
				switch (result)
				{
					case 1:
						return MonthOfYear.Months.January;
					case 2: 
						return MonthOfYear.Months.February;
					case 3:
						return MonthOfYear.Months.March;
					case 4:
						return MonthOfYear.Months.April;
					case 5:
						return MonthOfYear.Months.May;
					case 6:
						return MonthOfYear.Months.June;
					case 7:
						return MonthOfYear.Months.July;
					case 8:
						return MonthOfYear.Months.August;
					case 9:
						return MonthOfYear.Months.September;
					case 10:
						return MonthOfYear.Months.October;
					case 11:
						return MonthOfYear.Months.November;
					case 12:
						return MonthOfYear.Months.December;
					

				}
				return 0;
			}




		}
	} 
}

