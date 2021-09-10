using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {

            //--Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "brobva@dda.com",
                FirstName = "Bram",
                LastName = "Joe",
                AddressList = null
            };
            changedItems.Add(customer);
            var product = new Product(2) { ProductName = "Rice", ProductDescription = "melted Rice", CurrentPrice = 6M };
            changedItems.Add(product);

            //--Act
            LoggingService.WriteToFile(changedItems);

            //--Assert
        
        }
    }
}
