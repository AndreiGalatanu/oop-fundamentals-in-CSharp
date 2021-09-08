using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepsitoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customreRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "brobva@dda.com",
                FirstName = "Bram",
                LastName = "Joe"
            };
            //-- Act
            var actual = customreRepository.Retrieve(1);
            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
        [TestMethod]

        public void RetrievieExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "brobva@dda.com",
                FirstName = "Bram",
                LastName = "Joe",
                AddressList = new System.Collections.Generic.List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bag Endsd 2",
                        City = "Hobitton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "133242"
                    },

                    new Address()
                    {

                        AddressType = 2,
                        StreetLine1 = "Green Smile",
                        StreetLine2 = "Bag Slug",
                        City = "Worky",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "321242"

                    }
                }
            };
            //-- Act
            var actual = customerRepository.Retrieve(1);
            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    };
}



