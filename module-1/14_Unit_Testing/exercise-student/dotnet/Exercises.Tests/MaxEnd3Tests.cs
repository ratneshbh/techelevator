using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        MaxEnd3 maxEnd3Class = new MaxEnd3();
        [TestMethod]

        public void MaxEndTestConditionBasicCondition1()
        {
            int[] param = { 1, 2, 3 };
            int[] actual = maxEnd3Class.MakeArray(param);
            int[] expected = { 3, 3, 3 };
            Assert.AreEqual(expected, maxEnd3Class.MakeArray(param));
        }
            public void MaxEndTestConditionBasicCondition2()
        { 
            //CollectionAssert.AreEqual(expected, actual,          //not sure
            int[] param = { 11, 5, 9 };
            int[] actual = maxEnd3Class.MakeArray(param);
            int[] expected = { 11, 11, 11 };
            Assert.AreEqual(expected, maxEnd3Class.MakeArray(param));
        }
        public void MaxEndTestConditionBasicCondition3()
        {
            int[] param = { 2, 11, 3 };
            int[] actual = maxEnd3Class.MakeArray(param);
            int[] expected = { 3, 3, 3 };
            Assert.AreEqual(expected, maxEnd3Class.MakeArray(param));
        }


        //if nums[0] > nums[nums.Length - 1] then nums[0]
        // else nums[nums.Length - 1] is false 

        //issue - how to instantiate new array for step 1

        //int[] theArray = { 1, 3, 5, 7, 9 };
        //PrintArray(theArray);
    }
}
