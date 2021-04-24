using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestableClasses.Classes.Tests
{
    [TestClass()]
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
        public void MakeAbbaWithOneCharacter()
        {
            /*
             Arrange
             Act
             Assert 
             */
            //arrange
            StringExercises stringExercises = new StringExercises(); //new instance of that class that I can call methods on with constructor
            //act
            string actual = stringExercises.MakeAbba("A", "B");
            //assert
            Assert.AreEqual("ABBA", actual2);
        }

        [TestMethod]
        public void FirstTwoTest()
        {
            //arrange
            StringExercises stringExercises = new StringExercises();

            stringExercises.FirstTwo("Hello");

            Assert.AreEqual("He", actual); //what did we expect? "He". What did the code do? Actual
        }

        [TestMethod]
        public void FirstTwoTestShorterString()   //this tests whether the condition is true
        {
            //arrange
            StringExercises stringExercises = new StringExercises();

            string actual = stringExercises.FirstTwo("Hello");

            Assert.AreEqual("a", actual);

        }


    }
}