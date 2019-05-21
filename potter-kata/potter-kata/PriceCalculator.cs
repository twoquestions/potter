using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Potter_Kata
{
    public class PriceCalculator
    {
        private List<Book> books = new List<Book>();

        private decimal bookPrice = 8;

        private decimal set2discount = 0.95M;
        private decimal set3discount = 0.9M;
        private decimal set4discount = 0.8M;
        private decimal set5discount = 0.75M;

        /// <summary>
        /// This function takes the books in the order and 
        /// sorts them into stacks, then takes the "top" book
        /// from the stacks, starting with the largest possible 
        /// set and working down to smaller sets.
        /// </summary>
        /// <returns></returns>
        public decimal OrderPrice()
        {
            decimal finalPrice = 0M;
            var bookStacks = new List<int>() {
                books.Where(x => x.bookNum == 1).Count(),
                books.Where(x => x.bookNum == 2).Count(),
                books.Where(x => x.bookNum == 3).Count(),
                books.Where(x => x.bookNum == 4).Count(),
                books.Where(x => x.bookNum == 5).Count()
            };

            //While there are books not in a set...
            while(bookStacks.Any(x => x > 0))
            {
                switch(bookStacks.Where(x => x > 0).Count())
                {
                    case 5:
                        finalPrice += (bookPrice * 5) * set5discount;
                        break;
                    case 4:
                        finalPrice += (bookPrice * 4) * set4discount;
                        break;
                    case 3:
                        finalPrice += (bookPrice * 3) * set3discount;
                        break;
                    case 2:
                        finalPrice += (bookPrice * 2) * set2discount;
                        break;
                    case 1:
                        finalPrice += bookPrice;
                        break;
                }

                //Decrement everything greater than 1
                bookStacks = bookStacks.Select(x =>
                {
                    if (x > 0) { return x - 1; }
                    else { return x; }
                }).ToList();
            }

            return finalPrice;
        }


        public void addBook(Book book)
        {
            books.Add(book);
        }
    }
}
