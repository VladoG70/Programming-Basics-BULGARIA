using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_DrawFort
    {
    class Program
        {
        static void Main(string[] args)
            {
            var n = int.Parse(Console.ReadLine());

            var colSize = n / 2;
            var midSize = 2 * n - 2 * colSize - 4;

            // Draw the first row
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colSize), new string('_', midSize));

            // Middle rows
            for (var row = 1; row < n - 2; row++)
                {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
                }

            // Draw the row before the last
            Console.WriteLine("|{0}{1}{0}|", new string(' ', colSize + 1), new string('_', midSize));

            // Draw the last row
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', midSize));
            }
        }
    }
