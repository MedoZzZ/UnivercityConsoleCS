using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.ConsoleApp1
{
    internal class LoginDoctor
    {
        public LoginDoctor(string name, string password)
        {
            var MyConnection = DataBConnection.GetConnection();
            string query = $"SELECT doctor_name ,doctor_password FROM doctor";
            NpgsqlCommand command = new NpgsqlCommand(query, MyConnection);
            try
            {
                MyConnection.Open();
                bool flag = false;
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((string)reader["doctor_name"] == name && (string)reader["doctor_password"] == password)
                    {
                        Console.WriteLine("Login Done :)");
                        flag = true; break;
                    }
                }
                if (!flag)
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

