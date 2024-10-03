namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
int input = 0;
int[] arr = { 4, 5, 6, 2, 88, 2, 1, 4, 78, 8, 5, 4, 9, 75, 3 };
var sort = CostumSort(arr);
int i = 0;
foreach (int item in sort)
{

    Console.WriteLine($"Index number {i}) {item}");
    i++;
}


bool IsSucces = int.TryParse(Console.ReadLine(), out input);
if (IsSucces)
{

    Console.WriteLine(CostumBinarySearch(sort, 0, 14, input));
}

int CostumBinarySearch(int[] ar, int low, int lenght, int searchNum)
{
    var result = 0;

    int index = (low + lenght) / 2;
    if (low > lenght)
    {
        return -1;
    }
    if (ar[index] == searchNum)
    {
        return index;
    }

    if (ar[index] > searchNum)
    {
        result = CostumBinarySearch(ar, low, index - 1, searchNum);
    }
    if (ar[index] < searchNum)
    {
        result = CostumBinarySearch(ar, index + 1, lenght, searchNum);

    }
    return result;
}

int[] CostumSort(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        for (int j = 0; j < ar.Length; j++)
        {
            int temp;
            if (ar[i] < ar[j])
            {
                temp = ar[i];
                ar[i] = ar[j];
                ar[j] = temp;
            }
        }
    }
    return ar;
}*/


            // Jump Search
            /*
            int[] arr = { 4, 5, 6, 2, 88, 2, 1, 4, 78, 8, 5, 4, 9, 75, 3 };
            int[] sort = CostumSort(arr);
            int i = 0;
            foreach (int item in sort)
            {

                Console.WriteLine($"Index number {i}) {item}");
                i++;
            }

            Console.WriteLine(JumpSearchCostum(sort,1));


            int JumpSearchCostum(int[] ar,int searchNum)
            {
                double sqrt = Math.Sqrt(sort.Length);
                double round = Math.Round(sqrt);
                int num = 0;
                for (int i = 0;  i < ar.Length; i+=(int)round)
                {

                    num += (int)round;

                    if(num > ar.Length)
                    {
                        int a = num - ar.Length;
                        num -= a+1;
                    }

                    if (ar[i] <= searchNum && ar[num] >= searchNum )
                    {
                        for (int j = i; j < num+1; j++)
                        {
                            if (ar[j] == searchNum)
                            {
                                return j;
                            }
                        }
                        return -1;
                    }

                }

                return -1;
            }


            int[] CostumSort(int[] ar)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = 0; j < ar.Length; j++)
                    {
                        int temp;
                        if (ar[i] < ar[j])
                        {
                            temp = ar[i];
                            ar[i] = ar[j];
                            ar[j] = temp;
                        }
                    }
                }
                return ar;
            }
            */




            /*   Parkingdə hər maşın 1 saat üçün 1 manat pul ödəməlidir.Əgər maşın 3-5 saat qalıbsa 4-5-ci saat üçün 20% endirim,
               əgər maşın 5-8 saat qalıbsa yuxarıdakı endirimə əlavə olaraq 6-7 və 8ci saat üçün 50% endirim,
               8 saatdan çox qalıbsa qaldığı hər saat üçün 75% endirim əldə edir. 
               Bu şərtlər əsasında ümumi ödəniləcək məbləği hesablayan alqoritm qurun.
            */



            /*using System.Threading.Channels;

            decimal input = 0;

            bool IsSuccess = decimal.TryParse(Console.ReadLine(), out input);
            if (IsSuccess)
            {
                Console.WriteLine(Parking(input));
            }

            decimal Parking(decimal parking)
            {
                int azn = 1;
                if (input > 0 && input <= 3)
                {
                    return parking * azn;
                }

                if (parking >= 4 && parking <= 8)
                {
                    decimal prezent20 = 0;
                    decimal prezent50 = 0;
                    decimal hour20 = parking <= 5 ? 1 : 2;

                    prezent20 = hour20 * 20 / 100;


                    if (parking >= 5 && parking <= 8)
                    {
                        decimal hour50 = parking - 5;

                        prezent50 = hour50 * 50 / 100;
                    }
                    return azn * parking - prezent20 - prezent50;
                }
                else if (parking >= 9)
                {
                    decimal prezent75 = 0;
                    prezent75 = parking * 75 / 100;
                    return azn * parking - prezent75;
                }


                return -1;
            }

            */


            /*using System.Numerics;

            Console.WriteLine("Eded girin");
            var number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Eded girin");
            var number2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($" Operator secin - || ++ || * || /");
            var @operator = Console.ReadLine();
            switch (@operator)
            {
                case "-":
                    {
                        Console.WriteLine(Subtraction(number1,number2));
                        break;

                    }
                case "+":
                    {
                        Console.WriteLine(Addition(number1,number2));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(Multiplication(number1,number2));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(Division(number1,number2));
                        break;
                    }
            }

            decimal Subtraction(decimal num1 ,decimal num2)
            {
                return num1 - num2;
            }
            decimal Addition(decimal num1, decimal num2)
            {
                return num1 + num2;
            }
            decimal Multiplication(decimal num1, decimal num2)
            {
                return num1 * num2;
            }
            decimal Division(decimal num1, decimal num2)
            {
                return num1 / num2;
            }
            */

            //////////////////////////////////////////////////////////////////////////////

            /*int input = 0;


            while (true)
            {
                bool IsSuccess = int.TryParse(Console.ReadLine(), out input);
                if (IsSuccess)
                {
                    SimpleNumber(input);
                }
            }
            void SimpleNumber(int num)
            {
                int saygac = 0;
                for (int j = 1; j <= num; j++)
                {

                    if (num % j == 0)
                    {
                        saygac++;
                        if (saygac > 2)
                        {
                            break;
                        }
                    }
                }
                if (saygac == 2)
                {
                    Console.WriteLine($"Sade ededdir: {input}");
                }
                else
                {
                    Console.WriteLine($"Murekkeb ededdir: {input}");
                }
            }
            */



            ///////////////////////////////////////////////////////////////////////
            //int input = 0;
            //bool IsSuccess = int.TryParse(Console.ReadLine(), out input);
            //if (IsSuccess)
            //{
            //    int result = 0;
            //    foreach (var item in SimpleNumber(input))
            //    {
            //        Console.WriteLine(item);
            //        result += item;
            //    }
            //    Console.WriteLine($"Sade ededlerin cemi: {result}");

            //}
            //List<int> SimpleNumber(int num)
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 1; i <= num; i++)
            //    {
            //        int saygac = 0;
            //        for (int j = 1; j <= num; j++)
            //        {

            //            if (i % j == 0)
            //            {
            //                saygac++;
            //                if (saygac > 2)
            //                {
            //                    break;
            //                }
            //            }
            //        }
            //        if (saygac == 2)
            //        {
            //            list.Add(i);
            //        }
            //    }
            //    return list;
            //}

            /////////////////////////////////////////////////////////////////////

            //using System.Drawing;
            //using System.Runtime.InteropServices;

            //int wide = 0;
            //int pride = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enini girin");
            //    int.TryParse(Console.ReadLine(), out wide);
            //    Console.WriteLine("Uzunlugunu girin");
            //    int.TryParse(Console.ReadLine(), out pride);
            //    Rectangle(wide, pride);
            //}

            //void Rectangle(int wide, int pride)
            //{
            //    for (int i = 1; i <= wide; i++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            //    for (int i = 1; i <= pride - 2; i++)
            //    {
            //        Console.Write("*");
            //        for (int j = 1; j < wide - 1; j++)
            //        {
            //            Console.Write("  ");
            //        }
            //        Console.WriteLine(" *");
            //    }

            //    for (int i = 1; i <= wide; i++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}


            ////////////////////////////////////////////////////////////////////////////////////

            /*
            using System.ComponentModel.DataAnnotations;

            Console.WriteLine(Min(4,8,1,6,2,4,7,5,5,41,2,22,4,5,15));
            int Min(params int[] nums)
            {

                int data = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (data > nums[i])
                    {
                        data = nums[i];
                    }
                }
                return data;
            }
            */

            ////////////////////////////////////////////////////////////////////////////////////



            //public class ss
            //{
            //    public static decimal Square(int radius)
            //    {
            //        double n = 3.14159;
            //        return (radius * radius) * (decimal)n;
            //    }
            //    public static decimal Square(int pride, int wide)
            //    {
            //        decimal result = pride * wide;
            //        return result;
            //    }
            //    public static decimal Square(int a, int b, int c)
            //    {
            //        var result = 2*(a * b + a * c + b * c);
            //        return result;
            //    }
            //    public static Double Square(int a, int b, Double c)
            //    {
            //        // S = p * r; p = (a + b + c) / 2
            //        var result = 2 * (a * b + a * c + b * c);
            //        return result;
            //    }
            //}





            //2)Userdən integer dəyər götürürsünüz və userin daxil etdiyi ədədə qədər olan sadə ədədlərin cəmini çap edən alqoritm qurun.

            int input = 0;
            bool IsSuccess = int.TryParse(Console.ReadLine(), out input);

            if (IsSuccess)
            {
                Console.WriteLine($"{input}'a qeder olan sade ededler: ");
                int sum = 0;
                foreach (int item in Sade(input))
                {
                    sum += item;
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Toplam sade ededlerin cemi {sum}");
            }
            else Console.WriteLine("Soz daxil edildi!!!! zehmet olmazsa eded girin");


            List<int> Sade(int num)
            {
                List<int> list = new List<int>();
                for (int i = 1; i < input; i++)
                {
                    int saygac = 0;
                    for (int j = 1; j < input; j++)
                    {


                        if (i % j == 0)
                        {
                            saygac++;
                            if (saygac > 2)
                            {
                                break;
                            }
                        }
                    }
                    if (saygac == 2)
                    {
                        list.Add(i);

                    }
                }
                return list;

            }
        }
    }
}