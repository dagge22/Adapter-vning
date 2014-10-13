using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;

namespace ProductTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Product product = new Product();
            var actualPrice = product.Price;
            //Act
            

            //Assert

        }
    }
}
