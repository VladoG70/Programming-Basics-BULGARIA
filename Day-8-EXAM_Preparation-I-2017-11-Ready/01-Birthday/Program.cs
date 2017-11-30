using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {           
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = l * w * h; // cm3

            volume = volume / 1000.0; // dm3 = l

            //volume = volume - volume * percent/100.0;
            volume = volume * (1 - percent / 100.0);

            Console.WriteLine("{0:F3}", volume);
           

        }
    }
}
