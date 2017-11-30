using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_06_StupidPasswordGenerator_Author
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (var d1 = 1; d1 <= n; d1++)
                {
                for (var d2 = 1; d2 <= n; d2++)
                    {
                    for (char ch1 = 'a'; ch1 < ('a' + l); ch1++)
                        {
                        for (char ch2 = 'a'; ch2 < ('a' + l); ch2++)
                            {
                            for (var d3 = Math.Max(d1, d2) + 1; d3 <= n; d3++)
                                {
                                Console.Write("{0}{1}{2}{3}{4} ", d1, d2, ch1, ch2, d3);
                                }
                            }
                        }
                    }
                }
            Console.WriteLine();
            }
        }
    }
