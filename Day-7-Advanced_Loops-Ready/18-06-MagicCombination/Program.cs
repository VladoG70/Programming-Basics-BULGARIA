﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_06_MagicCombination
    {
    class Program
        {
        static void Main(string[] args)
            {
            int magic = int.Parse(Console.ReadLine());

            for (int d1 = 0; d1 <= 9; d1++)
                {
                for (int d2 = 0; d2 <= 9; d2++)
                    {
                    for (int d3 = 0; d3 <= 9; d3++)
                        {
                        for (int d4 = 0; d4 <= 9; d4++)
                            {
                            for (int d5 = 0; d5 <= 9; d5++)
                                {
                                for (int d6 = 0; d6 <= 9; d6++)
                                    {
                                    if (d1 * d2 * d3 * d4 * d5 * d6 == magic)
                                        {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", d1, d2, d3, d4, d5, d6);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
