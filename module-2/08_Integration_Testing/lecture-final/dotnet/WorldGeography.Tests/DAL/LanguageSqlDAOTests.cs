using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldDAOTests
    {
        [TestMethod]
        [DataRow("Oceania", 0)]
        [DataRow("USA", 1)]
        public void GetLanguagesTest(string continent, int expectedNumberOfRows)
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);

            // Act
            IList<Language> languages = dao.GetLanguages(continent);
            
            // Assert
            Assert.AreEqual(expectedNumberOfRows, languages.Count);

        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange


            // Act


            // Assert


        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange



            // Act



            // Assert
            // SqlException is expected to be thrown
        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);

            // Act
            Language language = new Language();
            language.Name = "Test Language";
            language.CountryCode = "USA";

            int rowsBefore = GetRowCount("countrylanguage");
            bool isSuccessful = dao.RemoveLanguage(language);
            int rowsAfter = GetRowCount("countrylanguage");

            // Assert
            int countChange  = rowsAfter - rowsBefore;
            Assert.AreEqual(-1, countChange, "wrong number of rows after deletion");
            Assert.IsTrue(isSuccessful,"returned wrong bool value");
        }
    }
}
