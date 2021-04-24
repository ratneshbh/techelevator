using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        public void Less20Test()
        {
            Less20 less20 = new Less20(); 
            bool actual = less20.IsLessThanMultipleOf20(18);
            Assert.AreEqual(true, actual); 
             
            Less20 less20two = new Less20();
            bool actual2 = less20two.IsLessThanMultipleOf20(19);
            Assert.AreEqual(true, actual2); 

            Less20 less20three = new Less20(); 
            bool actual3 = less20three.IsLessThanMultipleOf20(20);
            Assert.AreEqual(false, actual3);

          

        }


    }
}
