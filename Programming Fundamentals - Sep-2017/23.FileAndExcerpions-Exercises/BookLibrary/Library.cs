using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Books.Sum(a => a.Price);
            }
        }
    }
}
