using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            //--Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            var handler = new StringHandler();

            //--Act
            var actual = handler.InsertSpace(source);

            //--Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpaceWithExisitingWhiteSpace()
        {
            //--Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var handler = new StringHandler();

            //--Act
            var actual = handler.InsertSpace(source);

            //--Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
