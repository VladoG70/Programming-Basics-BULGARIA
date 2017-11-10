using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PointInTheFigure
    {
    class Program
        {
        static void Main(string[] args)
            {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var x1 = 0;
            var y1 = 0;
            var x2 = 3 * h;
            var y2 = h;
            var x3 = h;
            var y3 = h;
            var x4 = 2 * h;
            var y4 = 4 * h;

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
                {
                if (x == x1 || x == x2 || y == y1 || y == y2)
                    {
                    if (y == y2 && (x > x3 && x < x4))
                        {
                        Console.WriteLine("inside");
                        }
                    else
                        {
                        Console.WriteLine("border");
                        }
                    }
                else
                    {
                    Console.WriteLine("inside");
                    }
                }
            else // Check Rectangle-2
                {
                if (x >= x3 && x <= x4 && y >= y3 && y <= y4)
                    {
                    if (x == x3 || x == x4 || y == y3 || y == y4)
                        {
                        if (y == y3 && (x > x3 && x < x4))
                            {
                            Console.WriteLine("inside");
                            }
                        else
                            {
                            Console.WriteLine("border");
                            }
                        }
                    else
                        {
                        Console.WriteLine("inside");
                        }
                    }
                else
                    {
                    Console.WriteLine("outside");
                    }
                }

            }
        }
    }
