using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LeftAndRightSum
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            var sumL = 0;
            var sumR = 0;
            var diffN = 0;

            for (int i = 0; i < n; i++)
                {
                sumL += int.Parse(Console.ReadLine());
                }

            for (int j = 0; j < n; j++)
                {
                sumR += int.Parse(Console.ReadLine());
                }

            if (sumL == sumR)
                {
                Console.WriteLine("Yes, sum = {0}", sumL);
                }
            else
                {
                diffN = Math.Abs(sumL - sumR);
                Console.WriteLine("No, diff = {0}", diffN);
                }
            }
        }
    }
