using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder
{
    public class Phone : Product
    {
        string RAM;
        string Color;
        decimal Balance;

        public Phone(string BrandName, string Model, decimal Price, decimal Cost,
            int Count, string RAM, string Color = "BLack")
            : base(BrandName, Model, Price, Cost, Count)
        {
            this.RAM = RAM;
            this.Color = Color;
            this.Balance = 0;
            this.Color = Color;
        }

       public void Call(decimal seconds)
        {
            if((Balance * 100)  - seconds >= 0)
            {
                Balance -= seconds;
                Console.WriteLine($"Zeng edildi \n Qaliq balans {Balance}");
                Console.WriteLine($"{seconds} - danisdiniz");
            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder vesait qalmiyib");
            }
        }
       public void Pay(decimal money)
        {
            Balance += money * 100;
            Console.WriteLine($"Balansiniz artirildi: {Balance}");
        }




    /*    fieldleri var.Balance constructor ishe dushdukde 0-a beraber olur.Color gonderilmese default 
olaraq BLack deyerini goturur gonderilirse gonderilen deyeri menimsedilir. Diger deyerler
gonderilmemish yarana bilmez

Call(seconds) methodu yaradirsiz.Seconds qebul edir danishigin saniyesinden asili olaraq
        her saniyeye gore balansdan 0.1 deyer cixilir.Zengden evvel balansda zeng ucun kifayet qeder
vesait varmi yoxlanmalidir eger varsa ekrana zeng edildi yoxdursa balansda kifayet qeder vesait
qalmiyib yazisini cixarin.
*/


    }
}
