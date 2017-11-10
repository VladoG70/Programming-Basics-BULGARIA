using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MetricConverter
    {
    class Program
        {
        static void Main(string[] args)
            {
            var size = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine();
            var destMetric = Console.ReadLine();

            if (sourceMetric == "km")
                {
                size *= 1000;
                }
            else
                {
                if (sourceMetric == "cm")
                    {
                    size /= 100;
                    }
                else
                    {
                    if (sourceMetric == "mm")
                        {
                        size /= 1000;
                        }
                    else
                        {
                        if (sourceMetric == "mi")
                            {
                            size /= 0.000621371192;
                            }
                        else
                            {
                            if (sourceMetric == "in")
                                {
                                size /= 39.3700787;
                                }
                            else
                                {
                                if (sourceMetric == "ft")
                                    {
                                    size /= 3.2808399;
                                    }
                                else
                                    {
                                    if (sourceMetric == "yd")
                                        {
                                        size /= 1.0936133;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            switch (destMetric)
                {
                case "km": size *= 0.001; break;
                case "m": break;
                case "cm": size *= 100; break;
                case "mm": size *= 1000; break;
                case "mi": size *= 0.000621371192; break;
                case "in": size *= 39.3700787; break;
                case "ft": size *= 3.2808399; break;
                case "yd": size *= 1.0936133; break;
                default: break;
                }
            Console.WriteLine("{0} {1}", size, destMetric);
            }
        }
    }
