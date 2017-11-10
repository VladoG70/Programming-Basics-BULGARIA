using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TimePlus15Minutes
    {
    class Program
        {
        static void Main(string[] args)
            {
            var inHour = int.Parse(Console.ReadLine());
            var inMin = int.Parse(Console.ReadLine());
            int hour = inHour;
            int min = inMin + 15;


            if (min > 59)
                {
                min %= 60;
                hour += 1;
                }

            hour %= 24;

            if (min < 10)
                {
                Console.WriteLine("{0}:0{1}", hour, min);
                }
            else
                {
                Console.WriteLine("{0}:{1}", hour, min);
                }
            }
        }
    }
