namespace TataTypeParametersParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle Parameters: " + Program.Square(22,25));




        }

        public static decimal Square(int radius)
        {
            double n = 3.14159;
            return (radius * radius) * (decimal)n;
        }
        public static decimal Square(int pride, int wide)
        {
            decimal result = pride * wide;
            return result;
        }
        public static decimal Square(int a, int b, int c)
        {
            var result = 2 * (a * b + a * c + b * c);
            return result;
        }
        public static Double Square(int a, int b, Double c)
        {
            // S = p * r; p = (a + b + c) / 2
            var result = 2 * (a * b + a * c + b * c);
            return result;
        }

    }
}