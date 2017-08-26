using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Common
{
    public static class Database
    {
        public static MySqlConnection connection;
        public static string server;
        public static string database;
        public static string uid;
        public static string password;

        public static bool OpenConnection()
        {
            server = "10.0.7.4";
            database = "gtavmp";
            uid = "gtavmp";
            password = "chu9Uswu!";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Log.Instance.Error("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Log.Instance.Error("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Log.Instance.Error(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// UpdatePlayerLocation
        /// </summary>
        public static void UpdatePlayerLocation(string LocationAuthor, string LocationX, string LocationY, string LocationZ)
        {
            string query = $"INSERT INTO `location` (`LocationId`, `LocationAuthor`, `LocationX`, `LocationY`, `LocationZ`) VALUES(NULL, '{LocationAuthor}', '{LocationX}', '{LocationY}', '{LocationZ}')";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQueryAsync();

                //close connection
                CloseConnection();
            }
        }

    }
}
