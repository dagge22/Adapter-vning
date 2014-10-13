using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib;
using ProductLib;

namespace ProductTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatProductValuesAreCorrect()
        {
            //Arrange
            Product product = new Product();
            int expectedPrice = 10;
            string expectedBarcode = "barcode";
            string expectedTitle = "title";
            //Act
            decimal actualPrice = product.Price;

            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
