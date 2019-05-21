using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Potter_Kata;

namespace Potter_Kata_Test
{
    [TestClass]
    public class PriceCalculator_Tests
    {
        private PriceCalculator priceCalc;

        [TestInitialize]
        public void Setup()
        {
            priceCalc = new PriceCalculator();
        }

        [TestMethod]
        public void Calculates_Price_of_one_book()
        {
            priceCalc.addBook(new Book() { bookNum = 1 });

            Assert.AreEqual(8M, priceCalc.OrderPrice());
        }

        [TestMethod]
        public void No_discount_for_two_copies()
        {
            priceCalc.addBook(new Book() { bookNum = 1 });
            priceCalc.addBook(new Book() { bookNum = 1 });

            Assert.AreEqual(16M, priceCalc.OrderPrice());
        }

        [TestMethod]
        public void Five_percent_off_for_two_different_books()
        {
            priceCalc.addBook(new Book() { bookNum = 1 });
            priceCalc.addBook(new Book() { bookNum = 2 });

            Assert.AreEqual(15.2M, priceCalc.OrderPrice());
        }

        [TestMethod]
        public void Ten_percent_off_for_three_different_books()
        {
            priceCalc.addBook(new Book() { bookNum = 1 });
            priceCalc.addBook(new Book() { bookNum = 2 });
            priceCalc.addBook(new Book() { bookNum = 3 });

            Assert.AreEqual(21.6M, priceCalc.OrderPrice());
        }

        [TestMethod]
        public void Two_sets_of_4_is_better_than_a_set_of_5_and_3()
        {
            priceCalc.addBook(new Book(1));
            priceCalc.addBook(new Book(1));
            priceCalc.addBook(new Book(2));
            priceCalc.addBook(new Book(2));
            priceCalc.addBook(new Book(3));
            priceCalc.addBook(new Book(3));
            priceCalc.addBook(new Book(4));
            priceCalc.addBook(new Book(5));

            Assert.AreEqual(51.2M, priceCalc.OrderPrice());
        }
    }
}
