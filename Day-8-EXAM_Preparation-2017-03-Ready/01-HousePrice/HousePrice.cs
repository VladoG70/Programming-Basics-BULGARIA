using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HousePrice
    {
    class HousePrice
        {
        static void Main(string[] args)
            {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var priceSqM = double.Parse(Console.ReadLine());

            var bathroomArea = smallestRoomArea / 2.0;
            var secondRoomArea = smallestRoomArea * 1.1; // (110%) smallestRoomArea + smallestRoomArea * 0.1;
            var thirdRoomArea = secondRoomArea * 1.1;

            var houseArea = smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea;
            houseArea = houseArea + houseArea * 0.05; // houseArea + (5 * houseArea)/100.00; - because of corridor

            var housePrice = houseArea * priceSqM;
            Console.WriteLine("{0:F2}", housePrice);
            }
        }
    }
