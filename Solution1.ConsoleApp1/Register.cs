using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.ConsoleApp1
{
    internal class Register
    {
        public Register(int role)
        {

            if(role==1)
            {
                doctorR();
            }
            else 
            { 
                studentR(); 
            }
        }
        public static void studentR()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); ;
            Console.Write("Enetr your Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Your Degree: ");
            int degree = int.Parse(Console.ReadLine());

            var MyConnection = DataBConnection.GetConnection();
            MyConnection.Open();
             using var cmd = new NpgsqlCommand("INSERT INTO student (student_name,student_password,student_degree) VALUES ($1,$2,$3)", MyConnection)
            {
                Parameters =
                {
                     new() { Value = name},
                     new() { Value = password},
                     new() { Value = degree}
                }
            };

            cmd.ExecuteNonQuery();
            MyConnection.Close();
        }
        public static void doctorR()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); ;
            Console.Write("Enetr your Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Your Dep: ");
            string Dep = Console.ReadLine();
            Console.Write("Enter your specialization: ");
            string specil = Console.ReadLine();


            var MyConnection = DataBConnection.GetConnection();
            MyConnection.Open();
            using var cmd = new NpgsqlCommand("INSERT INTO doctor (doctor_name,doctor_password,dep,specialization) VALUES ($1,$2,$3,$4)", MyConnection)
            {
                Parameters =
                {
                     new() { Value = name},
                     new() { Value = password},
                     new() { Value = Dep},
                     new() { Value = specil}
                }
            };

            cmd.ExecuteNonQuery();
            MyConnection.Close();
        }
    }
}
