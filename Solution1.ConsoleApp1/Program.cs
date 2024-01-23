using System;
using Npgsql;
using System.Data;

namespace Solution1.ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Please Choose [1] for Register and [2] for login");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                Console.WriteLine("Hello Please Choose [1] for Doctor and [2] for Student");
                int role = int.Parse(Console.ReadLine());
                new Register(role);

            }
            else if(opt == 2)
            {
                Console.WriteLine("Hello Please Choose [1] for Doctor and [2] for Student");
                int role = int.Parse(Console.ReadLine());
                Console.Write("Please Enter Your Name: ");
                string name = Console.ReadLine();
                Console.Write("Please Enter Your Password: ");
                string password = Console.ReadLine();
                if (role==1)
                {
                    
                    new LoginDoctor(name, password);

                }
                else
                {
                    new LoginStudent(name, password);
                }
                
            }
        }

       
        /////////////////////// DB Connection \\\\\\\\\\\\\\\\\\\\\\\\\\\\
        
    }
}
