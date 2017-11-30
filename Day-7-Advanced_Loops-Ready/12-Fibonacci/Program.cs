using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Fibonacci
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;

            for (var i = 0; i < n - 1; i++) // Original Fibonacci (i = 1)
                {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
                }
            Console.WriteLine(f1);
            }
        }
    }
