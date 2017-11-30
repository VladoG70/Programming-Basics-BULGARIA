using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxCombination
    {
    class MaxCombination
        {
        static void Main(string[] args)
            {
            var begin = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombNumber = int.Parse(Console.ReadLine());

            var count = 1;

            for (int first = begin; first <= end; first++)
                {
                for (int second = begin; second <= end; second++)
                    {
                    Console.Write("<{0}-{1}>", first, second);
                    count++;
                    if (count > maxCombNumber)
                        {
                        break;
                        }
                    }
                if (count > maxCombNumber)
                    {
                    break;
                    }
                }
            }
        }
    }
