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
            //Arrange
            //SomeExternalVendorProduct product = new SomeExternalVendorProduct();
            //SomeExternalVendorProductAdapter product = new SomeExternalVendorProductAdapter();
            int expectedPrice = 10;
            string expectedEANCode = "EANCode";
            string expectedDescription = "Description";
            //Act
            //int actualPrice = product.IUnitPrice;
            //string actualEANCode = product.EANCode;
            //string actualDescription = product.Description;

            //Assert
            //Assert.AreEqual(expectedPrice, actualPrice);
            //Assert.AreEqual(expectedEANCode, actualEANCode);
            //Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}
