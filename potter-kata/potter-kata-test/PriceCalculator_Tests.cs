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
        [TestMethod]
        public void Calculates_Price_of_one_book()
        {
            var priceCalc = new PriceCalculator();

            priceCalc.addBook(new Book() { bookNum = 1 });

            Assert.AreEqual(8, priceCalc.OrderPrice);
        }
    }
}
