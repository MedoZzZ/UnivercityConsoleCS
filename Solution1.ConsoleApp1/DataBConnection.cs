using Npgsql;
namespace Solution1.ConsoleApp1
{
    internal class DataBConnection
    {
        public static NpgsqlConnection GetConnection()
        {
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=school";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            return connection;
        }
       /* public static void DBSelectionOpeation()
        {
            string s = "name", fees = "fees";
            string query = $"SELECT {s},{fees} FROM student";
            var MyConnection = GetConnection();
            NpgsqlCommand command = new NpgsqlCommand(query, MyConnection);
            try
            {
                MyConnection.Open();

                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[s] + " - " + reader["fees"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally { MyConnection.Close(); }
        }*/
    }
}
