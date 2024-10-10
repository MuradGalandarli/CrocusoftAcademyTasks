using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder
{
    public class Product
    {
        string Id = "";
        string BrandName = "";
        string Model = "";
        decimal Price = 0;
        decimal Cost = 0; // Cost, - xercleri
        decimal Income = 0; //Income, - umumi gelir
         int Count = 0;  // - mehsulun sayi

        public Product(string BrandName, string Model, decimal Price, decimal Cost, int Count)
        {
            this.BrandName = BrandName;
            this.Model = Model;
            this.Price = Price;
            this.Cost = Cost;
            set(Count);
            CreateId(BrandName, Model);
        }
       
         void set(int num)
        {
            if (num < 0)
            {
                this.Count = 0;
            }
            else
            { 
                this.Count = num;
            }

        }

        public void CreateId(string BrandName,string Model)
        {
           string brandName = BrandName.Substring(0, 2);
           string model = Model.Substring(0, 2);
            Id = brandName + model;
        }

       public void GetInfo()
        {
            Console.WriteLine($"Idisi: {this.Id}\n BrandName: {BrandName}\n Model: {Model}\n Price: {Price}\n Cost: {Cost}" +
                $"\n Income: {this.Income}\n Count: {this.Count}");
            
        }
        /*Sale() methodu olur.Eger kifayet qeder mehsul varsa Satishi heyata kecirir satilan qiymetden xercler
    cixilaraq gelire elave edir ve mehsul sayini azaldir.
*/

      public void Sale(string BrandName, string Model, decimal Price, int sellCount)
        {
            if(this.BrandName == BrandName && this.Model == Model && this.Price - Price >= 0 && this.Count - sellCount >=0)
            {
                Console.WriteLine("Satildi");
                if (this.Price < Price)
                {
                    var rest = Price - this.Price;
                    Console.WriteLine($"Qaliq: {rest}");
                    this.Income += this.Price - Cost - rest;
                    this.Count = this.Count - sellCount;
                }
                else
                {
                   // Income = Price - this.Cost;
                    this.Count -= sellCount;
                    this.Income += this.Price - Cost;
                }
            }
            if(this.Count - sellCount < 0)
            {
                Console.WriteLine("Depoda mal yoxdur");
            }
            if (this.Price - Price < 0)
            {
                Console.WriteLine("Qiymeti duzgun girin");
            }
            if (this.Price - Price < 0)
            {
                Console.WriteLine("Qiymeti duzgun girin");
            }
            if(this.BrandName != BrandName && this.Model != Model)
            {
                Console.WriteLine("Model ve markasini duzgun girin");
            }
        }



       /* string Id = "";
        string BrandName = "";
        string Model = "";
        decimal Price = 0;
        decimal Cost = 0; // Cost, - xercleri
        decimal Income = 0; //Income, - umumi gelir
        public int Count = 0;  // -*/


    }

}
