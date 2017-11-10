using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_10_HalfSumElement
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            int sumN = 0, diffN;
            var num = int.Parse(Console.ReadLine());
            int maxN = num;
            sumN += num;

            for (int i = 1; i < n; i++)
                {
                num = int.Parse(Console.ReadLine());
                sumN += num;
                if (num > maxN)
                    {
                    maxN = num;
                    }
                }
            // Mahame MAX-element, poneje toi se sadarja v sumata na vsichki elementi - sumN
            sumN -= maxN;

            if (sumN == maxN)
                {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sumN);
                }
            else
                {
                diffN = Math.Abs(maxN - sumN);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diffN);

                }
            }
        }
    }
