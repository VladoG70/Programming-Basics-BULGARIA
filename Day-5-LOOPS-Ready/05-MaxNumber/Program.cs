using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MaxNumber
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            // First NUM
            var num = int.Parse(Console.ReadLine());
            int maxNum = num;

            for (int i = 1; i < n; i++)
                {
                num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                    {
                    maxNum = num;
                    }
                }
            Console.WriteLine(maxNum);
            }
        }
    }
