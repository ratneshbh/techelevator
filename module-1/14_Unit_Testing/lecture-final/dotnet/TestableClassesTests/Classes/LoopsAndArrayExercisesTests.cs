using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object
        LoopsAndArrayExercises loopClass = new LoopsAndArrayExercises();

        [TestMethod]
        public void TestMiddleWay()
        {
            //middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
            int[] param1 = {1,2,3 };
            int[] param2 = {4,5,6};
            int[] actual = loopClass.MiddleWay(param1, param2);

            int[] expected = { 2, 5 };

            CollectionAssert.AreEqual(expected, actual, "youre sooo close, keep going");

        }
    }
}