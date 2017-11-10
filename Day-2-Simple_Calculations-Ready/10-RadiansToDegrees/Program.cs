using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_RadiansToDegrees
    {
    class Program
        {
        static void Main(string[] args)
            {
            // Angle=Radian*(180/Pi)
            Console.Write("Enter angle in Radian = ");
            var Radian = double.Parse(Console.ReadLine());
            var angle = Radian * (180 / Math.PI);
            Console.WriteLine("Angle in Gradus = " + Math.Round(angle, 0));
            }
        }
    }
