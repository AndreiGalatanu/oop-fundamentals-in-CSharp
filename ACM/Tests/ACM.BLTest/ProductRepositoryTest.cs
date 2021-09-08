using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void TestValid()
        {
            //-- Arrange

            var productRepo = new ProductRepository();
            var expecterd = new Product
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright ",
                CurrentPrice = 15.23M
            };
            //-- Act
            var actual = productRepo.Retrive(2);
            //--Append

            Assert.AreEqual(expecterd.ProductName, actual.ProductName);

        }
    }
}
