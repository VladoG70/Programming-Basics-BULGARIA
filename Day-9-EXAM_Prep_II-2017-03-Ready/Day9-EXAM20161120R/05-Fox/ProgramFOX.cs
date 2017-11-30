using System;

namespace _05_Fox
    {
    class ProgramFOX
        {
        static void Main()
            {
            int n = int.Parse(Console.ReadLine());

            int lines = n;
            int leftRight = 1;
            int middle = 2 * n - 1;
            // TOP
            for (int rows = 0; rows < lines; rows++)
                {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', leftRight), new string('-', middle));
                leftRight++;
                middle -= 2;
                }

            // MIDDLE
            lines = n / 3;
            leftRight = n / 2;
            middle = n;
            for (int rows = 0; rows < lines; rows++)
                {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', leftRight), new string('*', middle));
                leftRight++;
                middle -= 2;
                }


            // BOTTOM
            lines = n;
            leftRight = 1;
            middle = 2 * n - 1;
            for (int rows = 0; rows < lines; rows++)
                {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', leftRight), new string('*', middle));
                leftRight++;
                middle -= 2;
                }
            }
        }
    }
