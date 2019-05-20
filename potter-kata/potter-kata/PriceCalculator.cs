using System;
using System.Collections.Generic;
using System.Text;

namespace Potter_Kata
{
    public class PriceCalculator
    {
        private List<Book> books;
        private decimal bookPrice;

        public PriceCalculator()
        {
            books = new List<Book>();
            bookPrice = 8;
        }

        public decimal OrderPrice()
        {
            return books.Count * bookPrice;
        }

        public void addBook(Book book)
        {
            books.Add(book);
        }
    }
}
