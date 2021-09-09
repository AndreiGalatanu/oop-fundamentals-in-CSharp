using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProduct()
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

        [TestMethod]

        public void SaveTestValid()
        {
            //--Arrange
            var prodRep = new ProductRepository();
            var updatedProd = new Product(2)
            {
                CurrentPrice = 18m,
                ProductDescription = "Assorted size of 4 brightsdad",
                ProductName = "Sunflowers",
                HasChages = true
            };
            //--Act
            var actual = prodRep.Save(updatedProd);
            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]

        public void SaveTestNotValid()
        {
            //--Arrange
            var prodRep = new ProductRepository();
            var updatedProd = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted size of 4 brightsdad",
                ProductName = "Sunflowers",
                HasChages = true
            };
            //--Act
            var actual = prodRep.Save(updatedProd);
            //--Assert
            Assert.AreEqual(false, actual);
        }



    }


}

