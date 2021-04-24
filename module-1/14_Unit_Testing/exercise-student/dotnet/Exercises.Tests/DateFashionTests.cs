using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
        public void DateFashionTestToGetTable()  //rename this DateFashionTestForGettingATable
        {
            //TestToGetTable
            //TestToNotGetTable
            //TestToMaybeGetTable

            DateFashion dateFashion = new DateFashion();  //arrange
            int actual = dateFashion.GetATable(5, 10);    //act
            Assert.AreEqual(2, actual);                   //Assert
        }
        public void DateFashionTestToNotGetTable()
        {
            DateFashion dateFashion1 = new DateFashion();
            int actual2 = dateFashion1.GetATable(5, 2);
            Assert.AreEqual(0, actual2);
        }
        public void DateFashionTestToMaybeGetTable()
        {
            DateFashion dateFashion2 = new DateFashion();
            int actual3 = dateFashion2.GetATable(5, 5);
            Assert.AreEqual(1, actual3);
        }
        public void DateFashionTestWhenZero()
        { 
        DateFashion dateFashion0 = new DateFashion();   //edge case for int is 0
        int actual0 = dateFashion0.GetATable(0, 0);
        Assert.AreEqual(1, actual0);
            }
        public void DateFashionTestWhenNegative()
        { 
            DateFashion dateFashionNegative = new DateFashion();   //edge case for int is negative numbers
            int actualNegative = dateFashionNegative.GetATable(-1, -1);
            Assert.AreEqual(0, actualNegative);
        }
        public void DateFashionTestWithOneValueZero()
        {
            DateFashion dateFashion4 = new DateFashion();
            int actual4 = dateFashion4.GetATable(5, 0); 
            Assert.AreEqual(0, actual4);
        }

    }
}
