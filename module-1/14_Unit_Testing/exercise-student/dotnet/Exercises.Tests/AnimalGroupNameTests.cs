using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting; //add to each one
namespace Exercises.Tests
{
    [TestClass]  //add this to each one
 
    public class AnimalGroupNameTests
    {
        [TestMethod]  //add this to each one 
        public void MakeAnimalGroupNameTest()  //don't forget the body of the method i.e. public void MAGNTest(){} - test code goes inside
        {
            AnimalGroupName animalGroupName = new AnimalGroupName(); //instantiate the class being tested 
            string actual = animalGroupName.GetHerd("giraffe");
            Assert.AreEqual("Tower", actual);
        }

        //{
           // AnimalGroupName animalGroupName2 = new AnimalGroupName(); //instantiate the class being tested 
           // string actual = animalGroupName2.GetHerd("giraffe");
           // Assert.AreEqual("Tower", actual);
        }



}

