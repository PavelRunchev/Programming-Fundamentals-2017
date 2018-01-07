using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibraryModification
{
    class Book
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
    class BookLibraryModification
    {
        static void Main()
        {
            List<Book> books = new List<Book>();
            var numberOfLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLine; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string title = input[0];
                DateTime date = DateTime.ParseExact(input[3],
                    "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Book book = new Book();
                book.Date = date;
                book.Title = title;
                books.Add(book);
            }

            DateTime searchDate = DateTime.ParseExact(Console.ReadLine(),
                    "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<Book> orderedBooks = books.Where(d => d.Date > searchDate)
                .OrderBy(x => x.Date)
                .ThenBy(t => t.Title)
                .ToList();

            foreach (var book in orderedBooks)
            {
                Console.WriteLine($"{book.Title} -> {book.Date.ToString(@"dd.MM.yyyy")}");
            }
        }
    }
}
