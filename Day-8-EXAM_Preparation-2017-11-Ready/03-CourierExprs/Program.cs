using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CourierExprs
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string service = Console.ReadLine().ToLower();
            int distance = int.Parse(Console.ReadLine());

            double price = 0;

            if (weight < 1)
            {
                price = distance * 0.03;
            }
            else
            {
                if (weight >= 1 && weight < 11)
                {
                    price = distance * 0.05;
                }
                else
                {
                    if (weight >= 11 && weight < 41)
                    {
                        price = distance * 0.10;
                    }
                    else
                    {
                        if (weight >= 41 && weight < 91)
                        {
                            price = distance * 0.15;
                        }
                        else
                        {
                            if (weight >= 91 && weight <= 150)
                            {
                                price = distance * 0.20;
                            }
                        }
                    }
                }
            }

            if (service == "express")
            {
                if (weight < 1)
                {
                    price = price + (0.8 * 0.03 * weight * distance);
                }
                else
                {
                    if (weight >= 1 && weight < 11)
                    {
                        price = price + (0.4 * 0.05 * weight * distance);
                    }
                    else
                    {
                        if (weight >= 11 && weight < 41)
                        {
                            price = price + (0.05 * 0.10 * weight * distance);
                        }
                        else
                        {
                            if (weight >= 41 && weight < 91)
                            {
                                price = price + (0.02 * 0.15 * weight * distance);
                            }
                            else
                            {
                                if (weight >= 91 && weight <= 150)
                                {
                                    price = price + (0.01 * 0.20 * weight * distance);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("The delivery of your shipment with weight of {0:F3} kg. would cost {1:F2} lv.", weight, price);


        }
    }
}
