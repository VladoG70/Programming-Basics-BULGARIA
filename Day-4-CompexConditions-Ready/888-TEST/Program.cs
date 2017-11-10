using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _888_TEST
    {
    class Program
        {
        static void Main(string[] args)
            {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            var op = Console.ReadLine().ToLower();
            var result = 0.0;

            if ((N1 >= 0 && N1 <= 40000) && (N2 >= 0 && N1 <= 40000))
                {
                if ((op == "+") || (op == "-") || (op == "*"))
                    if (op == "+")
                        {
                            {
                            result = (N1 + N2);
                            }

                        if (result % 2 == 0)

                            Console.WriteLine(N1 + " + " + N2 + " = " + result + " - even");
                        else
                            Console.WriteLine(N1 + " + " + N2 + " = " + result + " - odd");
                        }

                if (op == "-")
                    {
                        {
                        result = (N1 - N2);
                        }

                    if (result % 2 == 0)

                        Console.WriteLine(N1 + " - " + N2 + " = " + result + " - even");
                    else
                        Console.WriteLine(N1 + " - " + N2 + " = " + result + " - odd");
                    }

                if (op == "*")
                    {
                        {
                        result = (N1 * N2);
                        }

                    if (result % 2 == 0)

                        Console.WriteLine(N1 + " * " + N2 + " = " + result + " - even");
                    else
                        Console.WriteLine(N1 + " * " + N2 + " = " + result + " - odd");
                    }
                }

            if (op == "/")
                {
                if (N2 == 0) Console.WriteLine("Cannot devide " + N1 + " by zero");
                    {
                    result = (N1 / N2);

                    Console.WriteLine(N1 + " / " + N2 + " = " + "{0:f2}", result);

                    }
                }
            if (op == "%")
                {
                if (N2 == 0) Console.WriteLine("Cannot devide " + N1 + " by zero");
                    {
                    result = (N1 % N2);

                    Console.WriteLine(N1 + " % " + N2 + " = " + result);
                    }
                }
            }
        }
    }
