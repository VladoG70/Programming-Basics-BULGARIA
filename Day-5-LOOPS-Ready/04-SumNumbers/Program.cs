using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SumNumbers
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            var sumN = 0;

            for (int i = 1; i <= n; i++)
                {
                sumN = sumN + int.Parse(Console.ReadLine());
                }
            Console.WriteLine(sumN);
            }
        }
    }
