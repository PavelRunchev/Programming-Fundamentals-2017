using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Book
    {
        public string title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

    }

    class Library
    {
        public string Name { get; set; }
        public List<Book>  Books { get; set; }
    }

    class BookLibrary
    {
        static void Main()
        {
            List<Library> listLibrary = new List<Library>();
            var numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string title = input[0];
                string author = input[1];
                decimal price = decimal.Parse(input[5]);
                if (!listLibrary.Any(n => n.Name == author))
                {
                    Book book = new Book();
                    book.Author = author;
                    book.Price = price;
                    book.title = title;
                    Library library = new Library();
                    library.Name = author;
                    if (library.Books == null)
                    {
                        library.Books = new List<Book>();
                    }
                    library.Books.Add(book);
                    listLibrary.Add(library);
                }
                else
                {
                    Book book = new Book();
                    book.Author = author;
                    book.Price = price;
                    book.title = title;
                    var addInLibrary = listLibrary.FirstOrDefault(a => a.Name == author);
                    addInLibrary.Books.Add(book);
                }

            }

            var orderedLibrary = listLibrary.OrderByDescending(s => s.Books.Sum(a => a.Price))
                .ThenBy(auth => auth.Name)
                .ToList();

            foreach (var item in orderedLibrary)
            {
                Console.WriteLine($"{item.Name} -> {item.Books.Sum(a => a.Price):f2}");
            }
        }
    }
}
