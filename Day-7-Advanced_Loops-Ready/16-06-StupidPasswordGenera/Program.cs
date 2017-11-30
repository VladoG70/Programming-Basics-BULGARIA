using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_06_StupidPasswordGenerator
    {
    class Program
        {
        static void Main(string[] args)
            {
            string symb = "abcdefghi";
            int dig5 = 0;

            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            if ((n > 0 && n < 10) && (l > 0 && l < 10))
                {
                for (int i = 1; i <= n; i++) // Symbol 1
                    {
                    for (int j = 1; j <= n; j++) // Symbol 2
                        {
                        for (int k = 0; k < l; k++) // Symbol 3
                            {
                            for (int m = 0; m < l; m++) // Symbol 4
                                {
                                if (i > j)
                                    {
                                    dig5 = i + 1;
                                    }
                                else
                                    {
                                    dig5 = j + 1;
                                    }
                                for (int p = dig5; p <= n; p++) // Symbol 5
                                    {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, symb[k], symb[m], p);
                                    } // End For-p
                                } // End For-m
                            } // End For-k
                        } // End For-j
                    } // End For-i
                }
            }
        }
    }
