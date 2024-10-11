namespace Tuple_ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* İstifadəçi məlumatlarını Tuple ilə saxlamaq
               Məqsəd: İstifadəçi adını, yaşını və email ünvanını Tuple istifadə edərək saxlamaq.
            */

            /* (string Name, byte Age, string Email) data = ("Ehmed", 30, "Ehmed@gmail.com");
             Console.WriteLine(data);

             var data1 = Tuple.Create("Rufet",30,"Rufet@gamil.com");
             Console.WriteLine(data1);*/

            ///////////////////////////////////////////////////////////
            ///

            /*İki ədədin bölməsini və qalığını Tuple ilə qaytarmaq
            Məqsəd: Verilən iki tam ədədin bölünmə nəticəsini və qalığını Tuple istifadə edərək qaytarmaq.
*/


            (int worth, int rest) data = Division(7, 3);
            Console.WriteLine($"Cavab: {data.worth} Qaliq: {data.rest}");

           (int worth,int rest) Division(int a ,int b)
            {
                var worth = a / b;
                var rest = a % b;
                return (worth,rest);    

            }



        }
    }
}
