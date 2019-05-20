using System;
using System.Collections.Generic;
using System.Text;

namespace Potter_Kata
{
    public class PriceCalculator
    {
        private List<Book> books;

        public PriceCalculator()
        {
            books = new List<Book>();
        }

        public decimal OrderPrice
        {
            get
            {
                return books.Count * 8;
            }
        }

        public void addBook(Book book)
        {
            books.Add(book);
        }
    }
}
