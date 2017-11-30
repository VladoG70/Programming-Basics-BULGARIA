using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Battles_2016_12
    {
    class Program
        {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int count = 1;

            for (int first = 1; first <= firstN; first++)
            {
                for (int second = 1; second <= secondN; second++)
                {
                    Console.Write("({0} <-> {1}) ", first, second);
                    count++;
                    if (count > maxBattles)
                    {
                        break;
                    }
                }
                if (count > maxBattles)
                {
                    break;
                }
            }
        }
        }
    }
