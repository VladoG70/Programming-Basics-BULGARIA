﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = (3 * n - 1) / 2;
            int xCount = n;
            bool reward = false;

            for (int row = 0; row < n + 4; row++)
            {
                // Top - PEAK
                if (row == 0)
                {
                    Console.WriteLine(new string('.', dots) + "x" + new string('.', dots));
                }
                else
                {
                    if (row == 1)
                    {
                        dots--;
                        Console.WriteLine(new string('.', dots) + "/x\\" + new string('.', dots));
                    }
                    else
                    {
                        if (row == 2)
                        {
                            Console.WriteLine(new string('.', dots) + "x|x" + new string('.', dots));
                        }
                        else
                        {
                            if (row > 2 && xCount >= n)
                            {
                                if (dots == 1)
                                {
                                    reward = true;
                                }

                                dots = (3 * n - 1) / 2 - xCount;
                                if (xCount >= 0 && dots >= 0)
                                {
                                    Console.WriteLine(new string('.', dots) + new string('x', xCount) + "|" + new string('x', xCount) + new string('.', dots));
                                }

                                if (reward)
                                {
                                    xCount--;
                                }
                                else
                                {
                                    xCount++;
                                }
                            }
                        }
                    }
                }

                if (row == n + 4 - 1)
                {
                    dots = (3 * n - 2) / 2;
                    Console.WriteLine(new string('.', dots) + "/x\\" + new string('.', dots));
                }
            } // ROWS

            // MIRROR ARROW
            xCount = n;
            reward = false;
            for (int row = n + 3; row >= 0; row--)
            {
                if (row == n + 4 - 1)
                {
                    dots = (3 * n - 2) / 2;
                    Console.WriteLine(new string('.', dots) + "\\x/" + new string('.', dots));
                }

                if (row == 0)
                {
                    dots = (3 * n - 1) / 2;
                    Console.WriteLine(new string('.', dots) + "x" + new string('.', dots));
                }
                else
                {
                    if (row == 1)
                    {
                        Console.WriteLine(new string('.', dots) + "\\x/" + new string('.', dots));
                    }
                    else
                    {
                        if (row == 2)
                        {
                            dots = (3 * n - 1) / 2 - 1;
                            Console.WriteLine(new string('.', dots) + "x|x" + new string('.', dots));
                        }
                        else
                        {
                            if (row > 2 && xCount >= n)
                            {
                                if (dots == 1)
                                {
                                    reward = true;
                                }

                                // Write
                                dots = (3 * n - 1) / 2 - xCount;
                                if (xCount >= 0 && dots >= 0)
                                {
                                    Console.WriteLine(new string('.', dots) + new string('x', xCount) + "|" +
                                                      new string('x', xCount) + new string('.', dots));
                                }

                                if (reward)
                                {
                                    xCount--;
                                }
                                else
                                {
                                    xCount++;
                                }
                            }
                        }
                    }
                }
            } // ROWS

        }
    }
}
