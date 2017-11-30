using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine().ToLower();
            string typeContract = Console.ReadLine().ToLower();
            string internet = Console.ReadLine().ToLower();
            int months = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (years == "one")
            {
                switch (typeContract)
                {
                    case "small":
                        price = 9.98;
                        break;
                    case "middle":
                        price = 18.99;
                        break;
                    case "large":
                        price = 25.98;
                        break;
                    case "extralarge":
                        price = 35.99;
                        break;
                }

                if (internet == "yes")
                {
                    if (price <= 10)
                    {
                        price += 5.50;
                    }
                    else
                    {
                        if (price <= 30)
                        {
                            price += 4.35;
                        }
                        else
                        {
                            price += 3.85;
                        }
                    }
                }

                price *= months;
            }
            else
            {
                switch (typeContract)
                {
                    case "small":
                        price = 18.58;
                        break;
                    case "middle":
                        price = 17.09;
                        break;
                    case "large":
                        price = 23.59;
                        break;
                    case "extralarge":
                        price = 31.79;
                        break;
                }

                if (internet == "yes")
                {
                    if (price <= 10)
                    {
                        price += 5.50;
                    }
                    else
                    {
                        if (price <= 30)
                        {
                            price += 4.35;
                        }
                        else
                        {
                            price += 3.85;
                        }
                    }
                }

                price *= months;
                price = price - price * (3.75 / 100.0);
            }

            Console.WriteLine("{0:F2} lv.", price);
        }
    }
}
