using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rocket
    {
    class Rocket
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int leftRight;
            int middle;

            // TOP
            leftRight = (3 * n - 2) / 2;
            middle = 0;
            for (int row = 1; row <= n; row++)
                {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', leftRight), new string(' ', middle));
                leftRight--;
                middle += 2;
                }

            // RING
            leftRight = n / 2;
            middle = 2 * n; // (3 * n) - (2 * leftRight)
            Console.WriteLine("{0}{1}{0}", new string('.', leftRight), new string('*', middle));

            // BODY
            leftRight = n / 2;
            middle = 2 * n - 2;
            for (int row = 1; row <= (2 * n); row++)
                {
                Console.WriteLine("{0}|{1}|{0}", new string('.', leftRight), new string('\\', middle));
                }


            // BOTTOM
            leftRight = n / 2;
            middle = 2 * n - 2;
            for (int row = 1; row <= (n / 2); row++)
                {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', leftRight), new string('*', middle));
                leftRight--;
                middle += 2;
                }

            }
        }
    }
