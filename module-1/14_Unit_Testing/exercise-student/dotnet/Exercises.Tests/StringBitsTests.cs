using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        public void StringBitsTest()
        {
            //Assert
            StringBits stringBits = new StringBits();
            //Arrange
            string s = stringBits.GetBits("Hello");
            //Act
            Assert.AreEqual("Hlo", s);

            //Assert
            StringBits stringBits2 = new StringBits();
            //Arrange
            string s2 = stringBits2.GetBits("Hi");
            //Act
            Assert.AreEqual("H", s2);

            //Assert
            StringBits stringBits3 = new StringBits();
            //Arrange
            string s3 = stringBits3.GetBits("Heeololeo");
            //Act
            Assert.AreEqual("Hi", s3);
        }
        public void StringBitsTestForEmptyString()
        {
            StringBits stringBitsEmptyString = new StringBits();
            //Arrange
            string sEmptyString = stringBitsEmptyString.GetBits("");   //edge case empty string
            //Act
            Assert.AreEqual("", sEmptyString);
        }
        public void StringBitsTestForNull()
        {
            StringBits stringBitsNull = new StringBits();
            //Arrange
            string sEmptyString = stringBitsNull.GetBits(null);   //edge case null returns empty string
            //Act
            Assert.AreEqual("", sEmptyString);
        }
    }
}
