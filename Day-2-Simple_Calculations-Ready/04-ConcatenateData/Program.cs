using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConcatenateData
    {
    class Program
        {
        static void Main(string[] args)
            {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = double.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2:f2}-years old person from {3}.", firstName, lastName, age, town);
            // {2:f2} - f2 is FORMAT output data
            }
        }
    }
