using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MinNumber
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());
            int minNum = num;

            for (int i = 1; i < n; i++)
                {
                num = int.Parse(Console.ReadLine());
                if (num < minNum)
                    {
                    minNum = num;
                    }
                }
            Console.WriteLine(minNum);
            }
        }
    }
