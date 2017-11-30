using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NumbersN_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i -= 1)
                {
                Console.WriteLine(i);
                }
            }
        }
    }
