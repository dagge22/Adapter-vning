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
            decimal actualPrice = product.IUnitPrice;
            string actualBarcode = product.IBarcode;
            string actualTitle = product.ITitle;

            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
            Assert.AreEqual(expectedBarcode, actualBarcode);
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [TestMethod]
        public void TestSomeExternalVendorProductAdapter()
        {
            
        }
    }
}
