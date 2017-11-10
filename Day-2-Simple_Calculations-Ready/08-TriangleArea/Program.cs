using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TriangleArea
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter h = ");
            var h = double.Parse(Console.ReadLine());
            double area = (a * h) / 2;
            area = Math.Round(area, 2);
            Console.WriteLine("Triangle area = {0}", area);
            }
        }
    }
