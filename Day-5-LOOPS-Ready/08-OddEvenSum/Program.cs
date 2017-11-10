using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OddEvenSum
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            var evenPosSUM = 0;
            var oddPosSum = 0;
            var diffSum = 0;
            var num = 0;

            for (int i = 1; i <= n; i++)
                {
                num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    {
                    evenPosSUM += num;
                    }
                else
                    {
                    oddPosSum += num;
                    }
                }

            if (evenPosSUM == oddPosSum)
                {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenPosSUM);
                }
            else
                {
                diffSum = Math.Abs(evenPosSUM - oddPosSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diffSum);
                }
            }
        }
    }
