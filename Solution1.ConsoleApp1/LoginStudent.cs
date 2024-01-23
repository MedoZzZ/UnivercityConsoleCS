
using Npgsql;
namespace Solution1.ConsoleApp1
{
    internal class LoginStudent
    {
        public LoginStudent(string name,string password)
        {
            var MyConnection = DataBConnection.GetConnection();
            string query = $"SELECT student_name ,student_password FROM student";
            NpgsqlCommand command = new NpgsqlCommand(query, MyConnection);
            try
            {
                MyConnection.Open();
                bool flag = false;
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((string)reader["student_name"] == name && (string)reader["student_password"] == password)
                    {
                        Console.WriteLine("Login Done :)");
                        flag = true; break;
                    }
                }
                if(!flag)
                {
                    Console.WriteLine("Wornge Data");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally { MyConnection.Close(); }
        }
    }
    
}
