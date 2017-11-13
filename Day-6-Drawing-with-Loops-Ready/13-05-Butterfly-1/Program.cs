﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05_Butterfly_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            int rows = 2 * (n - 2) + 1;
            int cols = 2 * n - 1;

            // using ?: operator https://msdn.microsoft.com/en-us/library/ty67wk28.aspx
            for (int i = 0; i < n - 2; i++)
                {
                Console.WriteLine("{0}\\ /{0}", new string(i % 2 == 0 ? '*' : '-', n - 2));
                }
            Console.WriteLine(new string(' ', n - 1) + "@");
            for (int i = 0; i < n - 2; i++)
                {
                Console.WriteLine("{0}/ \\{0}", new string(i % 2 == 0 ? '*' : '-', n - 2));
                }
            }
        }
    }
