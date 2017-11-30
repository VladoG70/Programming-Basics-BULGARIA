using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomato = double.Parse(Console.ReadLine());
            int boxes = int.Parse(Console.ReadLine());
            int jars = int.Parse(Console.ReadLine());

            double lutenica = tomato / 5.0;
            double jarsNeeded = lutenica / 0.535;
            double boxesNeeded = jarsNeeded / jars;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Truncate(lutenica));

            if (boxesNeeded > boxes)
            {
                Console.WriteLine("{0} boxes left.", Math.Truncate(boxesNeeded - boxes));
                Console.WriteLine("{0} jars left.", Math.Truncate((boxesNeeded - boxes) * jars));
            }
            else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Truncate(boxes - boxesNeeded));
                Console.WriteLine("{0} more jars needed.", Math.Truncate((boxes - boxesNeeded) * jars));
            }



        }
    }
}
