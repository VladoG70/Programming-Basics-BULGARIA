using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            var leftRight = (n - 1) / 2;

            if (n == 1)
                {
                Console.WriteLine('*');
                }
            else
                {
                for (int i = 1; i <= (n - 1) / 2; i++)
                    {
                    // Draw the TOP part
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    var mid = n - 2 * leftRight - 2;
                    if (mid >= 0)
                        {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        }
                    Console.WriteLine(new string('-', leftRight));
                    leftRight--;
                    } 
                // MIDDLE ROW
                Console.WriteLine('*' + new string('-', n - 2) + '*');
                // TODO: Draw the bottom part
                    leftRight++;
                for (int i = 1; i <= (n - 1) / 2; i++)
                    {
                    // Draw the DOWN part
                    Console.Write(new string('-', leftRight));
                    Console.Write("*");
                    var mid = n - 2 * leftRight - 2;
                    if (mid >= 0)
                        {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                        }
                    Console.WriteLine(new string('-', leftRight));
                    leftRight++;
                    }
                }
            }
        }
    }
