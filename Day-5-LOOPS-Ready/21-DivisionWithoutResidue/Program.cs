using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_DivisionWithoutResidue
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0.0; // Div % 2
            double p2 = 0.0; // Div % 3
            double p3 = 0.0; // Div % 4

            for (int i = 0; i < n; i++)
                {
                var num = int.Parse(Console.ReadLine());
                if ((num % 2) == 0)
                    {
                    p1++;
                    }

                if ((num % 3) == 0)
                    {
                    p2++;
                    }

                if ((num % 4) == 0)
                    {
                    p3++;
                    }
                }

            Console.WriteLine("{0:F2}%", (p1 / n) * 100.0);
            Console.WriteLine("{0:F2}%", (p2 / n) * 100.0);
            Console.WriteLine("{0:F2}%", (p3 / n) * 100.0);
            }
        }
    }
