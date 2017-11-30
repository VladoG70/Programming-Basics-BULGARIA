using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BikeRace
    {
    class BikeRace
        {
        static void Main(string[] args)
            {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var way = Console.ReadLine().ToLower();

            var totalSum = 0.0;
            var juniorsTax = 0.0;
            var seniorsTax = 0.0;

            switch (way)
                {
                case "trail":
                    juniorsTax = 5.50;
                    seniorsTax = 7.00;
                    break;
                case "cross-country":
                    juniorsTax = 8.00;
                    seniorsTax = 9.50;
                    if ((juniors + seniors) >= 50)
                        {
                        juniorsTax = juniorsTax - juniorsTax * 0.25; // juniorTax * 0.75;
                        seniorsTax = seniorsTax - seniorsTax * 0.25;
                        }
                    break;
                case "downhill":
                    juniorsTax = 12.25;
                    seniorsTax = 13.75;
                    break;
                case "road":
                    juniorsTax = 20.00;
                    seniorsTax = 21.50;
                    break;
                default: break;
                }
            totalSum = juniors * juniorsTax + seniors * seniorsTax;
            totalSum = totalSum - (5 * totalSum) / 100.00;

            Console.WriteLine("{0:F2}", totalSum);
            }
        }
    }
