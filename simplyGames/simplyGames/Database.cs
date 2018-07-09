using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace SimplyGames
{
    public class Database
    {
        private string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\SimplyGamesDatabase.accdb;Persist Security Info=False";

        private OleDbConnection connection;
        private OleDbCommand command;

        /// <summary>
        /// Creates a database connection 
        /// and creates command objects 
        /// for the database
        /// </summary>
        public Database()
        {
            //create connection and command objects
            connection = new OleDbConnection(ConnString);
            command = connection.CreateCommand();
        }

        /// <summary>
        ///  Retrieves all of the data from each column
        /// in the Games table located in the 
        /// connected database or throws exception
        /// then closes the connection to the 
        /// database
        /// </summary>
        /// <returns>Games</returns>
        public List<Game> getGameData()
        {
            List<Game> Games = new List<Game>();
            try
            {
                command.CommandText = "Select * from Game";
                command.CommandType = CommandType.Text;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Game g = new Game();
                    g.GameID = Convert.ToInt32(reader["GameID"].ToString());
                    g.Name = reader["Name"].ToString();
                    g.Platform = reader["Platform"].ToString();
                    g.Genre = reader["Genre"].ToString();
                    g.Price = Convert.ToDecimal(reader["Price"].ToString());
                    g.AgeClassification = Convert.ToInt32(reader["AgeClassification"].ToString());
                    g.Description = reader["Description"].ToString();
                    g.Rating = Convert.ToInt32(reader["Rating"].ToString());
                    g.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                    g.ProductCode = reader["ProductCode"].ToString();
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
        }//end of method

        /// <summary>
        /// Inserts each parameter into
        /// the relevant tables in the
        /// connected access database
        /// and throws exception if 
        /// cannot be added
        /// </summary>
        /// <param name="strName">Inserts name of game</param>
        /// <param name="strPlatform">Inserts platform game belongs to</param>
        /// <param name="strGenre">Inserts genre of the game</param>
        /// <param name="strPrice">Inserts the price of the game</param>
        /// <param name="strAge">Inserts the age classification for the game</param>
        /// <param name="strDesc">Inserts description of the game</param>
        /// <param name="strRating">Inserts game rating</param>
        /// <param name="strQuantity">Inserts quantity of game available</param>
        /// <param name="strProductCode">Inserts product code for the game</param>
        internal void insertGame(string strName, string strPlatform, string strGenre, string strPrice, string strAge, string strDesc, string strRating, string strQuantity, string strProductCode)
        {
            try
            {
                command.CommandText = "INSERT INTO Game (Name, Platform, Genre, Price, AgeClassification, Description, Rating, Quantity, ProductCode) VALUES ('" + strName + "' '" + strPlatform + "', '" + strGenre + "', '" + strPrice + "', '" + strAge + "', '" + strDesc + "', '" + strRating + "', '" + strQuantity + "', '" + strProductCode + "')";

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
                //closes the connection to the 
                //database if the connection is 
                //not null
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//end of method

        public void updateGame(Game g)
        {
            try
            {
                command.CommandText = "UPDATE Game SET Name='" + g.Name +
                    "', Platform ='" + g.Platform + "', Genre ='" + g.Genre + "', Price ='" + g.Price + "', AgeClassification ='" + g.AgeClassification + "', Description ='" + g.Description + "', Rating ='" + g.Rating + "', Quantity ='" + g.Quantity + "', ProductCode ='" + g.ProductCode + "' WHERE GameID = " + g.GameID;

                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();

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

        }//end of method

        internal void deleteGame(Game g)
        {

            try
            {
                command.CommandText = "DELETE FROM Game WHERE GameID = " + g.GameID;

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
