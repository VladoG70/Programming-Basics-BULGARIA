using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
    {
    class Program
        {
        static void Main(string[] args)
            {
            var typePRJ = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());
            var viewers = row * column;
            var price = 0.0;
            var totalSum = 0.0;

            if (typePRJ == "premiere")
                {
                price = 12.00;
                }
            else
                {
                if (typePRJ == "normal")
                    {
                    price = 7.5;
                    }
                else
                    {
                    if (typePRJ == "discount")
                        {
                        price = 5.0;
                        }
                    }
                }

            totalSum = viewers * price;
            Console.WriteLine("{0:f2} leva", totalSum);

            }
        }
    }
