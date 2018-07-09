using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace HillRaceSystem
{
    public class RacesDatabase
    {
        private string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\HillRaceDB.accdb;Persist Security Info=False";

        private OleDbConnection connection;
        private OleDbCommand command;

        /// <summary>
        /// Creates a database connection 
        /// and creates command objects 
        /// for the database
        /// </summary>
        public RacesDatabase()
        {
            //create connection and command objects
            connection = new OleDbConnection(ConnString);
            command = connection.CreateCommand();
        }

        /// <summary>
        ///  Retrieves all of the data from each column
        /// in the Races table located in the 
        /// connected database or throws exception
        /// then closes the connection to the 
        /// database
        /// </summary>
        /// <returns>Races</returns>
        public List<Races> getRacesData()
        {
            List<Races> Races = new List<Races>();
            try
            {
                command.CommandText = "Select * from Races";
                command.CommandType = CommandType.Text;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Races r = new Races();
                    r.RaceID = Convert.ToInt32(reader["RaceID"].ToString());
                    r.RaceName = reader["RaceName"].ToString();
                    r.RaceLocation = reader["RaceLocation"].ToString();
                    r.RaceDistance = reader["RaceDistance"].ToString();
                    r.RaceDate = reader["RaceDate"].ToString();
                    r.JuniorMaleTime = reader["JuniorMaleTime"].ToString();
                    r.JuniorFemaleTime = reader["JuniorFemaleTime"].ToString();
                    r.SeniorMaleTime = reader["SeniorMaleTime"].ToString();
                    r.SeniorFemaleTime = reader["SeniorFemaleTime"].ToString();
                    Races.Add(r);
                }
                return Races;
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
        /// the relevant columns in the
        /// connected access database
        /// and throws exception if 
        /// cannot be added
        /// </summary>
        internal void insertRaces(string strRaceName, string strRaceLocation, string strRaceDistance, string strRaceDate, string strJuniorMaleTime, string strJuniorFemaleTime, string strSeniorMaleTime, string strSeniorFemaleTime)
        {
            try
            {
                command.CommandText = "INSERT INTO Races (RaceName, RaceLocation, RaceDistance, RaceDate, JuniorMaleTime, JuniorFemaleTime, SeniorMaleTime, SeniorFemaleTime) VALUES ('" + strRaceName + "', '" + strRaceLocation + "', '" + strRaceDistance + "', '" + strRaceDate + "', '" + strJuniorMaleTime + "', '" + strJuniorFemaleTime + "', '" + strSeniorMaleTime + "', '" + strSeniorFemaleTime + "')";

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
                //closes the connection to the 
                //database if the connection is 
                //not null
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//end of method

        /// <summary>
        /// Sets up a string named strcmd which
        /// will allow the Races in the access database
        /// to be updated. It will then save the updated
        /// race record or throw an exception if it cannot
        /// </summary>
        /// <param name="r"></param>
        public void updateRaces(Races r)
        {
            try
            {
                string strcmd =
                 "UPDATE Races SET RaceName='" + r.RaceName +
                    "', RaceLocation ='" + r.RaceLocation + "', RaceDistance ='" + r.RaceDistance + "', RaceDate ='" + r.RaceDate + "', JuniorMaleTime ='" + r.JuniorMaleTime + "', JuniorFemaleTime ='" + r.JuniorFemaleTime + "', SeniorMaleTime ='" + r.SeniorMaleTime + "', SeniorFemaleTime ='" + r.SeniorFemaleTime + "' WHERE RaceID = " + r.RaceID;
                command.CommandText = strcmd;
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
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

        internal void deleteRaces(Races r)
        {

            try
            {
                command.CommandText = "DELETE FROM Races WHERE RaceID = " + r.RaceID;

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
