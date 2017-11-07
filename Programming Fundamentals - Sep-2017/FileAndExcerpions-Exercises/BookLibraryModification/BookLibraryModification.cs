using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;

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
            string inputFilePath = "..\\..\\input.txt";
            if (!File.Exists(inputFilePath))
            {
                File.Create(inputFilePath);
            }
            var input = File.ReadAllLines(inputFilePath);
            int countBooks = int.Parse(input.First());
            for (int c = 0; c < countBooks; c++)
            {
                string[] tokens = input[c + 1].Split(' ');
                string title = tokens[0];
                DateTime date = DateTime.ParseExact(tokens[3],
                    "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Book book = new Book();
                book.Date = date;
                book.Title = title;
                books.Add(book);
            }

            DateTime searchDate = DateTime.ParseExact(input.Last(),
                       "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<Book> orderedBooks = books.Where(d => d.Date > searchDate)
                .OrderBy(x => x.Date)
                .ThenBy(t => t.Title)
                .ToList();

            File.WriteAllText("..\\..\\output.txt", string.Empty);
            foreach (var book in orderedBooks)
            {
                string output = $"{book.Title} -> {book.Date.ToString(@"dd.MM.yyyy")}";
                File.AppendAllText("..\\..\\output.txt", output + Environment.NewLine);
            }
        }
    }
}
