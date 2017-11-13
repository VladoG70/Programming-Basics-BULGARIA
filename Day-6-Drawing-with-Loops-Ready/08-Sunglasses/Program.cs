using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sunglasses
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            // Print the top part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            // Print the middle part
            for (int i = 0; i < n - 2; i++)
                {
                // TODO: print *///////*
                Console.Write('*' + new string('/', (n * 2) - 2) + '*');
                if (i == (n - 1) / 2 - 1)
                    {
                    Console.Write(new string('|', n));
                    }
                else
                    {
                    Console.Write(new string(' ', n));
                    }
                // TODO: print *///////*
                Console.Write('*' + new string('/', (n * 2) - 2) + '*');
                Console.WriteLine();
                }

            // Print the bottom part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            }
        }
    }
