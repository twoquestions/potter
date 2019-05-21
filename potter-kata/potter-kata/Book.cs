using System;
using System.Collections.Generic;
using System.Text;

namespace Potter_Kata
{
    public class Book
    {
        public Book() { }
        public Book(int bookNum)
        {
            this.bookNum = bookNum;
        }
        public int bookNum { get; set; }
    }
}
