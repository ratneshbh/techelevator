using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private readonly string connectionString;

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public void AddCity(City city)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO city (name, countrycode, district, population) VALUES (@name, @countrycode, @district, @population);SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@name", city.Name);
                    cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
                    cmd.Parameters.AddWithValue("@district", city.District);
                    cmd.Parameters.AddWithValue("@population", city.Population);

                    int rowsId = Convert.ToInt32(cmd.ExecuteScalar());
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            throw new NotImplementedException();
        }
    }
}
