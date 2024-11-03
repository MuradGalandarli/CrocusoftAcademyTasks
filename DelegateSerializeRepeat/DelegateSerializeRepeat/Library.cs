using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DelegateSerializeRepeat
{
    public class Library
    {
        static Library()
        {
           // Books = new List<Book>();
        }

        /*    ~Books - book listi
    ~AddBook() - Library'e kitab elave edir
    ~GetBook() - verilen sert daxilinde olan kitabi qaytarir
    ~FindAllBooks() - verilen sert daxilinde olan kitablari qaytarir
    ~RemoveAllBooks() - verilen sert daxilinde olan kitabları silir ve silinen kitablarin sayini qaytarir
    QEYD: Verilen shert yani Methodlariniz delegate qebul edecek

    Program.cs de Library yaradirsiz. Bir nece kitab yaradib Library-e elave edirsiz.

    SerializeLibrary() Methodu yaradirsiz Library qebul edir
        LibraryData.json file-a serialize edib gonderir
    DeserializeLibrary() Methodu yaradirsiz LibraryData.
        json file-dan datalari cekib deserialize edib geriye Library qaytarir*/

        public static List<Book>? Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            
            Books.Add(book);
            
        }
        public Book GetBook(string authorName)
        {
            return Books.FirstOrDefault(x=>x.AuthorName == authorName);
        }
        public List<Book> FindAllBooks()
        {
            return Books.ToList();
        }
        public int RemoveAllBooks()
        {
            int count = Books.Count();
            Books.Clear();
           
          
          return count;
        }

    }
}
