using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ChristmasHat
    {
    class ProgramChristmasHat
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int lines = 2 * n + 5 - 5;
            int lefRight = (4 * n + 1 - 3) / 2;
            int middle = 0;

            // TOP
            Console.WriteLine("{0}/|\\{0}", new string('.', lefRight));
            Console.WriteLine("{0}\\|/{0}", new string('.', lefRight));

            // MIDDLE
            for (int rows = 0; rows < lines; rows++)
                {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', lefRight), new string('-', middle));
                lefRight--;
                middle++;
                }

            // BOTTOM
            Console.WriteLine(new string('*', (4 * n + 1)));
            for (int col = 0; col < (4 * n + 1) / 2; col++)
                {
                Console.Write("*.");
                }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', (4 * n + 1)));
            }
        }
    }
