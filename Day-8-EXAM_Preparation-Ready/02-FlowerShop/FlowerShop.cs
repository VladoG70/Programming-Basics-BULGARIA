using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FlowerShop
    {
    class FlowerShop
        {
        static void Main(string[] args)
            {
            var magnolies = int.Parse(Console.ReadLine());
            var hyacinths = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactuses = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var orderSum = magnolies * 3.25 + hyacinths * 4.00 + roses * 3.50 + cactuses * 8.00;
            orderSum = orderSum - orderSum * 0.05; // orderSum - (5 * orderSum)/100.00;

            if (orderSum >= giftPrice)
                {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(orderSum - giftPrice));
                }
            else
                {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - orderSum));
                }
            }
        }
    }
