using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InchesToCentimeters
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Enter Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var cmInch = 2.54;
            var cm = inches * cmInch;
            Console.Write("Centimetres = ");
            Console.WriteLine(cm);
            }
        }
    }
