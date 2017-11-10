using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GreetingByName
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter Your Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
            }
        }
    }
