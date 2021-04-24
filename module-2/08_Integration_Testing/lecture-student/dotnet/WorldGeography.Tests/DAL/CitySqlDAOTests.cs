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
        //[DataRow("ddd", )]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedvaluee)
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);
            int rowsBefore = GetRowCount("city");
            //public void AddCity(City city)
            
            // Act
            

            // public IList<City> GetCitiesByCountryCode(string countryCode)
            //IList<City> cities = dao.GetCitiesByCountryCode("USA");

            // Assert
            //Assert.AreEqual(expectedvaluee, cities.Count);
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

            // Act
            dao.AddCity(cincinnati);
            int RowsAfter = GetRowCount("city");

            // Assert
            //int result = rowsAfter - rowsBefore;
                //Assert.AreEqual(1, result);


        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);

            City city = new City();
            city.Name = "Cincinnati";
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
