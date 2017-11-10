using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CelsiusToFahrenheit
    {
    class Program
        {
        static void Main(string[] args)
            {
            // °F = °C × 1,8 + 32 ([°F] = [°C] × 9⁄5 + 32)
            Console.Write("Enter temp C = ");
            var celsius = double.Parse(Console.ReadLine());
            var Fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("Temp in Fahrenheit = " + Math.Round(Fahrenheit, 2));
            }
        }
    }
