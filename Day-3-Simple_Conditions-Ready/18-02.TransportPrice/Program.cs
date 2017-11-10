using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_02.TransportPrice
    {
    class Program
        {
        static void Main(string[] args)
            {
            int n;
            string periodDay;
            double taxiStart = 0.7, taxiDayTariff = 0.79, taxiNightTariff = 0.9;
            double busTariff = 0.09;
            double trainTariff = 0.06;
            // int busLimitMin = 20;
            // int trainLimitMin = 100;
            double taxiPrice = 5000, busPrice = 5000, trainPrice = 5000;

            do
                {
                n = int.Parse(Console.ReadLine());
                periodDay = Console.ReadLine();
                } while (n < 1 || n > 5000 || (periodDay != "day" && periodDay != "night"));

            // Taxi
            if (periodDay == "day")
                {
                taxiPrice = taxiStart + (n * taxiDayTariff);
                }
            else
                {
                taxiPrice = taxiStart + (n * taxiNightTariff);
                }

            // Bus
            if (n >= 20)
                {
                busPrice = n * busTariff;
                }

            // Train
            if (n >= 100)
                {
                trainPrice = n * trainTariff;
                }


            if (taxiPrice < busPrice)
                {
                Console.WriteLine(taxiPrice);
                }
            else
                {
                if (busPrice < trainPrice)
                    {
                    Console.WriteLine(busPrice);
                    }
                else
                    {
                    Console.WriteLine(trainPrice);
                    }
                }

            }
        }
    }
