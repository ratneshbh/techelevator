using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private readonly string connectionString;

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public IList<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();

            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT code, name, continent, surfacearea, population, governmentform FROM country;", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        countries.Add(countryFromReader(reader));
                    }
                }
            } catch (Exception ex)
            {
                //TODO dont couple with console
                Console.WriteLine(ex.Message);
            } 

            return countries;
        }

        //continent provided from user typing
        public IList<Country> GetCountries(string continent)
        {
            List<Country> countries = new List<Country>();

            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT code, name, continent, surfacearea, population, governmentform FROM country WHERE continent = @continent;";                   
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@continent", continent);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        countries.Add(countryFromReader(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO dont couple with console
                Console.WriteLine(ex.Message);
            }

            return countries;
        }

        private Country countryFromReader(SqlDataReader reader)
        {
            Country country = new Country();

            //convert allows for null values
            country.Code = Convert.ToString(reader["code"]);
            country.Name = Convert.ToString(reader["name"]);
            country.Continent = Convert.ToString(reader["continent"]);
            country.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
            country.Population = Convert.ToInt32(reader["population"]);
            country.GovernmentForm = Convert.ToString(reader["governmentform"]);

            return country;

        }

    }
}

