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
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);

            // Act
            IList<Country> countries = dao.GetCountries();

            // Assert
            Assert.AreEqual(1, countries.Count);

        }

        [DataTestMethod]
        [DataRow("North America", 1)]
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

        [TestMethod]
        public void GetCountryHasCorrectValues()
        {

            //arrange
            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);

            //act
            IList<Country> countries = dao.GetCountries("North America");

            string expectedRegion = "Region";
            string actualRegion = "";
            foreach (Country country in countries)
            {

                if (country.Code == "USA") {

                    actualRegion = country.Region;
                }
            }

            //ASSERT
            Assert.AreEqual(expectedRegion, actualRegion);
        }
    }
}
