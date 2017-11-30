using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChangeTiles
    {
    class ProgramChangeTiles
        {
        static void Main(string[] args)
            {
            double sum = double.Parse(Console.ReadLine());
            double floorWide = double.Parse(Console.ReadLine());
            double floorLong = double.Parse(Console.ReadLine());
            double triangelA = double.Parse(Console.ReadLine());
            double triangelH = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double masterPrice = double.Parse(Console.ReadLine());

            double floorArea = floorWide * floorLong;
            double tileArea = (triangelA * triangelH) / 2;

            int qtyTile = (int)Math.Ceiling(floorArea / tileArea) + 5;

            double priceNeeded = qtyTile * tilePrice + masterPrice;

            if (priceNeeded <= sum)
                {
                Console.WriteLine("{0:F2} lv left.", sum - priceNeeded);
                }
            else
                {
                Console.WriteLine("You'll need {0:F2} lv more.", priceNeeded - sum);
                }

            }
        }
    }
