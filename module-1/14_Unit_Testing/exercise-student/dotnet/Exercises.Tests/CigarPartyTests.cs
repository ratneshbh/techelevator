using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        public void CigarPartyTest() 
        {
            CigarParty cigarParty = new CigarParty();
            bool actual = cigarParty.HaveParty(30, false);
            Assert.AreEqual(false, actual);

        
        }
    }
    /* haveParty(30, false) → false    
       haveParty(50, false) → true
       haveParty(70, true) → true
     
     */
}
