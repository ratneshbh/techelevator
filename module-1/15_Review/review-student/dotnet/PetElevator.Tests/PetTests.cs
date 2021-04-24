using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
   public class PetTests
    {
        [TestMethod]
        public void test_Vaccine_list()
        {
            Pet Meaw = new Pet(PetName:"Kitty", Species:"Feline");
            string[] myArray = { "hello", "rabbiesVacc", "CovidVacc" };
            for (int i = 0; i < myArray.Length; i++)
            {
                Meaw.Vaccinations.Add(myArray[i]); 
            }
            Console.WriteLine(Meaw.ListVaccination()); 
           Assert.IsTrue(Meaw.ListVaccination() =="hello, rabbiesVacc, CovidVacc"); 
            //Meaw.ListVaccination(); 


        }

    }
}
