using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2DRectangleArea
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter x1 = ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1 = ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2 = ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2 = ");
            var y2 = double.Parse(Console.ReadLine());

            double a = Math.Max(x2, x1) - Math.Min(x2, x1);
            double b = Math.Max(y2, y1) - Math.Min(y2, y1);
            double rectArea = a * b;
            double rectPerimeter = 2 * (a + b);

            Console.WriteLine("Rectangle Area = " + rectArea);
            Console.WriteLine("Rectangle Perimeter = " + rectPerimeter);
            }
        }
    }
