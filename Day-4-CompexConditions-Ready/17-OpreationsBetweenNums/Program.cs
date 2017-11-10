using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OpreationsBetweenNums
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            var oper = Console.Read();
            var result = 0.0; // Because of / -> Floating point number
            var evenOdd = "";

            switch (oper)
                {
                case '+':
                    result = n1 + n2;
                    if ((result % 2) == 0)
                        {
                        evenOdd = "even";
                        }
                    else
                        {
                        evenOdd = "odd";
                        }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, (char)oper, n2, result, evenOdd);

                    break;
                case '-':
                    result = n1 - n2;
                    if ((result % 2) == 0)
                        {
                        evenOdd = "even";
                        }
                    else
                        {
                        evenOdd = "odd";
                        }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, (char)oper, n2, result, evenOdd);
                    break;
                case '*':
                    result = n1 * n2;
                    if ((result % 2) == 0)
                        {
                        evenOdd = "even";
                        }
                    else
                        {
                        evenOdd = "odd";
                        }
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, (char)oper, n2, result, evenOdd);
                    break;
                case '/':
                    if (n2 == 0)
                        {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                        }
                    else
                        {
                        result = (double)n1 / (double)n2;
                        Console.WriteLine("{0} {1} {2} = {3:F2}", n1, (char)oper, n2, result);
                        }
                    break;
                case '%':
                    if (n2 == 0)
                        {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                        }
                    else
                        {
                        result = n1 % n2;
                        Console.WriteLine("{0} {1} {2} = {3}", n1, (char)oper, n2, result);
                        }
                    break;
                default: break;
                }
            }
        }
    }