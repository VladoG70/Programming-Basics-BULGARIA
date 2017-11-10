using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_OddEvenPosition
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());
            double num;
            var oddSum = 0.0;
            double oddMin, oddMax;
            var evenSum = 0.0;
            double evenMin, evenMax;

            var no = "No";

            if (n > 0)
                {
                num = double.Parse(Console.ReadLine());
                oddMin = num;
                oddMax = num;
                oddSum = num;

                if (n > 1)
                    {
                    num = double.Parse(Console.ReadLine()); // 2nd ELEMENT - Only 1st EVEN
                    evenMin = num;
                    evenMax = num;
                    evenSum = num;
                    for (int i = 3; i <= n; i++)
                        {
                        num = double.Parse(Console.ReadLine());
                        if ((i % 2) == 0) // Even
                            {
                            if (num > evenMax)
                                {
                                evenMax = num;
                                }
                            else
                                {
                                if (num < evenMin)
                                    {
                                    evenMin = num;
                                    }
                                }
                            evenSum += num;
                            }
                        else // Odd
                            {
                            if (num > oddMax)
                                {
                                oddMax = num;
                                }
                            else
                                {
                                if (num < oddMin)
                                    {
                                    oddMin = num;
                                    }
                                }
                            oddSum += num;
                            } // end else Odd

                        } // end for

                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMax);
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=" + evenMin);
                    Console.WriteLine("EvenMax=" + evenMax);

                    }
                else
                    {
                    Console.WriteLine("OddSum=" + oddSum);
                    Console.WriteLine("OddMin=" + oddMin);
                    Console.WriteLine("OddMax=" + oddMax);
                    Console.WriteLine("EvenSum=" + evenSum);
                    Console.WriteLine("EvenMin=" + no);
                    Console.WriteLine("EvenMax=" + no);
                    }
                } // if>0
            else
                {
                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=" + no);
                Console.WriteLine("OddMax=" + no);
                Console.WriteLine("EvenSum=" + evenSum);
                Console.WriteLine("EvenMin=" + no);
                Console.WriteLine("EvenMax=" + no);
                }

            }
        }
    }
