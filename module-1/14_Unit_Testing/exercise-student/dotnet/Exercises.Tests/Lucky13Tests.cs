using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        Lucky13 arrayTest = new Lucky13();  //variable arrayTest equals class Lucky13, which we are testing 
        [TestMethod]
        public void Lucky13Test()
        {

            int[] Lucky13 = new int[] { 0, 2, 4 };  //new array called Lucky13 including 0,2,4
            bool actual = arrayTest.GetLucky(Lucky13); // passing in Lucky13, the new array, into method GetLucky 
            Assert.AreEqual(true, actual);


            




        }
    }
}
