using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WPfAccessExample
{
    /// <summary>
    /// broker between database and business model
    /// </summary>
    public class DBBroker
    {
        private string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\StudentDB.accdb;Persist Security Info=False";

        private OleDbConnection conn;
        private OleDbCommand cmd;

        public DBBroker()
        {
            //create connection and command objects
            conn = new OleDbConnection(ConnString);
            cmd = conn.CreateCommand();
        }

        

        /// <summary>
        /// Select query returns a list of Students from database
        /// </summary>
        /// <returns>List of students </returns>
        public List<Student> getData()
        {
            List<Student> students = new List<Student>();
            try
            {
                cmd.CommandText = "Select * from Students";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student();
                    s.ID = Convert.ToInt32(reader["ID"].ToString());
                    s.FirstName = reader["FirstName"].ToString();
                    s.LastName = reader["LastName"].ToString();
                    students.Add(s);
                }
                return students;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (conn!=null)
                {
                    conn.Close();
                }
            }
            
        }

        public void update (Student s)
        {
            try
            {
                cmd.CommandText = "UPDATE Students SET FirstName='" + s.FirstName +
                    "', LastName ='"+s.LastName+"' WHERE ID = " + s.ID;
                    
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (conn != null)
                {
                    conn.Close();
                }
            }
            
        }


        internal void delete(Student s)
        {

            try
            {
                cmd.CommandText = "DELETE FROM Students WHERE ID = " + s.ID;

                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        internal void insert(string strFirst, string strLast)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Students (FirstName,LastName) VALUES ('" + strFirst + "', '" + strLast + "')";

                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                throw;
            }
            finally
            {
                //make sure connection is closed
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
