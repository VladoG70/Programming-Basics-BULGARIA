using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SquareFrame
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            // Row 1st
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
                {
                Console.Write("- ");
                }
            Console.WriteLine("+");

            // Rows BETWEEN 1st & Last
            for (int row = 0; row < n - 2; row++)
                {
                Console.Write("| ");
                for (int i = 0; i < n - 2; i++)
                    {
                    Console.Write("- ");
                    }
                Console.WriteLine("|");
                }

            // Row Last
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
                {
                Console.Write("- ");
                }
            Console.WriteLine("+");

            }
        }
    }
