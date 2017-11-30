using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Flowers_2016_12
    {
    class ProgramFlowers
        {
        static void Main(string[] args)
            {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());

            string sezon = Console.ReadLine().ToLower();
            char praznik = char.Parse(Console.ReadLine().ToLower());

            double hriznatemiPrice = 0.00, roziPrice = 0.00, laletaPrice = 0.00;
            double bouquetPrice = 0.00;

            switch (sezon)
                {
                case "spring":
                case "summer":
                    hriznatemiPrice = 2.00;
                    roziPrice = 4.10;
                    laletaPrice = 2.50;
                    if (praznik == 'y')
                        {
                        hriznatemiPrice *= 1.15;
                        roziPrice *= 1.15;
                        laletaPrice *= 1.15;
                        }
                    break;
                case "autumn":
                case "winter":
                    hriznatemiPrice = 3.75;
                    roziPrice = 4.50;
                    laletaPrice = 4.15;
                    if (praznik == 'y')
                        {
                        hriznatemiPrice *= 1.15;
                        roziPrice *= 1.15;
                        laletaPrice *= 1.15;
                        }
                    break;
                }
            bouquetPrice = hrizantemi * hriznatemiPrice + rozi * roziPrice + laleta * laletaPrice;

            if (laleta > 7 && sezon == "spring")
                {
                bouquetPrice *= 0.95;
                }
            if (rozi >= 10 && sezon == "winter")
                {
                bouquetPrice *= 0.90;
                }
            if ((hrizantemi + rozi + laleta) > 20)
                {
                bouquetPrice *= 0.80;
                }

            bouquetPrice += 2.00;

            Console.WriteLine("{0:F2}", bouquetPrice);
            }
        }
    }
