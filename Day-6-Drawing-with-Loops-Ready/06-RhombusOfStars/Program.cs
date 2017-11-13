using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RhombusOfStars
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            // UP
            for (var row = 1; row <= n; row++)
                {
                for (var col = 1; col <= n - row; col++)
                    {
                    Console.Write(" ");
                    }
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    {
                    Console.Write(" *");
                    }
                Console.WriteLine();
                }

            // DOWN
            for (var row = n - 1; row >= 1; row--)
                {
                for (int col = n - row; col >= 1; col--)
                    {
                    Console.Write(" ");
                    }
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write("* ");
                    }
                Console.WriteLine();
                }

            }
        }
    }
