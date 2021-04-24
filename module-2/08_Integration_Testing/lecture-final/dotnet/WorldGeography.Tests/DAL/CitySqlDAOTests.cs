using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CitySqlDAOTests : WorldDAOTests
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("BEL", 0)]
        [DataRow("ddd", 0)]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedValue)
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);

            // Act

            IList<City> cities = dao.GetCitiesByCountryCode(countryCode);
            // Assert

            Assert.AreEqual(expectedValue, cities.Count);

        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);

            City cincinnati = new City();
            cincinnati.Name = "Cincinnati";
            cincinnati.District = "OH";
            cincinnati.CountryCode = "USA";
            cincinnati.Population = 1;

            int rowsBefore = GetRowCount("city");

            // Act
            dao.AddCity(cincinnati);
            int rowsAfter = GetRowCount("city");
            // Assert

            int result = rowsAfter - rowsBefore;
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);

            City city = new City();
            city.Name = "Bad City";
            city.District = "OH";
            city.CountryCode = "CHN";
            city.Population = 1999;

            // Act

            dao.AddCity(city);

            // Assert
            // SqlException is expected to be thrown
        }
    }
}
