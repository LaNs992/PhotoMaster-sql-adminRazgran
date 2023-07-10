using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class DataBase
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=YOBIC;Initial Catalog=BD_PhotoMaster;
Integrated Security=True");


        public void openConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void closeConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
