using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Smoke
            for (int smoke = 0; smoke < n; smoke++)
            {
                Console.WriteLine(new string(' ', n) + "~ ~ ~");
            }

            // Top
            Console.WriteLine(new string('=', 3 * n + 5));

            for (int ring = 0; ring < (3 * n - 2 * n - 2); ring++)
            {
                if (n / 2 - 1 == ring)
                {
                    Console.Write("|" + new string('~', n) + "JAVA" + new string('~', n) + "|");
                }
                else
                {
                    Console.Write("|" + new string('~', 2 * n + 4) + "|");
                }
                Console.WriteLine(new string(' ', n - 1) + "|");
            }

            Console.WriteLine(new string('=', 3 * n + 5));

            // Middle
            for (int middle = 0; middle < n; middle++)
            {
                Console.Write(new string(' ', middle));
                Console.Write("\\");
                Console.Write(new string('@', 2 * n + 4 - middle * 2));
                Console.WriteLine("/");
            }

            // Bottom
            Console.WriteLine(new string('=', (3 * n + 6) - n));
        }
    }
}
