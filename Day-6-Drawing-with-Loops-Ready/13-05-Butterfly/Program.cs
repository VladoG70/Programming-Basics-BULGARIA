using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05_Butterfly
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            int halfRowSize = n - 2;

            for (int i = 1; i <= halfRowSize; i++)
                {
                if (i % 2 != 0)
                    {
                    Console.WriteLine("{0}\\ /{0}", new string('*', halfRowSize));
                    }
                else
                    {
                    Console.WriteLine("{0}\\ /{0}", new string('-', halfRowSize));
                    }
                }

            Console.WriteLine("{0} @ {0}", new string(' ', halfRowSize));

            for (int i = 1; i <= halfRowSize; i++)
                {
                if (i % 2 != 0)
                    {
                    Console.WriteLine("{0}/ \\{0}", new string('*', halfRowSize));
                    }
                else
                    {
                    Console.WriteLine("{0}/ \\{0}", new string('-', halfRowSize));
                    }
                }
            }
        }
    }
