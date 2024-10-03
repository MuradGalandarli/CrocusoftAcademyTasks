namespace Array_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arraydaki yalnız tək ədədlərin cəmini çap edən alqoritm qurun.

               int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            Console.WriteLine(EvenNumbers(arr));

            int EvenNumbers(int[] ar)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.WriteLine(arr[i]);
                        sum += arr[i];
                    }
                }
                return sum;
            }

            /////////////////////////////////////////////////////////////////////////////
            ///
            //  2.Arraydaki ədədlərin ədədi ortasını hesablayan alqoritm qurun

            int[] arry = { 0,0,0,0,0 };
            var result = ArithmeticMean(arry);
            Console.WriteLine($"Arrayin ededlerin ortalamasi {result.Mean}");
            Console.WriteLine($"Arraydaki ededlerin toplami {result.Sum}");
          
            (decimal Mean, int Sum) ArithmeticMean(int[] ar)
            {
                decimal sum = 0;

                for (int i = 0; i < arry.Length; i++)
                {
                    sum += ar[i];
                }
                decimal mean = sum / ar.Length;
                return (mean, (int)sum);

            }

        }
    }
}