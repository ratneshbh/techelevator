using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void FrontTimesTestForProvidedConditions() 
        {
            
            FrontTimes frontTimes = new FrontTimes(); 
            string actual = frontTimes.GenerateString("Chocolate", 2);
            Assert.AreEqual("ChoCho", actual); 

            FrontTimes frontTimes2 = new FrontTimes(); 
            string actual2 = frontTimes2.GenerateString("Chocolate", 3);
            Assert.AreEqual("ChoChoCho", actual2); 

            FrontTimes frontTimes3 = new FrontTimes(); 
            string actual3 = frontTimes3.GenerateString("Abc", 3);
            Assert.AreEqual("AbcAbcAbc", actual3); 


        }
        [TestMethod]
        public void FrontTimesTestForEmptyString()
        {
            FrontTimes frontTimes3 = new FrontTimes();
            string actual3 = frontTimes3.GenerateString("", 3);
            Assert.AreEqual("", actual3);   

            // empty string 
        }
        public void FrontTimesTestForNullString()
        {
            FrontTimes frontTimes3 = new FrontTimes();
            string actual3 = frontTimes3.GenerateString(null, 3);
            Assert.AreEqual("AbcAbcAbc", actual3);   //is length of empty string 0 when length > 1
        }



        }
}
