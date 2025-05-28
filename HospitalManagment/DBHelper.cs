using MySql.Data.MySqlClient;

namespace HospitalManagment
{
    public static class DBHelper
    {
        // Connection string for MySQL database
        private static readonly string connectionString =
            "server=127.0.0.1;user=root;password=C0ventryCUC;database=example;";

        /// <summary>
        /// Returns a new MySqlConnection object using the configured connection string.
        /// Caller is responsible for opening and closing the connection.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
