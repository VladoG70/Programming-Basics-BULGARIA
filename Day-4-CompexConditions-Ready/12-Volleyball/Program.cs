using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Volleyball
    {
    class Program
        {
        static void Main(string[] args)
            {
            var kindOfYear = Console.ReadLine();
            var holidaysP = int.Parse(Console.ReadLine());
            var weekendsH = int.Parse(Console.ReadLine());
            int numWeekInYear = 48;
            var volleyN = 0.0;

            // V Sofia
            volleyN = (numWeekInYear - weekendsH) * (3.0 / 4.0);
            //Console.WriteLine(volleyN);

            // Na Praznicite + v Sofia
            volleyN += holidaysP * (2.0 / 3.0);
            //Console.WriteLine(volleyN);

            // V Rodnia grad + (na Praznicite + v Sofia) 
            volleyN += weekendsH;
            //Console.WriteLine(volleyN);

            if (kindOfYear == "leap")
                {
                volleyN *= 1.15;
                }

            Console.WriteLine("{0}", Math.Truncate(volleyN));

            }
        }
    }
