using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace GamesOrderApp
{
    public class DatabaseBroker
    {
        private string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\GameOrderSystem.accdb;Persist Security Info=False";

        private OleDbConnection connection;
        private OleDbCommand command;

        public DatabaseBroker()
        {
            //create connection and command objects
            connection = new OleDbConnection(ConnString);
            command = connection.CreateCommand();
        }

        public List<Customer> getData()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                command.CommandText = "Select * from Customers";
                command.CommandType = CommandType.Text;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.CustomerID = Convert.ToInt32(reader["CustomerID"].ToString());
                    c.FirstName = reader["FirstName"].ToString();
                    c.LastName = reader["LastName"].ToString();
                    c.HouseNumber = Convert.ToInt32(reader["HouseNumber"].ToString());
                    c.Street = reader["Street"].ToString();
                    c.Town = reader["Town"].ToString();
                    c.Postcode = reader["Postcode"].ToString();
                    c.Age = Convert.ToInt32(reader["Age"].ToString());
                    customers.Add(c);
                }
                return customers;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Game> getGameData()
        {
            List<Game> Games = new List<Game>();
            try
            {
                command.CommandText = "Select * from Games";
                command.CommandType = CommandType.Text;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Game g = new Game();
                    g.GameID = Convert.ToInt32(reader["GameID"].ToString());
                    g.Name = reader["Name"].ToString();
                    g.Genre = reader["Genre"].ToString();
                    g.Description = reader["Description"].ToString();
                    g.Price = Convert.ToDecimal(reader["Price"].ToString());
                    g.AgeRating = Convert.ToInt32(reader["AgeRating"].ToString());
                    Games.Add(g);
                }
                return Games;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Inserts each parameter into
        /// the relevant tables in the
        /// connected access database
        /// and throws exception if 
        /// cannot be added
        /// </summary>
        /// <param name="strFirst">Inserts customers first name</param>
        /// <param name="strLast">Inerts customers surname</param>
        /// <param name="strNumber">Inserts customers house number</param>
        /// <param name="strStreet">Inserts customers street name</param>
        /// <param name="strTown">Inserts customers town name</param>
        /// <param name="strPostcode">Inserts customers postcode</param>
        /// <param name="strAge">Inserts customers age</param>
        internal void insertCustomer(string strFirst, string strLast, string strNumber, string strStreet, string strTown, string strPostcode, string strAge)
        {
            try
            {
                command.CommandText = "INSERT INTO Customers (FirstName,LastName,HouseNumber,Street,Town,Postcode,Age) VALUES ('" + strFirst + "', '" + strLast + "', '" + strNumber + "', '" + strStreet + "', '" + strTown + "', '" + strPostcode + "', '" + strAge + "')";

                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//end of method

        /// <summary>
        /// Inserts each parameter into
        /// the relevant tables in the
        /// connected access database
        /// and throws exception if 
        /// cannot be added
        /// </summary>
        /// <param name="strName">Inserts game name</param>
        /// <param name="strGenre">Inserts genre of game</param>
        /// <param name="strDesc">Inserts a description of the game</param>
        /// <param name="strPrice">Inserts the price of the game</param>
        /// <param name="strAgeRating">Inserts the age rating of the game</param>
        internal void insertGame(string strName, string strGenre, string strDesc, string strPrice, string strAgeRating)
        {
            try
            {
                command.CommandText = "INSERT INTO Games (Name,Genre,Description,Price,AgeRating) VALUES ('" + strName + "', '" + strGenre + "', '" + strDesc + "', '" + strPrice + "', '" + strAgeRating + "')";

                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//end of method

    }
}

