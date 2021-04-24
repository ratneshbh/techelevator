using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestableClasses.Classes.Tests
{
    [TestClass]
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        [TestMethod]
        public void MakeAbbaTest()
        {
            /*
             Arrange
             Act
             Assert
             */

            //arrange
            StringExercises stringExercises = new StringExercises();
            //act
            string actual = stringExercises.MakeAbba("Hi", "Bye");
            //assert
            Assert.AreEqual("HiByeByeHi", actual);

            string actual2 = stringExercises.MakeAbba("A", "B");
            //assert
            Assert.AreEqual("ABBA", actual2);

        }

        [TestMethod]
        public void MakeAbbaWithOneCharacterNull()
        {
            //arrange
            StringExercises stringExercises = new StringExercises();
            //act
            string actual = stringExercises.MakeAbba("A", null);
            //assert
            Assert.AreEqual("AA", actual,"you're doing great, keep trying");
        }

        [TestMethod]
        public void FirstTwoTest()
        {
            //arrange
            StringExercises stringExercises = new StringExercises();
            
            string actual = stringExercises.FirstTwo("Hello");

            Assert.AreEqual("He", actual);

        }

        [TestMethod]
        public void FirstTwoTestShorterString()
        {

            StringExercises stringExercises = new StringExercises();

            string actual = stringExercises.FirstTwo("a");

            Assert.AreEqual("a", actual);

        }
    }
}