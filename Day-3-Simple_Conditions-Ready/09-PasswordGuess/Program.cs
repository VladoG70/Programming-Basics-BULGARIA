using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PasswordGuess
    {
    class Program
        {
        static void Main(string[] args)
            {
            string passUser = "s3cr3t!P@ssw0rd";

            var pass = Console.ReadLine();
            if (pass == passUser)
                {
                Console.WriteLine("Welcome");
                }
            else
                {
                Console.WriteLine("Wrong password!");
                }
            }
        }
    }
