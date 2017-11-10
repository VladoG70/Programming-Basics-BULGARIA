using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _777_TEST
    {
    class Program
        {
        static void Main(string[] args)
            {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var minSum = min + 15;



            if (minSum > 59)
                {
                minSum = minSum - 60;
                var hourNew = hour + 1;
                if (hourNew > 23)
                    {
                    hourNew = hourNew - 24;
                    }

                if (minSum < 10)
                    {
                    Console.WriteLine("{0}:0{1}", hourNew, minSum);
                    }
                else
                    {
                    Console.WriteLine("{0}:{1}", hourNew, minSum);
                    }
                }
            else
                {
                if (minSum <= 59)
                    {
                    Console.WriteLine("{0}:{1}", hour, minSum);
                    }
                }
            }
        }
    }
