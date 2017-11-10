using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FruitShop
    {
    class Program
        {
        static void Main(string[] args)
            {
            var fruit = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var totalSum = -1.0;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
                {
                if (fruit == "banana")
                    {
                    totalSum = quantity * 2.50;
                    }
                else
                    {
                    if (fruit == "apple")
                        {
                        totalSum = quantity * 1.20;
                        }
                    else
                        {
                        if (fruit == "orange")
                            {
                            totalSum = quantity * 0.85;
                            }
                        else
                            {
                            if (fruit == "grapefruit")
                                {
                                totalSum = quantity * 1.45;
                                }
                            else
                                {
                                if (fruit == "kiwi")
                                    {
                                    totalSum = quantity * 2.70;
                                    }
                                else
                                    {
                                    if (fruit == "pineapple")
                                        {
                                        totalSum = quantity * 5.50;
                                        }
                                    else
                                        {
                                        if (fruit == "grapes")
                                            {
                                            totalSum = quantity * 3.85;
                                            }
                                        else
                                            {
                                            Console.WriteLine("error");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                if (totalSum >= 0)
                    {
                    Console.WriteLine("{0:f2}", totalSum);
                    }
                } // If [Monday..Friday]
            else
                {
                if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
                    {
                    if (fruit == "banana")
                        {
                        totalSum = quantity * 2.70;
                        }
                    else
                        {
                        if (fruit == "apple")
                            {
                            totalSum = quantity * 1.25;
                            }
                        else
                            {
                            if (fruit == "orange")
                                {
                                totalSum = quantity * 0.90;
                                }
                            else
                                {
                                if (fruit == "grapefruit")
                                    {
                                    totalSum = quantity * 1.60;
                                    }
                                else
                                    {
                                    if (fruit == "kiwi")
                                        {
                                        totalSum = quantity * 3.00;
                                        }
                                    else
                                        {
                                        if (fruit == "pineapple")
                                            {
                                            totalSum = quantity * 5.60;
                                            }
                                        else
                                            {
                                            if (fruit == "grapes")
                                                {
                                                totalSum = quantity * 4.20;
                                                }
                                            else
                                                {
                                                Console.WriteLine("error");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    if (totalSum >= 0)
                        {
                        Console.WriteLine("{0:f2}", totalSum);
                        }
                    }
                else
                    {
                    Console.WriteLine("error");
                    }
                }

            }
        }
    }
