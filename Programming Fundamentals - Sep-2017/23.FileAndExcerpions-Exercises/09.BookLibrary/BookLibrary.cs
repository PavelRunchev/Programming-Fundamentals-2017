using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace BookLibrary
{
    class BookLibrary
    {
        static void Main()
        {
            List<Library> dataLibrary = new List<Library>();
            string[] input = File.ReadAllLines(@"..\..\input.txt");
            int numberOfLine = int.Parse(input[0]);
            for (int i = 1; i <= numberOfLine; i++)
            {
                string[] tokens = input.Skip(i).First().Split().ToArray();
                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3],
                    "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);
                Book book = new Book();
                book.Title = title;
                book.Author = author;
                book.Publisher = publisher;
                book.ReleaseDate = releaseDate;
                book.IsbnNumber = isbn;
                book.Price = price;
                if (!dataLibrary.Any(a => a.Name == author))
                {
                    Library library = new Library();
                    library.Name = author;
                    library.Books = new List<Book>();
                    library.Books.Add(book);
                    dataLibrary.Add(library);
                }
                else
                {
                    var searchAuthor = dataLibrary.FirstOrDefault(a => a.Name == author);
                    searchAuthor.Books.Add(book);
                }
            }

            var ordered = dataLibrary.OrderByDescending(t => t.TotalPrice)
                .ThenBy(a => a.Name)
                .ToList();
            File.WriteAllText(@"..\..\output.txt", string.Empty);

            foreach (var library in dataLibrary)
            {
                string resultAppend = $"{library.Name} -> {library.TotalPrice:f2}" 
                    + Environment.NewLine;
                File.AppendAllText(@"..\..\output.txt", resultAppend);
            }
        }
    }
}
