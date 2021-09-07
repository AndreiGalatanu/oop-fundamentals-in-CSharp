using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValis()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
            };
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer() { FirstName = "Bilbo" };
            Customer.InstanceCount += 1;
            var c2 = new Customer() { FirstName = "Frodo" };
            Customer.InstanceCount += 1;
            var c3 = new Customer() { FirstName = "Rosie" };
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }


        [TestMethod]
        public void ValidationValid()
        {
            //-- Arrange
            var c = new Customer() { LastName = "Bagg", EmailAddress = "dwds@ddd.com" };

            var expected = true;
            //-- Act
            var actual = c.Validate();
            //-- Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void ValidationNotValid()
        {
            //-- Arrange
            var c = new Customer() { FirstName="dd", EmailAddress = "dwds@ddd.com" };

            var expected = false;

            //-- Act
            var actual = c.Validate();
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
