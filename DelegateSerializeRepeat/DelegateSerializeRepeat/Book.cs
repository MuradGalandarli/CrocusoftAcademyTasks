using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSerializeRepeat
{
    public class Book
    {
        public Book(string name)
        {
            Count++;
            Name = name;
            Code = $"{Count}{Name[0]}";
            
        }

        static int Count;
        public static string? Name;
        public string? BookName = Name;
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public static string? Code { get; set; }
        

      
        /* 1) Aşağıdakı memberlərdən ibarət Book class:
 ~static Count ~Name
 ~AuthorName
 ~PageCount
 ~Price
 ~Code - kitabin adinin bash herfi ve elave olunma sirasi bitisik formada yazilmalidi(Sefiller=>S-3).
  Eger kitab adi bir nece sozden ibaretdirse her bir sozun
  bas herflerinden ve sira nomresinden ibaret olmalidir(Aklinda bir sayi tut => ABST-34)*/
    }
}
