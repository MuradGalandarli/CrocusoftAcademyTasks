namespace Luhn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 7, 8, 8, 9, 6, 4, 6, 1, 2, 3, 7, 9, 4, 8, 9, 6 };
            // int[] arra = { 4,1,6,9,7,3,8,8,0,2,2,4,0,0,5,5 };

            int[] arra = { 4, 0, 9, 8, 5, 8, 4, 4, 7, 8, 7, 7, 8, 0, 4, 4 };
            //    int[] arra = { 4,0,9,8,5,8,4,4,7,1,9,5,9,1,9,5};

            Console.WriteLine(Luich(arra));

            bool Luich(int[] ar)
            {
                List<int> list = new List<int>();
                var data = ar.Reverse().ToList();

                for (int i = 1; i < data.Count; i += 2)
                {
                    data[i] *= 2;
                    if (data[i] > 9)
                    {
                        int a = data[i] / 10;
                        int b = data[i] % 10;
                        int c = a + b;
                        list.Add(c);
                    }
                    else
                    {
                        list.Add(data[i]);
                    }
                }

                for (int i = 0; i < data.Count; i++)
                {
                    list.Add(data[i]);
                    i++;
                }
                int sum = 0;
                foreach (int i in list)
                {
                    sum += i;
                }
                if (sum % 10 == 0)
                {
                    return true;
                }

                return false;

            }

        }
    }
}
