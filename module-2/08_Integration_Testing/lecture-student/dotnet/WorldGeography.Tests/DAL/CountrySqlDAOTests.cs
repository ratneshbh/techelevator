using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CountrySqlDAOTests : WorldDAOTests
    {
        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            //integration test tests the whole class plus the database connection
            // Arrange
            //testing a CountrySQLDAO; DAO = "data access object"

            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);



            // Act - test GetCountries method 
            IList<Country> countries = dao.GetCountries();

            // Assert - (
            Assert.AreEqual(1, countries.Count);
        }

        [TestMethod]
        [DataRow("North America", 1)]  //creating a datarow with these objects, can think of it as a method
        [DataRow("Oceania", 0)]
        public void GetCountriesByContinent_Should_ReturnCorrectNumberOfCountries(string continent, int expectedRows)
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);

            // Act
            IList<Country> countries = dao.GetCountries(continent);

            // Assert
            Assert.AreEqual(expectedRows, countries.Count);
        }
    }
}
