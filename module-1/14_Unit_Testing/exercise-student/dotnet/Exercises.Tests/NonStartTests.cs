using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        public void NonStartTest()
        {
            NonStart nonStart = new NonStart();
            string ns = nonStart.GetPartialString("Hello", "There");
            Assert.AreEqual("ellohere", ns);

            NonStart nonStart2 = new NonStart();
            string ns2 = nonStart2.GetPartialString("java", "code");
            Assert.AreEqual("avaode", ns2);

            NonStart nonStart3 = new NonStart();
            string ns3 = nonStart3.GetPartialString("shotl", "java");
            Assert.AreEqual("hotlava", ns3);
        }
        [TestMethod]
        public void NonStartTestForEdgeCaseEmptyString()
        {  //empty string edge case
            NonStart nonStartEmptyString = new NonStart();
            string nsEmptyString = nonStartEmptyString.GetPartialString("", "");
            Assert.AreEqual(0, nsEmptyString);
        }
        [TestMethod]
        public void NonStartTestForEdgeCaseWhenOneParamIsNull()
        {  //one value is null edge case
            NonStart nonStartNull = new NonStart();
            string nsNull = nonStartNull.GetPartialString(null, "abc");
            Assert.AreEqual(0 + "bc", nsNull);
        }


    }
}
