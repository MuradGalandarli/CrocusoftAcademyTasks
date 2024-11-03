using Newtonsoft.Json;
using System.IO;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DelegateSerializeRepeat
{
    public class Program
    {
        delegate void DelegateAddBook(Book book);
        delegate Book DelegateGetBook(string authorName);
        delegate List<Book> DelegateFindAllBooks();
        delegate int DelegateRemoveAllBooks();


        static void Main(string[] args)
        {
            Book book = new Book("Test") { BookName = "Test", AuthorName = "Rufet", PageCount = 235, Price = 5 };
            Book book1 = new Book("Test1") { BookName = "Test10", AuthorName = "Ehmed", PageCount = 235, Price = 5 };


            Library library = new Library();

            DelegateAddBook delegateAddBook = new DelegateAddBook(library.AddBook);
            delegateAddBook(book);
            delegateAddBook(book1);


            DelegateGetBook delegateGet = new DelegateGetBook(library.GetBook);
            var result = delegateGet("Rufet");
            Console.WriteLine($"{result.AuthorName} {result.BookName} {result.Price} {result.PageCount}");



            DelegateFindAllBooks DelGetAll = new DelegateFindAllBooks(library.FindAllBooks);
            foreach (var item in DelGetAll())
            {
                Console.WriteLine($"{item.AuthorName} {item.BookName} {item.Price} {item.PageCount}");
            }
            DelegateRemoveAllBooks delegateRemoveAllBooks = new DelegateRemoveAllBooks(library.RemoveAllBooks);
            var data = delegateRemoveAllBooks();
            Console.WriteLine(data);


            string filePath = @"C:\\Users\\LENOVO\\Desktop\\Training\\DelegateSerializeRepeat\\DelegateSerializeRepeat\\Booksjson.json";
            void SerializeLibrary()
            {
                var data = library.FindAllBooks();
                var seri = JsonConvert.SerializeObject(data);
                using (var file = new StreamWriter(filePath))
                {
                    file.WriteLine(seri);
                };

            }
            void DeserializeLibrary()
            {
                string json = "";
                using (var file = new StreamReader(filePath))
                {
                    json = file.ReadToEnd();
                };

                var deSeri = JsonConvert.DeserializeObject<List<Book>>(json);
                Library.Books = deSeri;

            }
            // SerializeLibrary();
            // DeserializeLibrary();
        }

    }
}
