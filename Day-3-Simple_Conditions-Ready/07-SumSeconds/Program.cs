using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumSeconds
    {
    class Program
        {
        static void Main(string[] args)
            {
            int min = 0;
            int sec = 0;
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            int totalSec = sec1 + sec2 + sec3;
            
            min = totalSec / 60; // Celochisleno delenie na 60
            sec = totalSec % 60; // Ostatak ot delenieto na 60
            if (sec < 10)
                {
                Console.WriteLine("{0}:0{1}", min, sec);
                }
            else
                {
                Console.WriteLine("{0}:{1}", min, sec);
                }
            }
        }
    }
